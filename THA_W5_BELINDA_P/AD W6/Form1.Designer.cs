namespace AD_W6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView_showProducts = new System.Windows.Forms.DataGridView();
            this.dataGridView2_viewCategory = new System.Windows.Forms.DataGridView();
            this.label_product = new System.Windows.Forms.Label();
            this.label_namaDetails = new System.Windows.Forms.Label();
            this.label_categoryDetails = new System.Windows.Forms.Label();
            this.label_stockDetails = new System.Windows.Forms.Label();
            this.label_namaCategory = new System.Windows.Forms.Label();
            this.label_hargaDetails = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.label_details = new System.Windows.Forms.Label();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_editProduct = new System.Windows.Forms.Button();
            this.btn_removeProduct = new System.Windows.Forms.Button();
            this.btn_removeCategory = new System.Windows.Forms.Button();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.txt_namaDetails = new System.Windows.Forms.TextBox();
            this.txt_hargaDetails = new System.Windows.Forms.TextBox();
            this.txt_stockDetails = new System.Windows.Forms.TextBox();
            this.comboBox_filterDetails = new System.Windows.Forms.ComboBox();
            this.txt_namaCategory = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_filterItems = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_viewCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_showProducts
            // 
            this.dataGridView_showProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_showProducts.Location = new System.Drawing.Point(70, 167);
            this.dataGridView_showProducts.Name = "dataGridView_showProducts";
            this.dataGridView_showProducts.ReadOnly = true;
            this.dataGridView_showProducts.RowHeadersWidth = 102;
            this.dataGridView_showProducts.RowTemplate.Height = 49;
            this.dataGridView_showProducts.Size = new System.Drawing.Size(1353, 675);
            this.dataGridView_showProducts.TabIndex = 0;
            this.dataGridView_showProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_showProducts_CellClick);
            // 
            // dataGridView2_viewCategory
            // 
            this.dataGridView2_viewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_viewCategory.Location = new System.Drawing.Point(1530, 167);
            this.dataGridView2_viewCategory.Name = "dataGridView2_viewCategory";
            this.dataGridView2_viewCategory.RowHeadersWidth = 102;
            this.dataGridView2_viewCategory.RowTemplate.Height = 49;
            this.dataGridView2_viewCategory.Size = new System.Drawing.Size(696, 522);
            this.dataGridView2_viewCategory.TabIndex = 1;
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_product.Location = new System.Drawing.Point(70, 87);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(202, 62);
            this.label_product.TabIndex = 2;
            this.label_product.Text = "Product";
            // 
            // label_namaDetails
            // 
            this.label_namaDetails.AutoSize = true;
            this.label_namaDetails.Location = new System.Drawing.Point(94, 1005);
            this.label_namaDetails.Name = "label_namaDetails";
            this.label_namaDetails.Size = new System.Drawing.Size(103, 41);
            this.label_namaDetails.TabIndex = 5;
            this.label_namaDetails.Text = "Nama:";
            // 
            // label_categoryDetails
            // 
            this.label_categoryDetails.AutoSize = true;
            this.label_categoryDetails.Location = new System.Drawing.Point(94, 1099);
            this.label_categoryDetails.Name = "label_categoryDetails";
            this.label_categoryDetails.Size = new System.Drawing.Size(146, 41);
            this.label_categoryDetails.TabIndex = 6;
            this.label_categoryDetails.Text = "Category:";
            // 
            // label_stockDetails
            // 
            this.label_stockDetails.AutoSize = true;
            this.label_stockDetails.Location = new System.Drawing.Point(94, 1286);
            this.label_stockDetails.Name = "label_stockDetails";
            this.label_stockDetails.Size = new System.Drawing.Size(97, 41);
            this.label_stockDetails.TabIndex = 7;
            this.label_stockDetails.Text = "Stock:";
            // 
            // label_namaCategory
            // 
            this.label_namaCategory.AutoSize = true;
            this.label_namaCategory.Location = new System.Drawing.Point(1530, 760);
            this.label_namaCategory.Name = "label_namaCategory";
            this.label_namaCategory.Size = new System.Drawing.Size(103, 41);
            this.label_namaCategory.TabIndex = 8;
            this.label_namaCategory.Text = "Nama:";
            // 
            // label_hargaDetails
            // 
            this.label_hargaDetails.AutoSize = true;
            this.label_hargaDetails.Location = new System.Drawing.Point(94, 1185);
            this.label_hargaDetails.Name = "label_hargaDetails";
            this.label_hargaDetails.Size = new System.Drawing.Size(104, 41);
            this.label_hargaDetails.TabIndex = 9;
            this.label_hargaDetails.Text = "Harga:";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_category.Location = new System.Drawing.Point(1530, 87);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(228, 62);
            this.label_category.TabIndex = 10;
            this.label_category.Text = "Category";
            // 
            // label_details
            // 
            this.label_details.AutoSize = true;
            this.label_details.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_details.Location = new System.Drawing.Point(70, 898);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(177, 62);
            this.label_details.TabIndex = 11;
            this.label_details.Text = "Details";
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(809, 81);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(140, 58);
            this.btn_all.TabIndex = 12;
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(955, 81);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(140, 58);
            this.btn_filter.TabIndex = 13;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(827, 1286);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(227, 162);
            this.btn_addProduct.TabIndex = 16;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.Location = new System.Drawing.Point(1060, 1286);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.Size = new System.Drawing.Size(227, 162);
            this.btn_editProduct.TabIndex = 17;
            this.btn_editProduct.Text = "Edit Product";
            this.btn_editProduct.UseVisualStyleBackColor = true;
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.Location = new System.Drawing.Point(1293, 1286);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Size = new System.Drawing.Size(227, 162);
            this.btn_removeProduct.TabIndex = 18;
            this.btn_removeProduct.Text = "Remove Product";
            this.btn_removeProduct.UseVisualStyleBackColor = true;
            // 
            // btn_removeCategory
            // 
            this.btn_removeCategory.Location = new System.Drawing.Point(1999, 836);
            this.btn_removeCategory.Name = "btn_removeCategory";
            this.btn_removeCategory.Size = new System.Drawing.Size(227, 162);
            this.btn_removeCategory.TabIndex = 19;
            this.btn_removeCategory.Text = "Remove Category";
            this.btn_removeCategory.UseVisualStyleBackColor = true;
            this.btn_removeCategory.Click += new System.EventHandler(this.btn_removeCategory_Click);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Location = new System.Drawing.Point(1757, 836);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(227, 162);
            this.btn_addCategory.TabIndex = 20;
            this.btn_addCategory.Text = "Add Category";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // txt_namaDetails
            // 
            this.txt_namaDetails.Location = new System.Drawing.Point(268, 999);
            this.txt_namaDetails.Name = "txt_namaDetails";
            this.txt_namaDetails.Size = new System.Drawing.Size(874, 47);
            this.txt_namaDetails.TabIndex = 21;
            // 
            // txt_hargaDetails
            // 
            this.txt_hargaDetails.Location = new System.Drawing.Point(268, 1185);
            this.txt_hargaDetails.Name = "txt_hargaDetails";
            this.txt_hargaDetails.Size = new System.Drawing.Size(874, 47);
            this.txt_hargaDetails.TabIndex = 22;
            this.txt_hargaDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hargaDetails_KeyPress);
            // 
            // txt_stockDetails
            // 
            this.txt_stockDetails.Location = new System.Drawing.Point(268, 1280);
            this.txt_stockDetails.Name = "txt_stockDetails";
            this.txt_stockDetails.Size = new System.Drawing.Size(265, 47);
            this.txt_stockDetails.TabIndex = 23;
            this.txt_stockDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stockDetails_KeyPress);
            // 
            // comboBox_filterDetails
            // 
            this.comboBox_filterDetails.FormattingEnabled = true;
            this.comboBox_filterDetails.Location = new System.Drawing.Point(268, 1091);
            this.comboBox_filterDetails.Name = "comboBox_filterDetails";
            this.comboBox_filterDetails.Size = new System.Drawing.Size(302, 49);
            this.comboBox_filterDetails.TabIndex = 24;
            // 
            // txt_namaCategory
            // 
            this.txt_namaCategory.Location = new System.Drawing.Point(1639, 760);
            this.txt_namaCategory.Name = "txt_namaCategory";
            this.txt_namaCategory.Size = new System.Drawing.Size(587, 47);
            this.txt_namaCategory.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1763, 1069);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_filterItems
            // 
            this.comboBox_filterItems.FormattingEnabled = true;
            this.comboBox_filterItems.Location = new System.Drawing.Point(1121, 87);
            this.comboBox_filterItems.Name = "comboBox_filterItems";
            this.comboBox_filterItems.Size = new System.Drawing.Size(302, 49);
            this.comboBox_filterItems.TabIndex = 27;
            this.comboBox_filterItems.SelectedIndexChanged += new System.EventHandler(this.comboBox_filterItems_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(2292, 1557);
            this.Controls.Add(this.comboBox_filterItems);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_namaCategory);
            this.Controls.Add(this.comboBox_filterDetails);
            this.Controls.Add(this.txt_stockDetails);
            this.Controls.Add(this.txt_hargaDetails);
            this.Controls.Add(this.txt_namaDetails);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.btn_removeCategory);
            this.Controls.Add(this.btn_removeProduct);
            this.Controls.Add(this.btn_editProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.label_details);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.label_hargaDetails);
            this.Controls.Add(this.label_namaCategory);
            this.Controls.Add(this.label_stockDetails);
            this.Controls.Add(this.label_categoryDetails);
            this.Controls.Add(this.label_namaDetails);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.dataGridView2_viewCategory);
            this.Controls.Add(this.dataGridView_showProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_viewCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView_showProducts;
        private DataGridView dataGridView2_viewCategory;
        private Label label_product;
        private Label label_namaDetails;
        private Label label_categoryDetails;
        private Label label_stockDetails;
        private Label label_namaCategory;
        private Label label_hargaDetails;
        private Label label_category;
        private Label label_details;
        private Button btn_all;
        private Button btn_filter;
        private Button btn_addProduct;
        private Button btn_editProduct;
        private Button btn_removeProduct;
        private Button btn_removeCategory;
        private Button btn_addCategory;
        private TextBox txt_namaDetails;
        private TextBox txt_hargaDetails;
        private TextBox txt_stockDetails;
        private ComboBox comboBox_filterDetails;
        private TextBox txt_namaCategory;
        private PictureBox pictureBox1;
        private ComboBox comboBox_filterItems;
    }
}