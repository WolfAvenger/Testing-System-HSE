using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonTurnableTester
{
    public partial class Form1 : Form
    {
        Config c;
        Pack pack;
        CheckBox[] answers = new CheckBox[4];
        List<Control> mainControls, nameControls;
        int last_question_index = 0;

        void SaveLastAnswer(int index)
        {
            List<int> ans = new List<int>();
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i].Checked) { ans.Add(i); }
                answers[i].Checked = false;
            }
            pack.SetAnswer(ans, index);
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


            c = new Config();
            c.Deser();
            pack = new Pack();
            pack.GetPack();
            answers = new CheckBox[] { AnswerACheckBox, AnswerBCheckBox, AnswerCCheckBox, AnswerDCheckBox };

            //info in bar below
            CompIDtoolStrip.Text = $"Computer ID: {c.COMPUTER_ID.ToString()}";

            //start to fill this form

            for (int i=1; i<pack.GetQuestions().Count + 1; i++)
            {
                QuestionListBox.Items.Add(i);
            }

            //selecting first question

            QuestionListBox.SelectedIndex = 0;
        }

        private void QuestionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveLastAnswer(last_question_index);
            last_question_index = QuestionListBox.SelectedIndex;

            QuestionTextBox.Text = pack.GetQuestions()[QuestionListBox.SelectedIndex].GetQuestionText();
            AnswerACheckBox.Text = pack.GetQuestions()[QuestionListBox.SelectedIndex].GetA();
            AnswerBCheckBox.Text = pack.GetQuestions()[QuestionListBox.SelectedIndex].GetB();
            AnswerCCheckBox.Text = pack.GetQuestions()[QuestionListBox.SelectedIndex].GetC();
            AnswerDCheckBox.Text = pack.GetQuestions()[QuestionListBox.SelectedIndex].GetD();

            foreach (int index in pack.GetQuestions()[QuestionListBox.SelectedIndex].GetGivenAnswersIndexes())
            {
                answers[index].Checked = true;
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
            SaveLastAnswer(QuestionListBox.SelectedIndex);

            pack.SendPack();
            Environment.Exit(0);
        }
    }
}
