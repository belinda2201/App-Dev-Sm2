namespace AD_week5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_teamList = new System.Windows.Forms.Label();
            this.label_chooseCountry = new System.Windows.Forms.Label();
            this.label_chooseTeam = new System.Windows.Forms.Label();
            this.comboBox_chooseCountry = new System.Windows.Forms.ComboBox();
            this.comboBox_chooseTeam = new System.Windows.Forms.ComboBox();
            this.listBox_show = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.label_teamCountry = new System.Windows.Forms.Label();
            this.label_teamName = new System.Windows.Forms.Label();
            this.label_addTeam = new System.Windows.Forms.Label();
            this.txt_teamName = new System.Windows.Forms.TextBox();
            this.txt_teamCountry = new System.Windows.Forms.TextBox();
            this.txt_teamCity = new System.Windows.Forms.TextBox();
            this.label_teamCity = new System.Windows.Forms.Label();
            this.btn_addPlayer = new System.Windows.Forms.Button();
            this.label_playerPosition = new System.Windows.Forms.Label();
            this.txt_playerNumber = new System.Windows.Forms.TextBox();
            this.txt_playerName = new System.Windows.Forms.TextBox();
            this.label_playerNumber = new System.Windows.Forms.Label();
            this.label_playerName = new System.Windows.Forms.Label();
            this.label_addPlayer = new System.Windows.Forms.Label();
            this.comboBox_playerPosition = new System.Windows.Forms.ComboBox();
            this.btn_addTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_teamList
            // 
            this.label_teamList.AutoSize = true;
            this.label_teamList.Location = new System.Drawing.Point(93, 106);
            this.label_teamList.Name = "label_teamList";
            this.label_teamList.Size = new System.Drawing.Size(236, 41);
            this.label_teamList.TabIndex = 0;
            this.label_teamList.Text = "Soccer Team List";
            // 
            // label_chooseCountry
            // 
            this.label_chooseCountry.AutoSize = true;
            this.label_chooseCountry.Location = new System.Drawing.Point(93, 251);
            this.label_chooseCountry.Name = "label_chooseCountry";
            this.label_chooseCountry.Size = new System.Drawing.Size(248, 41);
            this.label_chooseCountry.TabIndex = 1;
            this.label_chooseCountry.Text = "Choose Country: ";
            // 
            // label_chooseTeam
            // 
            this.label_chooseTeam.AutoSize = true;
            this.label_chooseTeam.Location = new System.Drawing.Point(93, 379);
            this.label_chooseTeam.Name = "label_chooseTeam";
            this.label_chooseTeam.Size = new System.Drawing.Size(204, 41);
            this.label_chooseTeam.TabIndex = 2;
            this.label_chooseTeam.Text = "Choose Team:";
            // 
            // comboBox_chooseCountry
            // 
            this.comboBox_chooseCountry.FormattingEnabled = true;
            this.comboBox_chooseCountry.Location = new System.Drawing.Point(373, 256);
            this.comboBox_chooseCountry.Name = "comboBox_chooseCountry";
            this.comboBox_chooseCountry.Size = new System.Drawing.Size(331, 49);
            this.comboBox_chooseCountry.TabIndex = 3;
            this.comboBox_chooseCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox_chooseCountry_SelectedIndexChanged);
            this.comboBox_chooseCountry.SelectionChangeCommitted += new System.EventHandler(this.comboBox_chooseCountry_SelectionChangeCommitted);
            // 
            // comboBox_chooseTeam
            // 
            this.comboBox_chooseTeam.FormattingEnabled = true;
            this.comboBox_chooseTeam.Location = new System.Drawing.Point(373, 379);
            this.comboBox_chooseTeam.Name = "comboBox_chooseTeam";
            this.comboBox_chooseTeam.Size = new System.Drawing.Size(331, 49);
            this.comboBox_chooseTeam.TabIndex = 4;
            this.comboBox_chooseTeam.SelectedIndexChanged += new System.EventHandler(this.comboBox_chooseTeam_SelectedIndexChanged);
            // 
            // listBox_show
            // 
            this.listBox_show.FormattingEnabled = true;
            this.listBox_show.ItemHeight = 41;
            this.listBox_show.Location = new System.Drawing.Point(93, 513);
            this.listBox_show.Name = "listBox_show";
            this.listBox_show.Size = new System.Drawing.Size(611, 373);
            this.listBox_show.TabIndex = 5;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(96, 966);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(188, 58);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // label_teamCountry
            // 
            this.label_teamCountry.AutoSize = true;
            this.label_teamCountry.Location = new System.Drawing.Point(813, 326);
            this.label_teamCountry.Name = "label_teamCountry";
            this.label_teamCountry.Size = new System.Drawing.Size(209, 41);
            this.label_teamCountry.TabIndex = 9;
            this.label_teamCountry.Text = "Team Country:";
            // 
            // label_teamName
            // 
            this.label_teamName.AutoSize = true;
            this.label_teamName.Location = new System.Drawing.Point(813, 220);
            this.label_teamName.Name = "label_teamName";
            this.label_teamName.Size = new System.Drawing.Size(182, 41);
            this.label_teamName.TabIndex = 8;
            this.label_teamName.Text = "Team Name:";
            // 
            // label_addTeam
            // 
            this.label_addTeam.AutoSize = true;
            this.label_addTeam.Location = new System.Drawing.Point(825, 106);
            this.label_addTeam.Name = "label_addTeam";
            this.label_addTeam.Size = new System.Drawing.Size(193, 41);
            this.label_addTeam.TabIndex = 7;
            this.label_addTeam.Text = "Adding Team";
            // 
            // txt_teamName
            // 
            this.txt_teamName.Location = new System.Drawing.Point(1066, 222);
            this.txt_teamName.Name = "txt_teamName";
            this.txt_teamName.Size = new System.Drawing.Size(334, 47);
            this.txt_teamName.TabIndex = 13;
            // 
            // txt_teamCountry
            // 
            this.txt_teamCountry.Location = new System.Drawing.Point(1066, 323);
            this.txt_teamCountry.Name = "txt_teamCountry";
            this.txt_teamCountry.Size = new System.Drawing.Size(334, 47);
            this.txt_teamCountry.TabIndex = 14;
            // 
            // txt_teamCity
            // 
            this.txt_teamCity.Location = new System.Drawing.Point(1066, 429);
            this.txt_teamCity.Name = "txt_teamCity";
            this.txt_teamCity.Size = new System.Drawing.Size(334, 47);
            this.txt_teamCity.TabIndex = 18;
            // 
            // label_teamCity
            // 
            this.label_teamCity.AutoSize = true;
            this.label_teamCity.Location = new System.Drawing.Point(813, 435);
            this.label_teamCity.Name = "label_teamCity";
            this.label_teamCity.Size = new System.Drawing.Size(154, 41);
            this.label_teamCity.TabIndex = 17;
            this.label_teamCity.Text = "Team City:";
            // 
            // btn_addPlayer
            // 
            this.btn_addPlayer.Location = new System.Drawing.Point(1773, 523);
            this.btn_addPlayer.Name = "btn_addPlayer";
            this.btn_addPlayer.Size = new System.Drawing.Size(246, 58);
            this.btn_addPlayer.TabIndex = 27;
            this.btn_addPlayer.Text = "Add Player";
            this.btn_addPlayer.UseVisualStyleBackColor = true;
            this.btn_addPlayer.Click += new System.EventHandler(this.btn_addPlayer_Click);
            // 
            // label_playerPosition
            // 
            this.label_playerPosition.AutoSize = true;
            this.label_playerPosition.Location = new System.Drawing.Point(1520, 432);
            this.label_playerPosition.Name = "label_playerPosition";
            this.label_playerPosition.Size = new System.Drawing.Size(219, 41);
            this.label_playerPosition.TabIndex = 25;
            this.label_playerPosition.Text = "Player Position:";
            // 
            // txt_playerNumber
            // 
            this.txt_playerNumber.Location = new System.Drawing.Point(1773, 320);
            this.txt_playerNumber.Name = "txt_playerNumber";
            this.txt_playerNumber.Size = new System.Drawing.Size(334, 47);
            this.txt_playerNumber.TabIndex = 24;
            // 
            // txt_playerName
            // 
            this.txt_playerName.Location = new System.Drawing.Point(1773, 219);
            this.txt_playerName.Name = "txt_playerName";
            this.txt_playerName.Size = new System.Drawing.Size(334, 47);
            this.txt_playerName.TabIndex = 23;
            // 
            // label_playerNumber
            // 
            this.label_playerNumber.AutoSize = true;
            this.label_playerNumber.Location = new System.Drawing.Point(1520, 323);
            this.label_playerNumber.Name = "label_playerNumber";
            this.label_playerNumber.Size = new System.Drawing.Size(222, 41);
            this.label_playerNumber.TabIndex = 22;
            this.label_playerNumber.Text = "Player Number:";
            // 
            // label_playerName
            // 
            this.label_playerName.AutoSize = true;
            this.label_playerName.Location = new System.Drawing.Point(1520, 217);
            this.label_playerName.Name = "label_playerName";
            this.label_playerName.Size = new System.Drawing.Size(192, 41);
            this.label_playerName.TabIndex = 21;
            this.label_playerName.Text = "Player Name:";
            // 
            // label_addPlayer
            // 
            this.label_addPlayer.AutoSize = true;
            this.label_addPlayer.Location = new System.Drawing.Point(1532, 103);
            this.label_addPlayer.Name = "label_addPlayer";
            this.label_addPlayer.Size = new System.Drawing.Size(216, 41);
            this.label_addPlayer.TabIndex = 20;
            this.label_addPlayer.Text = "Adding Players";
            // 
            // comboBox_playerPosition
            // 
            this.comboBox_playerPosition.FormattingEnabled = true;
            this.comboBox_playerPosition.Items.AddRange(new object[] {
            "FW",
            "GK",
            "DF",
            "MF"});
            this.comboBox_playerPosition.Location = new System.Drawing.Point(1773, 429);
            this.comboBox_playerPosition.Name = "comboBox_playerPosition";
            this.comboBox_playerPosition.Size = new System.Drawing.Size(331, 49);
            this.comboBox_playerPosition.TabIndex = 28;
            // 
            // btn_addTeam
            // 
            this.btn_addTeam.Location = new System.Drawing.Point(1066, 523);
            this.btn_addTeam.Name = "btn_addTeam";
            this.btn_addTeam.Size = new System.Drawing.Size(246, 58);
            this.btn_addTeam.TabIndex = 29;
            this.btn_addTeam.Text = "Add Team";
            this.btn_addTeam.UseVisualStyleBackColor = true;
            this.btn_addTeam.Click += new System.EventHandler(this.btn_addTeam_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2263, 1189);
            this.Controls.Add(this.btn_addTeam);
            this.Controls.Add(this.comboBox_playerPosition);
            this.Controls.Add(this.btn_addPlayer);
            this.Controls.Add(this.label_playerPosition);
            this.Controls.Add(this.txt_playerNumber);
            this.Controls.Add(this.txt_playerName);
            this.Controls.Add(this.label_playerNumber);
            this.Controls.Add(this.label_playerName);
            this.Controls.Add(this.label_addPlayer);
            this.Controls.Add(this.txt_teamCity);
            this.Controls.Add(this.label_teamCity);
            this.Controls.Add(this.txt_teamCountry);
            this.Controls.Add(this.txt_teamName);
            this.Controls.Add(this.label_teamCountry);
            this.Controls.Add(this.label_teamName);
            this.Controls.Add(this.label_addTeam);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.listBox_show);
            this.Controls.Add(this.comboBox_chooseTeam);
            this.Controls.Add(this.comboBox_chooseCountry);
            this.Controls.Add(this.label_chooseTeam);
            this.Controls.Add(this.label_chooseCountry);
            this.Controls.Add(this.label_teamList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_teamList;
        private Label label_chooseCountry;
        private Label label_chooseTeam;
        private ComboBox comboBox_chooseCountry;
        private ComboBox comboBox_chooseTeam;
        private ListBox listBox_show;
        private Button btn_remove;
        private Label label_teamCountry;
        private Label label_teamName;
        private Label label_addTeam;
        private TextBox txt_teamName;
        private TextBox txt_teamCountry;
        private TextBox txt_teamCity;
        private Label label_teamCity;
        private Button btn_addPlayer;
        private Label label_playerPosition;
        private TextBox txt_playerNumber;
        private TextBox txt_playerName;
        private Label label_playerNumber;
        private Label label_playerName;
        private Label label_addPlayer;
        private ComboBox comboBox_playerPosition;
        private Button btn_addTeam;
    }
}