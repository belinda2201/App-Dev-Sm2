namespace AD_week3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nama = new System.Windows.Forms.TextBox();
            this.txt_Umur = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Notelp = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // txt_Nama
            // 
            this.txt_Nama.Location = new System.Drawing.Point(478, 142);
            this.txt_Nama.Name = "txt_Nama";
            this.txt_Nama.Size = new System.Drawing.Size(876, 47);
            this.txt_Nama.TabIndex = 4;
            // 
            // txt_Umur
            // 
            this.txt_Umur.Location = new System.Drawing.Point(478, 229);
            this.txt_Umur.Name = "txt_Umur";
            this.txt_Umur.Size = new System.Drawing.Size(876, 47);
            this.txt_Umur.TabIndex = 5;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(478, 317);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(876, 47);
            this.txt_Email.TabIndex = 6;
            // 
            // txt_Notelp
            // 
            this.txt_Notelp.Location = new System.Drawing.Point(478, 399);
            this.txt_Notelp.Name = "txt_Notelp";
            this.txt_Notelp.Size = new System.Drawing.Size(876, 47);
            this.txt_Notelp.TabIndex = 7;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Clear.Location = new System.Drawing.Point(393, 582);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(188, 58);
            this.button_Clear.TabIndex = 8;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(959, 582);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(188, 58);
            this.button_Submit.TabIndex = 9;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 804);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.txt_Notelp);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Umur);
            this.Controls.Add(this.txt_Nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_Nama;
        private TextBox txt_Umur;
        private TextBox txt_Email;
        private TextBox txt_Notelp;
        private Button button_Clear;
        private Button button_Submit;
    }
}