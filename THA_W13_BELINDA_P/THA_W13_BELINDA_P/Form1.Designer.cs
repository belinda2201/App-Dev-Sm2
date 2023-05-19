namespace THA_W13_BELINDA_P
{
    partial class Form1
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
            this.btn_addPlayer = new System.Windows.Forms.Button();
            this.txt_tinggiPlayer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_beratPlayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_bdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nomorPlayer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_nationality = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_teamName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_teamManager = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_manager = new System.Windows.Forms.DataGridView();
            this.btn_editManager = new System.Windows.Forms.Button();
            this.cb_delPlayerTeam = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgv_player = new System.Windows.Forms.DataGridView();
            this.btn_deletePlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_namaPlayer = new System.Windows.Forms.TextBox();
            this.txt_idPlayer = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgv_currentManager = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currentManager)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addPlayer
            // 
            this.btn_addPlayer.Location = new System.Drawing.Point(57, 754);
            this.btn_addPlayer.Name = "btn_addPlayer";
            this.btn_addPlayer.Size = new System.Drawing.Size(194, 75);
            this.btn_addPlayer.TabIndex = 0;
            this.btn_addPlayer.Text = "Add Player";
            this.btn_addPlayer.UseVisualStyleBackColor = true;
            this.btn_addPlayer.Click += new System.EventHandler(this.btn_addPlayer_Click);
            // 
            // txt_tinggiPlayer
            // 
            this.txt_tinggiPlayer.Location = new System.Drawing.Point(185, 233);
            this.txt_tinggiPlayer.Name = "txt_tinggiPlayer";
            this.txt_tinggiPlayer.Size = new System.Drawing.Size(529, 38);
            this.txt_tinggiPlayer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height :";
            // 
            // txt_beratPlayer
            // 
            this.txt_beratPlayer.Location = new System.Drawing.Point(185, 306);
            this.txt_beratPlayer.Name = "txt_beratPlayer";
            this.txt_beratPlayer.Size = new System.Drawing.Size(529, 38);
            this.txt_beratPlayer.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weight :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "ADD PLAYER";
            // 
            // dateTimePicker_bdate
            // 
            this.dateTimePicker_bdate.Location = new System.Drawing.Point(214, 443);
            this.dateTimePicker_bdate.Name = "dateTimePicker_bdate";
            this.dateTimePicker_bdate.Size = new System.Drawing.Size(500, 38);
            this.dateTimePicker_bdate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Birthdate :";
            // 
            // txt_nomorPlayer
            // 
            this.txt_nomorPlayer.Location = new System.Drawing.Point(265, 376);
            this.txt_nomorPlayer.Name = "txt_nomorPlayer";
            this.txt_nomorPlayer.Size = new System.Drawing.Size(449, 38);
            this.txt_nomorPlayer.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Team Number :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nationality :";
            // 
            // cb_nationality
            // 
            this.cb_nationality.FormattingEnabled = true;
            this.cb_nationality.Location = new System.Drawing.Point(239, 521);
            this.cb_nationality.Name = "cb_nationality";
            this.cb_nationality.Size = new System.Drawing.Size(475, 39);
            this.cb_nationality.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 599);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Position :";
            // 
            // cb_teamName
            // 
            this.cb_teamName.FormattingEnabled = true;
            this.cb_teamName.Location = new System.Drawing.Point(239, 670);
            this.cb_teamName.Name = "cb_teamName";
            this.cb_teamName.Size = new System.Drawing.Size(475, 39);
            this.cb_teamName.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 674);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "Team Name :";
            // 
            // txt_pos
            // 
            this.txt_pos.Location = new System.Drawing.Point(189, 599);
            this.txt_pos.Name = "txt_pos";
            this.txt_pos.Size = new System.Drawing.Size(529, 38);
            this.txt_pos.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(805, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "EDIT MANAGER";
            // 
            // cb_teamManager
            // 
            this.cb_teamManager.FormattingEnabled = true;
            this.cb_teamManager.Location = new System.Drawing.Point(993, 120);
            this.cb_teamManager.Name = "cb_teamManager";
            this.cb_teamManager.Size = new System.Drawing.Size(475, 39);
            this.cb_teamManager.TabIndex = 21;
            this.cb_teamManager.SelectedIndexChanged += new System.EventHandler(this.cb_teamManager_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(805, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 32);
            this.label11.TabIndex = 20;
            this.label11.Text = "Team Name :";
            // 
            // dgv_manager
            // 
            this.dgv_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manager.Location = new System.Drawing.Point(811, 420);
            this.dgv_manager.Name = "dgv_manager";
            this.dgv_manager.RowHeadersWidth = 102;
            this.dgv_manager.RowTemplate.Height = 40;
            this.dgv_manager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_manager.Size = new System.Drawing.Size(786, 618);
            this.dgv_manager.TabIndex = 30;
            // 
            // btn_editManager
            // 
            this.btn_editManager.Location = new System.Drawing.Point(809, 1072);
            this.btn_editManager.Name = "btn_editManager";
            this.btn_editManager.Size = new System.Drawing.Size(331, 75);
            this.btn_editManager.TabIndex = 31;
            this.btn_editManager.Text = "Edit Manager";
            this.btn_editManager.UseVisualStyleBackColor = true;
            this.btn_editManager.Click += new System.EventHandler(this.btn_editManager_Click);
            // 
            // cb_delPlayerTeam
            // 
            this.cb_delPlayerTeam.FormattingEnabled = true;
            this.cb_delPlayerTeam.Location = new System.Drawing.Point(1879, 117);
            this.cb_delPlayerTeam.Name = "cb_delPlayerTeam";
            this.cb_delPlayerTeam.Size = new System.Drawing.Size(475, 39);
            this.cb_delPlayerTeam.TabIndex = 33;
            this.cb_delPlayerTeam.SelectedIndexChanged += new System.EventHandler(this.cb_delPlayerTeam_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1691, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 32);
            this.label13.TabIndex = 32;
            this.label13.Text = "Team Name :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1691, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(243, 32);
            this.label15.TabIndex = 34;
            this.label15.Text = "DELETE PLAYER";
            // 
            // dgv_player
            // 
            this.dgv_player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_player.Location = new System.Drawing.Point(1697, 194);
            this.dgv_player.Name = "dgv_player";
            this.dgv_player.RowHeadersWidth = 102;
            this.dgv_player.RowTemplate.Height = 40;
            this.dgv_player.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_player.Size = new System.Drawing.Size(962, 659);
            this.dgv_player.TabIndex = 35;
            // 
            // btn_deletePlayer
            // 
            this.btn_deletePlayer.Location = new System.Drawing.Point(1697, 896);
            this.btn_deletePlayer.Name = "btn_deletePlayer";
            this.btn_deletePlayer.Size = new System.Drawing.Size(319, 75);
            this.btn_deletePlayer.TabIndex = 36;
            this.btn_deletePlayer.Text = "Delete Player";
            this.btn_deletePlayer.UseVisualStyleBackColor = true;
            this.btn_deletePlayer.Click += new System.EventHandler(this.btn_deletePlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // txt_namaPlayer
            // 
            this.txt_namaPlayer.Location = new System.Drawing.Point(185, 159);
            this.txt_namaPlayer.Name = "txt_namaPlayer";
            this.txt_namaPlayer.Size = new System.Drawing.Size(529, 38);
            this.txt_namaPlayer.TabIndex = 2;
            // 
            // txt_idPlayer
            // 
            this.txt_idPlayer.Location = new System.Drawing.Point(208, 94);
            this.txt_idPlayer.Name = "txt_idPlayer";
            this.txt_idPlayer.Size = new System.Drawing.Size(506, 38);
            this.txt_idPlayer.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(51, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 32);
            this.label17.TabIndex = 37;
            this.label17.Text = "ID Player : ";
            // 
            // dgv_currentManager
            // 
            this.dgv_currentManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_currentManager.Location = new System.Drawing.Point(809, 194);
            this.dgv_currentManager.Name = "dgv_currentManager";
            this.dgv_currentManager.RowHeadersWidth = 102;
            this.dgv_currentManager.RowTemplate.Height = 40;
            this.dgv_currentManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_currentManager.Size = new System.Drawing.Size(786, 197);
            this.dgv_currentManager.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2693, 1206);
            this.Controls.Add(this.dgv_currentManager);
            this.Controls.Add(this.txt_idPlayer);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_deletePlayer);
            this.Controls.Add(this.dgv_player);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cb_delPlayerTeam);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_editManager);
            this.Controls.Add(this.dgv_manager);
            this.Controls.Add(this.cb_teamManager);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_pos);
            this.Controls.Add(this.cb_teamName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_nationality);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_nomorPlayer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_bdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_beratPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tinggiPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_namaPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currentManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addPlayer;
        private System.Windows.Forms.TextBox txt_tinggiPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_beratPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_bdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nomorPlayer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_nationality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_teamName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_teamManager;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_manager;
        private System.Windows.Forms.Button btn_editManager;
        private System.Windows.Forms.ComboBox cb_delPlayerTeam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgv_player;
        private System.Windows.Forms.Button btn_deletePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_namaPlayer;
        private System.Windows.Forms.TextBox txt_idPlayer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgv_currentManager;
    }
}

