namespace AD_Week_9
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_team = new System.Windows.Forms.ComboBox();
            this.cb_player = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_namaPlayer = new System.Windows.Forms.Label();
            this.label_team = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label_nationality = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_pos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_sqNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_yellow = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_red = new System.Windows.Forms.Label();
            this.label_goal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_penaltyMiss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which team do you want to check?";
            // 
            // cb_team
            // 
            this.cb_team.FormattingEnabled = true;
            this.cb_team.Location = new System.Drawing.Point(238, 261);
            this.cb_team.Name = "cb_team";
            this.cb_team.Size = new System.Drawing.Size(515, 39);
            this.cb_team.TabIndex = 2;
            this.cb_team.SelectedIndexChanged += new System.EventHandler(this.cb_team_SelectedIndexChanged);
            // 
            // cb_player
            // 
            this.cb_player.FormattingEnabled = true;
            this.cb_player.Location = new System.Drawing.Point(979, 262);
            this.cb_player.Name = "cb_player";
            this.cb_player.Size = new System.Drawing.Size(515, 39);
            this.cb_player.TabIndex = 4;
            this.cb_player.SelectedIndexChanged += new System.EventHandler(this.cb_player_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Team :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(788, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player :";
            // 
            // label_namaPlayer
            // 
            this.label_namaPlayer.AutoSize = true;
            this.label_namaPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namaPlayer.Location = new System.Drawing.Point(68, 383);
            this.label_namaPlayer.Name = "label_namaPlayer";
            this.label_namaPlayer.Size = new System.Drawing.Size(144, 54);
            this.label_namaPlayer.TabIndex = 7;
            this.label_namaPlayer.Text = "name";
            // 
            // label_team
            // 
            this.label_team.AutoSize = true;
            this.label_team.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_team.Location = new System.Drawing.Point(68, 476);
            this.label_team.Name = "label_team";
            this.label_team.Size = new System.Drawing.Size(112, 46);
            this.label_team.TabIndex = 9;
            this.label_team.Text = "team";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1590, 247);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(279, 65);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Search!";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label_nationality
            // 
            this.label_nationality.AutoSize = true;
            this.label_nationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nationality.Location = new System.Drawing.Point(342, 571);
            this.label_nationality.Name = "label_nationality";
            this.label_nationality.Size = new System.Drawing.Size(34, 46);
            this.label_nationality.TabIndex = 10;
            this.label_nationality.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 46);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nationality :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 677);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 46);
            this.label5.TabIndex = 15;
            this.label5.Text = "Position :";
            // 
            // label_pos
            // 
            this.label_pos.AutoSize = true;
            this.label_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pos.Location = new System.Drawing.Point(294, 677);
            this.label_pos.Name = "label_pos";
            this.label_pos.Size = new System.Drawing.Size(34, 46);
            this.label_pos.TabIndex = 14;
            this.label_pos.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 782);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 46);
            this.label7.TabIndex = 17;
            this.label7.Text = "Squad Number :";
            // 
            // label_sqNumber
            // 
            this.label_sqNumber.AutoSize = true;
            this.label_sqNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sqNumber.Location = new System.Drawing.Point(424, 782);
            this.label_sqNumber.Name = "label_sqNumber";
            this.label_sqNumber.Size = new System.Drawing.Size(34, 46);
            this.label_sqNumber.TabIndex = 16;
            this.label_sqNumber.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 888);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 46);
            this.label9.TabIndex = 19;
            this.label9.Text = "Yellow Card :";
            // 
            // label_yellow
            // 
            this.label_yellow.AutoSize = true;
            this.label_yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_yellow.Location = new System.Drawing.Point(371, 888);
            this.label_yellow.Name = "label_yellow";
            this.label_yellow.Size = new System.Drawing.Size(34, 46);
            this.label_yellow.TabIndex = 18;
            this.label_yellow.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(66, 993);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 46);
            this.label11.TabIndex = 21;
            this.label11.Text = "Red Card :";
            // 
            // label_red
            // 
            this.label_red.AutoSize = true;
            this.label_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_red.Location = new System.Drawing.Point(322, 993);
            this.label_red.Name = "label_red";
            this.label_red.Size = new System.Drawing.Size(34, 46);
            this.label_red.TabIndex = 20;
            this.label_red.Text = "-";
            // 
            // label_goal
            // 
            this.label_goal.AutoSize = true;
            this.label_goal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_goal.Location = new System.Drawing.Point(1260, 571);
            this.label_goal.Name = "label_goal";
            this.label_goal.Size = new System.Drawing.Size(34, 46);
            this.label_goal.TabIndex = 22;
            this.label_goal.Text = "-";
            this.label_goal.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(927, 571);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(279, 46);
            this.label16.TabIndex = 23;
            this.label16.Text = "Goal Scored :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(927, 677);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(328, 46);
            this.label17.TabIndex = 25;
            this.label17.Text = "Penalty Missed :";
            // 
            // label_penaltyMiss
            // 
            this.label_penaltyMiss.AutoSize = true;
            this.label_penaltyMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_penaltyMiss.Location = new System.Drawing.Point(1296, 677);
            this.label_penaltyMiss.Name = "label_penaltyMiss";
            this.label_penaltyMiss.Size = new System.Drawing.Size(34, 46);
            this.label_penaltyMiss.TabIndex = 24;
            this.label_penaltyMiss.Text = "-";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2123, 1635);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label_penaltyMiss);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label_goal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_red);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_yellow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_sqNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_pos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label_nationality);
            this.Controls.Add(this.label_team);
            this.Controls.Add(this.label_namaPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_team);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_team;
        private System.Windows.Forms.ComboBox cb_player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_namaPlayer;
        private System.Windows.Forms.Label label_team;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label_nationality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_pos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_sqNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_yellow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_red;
        private System.Windows.Forms.Label label_goal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_penaltyMiss;
    }
}