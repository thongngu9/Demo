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
    public partial class frmSinhVien : Form
    {
        //Player
        private BUS_SinhVien bus;
        private En_SinhVien en;
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
        private Label lbl12 = new Label();
        private Label lbl13 = new Label();
        private Label lbl14 = new Label();
        private Label lbl15 = new Label();
        private Label lbl16 = new Label();

        private DataGridView dgv = new DataGridView();

        private TextBox txtMaSV = new TextBox();
        private TextBox txtHoSV = new TextBox();
        private TextBox txtTenSV = new TextBox();
        private TextBox txtNoiSinh = new TextBox();
        private TextBox txtDiaChi1 = new TextBox();
        private TextBox txtDiaChi2 = new TextBox();
        private TextBox txtSoDT = new TextBox();
        private TextBox txtTenPH1 = new TextBox();
        private TextBox txtTenPH2 = new TextBox();
        private TextBox txtSoDTPH1 = new TextBox();
        private TextBox txtSoDTPH2 = new TextBox();
        private TextBox txtGhiChu = new TextBox();

        private ComboBox cbMaL = new ComboBox();
        private ComboBox cbGioiTinh = new ComboBox();
        private ComboBox cbTrangThai = new ComboBox();

        private DateTimePicker dtNgaySinh = new DateTimePicker();

        private Button btnThem = new Button();
        private Button btnSua = new Button();
        private Button btnXoa = new Button();
        private Button btnHuy = new Button();
        private Button btnLuu = new Button();
        private Button btnThoat = new Button();
        //End Controls

        public frmSinhVien()
        {
            InitializeComponent();

            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            ((ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            //Add Items In GroupBox
            this.gb1.Controls.Add(this.lbl1);
            this.gb1.Controls.Add(this.lbl2);
            this.gb1.Controls.Add(this.lbl3);
            this.gb1.Controls.Add(this.lbl4);
            this.gb1.Controls.Add(this.lbl5);
            this.gb1.Controls.Add(this.lbl6);
            this.gb1.Controls.Add(this.lbl7);
            this.gb1.Controls.Add(this.lbl8);
            this.gb1.Controls.Add(this.lbl9);
            this.gb1.Controls.Add(this.lbl10);
            this.gb1.Controls.Add(this.lbl11);
            this.gb1.Controls.Add(this.lbl12);
            this.gb1.Controls.Add(this.lbl13);
            this.gb1.Controls.Add(this.lbl14);
            this.gb1.Controls.Add(this.lbl15);
            this.gb1.Controls.Add(this.lbl16);
            this.gb1.Controls.Add(this.txtMaSV);
            this.gb1.Controls.Add(this.txtHoSV);
            this.gb1.Controls.Add(this.txtTenSV);
            this.gb1.Controls.Add(this.txtNoiSinh);
            this.gb1.Controls.Add(this.txtDiaChi1);
            this.gb1.Controls.Add(this.txtDiaChi2);
            this.gb1.Controls.Add(this.txtSoDT);
            this.gb1.Controls.Add(this.txtTenPH1);
            this.gb1.Controls.Add(this.txtTenPH2);
            this.gb1.Controls.Add(this.txtSoDTPH1);
            this.gb1.Controls.Add(this.txtSoDTPH2);
            this.gb1.Controls.Add(this.txtGhiChu);
            this.gb1.Controls.Add(this.cbMaL);
            this.gb1.Controls.Add(this.cbGioiTinh);
            this.gb1.Controls.Add(this.cbTrangThai);
            this.gb1.Controls.Add(this.dtNgaySinh);

            this.gb2.Controls.Add(this.btnHuy);
            this.gb2.Controls.Add(this.btnLuu);
            this.gb2.Controls.Add(this.btnSua);
            this.gb2.Controls.Add(this.btnThem);
            this.gb2.Controls.Add(this.btnThoat);
            this.gb2.Controls.Add(this.btnXoa);

            this.gb3.Controls.Add(this.dgv);

            //Label
            this.lbl1.Location = new Point(6, 22);
            this.lbl1.Size = new Size(77, 13);
            this.lbl1.Text = "Mã sinh viên: *";

            this.lbl2.Location = new Point(178, 22);
            this.lbl2.Size = new Size(76, 13);
            this.lbl2.Text = "Họ + Tên lót: *";

            this.lbl3.Location = new Point(469, 22);
            this.lbl3.Size = new Size(36, 13);
            this.lbl3.Text = "Tên: *";

            this.lbl4.Location = new Point(140, 48);
            this.lbl4.Size = new Size(57, 13);
            this.lbl4.Text = "Giới tính: *";

            this.lbl5.Location = new Point(274, 48);
            this.lbl5.Size = new Size(64, 13);
            this.lbl5.Text = "Ngày sinh: *";

            this.lbl6.Location = new Point(450, 48);
            this.lbl6.Size = new Size(48, 13);
            this.lbl6.Text = "Nơi sinh:";

            this.lbl7.Location = new Point(6, 75);
            this.lbl7.Size = new Size(59, 13);
            this.lbl7.Text = "Địa chỉ 1: *";

            this.lbl8.Location = new Point(6, 101);
            this.lbl8.Size = new Size(52, 13);
            this.lbl8.Text = "Địa chỉ 2:";

            this.lbl9.Location = new Point(6, 127);
            this.lbl9.Size = new Size(41, 13);
            this.lbl9.Text = "Số ĐT:";

            this.lbl10.Location = new Point(227, 127);
            this.lbl10.Size = new Size(56, 13);
            this.lbl10.Text = "Tên PH 1:";

            this.lbl11.Location = new Point(419, 127);
            this.lbl11.Size = new Size(56, 13);
            this.lbl11.Text = "Tên PH 2:";

            this.lbl12.Location = new Point(6, 153);
            this.lbl12.Size = new Size(68, 13);
            this.lbl12.Text = "Số ĐT PH 1:";

            this.lbl13.Location = new Point(236, 153);
            this.lbl13.Size = new Size(68, 13);
            this.lbl13.Text = "Số ĐT PH 2:";

            this.lbl14.Location = new Point(466, 153);
            this.lbl14.Size = new Size(58, 13);
            this.lbl14.Text = "Trạng thái:";

            this.lbl15.Location = new Point(6, 179);
            this.lbl15.Size = new Size(47, 13);
            this.lbl15.Text = "Ghi chú:";

            this.lbl16.Location = new Point(6, 48);
            this.lbl16.Size = new Size(42, 13);
            this.lbl16.Text = "Mã lớp:";
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
            this.dgv.Size = new Size(598, 66);
            //End DataGridView

            //Textbox
            this.txtMaSV.Location = new Point(89, 19);
            this.txtMaSV.Size = new Size(83, 20);
            this.txtMaSV.TabIndex = 1;

            this.txtHoSV.Location = new Point(260, 19);
            this.txtHoSV.Size = new Size(203, 20);
            this.txtHoSV.TabIndex = 2;

            this.txtTenSV.Location = new Point(511, 19);
            this.txtTenSV.Size = new Size(93, 20);
            this.txtTenSV.TabIndex = 3;

            this.txtNoiSinh.Location = new Point(504, 45);
            this.txtNoiSinh.Size = new Size(100, 20);
            this.txtNoiSinh.TabIndex = 7;

            this.txtDiaChi1.Location = new Point(69, 72);
            this.txtDiaChi1.Size = new Size(535, 20);
            this.txtDiaChi1.TabIndex = 8;

            this.txtDiaChi2.Location = new Point(69, 98);
            this.txtDiaChi2.Size = new Size(535, 20);
            this.txtDiaChi2.TabIndex = 9;

            this.txtSoDT.Location = new Point(69, 124);
            this.txtSoDT.Size = new Size(150, 20);
            this.txtSoDT.TabIndex = 10;

            this.txtTenPH1.Location = new Point(289, 124);
            this.txtTenPH1.Size = new Size(123, 20);
            this.txtTenPH1.TabIndex = 11;

            this.txtTenPH2.Location = new Point(481, 124);
            this.txtTenPH2.Size = new Size(123, 20);
            this.txtTenPH2.TabIndex = 12;

            this.txtSoDTPH1.Location = new Point(80, 150);
            this.txtSoDTPH1.Size = new Size(150, 20);
            this.txtSoDTPH1.TabIndex = 13;

            this.txtSoDTPH2.Location = new Point(310, 150);
            this.txtSoDTPH2.Size = new Size(150, 20);
            this.txtSoDTPH2.TabIndex = 14;

            this.txtGhiChu.Location = new Point(69, 176);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Size = new Size(535, 40);
            this.txtGhiChu.TabIndex = 16;
            //End Textbox

            //DateTimePicker
            this.dtNgaySinh.Location = new Point(344, 45);
            this.dtNgaySinh.Size = new Size(100, 20);
            this.dtNgaySinh.Format = DateTimePickerFormat.Short;
            this.dtNgaySinh.TabIndex = 6;
            //End DateTimePicker

            //ComboBox
            this.cbMaL.FormattingEnabled = true;
            this.cbMaL.Location = new Point(54, 45);
            this.cbMaL.Size = new Size(80, 21);
            this.cbMaL.TabIndex = 4;

            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new Point(203, 45);
            this.cbGioiTinh.Size = new Size(65, 21);
            this.cbGioiTinh.TabIndex = 5;

            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new Point(530, 150);
            this.cbTrangThai.Size = new Size(74, 21);
            this.cbTrangThai.TabIndex = 15;
            //End ComboBox

            //Button
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new Point(21, 19);
            this.btnThem.Size = new Size(90, 23);
            this.btnThem.TabIndex = 17;

            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new Point(117, 19);
            this.btnSua.Size = new Size(90, 23);
            this.btnSua.TabIndex = 18;

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new Point(309, 19);
            this.btnXoa.Size = new Size(90, 23);
            this.btnXoa.TabIndex = 20;

            this.btnHuy.Text = "Hủy";
            this.btnHuy.Location = new Point(405, 19);
            this.btnHuy.Size = new Size(90, 23);
            this.btnHuy.TabIndex = 21;

            this.btnLuu.Text = "Lưu";
            this.btnLuu.Location = new Point(213, 19);
            this.btnLuu.Size = new Size(90, 23);
            this.btnLuu.TabIndex = 19;

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new Point(501, 19);
            this.btnThoat.Size = new Size(90, 23);
            this.btnThoat.TabIndex = 22;
            //End Button

            //GroupBox
            this.gb1.Anchor = AnchorStyles.Top;
            this.gb1.Location = new Point(12, 12);
            this.gb1.Size = new Size(610, 230);
            this.gb1.Text = "Thông Tin";

            this.gb2.Anchor = AnchorStyles.Top;
            this.gb2.Location = new Point(12, 248);
            this.gb2.Size = new Size(610, 55);
            this.gb2.Text = "Chức Năng";

            this.gb3.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.gb3.Location = new Point(12, 309);
            this.gb3.Size = new Size(610, 91);
            this.gb3.Text = "Hiển Thị";
            //End GroupBox

            //Set up the Form
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(634, 412);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Text = "Sinh Viên";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb3.ResumeLayout(false);
            ((ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            //End set up the form

            this.Load += new EventHandler(this.frmSinhVien_Load);
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

        void NapLop()
        {
            cbMaL.Items.Clear();

            DataTable dt = new DataTable();
            bus = new BUS_SinhVien();

            dt = bus.showdata();

            var item = new Dictionary<string, string>();
            foreach (DataRow dr in dt.Rows)
            {
                item.Add(dr["MaL"].ToString(), dr["TenL"].ToString());
            }
            cbMaL.DataSource = new BindingSource(item, null);
            cbMaL.DisplayMember = "Value";
            cbMaL.ValueMember = "Key";
        }

        void NapDuLieu()
        {
            DataTable dt = new DataTable();
            bus = new BUS_SinhVien();

            dt = bus.selectdata();
            dgv.DataSource = dt;

            if (dgv.ColumnCount > 0)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "Họ SV";
                dgv.Columns[2].HeaderText = "Tên SV";
                dgv.Columns[3].HeaderText = "Giới Tính";
                dgv.Columns[4].HeaderText = "Ngày Sinh";
                dgv.Columns[5].HeaderText = "Nơi Sinh";
                dgv.Columns[6].HeaderText = "ĐC1";
                dgv.Columns[7].HeaderText = "ĐC2";
                dgv.Columns[8].HeaderText = "Số ĐT";
                dgv.Columns[9].HeaderText = "Tên PH1";
                dgv.Columns[10].HeaderText = "Tên PH2";
                dgv.Columns[11].HeaderText = "Số ĐT PH1";
                dgv.Columns[12].HeaderText = "Số ĐT PH2";
                dgv.Columns[13].HeaderText = "Ghi Chú";
                dgv.Columns[14].HeaderText = "Mã Lớp";
                dgv.Columns[15].HeaderText = "Trạng Thái";
                dgv.Columns[16].HeaderText = "Ngày Tạo";
                dgv.Columns[17].HeaderText = "Ngày Cập Nhật";
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
                string MaSV = dgv.Rows[index].Cells["MaSV"].Value.ToString();
                string HoSV = dgv.Rows[index].Cells["HoSV"].Value.ToString();
                string TenSV = dgv.Rows[index].Cells["TenSV"].Value.ToString();
                string MaL = dgv.Rows[index].Cells["MaL"].Value.ToString();
                string GioiTinh = dgv.Rows[index].Cells["GioiTinh"].Value.ToString();
                string NgaySinh = dgv.Rows[index].Cells["NgaySinh"].Value.ToString();
                string NoiSinh = dgv.Rows[index].Cells["NoiSinh"].Value.ToString();
                string DC1 = dgv.Rows[index].Cells["DiaChi1"].Value.ToString();
                string DC2 = dgv.Rows[index].Cells["DiaChi2"].Value.ToString();
                string SDT = dgv.Rows[index].Cells["SoDT"].Value.ToString();
                string TenPH1 = dgv.Rows[index].Cells["TenPH1"].Value.ToString();
                string TenPH2 = dgv.Rows[index].Cells["TenPH2"].Value.ToString();
                string SDTPH1 = dgv.Rows[index].Cells["SoDTPH1"].Value.ToString();
                string SDTPH2 = dgv.Rows[index].Cells["SoDTPH2"].Value.ToString();
                string TrangThai = dgv.Rows[index].Cells["TrangThai"].Value.ToString();
                string GhiChu = dgv.Rows[index].Cells["GhiChu"].Value.ToString();

                txtMaSV.Text = MaSV;
                txtHoSV.Text = HoSV;
                txtTenSV.Text = TenSV;
                txtNoiSinh.Text = NoiSinh;
                txtDiaChi1.Text = DC1;
                txtDiaChi2.Text = DC2;
                txtSoDT.Text = SDT;
                txtTenPH1.Text = TenPH1;
                txtTenPH2.Text = TenPH2;
                txtSoDTPH1.Text = SDTPH1;
                txtSoDTPH2.Text = SDTPH2;
                txtGhiChu.Text = GhiChu;
                cbMaL.SelectedValue = MaL;
                cbGioiTinh.SelectedValue = Int32.Parse(GioiTinh);
                dtNgaySinh.Text = NgaySinh;
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
                txtMaSV.ReadOnly = true;
                txtHoSV.ReadOnly = true;
                txtTenSV.ReadOnly = true;
                txtNoiSinh.ReadOnly = true;
                txtDiaChi1.ReadOnly = true;
                txtDiaChi2.ReadOnly = true;
                txtSoDT.ReadOnly = true;
                txtTenPH1.ReadOnly = true;
                txtTenPH2.ReadOnly = true;
                txtSoDTPH1.ReadOnly = true;
                txtSoDTPH2.ReadOnly = true;
                txtGhiChu.ReadOnly = true;
                cbMaL.Enabled = false;
                cbGioiTinh.Enabled = false;
                dtNgaySinh.Enabled = false;
                cbTrangThai.Enabled = false;
            }
            else
            {
                txtMaSV.ReadOnly = false;
                txtHoSV.ReadOnly = false;
                txtTenSV.ReadOnly = false;
                txtNoiSinh.ReadOnly = false;
                txtDiaChi1.ReadOnly = false;
                txtDiaChi2.ReadOnly = false;
                txtSoDT.ReadOnly = false;
                txtTenPH1.ReadOnly = false;
                txtTenPH2.ReadOnly = false;
                txtSoDTPH1.ReadOnly = false;
                txtSoDTPH2.ReadOnly = false;
                txtGhiChu.ReadOnly = false;
                cbMaL.Enabled = true;
                cbGioiTinh.Enabled = true;
                dtNgaySinh.Enabled = true;
                cbTrangThai.Enabled = true;
            }
        }

        void XoaForm()
        {
            txtMaSV.Text = "";
            txtHoSV.Text = "";
            txtTenSV.Text = "";
            txtNoiSinh.Text = "";
            txtDiaChi1.Text = "";
            txtDiaChi2.Text = "";
            txtSoDT.Text = "";
            txtTenPH1.Text = "";
            txtTenPH2.Text = "";
            txtSoDTPH1.Text = "";
            txtSoDTPH2.Text = "";
            txtGhiChu.Text = "";
            cbGioiTinh.SelectedValue = 1;
            dtNgaySinh.Text = "";
            cbTrangThai.SelectedValue = 0;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            en = new En_SinhVien();

            NapGioiTinh();
            NapTrangThai();
            NapLop();
            NapDuLieu();

            EvenButton(0);
            EnableOrDisable(true);
        }

        void InserUpdateData()
        {
            if (txtMaSV.Text.Trim().Equals("") || txtHoSV.Text.Trim().Equals("") || txtTenSV.Text.Trim().Equals(""))
            {
                MessageBox.Show("Điền Mã sinh viên và Họ Tên sinh viên đầy đủ, sau đó thực hiện lại thao tác", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InsertNew == true)
            {
                try
                {
                    en.MaSV = txtMaSV.Text;
                    en.HoSV = txtHoSV.Text;
                    en.TenSV = txtTenSV.Text;
                    en.NoiSinh = txtNoiSinh.Text;
                    en.DiaChi1 = txtDiaChi1.Text;
                    en.DiaChi2 = txtDiaChi2.Text;
                    en.SoDT = txtSoDT.Text;
                    en.TenPH1 = txtTenPH1.Text;
                    en.TenPH2 = txtTenPH2.Text;
                    en.SoDTPH1 = txtSoDTPH1.Text;
                    en.SoDTPH2 = txtSoDTPH2.Text;
                    en.GhiChu = txtGhiChu.Text;
                    en.MaL = cbMaL.SelectedValue.ToString();
                    en.GioiTinh = Int32.Parse(cbGioiTinh.SelectedValue.ToString());
                    en.NgaySinh = Convert.ToDateTime(dtNgaySinh.Value.ToString(formatD));
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
                    en.MaSV = dgv.Rows[index].Cells["MaSV"].Value.ToString();
                    en.HoSV = txtHoSV.Text;
                    en.TenSV = txtTenSV.Text;
                    en.NoiSinh = txtNoiSinh.Text;
                    en.DiaChi1 = txtDiaChi1.Text;
                    en.DiaChi2 = txtDiaChi2.Text;
                    en.SoDT = txtSoDT.Text;
                    en.TenPH1 = txtTenPH1.Text;
                    en.TenPH2 = txtTenPH2.Text;
                    en.SoDTPH1 = txtSoDTPH1.Text;
                    en.SoDTPH2 = txtSoDTPH2.Text;
                    en.GhiChu = txtGhiChu.Text;
                    en.MaL = cbMaL.SelectedValue.ToString();
                    en.GioiTinh = Int32.Parse(cbGioiTinh.SelectedValue.ToString());
                    en.NgaySinh = Convert.ToDateTime(dtNgaySinh.Value.ToString(formatD));
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
            en.MaSV = dgv.Rows[index].Cells["MaSV"].Value.ToString();

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
