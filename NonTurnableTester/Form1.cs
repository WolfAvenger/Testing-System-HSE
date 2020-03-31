using NonTurnableTester.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace NonTurnableTester
{
    public partial class Form1 : Form
    {
        Pack pack;
        CheckBox[] answerCheckBoxes = new CheckBox[4];
        List<Control> mainControls, nameControls;
        int last_question_index = -1;
        JsonSender jsonSender = new JsonSender();
        Dictionary<CheckBox, Answer> CA = new Dictionary<CheckBox, Answer>();
        PackSettings sets;

        void SaveLastAnswer(int index, Question q)
        {
            for (int i = 0; i < 4; i++)
            {
                if (answerCheckBoxes[i].Checked) q.SetGivenAnswer(CA[answerCheckBoxes[i]].GetID(), true);
                else q.SetGivenAnswer(CA[answerCheckBoxes[i]].GetID(), false);
                answerCheckBoxes[i].Checked = false;
            }
        }

        string EmbedIMG(string s)
        {
            string url = "<html><body><img src=\"data:image/png;base64," + s + "\" /></body></html>";
            return url;
        }

        void TimeThread()
        {
            DateTimeOffset finish = sets.GetFinishTime();
            while (true)
            {
                DateTime now = DateTime.Now;
                if (now >= finish)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        // close the form on the forms thread
                        this.Close();
                    });
                }
            }
            
        }

        public Form1()
        {
            InitializeComponent();
            mainControls = new List<Control>()
            {
                QuestionListBox,
                webBrowser,
                AnswerACheckBox,
                AnswerBCheckBox,
                AnswerCCheckBox,
                AnswerDCheckBox,
                FinishButton
            };
            nameControls = new List<Control>()
            {
                Namelabel,
                NametextBox,
                StartButton
            };

            foreach (var elem in mainControls)
            {
                elem.Visible = false;
            }
            
            pack = jsonSender.GetPack(false);
            sets = pack.GetSettings();
            if (sets.GetPriorities().Count == 0) sets.SetPriorities(jsonSender.GetConfig().InPriority);
            answerCheckBoxes = new CheckBox[] { AnswerACheckBox, AnswerBCheckBox, AnswerCCheckBox, AnswerDCheckBox };
            
            foreach (var elem in answerCheckBoxes)
            {
                CA[elem] = null;
            }

            for (int i = 1; i < pack.GetQuestions().Count + 1; i++)
            {
                QuestionListBox.Items.Add(i);
            }

            QuestionListBox.SelectedIndex = 0;
            sets.SetFinishTime();

            Timer timer = new Timer();
            timer.Tick += delegate {
                TimeSpan remaining = sets.GetFinishTime().DateTime - DateTime.Now;
                CompIDtoolStrip.Text = "Оставшееся время: " + (int)(remaining.TotalMinutes) + " минут " + (int)(remaining.TotalSeconds) + " секунд";
                if (DateTime.Now >= sets.GetFinishTime())
                {
                    this.Close();
                }
            };
            timer.Interval = 1000;
            timer.Start();
        }
        private void QuestionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (last_question_index >= 0)
            {
                SaveLastAnswer(last_question_index, pack.GetQuestions()[last_question_index]);
            }
            last_question_index = QuestionListBox.SelectedIndex;

            switch (sets.GetPriorities()[0])
            {
                case "html":
                    webBrowser.DocumentText = pack.GetQuestions()[QuestionListBox.SelectedIndex].GetHTML();
                    break;
                case "image":
                    webBrowser.DocumentText = EmbedIMG(pack.GetQuestions()[QuestionListBox.SelectedIndex].GetQuestionImageEncoded());
                    break;
                case "text":
                    webBrowser.DocumentText = pack.GetQuestions()[QuestionListBox.SelectedIndex].GetQuestionText();
                    break;
            }
            CompIDtoolStrip.Text = webBrowser.DocumentText;
            List<Answer> a = pack.GetQuestions()[QuestionListBox.SelectedIndex].getAnswers();
            for (var i=0; i<4; i++)
            {
                answerCheckBoxes[i].Text = a[i].GetText();
                CA[answerCheckBoxes[i]] = a[i];
                if (a[i].IsChosen()) answerCheckBoxes[i].Checked = true;
                else answerCheckBoxes[i].Checked = false;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            pack.SetStudentName(NametextBox.Text);
            foreach (var elem in nameControls)
            {
                elem.Visible = false;
            }
            foreach (var elem in mainControls)
            {
                elem.Visible = true;
            }
            StudentNameToolStrip.Text = $"Student: {NametextBox.Text}";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinishButton_Click(sender, e);
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            SaveLastAnswer(last_question_index, pack.GetQuestions()[last_question_index]);

            jsonSender.SendPack(false, pack);
            Environment.Exit(0);
        }
    }
}
