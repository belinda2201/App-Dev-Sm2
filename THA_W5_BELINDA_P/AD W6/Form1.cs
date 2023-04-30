using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AD_W6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showAll();
            dataGridView2_viewCategory.DataSource = dtCategory;
            updateComboBox();
        }

        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        int selected_row = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView2_viewCategory.DataSource = dtCategory;

            //disable combobox filter
            comboBox_filterItems.Enabled = false;

            //nambah kolom di dgv tampilin produk
            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");
            dataGridView_showProducts.DataSource = dtProdukTampil;

            //nambah kolom di dgv tampilih kategori sama id barang
            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");
            

            //tambahin barang dulu biar pas run udh ada barang
            dtProdukTampil.Rows.Add("J001", "Jas Hitam", 100000, 10, "C1");
            dtProdukTampil.Rows.Add("T001", "T-Shirt Black Pink", 70000, 20, "C2");
            dtProdukTampil.Rows.Add("T002", "T-Shirt Obsessive", 75000, 16, "C2");
            dtProdukTampil.Rows.Add("R001", "Rok mini", 82000, 26, "C3");
            dtProdukTampil.Rows.Add("J002", "Jeans Biru", 90000, 5, "C4");
            dtProdukTampil.Rows.Add("J002", "Jeans Biru", 90000, 5, "C4");
            dtProdukTampil.Rows.Add("C001", "Celana Pendek Coklat", 60000, 11, "C4");
            dtProdukTampil.Rows.Add("J002", "Cawat Blink-blink", 1000000, 1, "C5");
            dtProdukTampil.Rows.Add("R003", "Rocca Shirt", 50000, 8, "C2");

            //tambahin barang ke category
            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-Shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");

            //masukin ke comboBox filter
            dataGridView2_viewCategory.DataSource = dtCategory;
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            showAll();
            comboBox_filterItems.Enabled= false;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {           
            comboBox_filterItems.Enabled = true;           
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            string addCategory = txt_namaCategory.Text;
            bool ketemu = false;
            var adaID = dtCategory.AsEnumerable().Select(row => row.Field<string>("ID Category"));

            if (!string.IsNullOrEmpty(txt_namaCategory.Text))
            {
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i]["Nama Category"].ToString() == addCategory)
                    {
                        ketemu = true;
                    }
                }
                if (ketemu == true)
                {
                    MessageBox.Show("Error", "Kategori sudah ada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string hurufAwal = "C";
                    int newId = 1;

                    while (adaID.Contains(hurufAwal + newId))
                    {
                        newId++;
                    }
                    string IDBaru = hurufAwal + newId;
                    DataRow row = dtCategory.NewRow();
                    row[0] = IDBaru;
                    row[1] = addCategory;
                    dtCategory.Rows.Add(row);
                    updateComboBox();
                }

            }
            else
            {
                MessageBox.Show("Isi Field yang Kosong", "Field belum diisi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_namaCategory.Focus();

            }
        }

        private void btn_removeCategory_Click(object sender, EventArgs e)
        {
            string simpan = txt_namaCategory.Text;
            string id = "";
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i]["Nama Category"].ToString() == simpan)
                {
                    id = dtCategory.Rows[i]["ID Category"].ToString();
                    dtCategory.Rows[i].Delete();
                    break;
                }
            }
            for (int j = 0; j < dtProdukSimpan.Rows.Count; j++)
            {
                if (dtProdukSimpan.Rows[j]["ID Category"].ToString() == id)
                {
                    dtProdukSimpan.Rows[j].Delete();
                    j--;
                }
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_namaDetails.Text) && !string.IsNullOrEmpty(txt_hargaDetails.Text) && !string.IsNullOrEmpty(txt_stockDetails.Text))
            {
                DataRow myDataRow, myDataRow1;
                string nama = txt_namaDetails.Text;
                string category = comboBox_filterDetails.SelectedItem.ToString();
                string harga = txt_hargaDetails.Text;
                string stok = txt_stockDetails.Text;
                int countnama = 1;

                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (dtProdukSimpan.Rows[i]["Nama Product"].ToString() == nama)
                    {
                        int nomor = dtProdukSimpan.Rows[i]["ID Product"].ToString()[3] - 48;
                        if (countnama <= nomor)
                            countnama = nomor + 1;
                    }
                }
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i]["Nama Category"].ToString() == category)
                    {
                        category = dtCategory.Rows[i]["ID Category"].ToString();
                        break;
                    }
                }

               
                    myDataRow = dtProdukSimpan.NewRow();
                    myDataRow["ID Product"] = nama[0] + "00" + countnama.ToString();
                    myDataRow["Nama Product"] = nama;
                    myDataRow["Harga"] = harga.ToString();
                    myDataRow["Stock"] = stok.ToString();
                    myDataRow["ID Category"] = category.ToString();
                    dtProdukSimpan.Rows.Add(myDataRow);

                    myDataRow1 = dtProdukTampil.NewRow();
                    myDataRow1["ID Product"] = nama[0] + "00" + countnama.ToString();
                    myDataRow1["Nama Product"] = nama;
                    myDataRow1["Harga"] = harga.ToString();
                    myDataRow1["Stock"] = stok.ToString();
                    myDataRow1["ID Category"] = category;
                    dtProdukTampil.Rows.Add(myDataRow1);
                
            }
            else
            {
                MessageBox.Show("Field belum diisi", "Isi Field yang Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_namaCategory.Focus();

            }
        }

        private void dataGridView_showProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            selected_row = rowIndex;
            if (rowIndex < dtProdukTampil.Rows.Count)
            {
                string category = dtProdukTampil.Rows[rowIndex]["ID Category"].ToString();
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i]["ID Category"].ToString() == category)
                    {
                        category = dtCategory.Rows[i]["Nama Category"].ToString();
                        break;
                    }
                }
                txt_namaDetails.Text = (dtProdukTampil.Rows[rowIndex]["Nama Product"].ToString());
                txt_hargaDetails.Text = (dtProdukTampil.Rows[rowIndex]["Harga"].ToString());
                comboBox_filterDetails.SelectedItem = category;
                txt_stockDetails.Text = (dtProdukTampil.Rows[rowIndex]["Stock"].ToString());
            }
        }

        private void comboBox_filterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = comboBox_filterItems.SelectedItem.ToString();
            string idcategory = "";
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i]["Nama Category"].ToString() == category)
                {
                    idcategory = dtCategory.Rows[i]["ID Category"].ToString();
                }
            }
            DataRow myDataRow;
            dtProdukTampil.Rows.Clear();
            for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
            {
                if (dtProdukSimpan.Rows[i]["ID Category"].ToString() == idcategory)
                {
                    myDataRow = dtProdukTampil.NewRow();
                    myDataRow["ID Product"] = dtProdukSimpan.Rows[i]["ID Product"].ToString();
                    myDataRow["Nama Product"] = dtProdukSimpan.Rows[i]["Nama Product"].ToString();
                    myDataRow["Harga"] = dtProdukSimpan.Rows[i]["Harga"].ToString();
                    myDataRow["Stock"] = dtProdukSimpan.Rows[i]["Stock"].ToString();
                    myDataRow["ID Category"] = dtProdukSimpan.Rows[i]["ID Category"].ToString();
                    dtProdukTampil.Rows.Add(myDataRow);
                }
            }
            dataGridView_showProducts.DataSource = dtProdukTampil;
        }

        public void updateComboBox()
        {
            comboBox_filterDetails.Items.Clear();
            comboBox_filterItems.Items.Clear();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                comboBox_filterDetails.Items.Add(dtCategory.Rows[i]["Nama Category"].ToString());
                comboBox_filterItems.Items.Add(dtCategory.Rows[i]["Nama Category"].ToString());
            }
        }

        public void showAll()
        {
            dtProdukTampil.Rows.Clear();
            foreach (DataRow dr in dtProdukSimpan.Rows)
            {
                dtProdukTampil.Rows.Add(dr.ItemArray);
            }
            dataGridView_showProducts.DataSource = dtProdukTampil;
        }

        private void txt_hargaDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_stockDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
