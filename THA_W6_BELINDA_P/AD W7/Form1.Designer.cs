namespace AD_W7
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
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_wordle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(254, 320);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(188, 70);
            this.btn_start.TabIndex = 32;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(228, 242);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(250, 47);
            this.txt_input.TabIndex = 31;
            this.txt_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 46);
            this.label1.TabIndex = 30;
            this.label1.Text = "Set how much you can guess!";
            // 
            // label_wordle
            // 
            this.label_wordle.AutoSize = true;
            this.label_wordle.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_wordle.Location = new System.Drawing.Point(228, 97);
            this.label_wordle.Name = "label_wordle";
            this.label_wordle.Size = new System.Drawing.Size(252, 71);
            this.label_wordle.TabIndex = 29;
            this.label_wordle.Text = "WORDLE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 495);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_wordle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_start;
        private TextBox txt_input;
        private Label label1;
        private Label label_wordle;
    }
}