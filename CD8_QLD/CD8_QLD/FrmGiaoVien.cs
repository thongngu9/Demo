using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add Library
using BUS;
using Entity;

namespace CD8_QLD
{
    public partial class frmGiaoVien : Form
    {
        //Player
        private BUS_GiaoVien bus;
        private En_GiaoVien en;
        //End Player

        //Controls
        private GroupBox gb1 = new GroupBox();
        private GroupBox gb2 = new GroupBox();
        private GroupBox gb3 = new GroupBox();

        private Label lbl1 = new Label();
        private Label lbl2 = new Label();
        private Label lbl3 = new Label();
        private Label lbl4 = new Label();
        private Label lbl5 = new Label();
        private Label lbl6 = new Label();
        private Label lbl7 = new Label();
        private Label lbl8 = new Label();
        private Label lbl9 = new Label();
        private Label lbl10 = new Label();
        private Label lbl11 = new Label();

        private DataGridView dgv = new DataGridView();

        private TextBox txtMaGV = new TextBox();
        private TextBox txtTenGV = new TextBox();
        private TextBox txtNoiSinh = new TextBox();
        private TextBox txtDiaChi1 = new TextBox();
        private TextBox txtDiaChi2 = new TextBox();
        private TextBox txtSoDT1 = new TextBox();
        private TextBox txtSoDT2 = new TextBox();

        private ComboBox cbGioiTinh = new ComboBox();
        private ComboBox cbTrangThai = new ComboBox();

        private DateTimePicker dtNgaySinh = new DateTimePicker();
        private DateTimePicker dtNgayNhanViec = new DateTimePicker();

        private Button btnThem = new Button();
        private Button btnSua = new Button();
        private Button btnXoa = new Button();
        private Button btnHuy = new Button();
        private Button btnLuu = new Button();
        private Button btnThoat = new Button();
        //End Controls

