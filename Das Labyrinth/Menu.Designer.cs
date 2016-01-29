using System.Drawing;
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.pnl_Link = new System.Windows.Forms.PictureBox();
            this.pnl_Zelda = new System.Windows.Forms.PictureBox();
            this.lbl_Level1 = new System.Windows.Forms.Label();
            this.lbl_Level2 = new System.Windows.Forms.Label();
            this.lbl_Level3 = new System.Windows.Forms.Label();
            this.lbl_Level4 = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Zelda)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Location = new System.Drawing.Point(222, 323);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(468, 85);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lbl_Welcome.Location = new System.Drawing.Point(159, 19);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(583, 54);
            this.lbl_Welcome.TabIndex = 1;
            this.lbl_Welcome.Text = "Willkommen zum Labyrinth";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_name.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(317, 256);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(275, 35);
            this.txt_name.TabIndex = 8;
            this.txt_name.Text = "Name Platzhalter";
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // pnl_Link
            // 
            this.pnl_Link.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.pnl_Link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Link.Location = new System.Drawing.Point(335, 169);
            this.pnl_Link.Name = "pnl_Link";
            this.pnl_Link.Size = new System.Drawing.Size(68, 78);
            this.pnl_Link.TabIndex = 10;
            this.pnl_Link.TabStop = false;
            this.pnl_Link.Click += new System.EventHandler(this.playerChoiceClick);
            // 
            // pnl_Zelda
            // 
            this.pnl_Zelda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Zelda.Location = new System.Drawing.Point(504, 169);
            this.pnl_Zelda.Name = "pnl_Zelda";
            this.pnl_Zelda.Size = new System.Drawing.Size(68, 78);
            this.pnl_Zelda.TabIndex = 11;
            this.pnl_Zelda.TabStop = false;
            this.pnl_Zelda.Click += new System.EventHandler(this.playerChoiceClick);
            // 
            // lbl_Level1
            // 
            this.lbl_Level1.AutoSize = true;
            this.lbl_Level1.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Level1.Font = new System.Drawing.Font("Stencil", 23F);
            this.lbl_Level1.Location = new System.Drawing.Point(37, 422);
            this.lbl_Level1.Name = "lbl_Level1";
            this.lbl_Level1.Size = new System.Drawing.Size(132, 37);
            this.lbl_Level1.TabIndex = 12;
            this.lbl_Level1.Text = "Level 1";
            this.lbl_Level1.Click += new System.EventHandler(this.levelChoiceClick);
            // 
            // lbl_Level2
            // 
            this.lbl_Level2.AutoSize = true;
            this.lbl_Level2.Font = new System.Drawing.Font("Stencil", 23F);
            this.lbl_Level2.Location = new System.Drawing.Point(271, 422);
            this.lbl_Level2.Name = "lbl_Level2";
            this.lbl_Level2.Size = new System.Drawing.Size(132, 37);
            this.lbl_Level2.TabIndex = 13;
            this.lbl_Level2.Text = "Level 2";
            this.lbl_Level2.Click += new System.EventHandler(this.levelChoiceClick);
            // 
            // lbl_Level3
            // 
            this.lbl_Level3.AutoSize = true;
            this.lbl_Level3.Font = new System.Drawing.Font("Stencil", 23F);
            this.lbl_Level3.Location = new System.Drawing.Point(497, 422);
            this.lbl_Level3.Name = "lbl_Level3";
            this.lbl_Level3.Size = new System.Drawing.Size(132, 37);
            this.lbl_Level3.TabIndex = 14;
            this.lbl_Level3.Text = "Level 3";
            this.lbl_Level3.Click += new System.EventHandler(this.levelChoiceClick);
            // 
            // lbl_Level4
            // 
            this.lbl_Level4.AutoSize = true;
            this.lbl_Level4.Font = new System.Drawing.Font("Stencil", 23F);
            this.lbl_Level4.Location = new System.Drawing.Point(744, 422);
            this.lbl_Level4.Name = "lbl_Level4";
            this.lbl_Level4.Size = new System.Drawing.Size(132, 37);
            this.lbl_Level4.TabIndex = 15;
            this.lbl_Level4.Text = "Level 4";
            this.lbl_Level4.Click += new System.EventHandler(this.levelChoiceClick);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(368, 294);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 16;
            this.lbl_error.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 490);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_Level4);
            this.Controls.Add(this.lbl_Level3);
            this.Controls.Add(this.lbl_Level2);
            this.Controls.Add(this.lbl_Level1);
            this.Controls.Add(this.pnl_Zelda);
            this.Controls.Add(this.pnl_Link);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.btn_Start);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Zelda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.PictureBox pnl_Link;
        private System.Windows.Forms.PictureBox pnl_Zelda;
        private System.Windows.Forms.Label lbl_Level1;
        private System.Windows.Forms.Label lbl_Level2;
        private System.Windows.Forms.Label lbl_Level3;
        private System.Windows.Forms.Label lbl_Level4;
        private System.Windows.Forms.Label lbl_error;
    }
}

