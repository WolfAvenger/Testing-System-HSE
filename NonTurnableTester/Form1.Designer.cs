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
            this.StudentNameToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.AnswerCCheckBox = new System.Windows.Forms.CheckBox();
            this.AnswerDCheckBox = new System.Windows.Forms.CheckBox();
            this.AnswerBCheckBox = new System.Windows.Forms.CheckBox();
            this.AnswerACheckBox = new System.Windows.Forms.CheckBox();
            this.FinishButton = new System.Windows.Forms.Button();
            this.Namelabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionListBox
            // 
            this.QuestionListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.QuestionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionListBox.FormattingEnabled = true;
            this.QuestionListBox.ItemHeight = 25;
            this.QuestionListBox.Location = new System.Drawing.Point(12, 12);
            this.QuestionListBox.Name = "QuestionListBox";
            this.QuestionListBox.Size = new System.Drawing.Size(81, 754);
            this.QuestionListBox.TabIndex = 0;
            this.QuestionListBox.SelectedIndexChanged += new System.EventHandler(this.QuestionListBox_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompIDtoolStrip,
            this.StudentNameToolStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 776);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1128, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CompIDtoolStrip
            // 
            this.CompIDtoolStrip.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.CompIDtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CompIDtoolStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompIDtoolStrip.Name = "CompIDtoolStrip";
            this.CompIDtoolStrip.Size = new System.Drawing.Size(152, 24);
            this.CompIDtoolStrip.Text = "Оставшееся время: ";
            this.CompIDtoolStrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StudentNameToolStrip
            // 
            this.StudentNameToolStrip.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StudentNameToolStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameToolStrip.Name = "StudentNameToolStrip";
            this.StudentNameToolStrip.Size = new System.Drawing.Size(75, 24);
            this.StudentNameToolStrip.Text = "Студент: ";
            this.StudentNameToolStrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnswerCCheckBox
            // 
            this.AnswerCCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerCCheckBox.AutoSize = true;
            this.AnswerCCheckBox.Location = new System.Drawing.Point(132, 680);
            this.AnswerCCheckBox.Name = "AnswerCCheckBox";
            this.AnswerCCheckBox.Size = new System.Drawing.Size(89, 21);
            this.AnswerCCheckBox.TabIndex = 3;
            this.AnswerCCheckBox.Text = "Answer C";
            this.AnswerCCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnswerDCheckBox
            // 
            this.AnswerDCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerDCheckBox.AutoSize = true;
            this.AnswerDCheckBox.Location = new System.Drawing.Point(132, 745);
            this.AnswerDCheckBox.Name = "AnswerDCheckBox";
            this.AnswerDCheckBox.Size = new System.Drawing.Size(90, 21);
            this.AnswerDCheckBox.TabIndex = 2;
            this.AnswerDCheckBox.Text = "Answer D";
            this.AnswerDCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnswerBCheckBox
            // 
            this.AnswerBCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerBCheckBox.AutoSize = true;
            this.AnswerBCheckBox.Location = new System.Drawing.Point(132, 615);
            this.AnswerBCheckBox.Name = "AnswerBCheckBox";
            this.AnswerBCheckBox.Size = new System.Drawing.Size(89, 21);
            this.AnswerBCheckBox.TabIndex = 1;
            this.AnswerBCheckBox.Text = "Answer B";
            this.AnswerBCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnswerACheckBox
            // 
            this.AnswerACheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerACheckBox.AutoSize = true;
            this.AnswerACheckBox.Location = new System.Drawing.Point(133, 555);
            this.AnswerACheckBox.Name = "AnswerACheckBox";
            this.AnswerACheckBox.Size = new System.Drawing.Size(89, 21);
            this.AnswerACheckBox.TabIndex = 0;
            this.AnswerACheckBox.Text = "Answer A";
            this.AnswerACheckBox.UseVisualStyleBackColor = true;
            // 
            // FinishButton
            // 
            this.FinishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FinishButton.BackColor = System.Drawing.Color.ForestGreen;
            this.FinishButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.FinishButton.Location = new System.Drawing.Point(932, 781);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(176, 23);
            this.FinishButton.TabIndex = 5;
            this.FinishButton.Text = "Finish the test";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // Namelabel
            // 
            this.Namelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(202, 298);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(284, 44);
            this.Namelabel.TabIndex = 6;
            this.Namelabel.Text = "Student Name: ";
            // 
            // NametextBox
            // 
            this.NametextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametextBox.Location = new System.Drawing.Point(492, 295);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(463, 49);
            this.NametextBox.TabIndex = 7;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(492, 370);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(195, 55);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(133, 12);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(975, 537);
            this.webBrowser.TabIndex = 9;
            this.webBrowser.TabStop = false;
            this.webBrowser.Visible = false;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1128, 806);
            this.ControlBox = false;
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.AnswerDCheckBox);
            this.Controls.Add(this.AnswerCCheckBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.AnswerBCheckBox);
            this.Controls.Add(this.AnswerACheckBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.QuestionListBox);
            this.Controls.Add(this.webBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox QuestionListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CompIDtoolStrip;
        private System.Windows.Forms.ToolStripStatusLabel StudentNameToolStrip;
        private System.Windows.Forms.CheckBox AnswerCCheckBox;
        private System.Windows.Forms.CheckBox AnswerDCheckBox;
        private System.Windows.Forms.CheckBox AnswerBCheckBox;
        private System.Windows.Forms.CheckBox AnswerACheckBox;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

