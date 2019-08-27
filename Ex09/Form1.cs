using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex09
{
    public partial class Form1 : Form
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

        private Button btnMore = new Button();
        private Button btnThemMoi = new Button();
        private Button btnCapNhat = new Button();
        private Button btnXoa = new Button();
        private Button btnThoat = new Button();

        //private ListView listView1 = new ListView();
        private DataGridView dgv = new DataGridView();

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        //End Controls

        public Form1()
        {
            InitializeComponent();

            //Set up the form.
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(450, 450);
            this.Text = "Sản phẩm";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            //Label
            this.lblLoaiSP.Text = "Loại Sản Phẩm";
            this.lblLoaiSP.Location = new System.Drawing.Point(12, 15);
            this.lblLoaiSP.Size = new System.Drawing.Size(79, 13);

            this.lblTenSP.Text = "Tên Sản Phẩm";
            this.lblTenSP.Location = new System.Drawing.Point(12, 42);
            this.lblTenSP.Size = new System.Drawing.Size(78, 13);

            this.lblDonGia.Text = "Đơn giá";
            this.lblDonGia.Location = new System.Drawing.Point(12, 68);
            this.lblDonGia.Size = new System.Drawing.Size(44, 13);

            this.lblDonVi.Text = "Đơn vị tính";
            this.lblDonVi.Location = new System.Drawing.Point(265, 42);
            this.lblDonVi.Size = new System.Drawing.Size(60, 13);

            this.lblSoTon.Text = "Số tồn";
            this.lblSoTon.Location = new System.Drawing.Point(265, 68);
            this.lblSoTon.Size = new System.Drawing.Size(38, 13);
            //End Label

            //ComboBox
            this.cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboLoaiSP.Location = new System.Drawing.Point(97, 12);
            this.cboLoaiSP.Size = new System.Drawing.Size(121, 21);
            //End ComboBox

            //Textbox
            this.txtTenSP.Location = new System.Drawing.Point(97, 39);
            this.txtTenSP.Size = new System.Drawing.Size(162, 20);

            this.txtDonGia.Location = new System.Drawing.Point(97, 65);
            this.txtDonGia.Size = new System.Drawing.Size(121, 20);

            this.txtDonVi.Location = new System.Drawing.Point(331, 39);
            this.txtDonVi.Size = new System.Drawing.Size(97, 20);

            this.txtSoTon.Location = new System.Drawing.Point(331, 65);
            this.txtSoTon.Size = new System.Drawing.Size(97, 20);
            //End Textbox

            //Button
            this.btnMore.Text = "...";
            this.btnMore.Location = new System.Drawing.Point(224, 10);
            this.btnMore.Size = new System.Drawing.Size(35, 23);

            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Location = new System.Drawing.Point(12, 91);
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);

            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Location = new System.Drawing.Point(93, 91);
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(174, 91);
            this.btnXoa.Size = new System.Drawing.Size(75, 23);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(255, 91);
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            //End Button

            //Listview
            //listView1.FullRowSelect = true;
            //this.listView1.Location = new System.Drawing.Point(62, 93);
            //this.listView1.Size = new System.Drawing.Size(456, 236);
            //End Listview

            //DataGridView
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ReadOnly = true;
            this.dgv.MultiSelect = false;
            this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Location = new System.Drawing.Point(12, 120);
            this.dgv.Size = new System.Drawing.Size(416, 285);
            //End DataGridView

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

            this.Controls.Add(btnMore);
            this.Controls.Add(btnThemMoi);
            this.Controls.Add(btnCapNhat);
            this.Controls.Add(btnXoa);
            this.Controls.Add(btnThoat);

            //this.Controls.Add(listView1);
            this.Controls.Add(dgv);

            en = new En_SanPham();
            
            NapLoaiSP();
            NapSanPham();

            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChange);
            //listView1.Click += new System.EventHandler(this.listView1_SelectedIndexChange);
            this.dgv.Click += new System.EventHandler(this.dgv_SelectedIndexChange);

            btnMore.Click += new System.EventHandler(this.btnMore_Click);
            btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            DataTable dt = new DataTable();
            bus = new BUS_SanPham();

            dt = bus.selectdata(cboLoaiSP.SelectedValue.ToString());
            dgv.DataSource = dt;

            if (dgv.ColumnCount > 0)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "Tên sản phẩm";
                dgv.Columns[2].HeaderText = "Đơn vị";
                dgv.Columns[3].HeaderText = "Đơn giá";
                dgv.Columns[4].HeaderText = "Số tồn";
            }

            for (int i = 0; i <= dgv.Columns.Count - 1; i++)
            {
                int colw = dgv.Columns[i].Width;
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgv.Columns[i].Width = colw;
            }

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Plum;
        }

        void cboLoaiSP_SelectedIndexChange(object sender, EventArgs e)
        {
            NapSanPham();
            XoaForm();
        }

        void btnMore_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.MdiParent = this.MdiParent;
            frm.Show();
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
            int index = dgv.CurrentCell.RowIndex;
            en.MaSP = dgv.Rows[index].Cells["MaSP"].Value.ToString();

            bus.updatedata(en);
            MessageBox.Show("Đã cập nhật 1 dòng");
            NapSanPham();
            XoaForm();
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentCell.RowIndex;
            en.MaSP = dgv.Rows[index].Cells["MaSP"].Value.ToString();

            bus.deletedata(en);
            MessageBox.Show("Đã xóa 1 dòng");
            NapSanPham();
            XoaForm();
        }

        void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void dgv_SelectedIndexChange(object sender, EventArgs e)
        {
            try
            {
                if (dgv.RowCount < 1)
                    return;
                int index = dgv.CurrentCell.RowIndex;
                string TenSP = dgv.Rows[index].Cells["TenSP"].Value.ToString();
                string DonGia = dgv.Rows[index].Cells["DonGiaMua"].Value.ToString();
                string DonViTinh = dgv.Rows[index].Cells["DonViTinh"].Value.ToString();
                string SoTon = dgv.Rows[index].Cells["SoTon"].Value.ToString();

                txtTenSP.Text = TenSP;
                txtDonGia.Text = DonGia;
                txtDonVi.Text = DonViTinh;
                txtSoTon.Text = SoTon;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }
        //End Function
    }
}
