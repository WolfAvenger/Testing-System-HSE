namespace NonTurnableTester
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CompIDtoolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.AnsweringPanel = new System.Windows.Forms.Panel();
            this.AnswerACheckBox = new System.Windows.Forms.CheckBox();
            this.AnswerBCheckBox = new System.Windows.Forms.CheckBox();
            this.AnswerCCheckBox = new System.Windows.Forms.CheckBox();
            this.AnswerDCheckBox = new System.Windows.Forms.CheckBox();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.AnsweringPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionListBox
            // 
            this.QuestionListBox.FormattingEnabled = true;
            this.QuestionListBox.ItemHeight = 16;
            this.QuestionListBox.Items.AddRange(new object[] {
            "Q1",
            "Q2",
            "Q3",
            "Q4",
            "Q5"});
            this.QuestionListBox.Location = new System.Drawing.Point(12, 12);
            this.QuestionListBox.Name = "QuestionListBox";
            this.QuestionListBox.Size = new System.Drawing.Size(59, 692);
            this.QuestionListBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompIDtoolStrip,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 777);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1128, 29);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CompIDtoolStrip
            // 
            this.CompIDtoolStrip.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.CompIDtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CompIDtoolStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompIDtoolStrip.Name = "CompIDtoolStrip";
            this.CompIDtoolStrip.Size = new System.Drawing.Size(102, 24);
            this.CompIDtoolStrip.Text = "Computer_ID";
            this.CompIDtoolStrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(111, 24);
            this.toolStripStatusLabel1.Text = "Student Name";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.QuestionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionTextBox.Location = new System.Drawing.Point(78, 13);
            this.QuestionTextBox.MaxLength = 65536;
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.ReadOnly = true;
            this.QuestionTextBox.Size = new System.Drawing.Size(1038, 525);
            this.QuestionTextBox.TabIndex = 2;
            this.QuestionTextBox.TabStop = false;
            this.QuestionTextBox.Text = "Here will be Question Text";
            // 
            // AnsweringPanel
            // 
            this.AnsweringPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnsweringPanel.Controls.Add(this.AnswerCCheckBox);
            this.AnsweringPanel.Controls.Add(this.AnswerDCheckBox);
            this.AnsweringPanel.Controls.Add(this.AnswerBCheckBox);
            this.AnsweringPanel.Controls.Add(this.AnswerACheckBox);
            this.AnsweringPanel.Location = new System.Drawing.Point(78, 544);
            this.AnsweringPanel.Name = "AnsweringPanel";
            this.AnsweringPanel.Size = new System.Drawing.Size(1038, 160);
            this.AnsweringPanel.TabIndex = 3;
            // 
            // AnswerACheckBox
            // 
            this.AnswerACheckBox.AutoSize = true;
            this.AnswerACheckBox.Location = new System.Drawing.Point(4, 4);
            this.AnswerACheckBox.Name = "AnswerACheckBox";
            this.AnswerACheckBox.Size = new System.Drawing.Size(89, 21);
            this.AnswerACheckBox.TabIndex = 0;
            this.AnswerACheckBox.Text = "Answer A";
            this.AnswerACheckBox.UseVisualStyleBackColor = true;
            // 
            // AnswerBCheckBox
            // 
            this.AnswerBCheckBox.AutoSize = true;
            this.AnswerBCheckBox.Location = new System.Drawing.Point(4, 41);
            this.AnswerBCheckBox.Name = "AnswerBCheckBox";
            this.AnswerBCheckBox.Size = new System.Drawing.Size(89, 21);
            this.AnswerBCheckBox.TabIndex = 1;
            this.AnswerBCheckBox.Text = "Answer B";
            this.AnswerBCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnswerCCheckBox
            // 
            this.AnswerCCheckBox.AutoSize = true;
            this.AnswerCCheckBox.Location = new System.Drawing.Point(4, 81);
            this.AnswerCCheckBox.Name = "AnswerCCheckBox";
            this.AnswerCCheckBox.Size = new System.Drawing.Size(89, 21);
            this.AnswerCCheckBox.TabIndex = 3;
            this.AnswerCCheckBox.Text = "Answer C";
            this.AnswerCCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnswerDCheckBox
            // 
            this.AnswerDCheckBox.AutoSize = true;
            this.AnswerDCheckBox.Location = new System.Drawing.Point(4, 121);
            this.AnswerDCheckBox.Name = "AnswerDCheckBox";
            this.AnswerDCheckBox.Size = new System.Drawing.Size(90, 21);
            this.AnswerDCheckBox.TabIndex = 2;
            this.AnswerDCheckBox.Text = "Answer D";
            this.AnswerDCheckBox.UseVisualStyleBackColor = true;
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Location = new System.Drawing.Point(12, 713);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(59, 61);
            this.NextQuestionButton.TabIndex = 4;
            this.NextQuestionButton.Text = "Next";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            // 
            // FinishButton
            // 
            this.FinishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FinishButton.BackColor = System.Drawing.Color.ForestGreen;
            this.FinishButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FinishButton.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.FinishButton.Location = new System.Drawing.Point(988, 781);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(120, 23);
            this.FinishButton.TabIndex = 5;
            this.FinishButton.Text = "Finish the test";
            this.FinishButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1128, 806);
            this.ControlBox = false;
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.AnsweringPanel);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.QuestionListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.AnsweringPanel.ResumeLayout(false);
            this.AnsweringPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox QuestionListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CompIDtoolStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Panel AnsweringPanel;
        private System.Windows.Forms.CheckBox AnswerCCheckBox;
        private System.Windows.Forms.CheckBox AnswerDCheckBox;
        private System.Windows.Forms.CheckBox AnswerBCheckBox;
        private System.Windows.Forms.CheckBox AnswerACheckBox;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Button FinishButton;
    }
}

