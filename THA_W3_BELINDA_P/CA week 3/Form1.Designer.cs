namespace CA_week_3
{
    partial class MainWindowForm
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
            this.btn_toForm2 = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_favArtist = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_artist = new System.Windows.Forms.TextBox();
            this.cb_confirm = new System.Windows.Forms.CheckBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_toForm2
            // 
            this.btn_toForm2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_toForm2.Location = new System.Drawing.Point(1280, 547);
            this.btn_toForm2.Name = "btn_toForm2";
            this.btn_toForm2.Size = new System.Drawing.Size(378, 75);
            this.btn_toForm2.TabIndex = 0;
            this.btn_toForm2.Text = "Open 2nd Form";
            this.btn_toForm2.UseVisualStyleBackColor = true;
            this.btn_toForm2.Click += new System.EventHandler(this.btn_toForm2_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(125, 175);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(128, 54);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // label_favArtist
            // 
            this.label_favArtist.AutoSize = true;
            this.label_favArtist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_favArtist.Location = new System.Drawing.Point(125, 302);
            this.label_favArtist.Name = "label_favArtist";
            this.label_favArtist.Size = new System.Drawing.Size(335, 54);
            this.label_favArtist.TabIndex = 2;
            this.label_favArtist.Text = "My Favorite Artist";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(500, 182);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(886, 47);
            this.txt_nama.TabIndex = 3;
            // 
            // txt_artist
            // 
            this.txt_artist.Location = new System.Drawing.Point(500, 302);
            this.txt_artist.Name = "txt_artist";
            this.txt_artist.Size = new System.Drawing.Size(886, 47);
            this.txt_artist.TabIndex = 4;
            // 
            // cb_confirm
            // 
            this.cb_confirm.AutoSize = true;
            this.cb_confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_confirm.Location = new System.Drawing.Point(125, 419);
            this.cb_confirm.Name = "cb_confirm";
            this.cb_confirm.Size = new System.Drawing.Size(714, 58);
            this.cb_confirm.TabIndex = 5;
            this.cb_confirm.Text = "All of the content I put above is true!";
            this.cb_confirm.UseVisualStyleBackColor = true;
            this.cb_confirm.CheckedChanged += new System.EventHandler(this.cb_confirm_CheckedChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_submit.Location = new System.Drawing.Point(125, 547);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(258, 75);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 1201);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cb_confirm);
            this.Controls.Add(this.txt_artist);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.label_favArtist);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.btn_toForm2);
            this.Name = "MainWindowForm";
            this.Text = "Main WIndow Form";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_toForm2;
        private Label label_name;
        private Label label_favArtist;
        private TextBox txt_nama;
        private TextBox txt_artist;
        private CheckBox cb_confirm;
        private Button btn_submit;
    }
}