        public frmGiaoVien()
        {
            InitializeComponent();

            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            ((ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            //Add Items In GroupBox
            this.gb1.Controls.Add(lbl1);
            this.gb1.Controls.Add(lbl2);
            this.gb1.Controls.Add(lbl3);
            this.gb1.Controls.Add(lbl4);
            this.gb1.Controls.Add(lbl5);
            this.gb1.Controls.Add(lbl6);
            this.gb1.Controls.Add(lbl7);
            this.gb1.Controls.Add(lbl8);
            this.gb1.Controls.Add(lbl9);
            this.gb1.Controls.Add(lbl10);
            this.gb1.Controls.Add(lbl11);
            this.gb1.Controls.Add(txtMaGV);
            this.gb1.Controls.Add(txtTenGV);
            this.gb1.Controls.Add(txtNoiSinh);
            this.gb1.Controls.Add(txtDiaChi1);
            this.gb1.Controls.Add(txtDiaChi2);
            this.gb1.Controls.Add(txtSoDT1);
            this.gb1.Controls.Add(txtSoDT2);
            this.gb1.Controls.Add(cbGioiTinh);
            this.gb1.Controls.Add(cbTrangThai);
            this.gb1.Controls.Add(dtNgaySinh);
            this.gb1.Controls.Add(dtNgayNhanViec);

            this.gb2.Controls.Add(this.btnHuy);
            this.gb2.Controls.Add(this.btnLuu);
            this.gb2.Controls.Add(this.btnSua);
            this.gb2.Controls.Add(this.btnThem);
            this.gb2.Controls.Add(this.btnThoat);
            this.gb2.Controls.Add(this.btnXoa);

            this.gb3.Controls.Add(this.dgv);

            //Label
            this.lbl1.Location = new Point(6, 22);
            this.lbl1.Size = new Size(78, 13);
            this.lbl1.Text = "Mã giáo viên: *";

            this.lbl2.Location = new Point(178, 22);
            this.lbl2.Size = new Size(53, 13);
            this.lbl2.Text = "Họ Tên: *";

            this.lbl3.Location = new Point(410, 48);
            this.lbl3.Size = new Size(85, 13);
            this.lbl3.Text = "Ngày nhận việc:";

            this.lbl4.Location = new Point(446, 22);
            this.lbl4.Size = new Size(57, 13);
            this.lbl4.Text = "Giới tính: *";

            this.lbl5.Location = new Point(6, 48);
            this.lbl5.Size = new Size(64, 13);
            this.lbl5.Text = "Ngày sinh: *";

            this.lbl6.Location = new Point(185, 48);
            this.lbl6.Size = new Size(48, 13);
            this.lbl6.Text = "Nơi sinh:";

            this.lbl7.Location = new Point(6, 75);
            this.lbl7.Size = new Size(52, 13);
            this.lbl7.Text = "Địa chỉ 1:";

            this.lbl8.Location = new Point(6, 101);
            this.lbl8.Size = new Size(52, 13);
            this.lbl8.Text = "Địa chỉ 2:";

            this.lbl9.Location = new Point(6, 127);
            this.lbl9.Size = new Size(50, 13);
            this.lbl9.Text = "Số ĐT 1:";

            this.lbl10.Location = new Point(225, 127);
            this.lbl10.Size = new Size(50, 13);
            this.lbl10.Text = "Số ĐT 2:";

            this.lbl11.Location = new Point(437, 127);
            this.lbl11.Size = new Size(58, 13);
            this.lbl11.Text = "Trạng thái:";
            //End Label

            //DataGridView
            this.dgv.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            //this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ReadOnly = true;
            this.dgv.MultiSelect = false;
            this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Location = new Point(6, 19);
            this.dgv.Size = new Size(598, 142);
            //End DataGridView

            //Textbox
            this.txtMaGV.Location = new Point(89, 19);
            this.txtMaGV.Size = new Size(83, 20);
            this.txtMaGV.TabIndex = 1;

            this.txtTenGV.Location = new Point(237, 19);
            this.txtTenGV.Size = new Size(203, 20);
            this.txtTenGV.TabIndex = 2;

            this.txtNoiSinh.Location = new Point(239, 45);
            this.txtNoiSinh.Size = new Size(165, 20);
            this.txtNoiSinh.TabIndex = 5;

            this.txtDiaChi1.Location = new Point(64, 72);
            this.txtDiaChi1.Size = new Size(540, 20);
            this.txtDiaChi1.TabIndex = 7;

            this.txtDiaChi2.Location = new Point(64, 98);
            this.txtDiaChi2.Size = new Size(540, 20);
            this.txtDiaChi2.TabIndex = 8;

            this.txtSoDT1.Location = new Point(64, 124);
            this.txtSoDT1.Size = new Size(155, 20);
            this.txtSoDT1.TabIndex = 9;

            this.txtSoDT2.Location = new Point(281, 124);
            this.txtSoDT2.Size = new Size(150, 20);
            this.txtSoDT2.TabIndex = 10;
            //End Textbox

            //DateTimePicker
            this.dtNgaySinh.Location = new Point(76, 45);
            this.dtNgaySinh.Size = new Size(100, 20);
            this.dtNgaySinh.Format = DateTimePickerFormat.Short;
            this.dtNgaySinh.TabIndex = 4;

            this.dtNgayNhanViec.Location = new Point(501, 46);
            this.dtNgayNhanViec.Size = new Size(100, 20);
            this.dtNgayNhanViec.Format = DateTimePickerFormat.Short;
            this.dtNgayNhanViec.TabIndex = 6;
            //End DateTimePicker

            //ComboBox
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new Point(504, 19);
            this.cbGioiTinh.Size = new Size(100, 21);
            this.cbGioiTinh.TabIndex = 3;

            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new Point(501, 124);
            this.cbTrangThai.Size = new Size(103, 21);
            this.cbTrangThai.TabIndex = 11;
            //End ComboBox

            //Button
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new Point(21, 19);
            this.btnThem.Size = new Size(90, 23);
            this.btnThem.TabIndex = 12;

            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new Point(117, 19);
            this.btnSua.Size = new Size(90, 23);
            this.btnSua.TabIndex = 13;

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new Point(309, 19);
            this.btnXoa.Size = new Size(90, 23);
            this.btnXoa.TabIndex = 15;

            this.btnHuy.Text = "Hủy";
            this.btnHuy.Location = new Point(405, 19);
            this.btnHuy.Size = new Size(90, 23);
            this.btnHuy.TabIndex = 16;

            this.btnLuu.Text = "Lưu";
            this.btnLuu.Location = new Point(213, 19);
            this.btnLuu.Size = new Size(90, 23);
            this.btnLuu.TabIndex = 14;

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new Point(501, 19);
            this.btnThoat.Size = new Size(90, 23);
            this.btnThoat.TabIndex = 17;
            //End Button

            //GroupBox
            this.gb1.Anchor = AnchorStyles.Top;
            this.gb1.Location = new Point(12, 12);
            this.gb1.Size = new Size(610, 154);
            this.gb1.Text = "Thông Tin";

            this.gb2.Anchor = AnchorStyles.Top;
            this.gb2.Location = new Point(12, 172);
            this.gb2.Size = new Size(610, 55);
            this.gb2.Text = "Chức Năng";

            this.gb3.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.gb3.Location = new Point(12, 233);
            this.gb3.Size = new Size(610, 167);
            this.gb3.Text = "Hiển Thị";
            //End GroupBox

            //Set up the Form
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(634, 412);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Text = "Giáo Viên";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb3.ResumeLayout(false);
            ((ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            //End set up the form

            this.Load += new EventHandler(this.frmGiaoVien_Load);
            this.dgv.Click += new System.EventHandler(this.dgv_SelectedIndexChange);

            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
        }

        //Function
        bool InsertNew;
        DateTime localDate = DateTime.Now;
        string formatDH = "yyyy-MM-dd HH:mm:ss";
        string formatD = "yyyy-MM-dd";

        void NapGioiTinh()
        {
            SortedDictionary<string, int> comboSource = new SortedDictionary<string, int>
            {
                {"Nam", 1},
                {"Nữ", 0}
            };
            cbGioiTinh.DataSource = new BindingSource(comboSource, null);
            cbGioiTinh.DisplayMember = "Key";
            cbGioiTinh.ValueMember = "Value";
        }

        void NapTrangThai()
        {
            SortedDictionary<string, int> comboSource = new SortedDictionary<string, int>
            {
                {"Kích hoạt", 0},
                {"Vô hiệu", 1}
            };
            cbTrangThai.DataSource = new BindingSource(comboSource, null);
            cbTrangThai.DisplayMember = "Key";
            cbTrangThai.ValueMember = "Value";
        }

        void NapDuLieu()
        {
            DataTable dt = new DataTable();
            bus = new BUS_GiaoVien();

            dt = bus.selectdata();
            dgv.DataSource = dt;

            if (dgv.ColumnCount > 0)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "Tên GV";
                dgv.Columns[2].HeaderText = "Ngày Sinh";
                dgv.Columns[3].HeaderText = "Giới Tính";
                dgv.Columns[4].HeaderText = "Nơi Sinh";
                dgv.Columns[5].HeaderText = "ĐC1";
                dgv.Columns[6].HeaderText = "ĐC2";
                dgv.Columns[7].HeaderText = "Số ĐT1";
                dgv.Columns[8].HeaderText = "Số ĐT2";
                dgv.Columns[9].HeaderText = "Ngày Nhận Việc";
                dgv.Columns[10].HeaderText = "Trạng Thái";
                dgv.Columns[11].HeaderText = "Ngày Tạo";
                dgv.Columns[12].HeaderText = "Ngày Cập Nhật";
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

        void dgv_SelectedIndexChange(object sender, EventArgs e)
        {
            EvenButton(0);
            EnableOrDisable(true);
            try
            {
                if (dgv.RowCount < 1)
                    return;
                int index = dgv.CurrentCell.RowIndex;
                string MaGV = dgv.Rows[index].Cells["MaGV"].Value.ToString();
                string TenGV = dgv.Rows[index].Cells["TenGV"].Value.ToString();
                string NgaySinh = dgv.Rows[index].Cells["NgaySinh"].Value.ToString();
                string GioiTinh = dgv.Rows[index].Cells["GioiTinh"].Value.ToString();
                string NoiSinh = dgv.Rows[index].Cells["NoiSinh"].Value.ToString();
                string DC1 = dgv.Rows[index].Cells["DiaChi1"].Value.ToString();
                string DC2 = dgv.Rows[index].Cells["DiaChi2"].Value.ToString();
                string SDT1 = dgv.Rows[index].Cells["SoDT1"].Value.ToString();
                string SDT2 = dgv.Rows[index].Cells["SoDT2"].Value.ToString();
                string NgayNhanViec = dgv.Rows[index].Cells["NgayNhanViec"].Value.ToString();
                string TrangThai = dgv.Rows[index].Cells["TrangThai"].Value.ToString();

                txtMaGV.Text = MaGV;
                txtTenGV.Text = TenGV;
                txtNoiSinh.Text = NoiSinh;
                txtDiaChi1.Text = DC1;
                txtDiaChi2.Text = DC2;
                txtSoDT1.Text = SDT1;
                txtSoDT2.Text = SDT2;
                cbGioiTinh.SelectedValue = Int32.Parse(GioiTinh);
                dtNgaySinh.Text = NgaySinh;
                dtNgayNhanViec.Text = NgayNhanViec;
                cbTrangThai.SelectedValue = Int32.Parse(TrangThai);
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
                txtMaGV.ReadOnly = true;
                txtTenGV.ReadOnly = true;
                txtNoiSinh.ReadOnly = true;
                txtDiaChi1.ReadOnly = true;
                txtDiaChi2.ReadOnly = true;
                txtSoDT1.ReadOnly = true;
                txtSoDT2.ReadOnly = true;
                cbGioiTinh.Enabled = false;
                dtNgaySinh.Enabled = false;
                dtNgayNhanViec.Enabled = false;
                cbTrangThai.Enabled = false;
            }
            else
            {
                txtMaGV.ReadOnly = false;
                txtTenGV.ReadOnly = false;
                txtNoiSinh.ReadOnly = false;
                txtDiaChi1.ReadOnly = false;
                txtDiaChi2.ReadOnly = false;
                txtSoDT1.ReadOnly = false;
                txtSoDT2.ReadOnly = false;
                cbGioiTinh.Enabled = true;
                dtNgaySinh.Enabled = true;
                dtNgayNhanViec.Enabled = true;
                cbTrangThai.Enabled = true;
            }
        }

        void XoaForm()
        {
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtNoiSinh.Text = "";
            txtDiaChi1.Text = "";
            txtDiaChi2.Text = "";
            txtSoDT1.Text = "";
            txtSoDT2.Text = "";
            cbGioiTinh.SelectedValue = 1;
            dtNgaySinh.Text = "";
            dtNgayNhanViec.Text = "";
            cbTrangThai.SelectedValue = 0;
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            en = new En_GiaoVien();

            NapGioiTinh();
            NapTrangThai();
            NapDuLieu();

            EvenButton(0);
            EnableOrDisable(true);
        }

        void InserUpdateData()
        {
            if (txtMaGV.Text.Trim().Equals("") || txtTenGV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Điền Mã giáo viên và Họ Tên giáo viên đầy đủ, sau đó thực hiện lại thao tác", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InsertNew == true)
            {
                try
                {
                    en.MaGV = txtMaGV.Text;
                    en.TenGV = txtTenGV.Text;
                    en.NoiSinh = txtNoiSinh.Text;
                    en.DiaChi1 = txtDiaChi1.Text;
                    en.DiaChi2 = txtDiaChi2.Text;
                    en.SoDT1 = txtSoDT1.Text;
                    en.SoDT2 = txtSoDT2.Text;
                    en.GioiTinh = Int32.Parse(cbGioiTinh.SelectedValue.ToString());
                    en.NgaySinh = Convert.ToDateTime(dtNgaySinh.Value.ToString(formatD));
                    en.NgayNhanViec = Convert.ToDateTime(dtNgayNhanViec.Value.ToString(formatD));
                    en.TrangThai = Int32.Parse(cbTrangThai.SelectedValue.ToString());
                    en.NgayTao = Convert.ToDateTime(localDate.ToString(formatDH));
                    en.NgayCapNhat = Convert.ToDateTime(localDate.ToString(formatDH));

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
                    int index = dgv.CurrentCell.RowIndex;
                    en.MaGV = dgv.Rows[index].Cells["MaGV"].Value.ToString();
                    en.TenGV = txtTenGV.Text;
                    en.NoiSinh = txtNoiSinh.Text;
                    en.DiaChi1 = txtDiaChi1.Text;
                    en.DiaChi2 = txtDiaChi2.Text;
                    en.SoDT1 = txtSoDT1.Text;
                    en.SoDT2 = txtSoDT2.Text;
                    en.GioiTinh = Int32.Parse(cbGioiTinh.SelectedValue.ToString());
                    en.NgaySinh = Convert.ToDateTime(dtNgaySinh.Value.ToString(formatD));
                    en.NgayNhanViec = Convert.ToDateTime(dtNgayNhanViec.Value.ToString(formatD));
                    en.TrangThai = Int32.Parse(cbTrangThai.SelectedValue.ToString());
                    en.NgayCapNhat = Convert.ToDateTime(localDate.ToString(formatDH));

                    bus.updatedata(en);
                    MessageBox.Show("Đã cập nhật 1 dòng");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message.ToString());
                }
            }
            NapDuLieu();
            XoaForm();
            EvenButton(0);
            EnableOrDisable(true);
        }

        void DeleteData()
        {
            int index = dgv.CurrentCell.RowIndex;
            en.MaGV = dgv.Rows[index].Cells["MaGV"].Value.ToString();

            bus.deletedata(en);
            MessageBox.Show("Đã xóa 1 dòng");
            NapDuLieu();
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

        void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //End Function
    }
}
