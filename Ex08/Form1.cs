using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex08
{
    public partial class Form1 : Form
    {
        //Player
        private BUS_LoaiSanPham bus;
        private En_LoaiSanPham en;
        //End Player

        //Controls
        private Label lblMaLoai = new Label();
        private Label lblTenLoai = new Label();
        private Label lblMoTa = new Label();

        private TextBox txtMaLoai = new TextBox();
        private TextBox txtTenLoai = new TextBox();
        private TextBox txtMoTa = new TextBox();

        private Button btnThemMoi = new Button();
        private Button btnCapNhat = new Button();
        private Button btnXoa = new Button();

        private ListView listView1 = new ListView();
        //End Controls
        public Form1()
        {
            InitializeComponent();

            //Set up the form.
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.BackColor = Color.White;
            //this.ForeColor = Color.Black;
            this.Size = new System.Drawing.Size(435, 300);
            this.Text = "Loại sản phẩm";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            //Label
            this.lblMaLoai.Text = "Mã loại";
            this.lblMaLoai.Location = new System.Drawing.Point(12, 15);
            this.lblMaLoai.Size = new System.Drawing.Size(41, 13);

            this.lblTenLoai.Text = "Tên loại";
            this.lblTenLoai.Location = new System.Drawing.Point(115, 15);
            this.lblTenLoai.Size = new System.Drawing.Size(45, 13);

            this.lblMoTa.Text = "Mô tả";
            this.lblMoTa.Location = new System.Drawing.Point(272, 15);
            this.lblMoTa.Size = new System.Drawing.Size(34, 13);
            //End Label

            //Textbox
            //this.txtMaLoai.Text = "Text";
            this.txtMaLoai.Location = new System.Drawing.Point(59, 12);
            this.txtMaLoai.Size = new System.Drawing.Size(50, 20);
            this.txtMaLoai.Enabled = false;

            //this.txtTenLoai.Text = "Text";
            this.txtTenLoai.Location = new System.Drawing.Point(166, 12);
            this.txtTenLoai.Size = new System.Drawing.Size(100, 20);

            //this.txtMoTa.Text = "Text";
            this.txtMoTa.Location = new System.Drawing.Point(312, 12);
            this.txtMoTa.Size = new System.Drawing.Size(100, 20);
            //End Textbox

            //Button
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Location = new System.Drawing.Point(15, 38);
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);

            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Location = new System.Drawing.Point(96, 38);
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(177, 38);
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            //End Button

            //Listview
            this.listView1.MultiSelect = false;
            this.listView1.Location = new System.Drawing.Point(15, 67);
            this.listView1.Size = new System.Drawing.Size(237, 188);
            //End Listview

            this.Controls.Add(lblMaLoai);
            this.Controls.Add(lblTenLoai);
            this.Controls.Add(lblMoTa);

            this.Controls.Add(txtMaLoai);
            this.Controls.Add(txtTenLoai);
            this.Controls.Add(txtMoTa);

            this.Controls.Add(btnThemMoi);
            this.Controls.Add(btnCapNhat);
            this.Controls.Add(btnXoa);

            this.Controls.Add(listView1);

            en = new En_LoaiSanPham();

            LoadData();

            listView1.Click += new System.EventHandler(this.listView1_SelectedIndexChange);

            btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
        }

        private void DeleteText()
        {
            txtMaLoai.ResetText();
            txtTenLoai.ResetText();
            txtMoTa.ResetText();
        }

        private void LoadData()
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();

            listView1.Columns.Add("Mã loại");
            listView1.Columns.Add("Tên loại");
            listView1.Columns.Add("Mô tả");
            
            DataTable dt = new DataTable();
            bus = new BUS_LoaiSanPham();

            dt = bus.showdata();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem listitem = new ListViewItem(dr["MaLoai"].ToString());
                listitem.SubItems.Add(dr["TenLoai"].ToString());
                listitem.SubItems.Add(dr["MoTa"].ToString());
                listView1.Items.Add(listitem);
            }
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }

        void btnThemMoi_Click(object sender, EventArgs e)
        {
            en.TenLoai = txtTenLoai.Text;
            en.MoTa = txtMoTa.Text;

            bus.insertdata(en);
            MessageBox.Show("Đã thêm 1 dòng");
            DeleteText();
            LoadData();
        }

        void btnCapNhat_Click(object sender, EventArgs e)
        {
            en.TenLoai = txtTenLoai.Text;
            en.MoTa = txtMoTa.Text;
            en.MaLoai = txtMaLoai.Text;

            bus.updatedata(en);
            MessageBox.Show("Đã sửa 1 dòng");
            DeleteText();
            LoadData();
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            en.MaLoai = txtMaLoai.Text;

            bus.deletedata(en);
            MessageBox.Show("Đã xóa 1 dòng");
            DeleteText();
            LoadData();
        }

        void listView1_SelectedIndexChange(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem it = listView1.SelectedItems[0];
                txtMaLoai.Text = it.Text;
                txtTenLoai.Text = it.SubItems[1].Text;
                txtMoTa.Text = it.SubItems[2].Text;
            }
        }
    }
}
