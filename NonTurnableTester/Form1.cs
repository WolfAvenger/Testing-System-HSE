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

namespace NonTurnableTester
{
    public partial class Form1 : Form
    {
        Pack pack;
        CheckBox[] answerCheckBoxes = new CheckBox[4];
        List<Control> mainControls, nameControls;
        int last_question_index = -1;
        JsonSender jsonSender = new JsonSender();

        void SaveLastAnswer(int index, Question q)
        {
            for (int i = 0; i < 4; i++)
            {
                if (answerCheckBoxes[i].Checked) q.getAnswers()[i].SetChooseState(true);
                else q.getAnswers()[i].SetChooseState(false);
                answerCheckBoxes[i].Checked = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
            mainControls = new List<Control>()
            {
                QuestionListBox,
                QuestionTextBox,
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
            Debug.WriteLine(pack.GetQuestions()[0].GetQuestionText());
            answerCheckBoxes = new CheckBox[] { AnswerACheckBox, AnswerBCheckBox, AnswerCCheckBox, AnswerDCheckBox };

            for (int i = 1; i < pack.GetQuestions().Count + 1; i++)
            {
                QuestionListBox.Items.Add(i);
            }

            QuestionListBox.SelectedIndex = 0;
        }
        private void QuestionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Answer> answers;
            if (last_question_index >= 0)
            {
                SaveLastAnswer(last_question_index, pack.GetQuestions()[last_question_index]);
            }
            last_question_index = QuestionListBox.SelectedIndex;
           
            QuestionTextBox.Text = pack.GetQuestions()[QuestionListBox.SelectedIndex].GetQuestionText();
            answers = pack.GetQuestions()[QuestionListBox.SelectedIndex].getAnswers();
            for (var i=0; i<4; i++)
            {
                answerCheckBoxes[i].Text = answers[i].GetText();
                if (answers[i].IsChosen()) answerCheckBoxes[i].Checked = true;
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

        private void FinishButton_Click(object sender, EventArgs e)
        {
            SaveLastAnswer(last_question_index, pack.GetQuestions()[last_question_index]);

            jsonSender.SendPack(false, pack);
            Environment.Exit(0);
        }
    }
}
