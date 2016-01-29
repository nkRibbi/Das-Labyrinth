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
            this.lbl_AnswerC = new System.Windows.Forms.Label();
            this.lbl_AnswerD = new System.Windows.Forms.Label();
            this.lbl_difficulty = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pb_life1 = new System.Windows.Forms.PictureBox();
            this.pb_life3 = new System.Windows.Forms.PictureBox();
            this.pb_life2 = new System.Windows.Forms.PictureBox();
            this.pnl_success = new System.Windows.Forms.Panel();
            this.lbl_clickToContinue = new System.Windows.Forms.Label();
            this.lbl_AnswerB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_life2)).BeginInit();
            this.pnl_success.SuspendLayout();
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
            // 
            // lbl_AnswerA
            // 
            this.lbl_AnswerA.Font = new System.Drawing.Font("Verdana", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnswerA.Location = new System.Drawing.Point(60, 114);
            this.lbl_AnswerA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AnswerA.Name = "lbl_AnswerA";
            this.lbl_AnswerA.Padding = new System.Windows.Forms.Padding(20);
            this.lbl_AnswerA.Size = new System.Drawing.Size(150, 80);
            this.lbl_AnswerA.TabIndex = 1;
            this.lbl_AnswerA.Text = "44";
            this.lbl_AnswerA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_AnswerA.Click += new System.EventHandler(this.checkAnswer_Click);
            this.lbl_AnswerA.MouseEnter += new System.EventHandler(this.pnl_AnswerA_MouseEnter);
            this.lbl_AnswerA.MouseLeave += new System.EventHandler(this.pnl_AnswerA_MouseLeave);
            // 
            // lbl_AnswerC
            // 
            this.lbl_AnswerC.Font = new System.Drawing.Font("Verdana", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnswerC.Location = new System.Drawing.Point(232, 192);
            this.lbl_AnswerC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AnswerC.Name = "lbl_AnswerC";
            this.lbl_AnswerC.Size = new System.Drawing.Size(150, 80);
            this.lbl_AnswerC.TabIndex = 3;
            this.lbl_AnswerC.Text = "210";
            this.lbl_AnswerC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_AnswerC.Click += new System.EventHandler(this.checkAnswer_Click);
            this.lbl_AnswerC.MouseEnter += new System.EventHandler(this.pnl_AnswerA_MouseEnter);
            this.lbl_AnswerC.MouseLeave += new System.EventHandler(this.pnl_AnswerA_MouseLeave);
            // 
            // lbl_AnswerD
            // 
            this.lbl_AnswerD.Font = new System.Drawing.Font("Verdana", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnswerD.Location = new System.Drawing.Point(60, 192);
            this.lbl_AnswerD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AnswerD.Name = "lbl_AnswerD";
            this.lbl_AnswerD.Padding = new System.Windows.Forms.Padding(20);
            this.lbl_AnswerD.Size = new System.Drawing.Size(150, 80);
            this.lbl_AnswerD.TabIndex = 4;
            this.lbl_AnswerD.Text = "44";
            this.lbl_AnswerD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_AnswerD.Click += new System.EventHandler(this.checkAnswer_Click);
            this.lbl_AnswerD.MouseEnter += new System.EventHandler(this.pnl_AnswerA_MouseEnter);
            this.lbl_AnswerD.MouseLeave += new System.EventHandler(this.pnl_AnswerA_MouseLeave);
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
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(689, 65);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "label2";
            // 
            // pb_life1
            // 
            this.pb_life1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_life1.Location = new System.Drawing.Point(12, 9);
            this.pb_life1.Name = "pb_life1";
            this.pb_life1.Size = new System.Drawing.Size(27, 25);
            this.pb_life1.TabIndex = 10;
            this.pb_life1.TabStop = false;
            // 
            // pb_life3
            // 
            this.pb_life3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_life3.Location = new System.Drawing.Point(78, 9);
            this.pb_life3.Name = "pb_life3";
            this.pb_life3.Size = new System.Drawing.Size(27, 25);
            this.pb_life3.TabIndex = 11;
            this.pb_life3.TabStop = false;
            // 
            // pb_life2
            // 
            this.pb_life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_life2.Location = new System.Drawing.Point(45, 9);
            this.pb_life2.Name = "pb_life2";
            this.pb_life2.Size = new System.Drawing.Size(27, 25);
            this.pb_life2.TabIndex = 12;
            this.pb_life2.TabStop = false;
            // 
            // pnl_success
            // 
            this.pnl_success.Controls.Add(this.lbl_clickToContinue);
            this.pnl_success.Location = new System.Drawing.Point(576, 316);
            this.pnl_success.Name = "pnl_success";
            this.pnl_success.Size = new System.Drawing.Size(177, 38);
            this.pnl_success.TabIndex = 13;
            this.pnl_success.Visible = false;
            this.pnl_success.Click += new System.EventHandler(this.continue_after_sucess_click);
            // 
            // lbl_clickToContinue
            // 
            this.lbl_clickToContinue.AutoSize = true;
            this.lbl_clickToContinue.Location = new System.Drawing.Point(13, 8);
            this.lbl_clickToContinue.Name = "lbl_clickToContinue";
            this.lbl_clickToContinue.Size = new System.Drawing.Size(154, 26);
            this.lbl_clickToContinue.TabIndex = 0;
            this.lbl_clickToContinue.Text = "Super! \nKlicke hier um weiter zu spielen";
            this.lbl_clickToContinue.Click += new System.EventHandler(this.continue_after_sucess_click);
            // 
            // lbl_AnswerB
            // 
            this.lbl_AnswerB.Font = new System.Drawing.Font("Verdana", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnswerB.Location = new System.Drawing.Point(232, 114);
            this.lbl_AnswerB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AnswerB.Name = "lbl_AnswerB";
            this.lbl_AnswerB.Padding = new System.Windows.Forms.Padding(20);
            this.lbl_AnswerB.Size = new System.Drawing.Size(150, 80);
            this.lbl_AnswerB.TabIndex = 2;
            this.lbl_AnswerB.Text = "55";
            this.lbl_AnswerB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_AnswerB.Click += new System.EventHandler(this.checkAnswer_Click);
            this.lbl_AnswerB.MouseEnter += new System.EventHandler(this.pnl_AnswerA_MouseEnter);
            this.lbl_AnswerB.MouseLeave += new System.EventHandler(this.pnl_AnswerA_MouseLeave);
            // 
            // DrachenRechnen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 366);
            this.Controls.Add(this.pb_life2);
            this.Controls.Add(this.pb_life3);
            this.Controls.Add(this.pb_life1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_difficulty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.pnl_success);
            this.Controls.Add(this.lbl_AnswerA);
            this.Controls.Add(this.lbl_AnswerB);
            this.Controls.Add(this.lbl_AnswerC);
            this.Controls.Add(this.lbl_AnswerD);
            this.Name = "DrachenRechnen";
            this.Text = "DrachenRechnen";
            ((System.ComponentModel.ISupportInitialize)(this.pb_life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_life2)).EndInit();
            this.pnl_success.ResumeLayout(false);
            this.pnl_success.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Label lbl_AnswerA;
        private System.Windows.Forms.Label lbl_AnswerC;
        private System.Windows.Forms.Label lbl_AnswerD;
        private System.Windows.Forms.Label lbl_difficulty;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pb_life1;
        private System.Windows.Forms.PictureBox pb_life3;
        private System.Windows.Forms.PictureBox pb_life2;
        private System.Windows.Forms.Panel pnl_success;
        private System.Windows.Forms.Label lbl_clickToContinue;
        private System.Windows.Forms.Label lbl_AnswerB;
    }
}