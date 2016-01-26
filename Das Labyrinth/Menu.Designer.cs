namespace Das_Labyrinth
{
    partial class Menu
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.cbb_Gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cbb_Level = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(309, 300);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(237, 103);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lbl_Welcome.Location = new System.Drawing.Point(159, 48);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(583, 54);
            this.lbl_Welcome.TabIndex = 1;
            this.lbl_Welcome.Text = "Willkommen zum Labyrinth";
            // 
            // cbb_Gender
            // 
            this.cbb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Gender.FormattingEnabled = true;
            this.cbb_Gender.Items.AddRange(new object[] {
            "Mädchen",
            "Junge"});
            this.cbb_Gender.Location = new System.Drawing.Point(12, 166);
            this.cbb_Gender.Name = "cbb_Gender";
            this.cbb_Gender.Size = new System.Drawing.Size(291, 21);
            this.cbb_Gender.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bist du ein Mädchen oder Junge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wähle dein Level";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(349, 150);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(75, 19);
            this.progressBar1.TabIndex = 6;
            // 
            // cbb_Level
            // 
            this.cbb_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Level.FormattingEnabled = true;
            this.cbb_Level.Location = new System.Drawing.Point(531, 167);
            this.cbb_Level.Name = "cbb_Level";
            this.cbb_Level.Size = new System.Drawing.Size(291, 21);
            this.cbb_Level.TabIndex = 7;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 490);
            this.Controls.Add(this.cbb_Level);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_Gender);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.btn_Start);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.ComboBox cbb_Gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cbb_Level;
    }
}

