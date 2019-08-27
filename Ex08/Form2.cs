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
    public partial class Form2 : Form
    {
        //Player
        private BUS_SanPham bus;
        private En_SanPham en;
        //End Player

        //Controls
        private ComboBox cboLoaiSP = new ComboBox();

        private Label lblLoaiSP = new Label();
        private Label lblTenSP = new Label();
        private Label lblDonVi = new Label();
        private Label lblDonGia = new Label();
        private Label lblSoTon = new Label();

        private TextBox txtTenSP = new TextBox();
        private TextBox txtDonVi = new TextBox();
        private TextBox txtDonGia = new TextBox();
        private TextBox txtSoTon = new TextBox();

        private Button btnThemMoi = new Button();
        private Button btnCapNhat = new Button();
        private Button btnXoa = new Button();

        private ListView listView1 = new ListView();
        //End Controls

        public Form2()
        {
            InitializeComponent();

            //Set up the form.
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(545, 374);
            this.Text = "Sản phẩm";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            //Label
            this.lblLoaiSP.Text = "Loại SP";
            this.lblLoaiSP.Location = new System.Drawing.Point(12, 15);
            this.lblLoaiSP.Size = new System.Drawing.Size(44, 13);

            this.lblTenSP.Text = "Tên SP";
            this.lblTenSP.Location = new System.Drawing.Point(189, 15);
            this.lblTenSP.Size = new System.Drawing.Size(43, 13);

            this.lblDonVi.Text = "Đơn vị";
            this.lblDonVi.Location = new System.Drawing.Point(394, 15);
            this.lblDonVi.Size = new System.Drawing.Size(38, 13);

            this.lblDonGia.Text = "Đơn giá";
            this.lblDonGia.Location = new System.Drawing.Point(189, 41);
            this.lblDonGia.Size = new System.Drawing.Size(44, 13);

            this.lblSoTon.Text = "Số tồn";
            this.lblSoTon.Location = new System.Drawing.Point(394, 41);
            this.lblSoTon.Size = new System.Drawing.Size(38, 13);
            //End Label

            //ComboBox
            this.cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboLoaiSP.Location = new System.Drawing.Point(62, 12);
            this.cboLoaiSP.Size = new System.Drawing.Size(121, 21);
            //End ComboBox

            //Textbox
            this.txtTenSP.Location = new System.Drawing.Point(238, 12);
            this.txtTenSP.Size = new System.Drawing.Size(150, 20);

            this.txtDonVi.Location = new System.Drawing.Point(438, 12);
            this.txtDonVi.Size = new System.Drawing.Size(80, 20);

            this.txtDonGia.Location = new System.Drawing.Point(239, 38);
            this.txtDonGia.Size = new System.Drawing.Size(80, 20);

            this.txtSoTon.Location = new System.Drawing.Point(438, 38);
            this.txtSoTon.Size = new System.Drawing.Size(80, 20);
            //End Textbox

            //Button
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Location = new System.Drawing.Point(62, 64);
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);

            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Location = new System.Drawing.Point(143, 64);
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(224, 64);
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            //End Button

            //Listview
            listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(62, 93);
            this.listView1.Size = new System.Drawing.Size(456, 236);
            //End Listview

            this.Controls.Add(lblLoaiSP);
            this.Controls.Add(lblTenSP);
            this.Controls.Add(lblDonVi);
            this.Controls.Add(lblDonGia);
            this.Controls.Add(lblSoTon);

            this.Controls.Add(cboLoaiSP);

            this.Controls.Add(txtTenSP);
            this.Controls.Add(txtDonVi);
            this.Controls.Add(txtDonGia);
            this.Controls.Add(txtSoTon);

            this.Controls.Add(btnThemMoi);
            this.Controls.Add(btnCapNhat);
            this.Controls.Add(btnXoa);

            this.Controls.Add(listView1);

            en = new En_SanPham();

            NapLoaiSP();
            NapSanPham();

            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChange);

            listView1.Click += new System.EventHandler(this.listView1_SelectedIndexChange);

            btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
        }

        //Function
        void XoaForm()
        {
            txtTenSP.Text = "";
            txtDonVi.Text = "";
            txtDonGia.Text = "";
            txtSoTon.Text = "";
        }

        void NapLoaiSP()
        {
            cboLoaiSP.Items.Clear();

            DataTable dt = new DataTable();
            bus = new BUS_SanPham();

            dt = bus.showdata();

            var item = new Dictionary<string, string>();
            foreach (DataRow dr in dt.Rows)
            {
                item.Add(dr["MaLoai"].ToString(), dr["TenLoai"].ToString());
            }
            cboLoaiSP.DataSource = new BindingSource(item, null);
            cboLoaiSP.DisplayMember = "Value";
            cboLoaiSP.ValueMember = "Key";
        }

        void NapSanPham()
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();

            listView1.Columns.Add("Mã SP", 0);
            listView1.Columns.Add("Tên SP", 140);
            listView1.Columns.Add("Đơn vị", 80);
            listView1.Columns.Add("Đơn giá", 80);
            listView1.Columns.Add("Số tồn", 80);

            DataTable dt = new DataTable();
            bus = new BUS_SanPham();

            dt = bus.selectdata(cboLoaiSP.SelectedValue.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem listitem = new ListViewItem(dr["MaSP"].ToString());
                listitem.SubItems.Add(dr["TenSP"].ToString());
                listitem.SubItems.Add(dr["DonViTinh"].ToString());
                listitem.SubItems.Add(dr["DonGiaMua"].ToString());
                listitem.SubItems.Add(dr["SoTon"].ToString());
                listView1.Items.Add(listitem);
            }
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }

        void cboLoaiSP_SelectedIndexChange(object sender, EventArgs e)
        {
            NapSanPham();
            XoaForm();
        }

        void btnThemMoi_Click(object sender, EventArgs e)
        {
            en.TenSP = txtTenSP.Text;
            en.DonVi = txtDonVi.Text;
            en.DonGia = float.Parse(txtDonGia.Text);
            en.SoTon = Int64.Parse(txtSoTon.Text);
            en.MaLoai = cboLoaiSP.SelectedValue.ToString();

            bus.insertdata(en);
            MessageBox.Show("Đã thêm 1 dòng");
            NapSanPham();
            XoaForm();
        }

        void btnCapNhat_Click(object sender, EventArgs e)
        {
            en.TenSP = txtTenSP.Text;
            en.DonVi = txtDonVi.Text;
            en.DonGia = float.Parse(txtDonGia.Text);
            en.SoTon = Int64.Parse(txtSoTon.Text);
            en.MaSP = listView1.SelectedItems[0].Text;

            bus.updatedata(en);
            MessageBox.Show("Đã cập nhật 1 dòng");
            NapSanPham();
            XoaForm();
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            en.MaSP = listView1.SelectedItems[0].Text;

            bus.deletedata(en);
            MessageBox.Show("Đã xóa 1 dòng");
            NapSanPham();
            XoaForm();
        }

        void listView1_SelectedIndexChange(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem it = listView1.SelectedItems[0];
                txtTenSP.Text = it.SubItems[1].Text;
                txtDonVi.Text = it.SubItems[2].Text;
                txtDonGia.Text = it.SubItems[3].Text;
                txtSoTon.Text = it.SubItems[4].Text;
            }
        }
        //End Function
    }
}
