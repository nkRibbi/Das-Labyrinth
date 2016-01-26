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
            this.lbl_difficulty = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Verdana", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(276, 74);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(0, 40);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Click += new System.EventHandler(this.lbl_Question_Click);
            // 
            // lbl_AnswerA
            // 
            this.lbl_AnswerA.AutoSize = true;
            this.lbl_AnswerA.Font = new System.Drawing.Font("Verdana", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnswerA.Location = new System.Drawing.Point(82, 175);
            this.lbl_AnswerA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AnswerA.Name = "lbl_AnswerA";
            this.lbl_AnswerA.Size = new System.Drawing.Size(171, 38);
            this.lbl_AnswerA.TabIndex = 1;
            this.lbl_AnswerA.Text = "Antwort A";
            this.lbl_AnswerA.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // lbl_AnswerB
            // 
            this.lbl_AnswerB.AutoSize = true;
            this.lbl_AnswerB.Font = new System.Drawing.Font("Verdana", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnswerB.Location = new System.Drawing.Point(513, 175);
            this.lbl_AnswerB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AnswerB.Name = "lbl_AnswerB";
            this.lbl_AnswerB.Size = new System.Drawing.Size(171, 38);
            this.lbl_AnswerB.TabIndex = 2;
            this.lbl_AnswerB.Text = "Antwort B";
            this.lbl_AnswerB.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // lbl_AnswerC
            // 
            this.lbl_AnswerC.AutoSize = true;
            this.lbl_AnswerC.Font = new System.Drawing.Font("Verdana", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnswerC.Location = new System.Drawing.Point(82, 239);
            this.lbl_AnswerC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AnswerC.Name = "lbl_AnswerC";
            this.lbl_AnswerC.Size = new System.Drawing.Size(172, 38);
            this.lbl_AnswerC.TabIndex = 3;
            this.lbl_AnswerC.Text = "Antwort C";
            this.lbl_AnswerC.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // lbl_AnswerD
            // 
            this.lbl_AnswerD.AutoSize = true;
            this.lbl_AnswerD.Font = new System.Drawing.Font("Verdana", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnswerD.Location = new System.Drawing.Point(512, 239);
            this.lbl_AnswerD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AnswerD.Name = "lbl_AnswerD";
            this.lbl_AnswerD.Size = new System.Drawing.Size(174, 38);
            this.lbl_AnswerD.TabIndex = 4;
            this.lbl_AnswerD.Text = "Antwort D";
            this.lbl_AnswerD.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // lbl_difficulty
            // 
            this.lbl_difficulty.AutoSize = true;
            this.lbl_difficulty.Location = new System.Drawing.Point(689, 9);
            this.lbl_difficulty.Name = "lbl_difficulty";
            this.lbl_difficulty.Size = new System.Drawing.Size(35, 13);
            this.lbl_difficulty.TabIndex = 6;
            this.lbl_difficulty.Text = "label2";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(689, 37);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(35, 13);
            this.lbl_gender.TabIndex = 7;
            this.lbl_gender.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Berechne:";
            // 
            // DrachenRechnen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_difficulty);
            this.Controls.Add(this.lbl_AnswerD);
            this.Controls.Add(this.lbl_AnswerC);
            this.Controls.Add(this.lbl_AnswerB);
            this.Controls.Add(this.lbl_AnswerA);
            this.Controls.Add(this.lbl_Question);
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
        private System.Windows.Forms.Label lbl_difficulty;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label label1;
    }
}