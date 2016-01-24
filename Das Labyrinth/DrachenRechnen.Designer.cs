namespace Das_Labyrinth
{
    partial class DrachenRechnen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Question = new System.Windows.Forms.Label();
            this.lbl_AnswerA = new System.Windows.Forms.Label();
            this.lbl_AnswerB = new System.Windows.Forms.Label();
            this.lbl_AnswerC = new System.Windows.Forms.Label();
            this.lbl_AnswerD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Location = new System.Drawing.Point(412, 78);
            this.lbl_Question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(168, 17);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Text = "FRAGEN PLATZHALTER";
            this.lbl_Question.Click += new System.EventHandler(this.lbl_Question_Click);
            // 
            // lbl_AnswerA
            // 
            this.lbl_AnswerA.AutoSize = true;
            this.lbl_AnswerA.Location = new System.Drawing.Point(127, 217);
            this.lbl_AnswerA.Name = "lbl_AnswerA";
            this.lbl_AnswerA.Size = new System.Drawing.Size(68, 17);
            this.lbl_AnswerA.TabIndex = 1;
            this.lbl_AnswerA.Text = "Antwort A";
            this.lbl_AnswerA.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // lbl_AnswerB
            // 
            this.lbl_AnswerB.AutoSize = true;
            this.lbl_AnswerB.Location = new System.Drawing.Point(316, 217);
            this.lbl_AnswerB.Name = "lbl_AnswerB";
            this.lbl_AnswerB.Size = new System.Drawing.Size(68, 17);
            this.lbl_AnswerB.TabIndex = 2;
            this.lbl_AnswerB.Text = "Antwort B";
            this.lbl_AnswerB.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // lbl_AnswerC
            // 
            this.lbl_AnswerC.AutoSize = true;
            this.lbl_AnswerC.Location = new System.Drawing.Point(127, 296);
            this.lbl_AnswerC.Name = "lbl_AnswerC";
            this.lbl_AnswerC.Size = new System.Drawing.Size(68, 17);
            this.lbl_AnswerC.TabIndex = 3;
            this.lbl_AnswerC.Text = "Antwort C";
            this.lbl_AnswerC.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // lbl_AnswerD
            // 
            this.lbl_AnswerD.AutoSize = true;
            this.lbl_AnswerD.Location = new System.Drawing.Point(316, 296);
            this.lbl_AnswerD.Name = "lbl_AnswerD";
            this.lbl_AnswerD.Size = new System.Drawing.Size(69, 17);
            this.lbl_AnswerD.TabIndex = 4;
            this.lbl_AnswerD.Text = "Antwort D";
            this.lbl_AnswerD.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // DrachenRechnen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.lbl_AnswerD);
            this.Controls.Add(this.lbl_AnswerC);
            this.Controls.Add(this.lbl_AnswerB);
            this.Controls.Add(this.lbl_AnswerA);
            this.Controls.Add(this.lbl_Question);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DrachenRechnen";
            this.Text = "DrachenRechnen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Label lbl_AnswerA;
        private System.Windows.Forms.Label lbl_AnswerB;
        private System.Windows.Forms.Label lbl_AnswerC;
        private System.Windows.Forms.Label lbl_AnswerD;
    }
}