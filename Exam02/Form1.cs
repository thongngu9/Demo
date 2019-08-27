using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangPhuThong_01_3Player
{
    public partial class Form1 : Form
    {
        //Player
        private BUS_SanPham bus;
        private En_SanPham en;
        //End Player

        //Controls
        private ComboBox cboLoaiSP = new ComboBox();

        private Label lbl1 = new Label();
        private Label lbl2 = new Label();
        private Label lbl3 = new Label();
        private Label lbl4 = new Label();
        private Label lbl5 = new Label();
        private Label lbl6 = new Label();

        private DataGridView dgv = new DataGridView();

        private NumericUpDown nud = new NumericUpDown();

        private TextBox txtMaSP = new TextBox();
        private TextBox txtTenSP = new TextBox();
        private TextBox txtGiaBan = new TextBox();

        private Button btnThem = new Button();
        private Button btnSua = new Button();
        private Button btnXoa = new Button();
        private Button btnHuy = new Button();
        private Button btnLuu = new Button();
        //End Controls

        public Form1()
        {
            InitializeComponent();

            //Set up the form.
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(600, 400);
            this.Text = "Quản lý sản phẩm theo loại";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            //ComboBox
            this.cboLoaiSP.Location = new System.Drawing.Point(94, 12);
            this.cboLoaiSP.Size = new System.Drawing.Size(200, 21);
            //End ComboBox

            //Label
            this.lbl1.Text = "Loại sản phẩm";
            this.lbl1.Location = new System.Drawing.Point(12, 15);
            this.lbl1.Size = new System.Drawing.Size(76, 13);

            this.lbl2.Text = "Thông tin sản phẩm dựa vào loại sản phẩm đã chọn";
            this.lbl2.Location = new System.Drawing.Point(12, 36);
            this.lbl2.Size = new System.Drawing.Size(254, 13);

            this.lbl3.Text = "Mã sản phẩm:";
            this.lbl3.Location = new System.Drawing.Point(16, 251);
            this.lbl3.Size = new System.Drawing.Size(74, 13);

            this.lbl4.Text = "Tên sản phẩm:";
            this.lbl4.Location = new System.Drawing.Point(12, 277);
            this.lbl4.Size = new System.Drawing.Size(78, 13);

            this.lbl5.Text = "Số lượng";
            this.lbl5.Location = new System.Drawing.Point(12, 277);
            this.lbl5.Size = new System.Drawing.Size(49, 13);

            this.lbl6.Text = "Giá bán:";
            this.lbl6.Location = new System.Drawing.Point(145, 302);
            this.lbl6.Size = new System.Drawing.Size(47, 13);
            //End Label

            //DataGridView
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ReadOnly = true;
            this.dgv.MultiSelect = false;
            this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Location = new System.Drawing.Point(15, 52);
            this.dgv.Size = new System.Drawing.Size(557, 190);
            //End DataGridView

            //NumericUpDown
            this.nud.Minimum = 0;
            this.nud.Maximum = 999999;
            this.nud.Location = new System.Drawing.Point(89, 300);
            this.nud.Size = new System.Drawing.Size(50, 20);
            //End NumericUpDown

            //Textbox
            this.txtMaSP.Location = new System.Drawing.Point(89, 248);
            this.txtMaSP.Size = new System.Drawing.Size(100, 20);

            this.txtTenSP.Location = new System.Drawing.Point(89, 274);
            this.txtTenSP.Size = new System.Drawing.Size(300, 20);

            this.txtGiaBan.Location = new System.Drawing.Point(198, 300);
            this.txtGiaBan.Size = new System.Drawing.Size(191, 20);
            //End Textbox

            //Button
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(173, 327);
            this.btnThem.Size = new System.Drawing.Size(75, 23);

            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(254, 326);
            this.btnSua.Size = new System.Drawing.Size(75, 23);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(335, 327);
            this.btnXoa.Size = new System.Drawing.Size(75, 23);

            this.btnHuy.Text = "Hủy";
            this.btnHuy.Location = new System.Drawing.Point(416, 327);
            this.btnHuy.Size = new System.Drawing.Size(75, 23);

            this.btnLuu.Text = "Lưu";
            this.btnLuu.Location = new System.Drawing.Point(497, 327);
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            //End Button

            this.Controls.Add(cboLoaiSP);

            this.Controls.Add(lbl1);
            this.Controls.Add(lbl2);
            this.Controls.Add(lbl3);
            this.Controls.Add(lbl4);
            this.Controls.Add(lbl5);
            this.Controls.Add(lbl6);

            this.Controls.Add(dgv);

            this.Controls.Add(nud);

            this.Controls.Add(txtMaSP);
            this.Controls.Add(txtTenSP);
            this.Controls.Add(txtGiaBan);

            this.Controls.Add(btnThem);
            this.Controls.Add(btnSua);
            this.Controls.Add(btnXoa);
            this.Controls.Add(btnHuy);
            this.Controls.Add(btnLuu);

            en = new En_SanPham();

            NapLoaiSP();
            NapSanPham();
            EvenButton(0);
            EnableOrDisable(true);

            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChange);
            this.dgv.Click += new System.EventHandler(this.dgv_SelectedIndexChange);

            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
        }

        //Function
        bool InsertNew;

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
                dgv.Columns[0].HeaderText = "Mã hàng";
                dgv.Columns[1].HeaderText = "Tên hàng";
                dgv.Columns[2].HeaderText = "Mã loại";
                dgv.Columns[3].HeaderText = "Số lượng";
                dgv.Columns[4].HeaderText = "Giá bán";
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
            EvenButton(0);
            EnableOrDisable(true);
        }

        void dgv_SelectedIndexChange(object sender, EventArgs e)
        {
            EvenButton(0);
            EnableOrDisable(true);
            try
            {
                if (dgv.RowCount < 1)
                    return;
                int index = dgv.CurrentCell.RowIndex;
                string MaHang = dgv.Rows[index].Cells["MaHang"].Value.ToString();
                string TenHang = dgv.Rows[index].Cells["TenHang"].Value.ToString();
                string SoLuong = dgv.Rows[index].Cells["SoLuong"].Value.ToString();
                string GiaBan = dgv.Rows[index].Cells["GiaBan"].Value.ToString();

                txtMaSP.Text = MaHang;
                txtTenSP.Text = TenHang;
                txtGiaBan.Text = GiaBan;
                nud.Value = Int32.Parse(SoLuong);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }

        void EvenButton(int cmd)
        {
            switch (cmd)
            {
                case 0://Trạng thái bình thường của button
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                    break;
                case 1://Thêm
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnHuy.Enabled = true;
                    btnLuu.Enabled = true;
                    break;
                case 2://Sửa --> Gọi lại case 1
                    break;
                case 3://Hủy --> Gọi lại case 0
                    break;
                case 4://Lưu --> Thành công thì gọi lại case 0
                    break;
                default:
                    break;
            }
        }

        void EnableOrDisable(bool isEnable)
        {
            if (isEnable)
            {
                txtMaSP.ReadOnly = true;
                txtTenSP.ReadOnly = true;
                txtGiaBan.ReadOnly = true;
                nud.ReadOnly = true;
            }
            else
            {
                txtMaSP.ReadOnly = false;
                txtTenSP.ReadOnly = false;
                txtGiaBan.ReadOnly = false;
                nud.ReadOnly = false;
            }
        }

        void XoaForm()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            nud.Value = 0;
        }

        void InserUpdateData()
        {
            if (txtMaSP.Text.Trim().Equals("") || txtTenSP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Điền Mã sản phẩm và Tên sản phẩm đầy đủ, sau đó thực hiện lại thao tác", "thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InsertNew == true)
            {
                try
                {
                    en.MaHang = txtMaSP.Text;
                    en.TenHang = txtTenSP.Text;
                    en.SoLuong = Int64.Parse(nud.Value.ToString());
                    en.GiaBan = float.Parse(txtGiaBan.Text);
                    en.MaLoai = cboLoaiSP.SelectedValue.ToString();

                    bus.insertdata(en);
                    MessageBox.Show("Đã thêm 1 dòng");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message.ToString());
                }
            }
            else
            {
                try
                {
                    en.MaHang = txtMaSP.Text;
                    en.TenHang = txtTenSP.Text;
                    en.SoLuong = Int64.Parse(nud.Value.ToString());
                    en.GiaBan = float.Parse(txtGiaBan.Text);

                    bus.updatedata(en);
                    MessageBox.Show("Đã cập nhật 1 dòng");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message.ToString());
                }
            }
            NapSanPham();
            XoaForm();
            EvenButton(0);
            EnableOrDisable(true);
        }

        void DeleteData()
        {
            int index = dgv.CurrentCell.RowIndex;
            en.MaHang = dgv.Rows[index].Cells["MaHang"].Value.ToString();

            bus.deletedata(en);
            MessageBox.Show("Đã xóa 1 dòng");
            NapSanPham();
            XoaForm();
        }

        void btnThem_Click(object sender, EventArgs e)
        {
            XoaForm();
            EvenButton(1);
            EnableOrDisable(false);
            InsertNew = true;
        }

        void btnSua_Click(object sender, EventArgs e)
        {
            EvenButton(1);
            EnableOrDisable(false);
            InsertNew = false;
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        void btnHuy_Click(object sender, EventArgs e)
        {
            EvenButton(0);
            EnableOrDisable(true);
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
            InserUpdateData();
        }
        //End Function
    }
}
