namespace AD_Week_9
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_match = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_team = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_teamHome = new System.Windows.Forms.DataGridView();
            this.dgv_teamAway = new System.Windows.Forms.DataGridView();
            this.dgv_detailMatch = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_teamHome = new System.Windows.Forms.Label();
            this.label_teamAway = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detailMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(779, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 46);
            this.label3.TabIndex = 16;
            this.label3.Text = "Match :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 46);
            this.label2.TabIndex = 15;
            this.label2.Text = "Team :";
            // 
            // cb_match
            // 
            this.cb_match.FormattingEnabled = true;
            this.cb_match.Location = new System.Drawing.Point(970, 247);
            this.cb_match.Name = "cb_match";
            this.cb_match.Size = new System.Drawing.Size(515, 39);
            this.cb_match.TabIndex = 14;
            this.cb_match.SelectedIndexChanged += new System.EventHandler(this.cb_match_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Which match do you want to check?";
            // 
            // cb_team
            // 
            this.cb_team.FormattingEnabled = true;
            this.cb_team.Location = new System.Drawing.Point(229, 246);
            this.cb_team.Name = "cb_team";
            this.cb_team.Size = new System.Drawing.Size(515, 39);
            this.cb_team.TabIndex = 12;
            this.cb_team.SelectedIndexChanged += new System.EventHandler(this.cb_team_SelectedIndexChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1577, 234);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(279, 65);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Search!";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_teamHome
            // 
            this.dgv_teamHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teamHome.Location = new System.Drawing.Point(65, 434);
            this.dgv_teamHome.Name = "dgv_teamHome";
            this.dgv_teamHome.RowHeadersWidth = 102;
            this.dgv_teamHome.RowTemplate.Height = 40;
            this.dgv_teamHome.Size = new System.Drawing.Size(872, 374);
            this.dgv_teamHome.TabIndex = 18;
            // 
            // dgv_teamAway
            // 
            this.dgv_teamAway.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teamAway.Location = new System.Drawing.Point(65, 891);
            this.dgv_teamAway.Name = "dgv_teamAway";
            this.dgv_teamAway.RowHeadersWidth = 102;
            this.dgv_teamAway.RowTemplate.Height = 40;
            this.dgv_teamAway.Size = new System.Drawing.Size(872, 374);
            this.dgv_teamAway.TabIndex = 19;
            // 
            // dgv_detailMatch
            // 
            this.dgv_detailMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detailMatch.Location = new System.Drawing.Point(1000, 434);
            this.dgv_detailMatch.Name = "dgv_detailMatch";
            this.dgv_detailMatch.RowHeadersWidth = 102;
            this.dgv_detailMatch.RowTemplate.Height = 40;
            this.dgv_detailMatch.Size = new System.Drawing.Size(1104, 831);
            this.dgv_detailMatch.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 46);
            this.label4.TabIndex = 21;
            this.label4.Text = "Team Home :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 828);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 46);
            this.label5.TabIndex = 22;
            this.label5.Text = "Team Away :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(992, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 46);
            this.label6.TabIndex = 23;
            this.label6.Text = "Details :";
            // 
            // label_teamHome
            // 
            this.label_teamHome.AutoSize = true;
            this.label_teamHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teamHome.Location = new System.Drawing.Point(354, 366);
            this.label_teamHome.Name = "label_teamHome";
            this.label_teamHome.Size = new System.Drawing.Size(34, 46);
            this.label_teamHome.TabIndex = 24;
            this.label_teamHome.Text = "-";
            // 
            // label_teamAway
            // 
            this.label_teamAway.AutoSize = true;
            this.label_teamAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teamAway.Location = new System.Drawing.Point(354, 828);
            this.label_teamAway.Name = "label_teamAway";
            this.label_teamAway.Size = new System.Drawing.Size(34, 46);
            this.label_teamAway.TabIndex = 25;
            this.label_teamAway.Text = "-";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2228, 1669);
            this.Controls.Add(this.label_teamAway);
            this.Controls.Add(this.label_teamHome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_detailMatch);
            this.Controls.Add(this.dgv_teamAway);
            this.Controls.Add(this.dgv_teamHome);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_match);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_team);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detailMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_match;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_team;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_teamHome;
        private System.Windows.Forms.DataGridView dgv_teamAway;
        private System.Windows.Forms.DataGridView dgv_detailMatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_teamHome;
        private System.Windows.Forms.Label label_teamAway;
    }
}