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
        Timer timer;

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
            if (sets.GetPriorities().Count != 3) sets.SetPriorities(jsonSender.GetConfig().InPriority);
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
        }
        private void QuestionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (last_question_index >= 0)
            {
                SaveLastAnswer(last_question_index, pack.GetQuestions()[last_question_index]);
            }
            last_question_index = QuestionListBox.SelectedIndex;
            Question q = pack.GetQuestions()[QuestionListBox.SelectedIndex];

            foreach (var elem in sets.GetPriorities())
            {
                //webBrowser.DocumentText = "";
                if (elem.Equals("text")) { 
                    if (q.GetQuestionText() != "")
                    {
                        webBrowser.DocumentText = q.GetQuestionText();
                        break;
                    }
                }
                else if (elem.Equals("html"))
                {
                    if (q.GetHTML() != "")
                    {
                        webBrowser.DocumentText = q.GetHTML();
                        break;
                    }
                }
                else if (elem.Equals("image"))
                {
                    if (q.GetQuestionImageEncoded() != "")
                    {
                        webBrowser.DocumentText = EmbedIMG(q.GetQuestionImageEncoded());
                        break;
                    }
                }
            }
            List<Answer> a = q.getAnswers();
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
            StudentNameToolStrip.Text = $"Студент: {NametextBox.Text}";

            sets.SetFinishTime();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += delegate {
                TimeSpan remaining = sets.GetFinishTime().DateTime - DateTime.Now;
                CompIDtoolStrip.Text = "Оставшееся время: " + (int)remaining.TotalMinutes + ":" + string.Format("{0:00}", Math.Round(remaining.TotalSeconds % 60));
                if (remaining.TotalSeconds <= 0)
                {
                    SaveLastAnswer(last_question_index, pack.GetQuestions()[last_question_index]);
                    Close();
                }
            };
            timer.Start();
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
