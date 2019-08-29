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
    public partial class frmDiem : Form
    {
        //Player
        private BUS_Diem bus;
        private En_Diem en;
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

        private DataGridView dgv = new DataGridView();

        private ComboBox cbMaL = new ComboBox();
        private ComboBox cbMaSV = new ComboBox();
        private ComboBox cbMaMH = new ComboBox();
        private ComboBox cbMaGV = new ComboBox();
        private ComboBox cbMaLD = new ComboBox();
        private ComboBox cbTrangThai = new ComboBox();

        private Button btnThem = new Button();
        private Button btnSua = new Button();
        private Button btnXoa = new Button();
        private Button btnHuy = new Button();
        private Button btnLuu = new Button();
        private Button btnThoat = new Button();
        //End Controls

        public frmDiem()
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
            this.gb1.Controls.Add(cbMaL);
            this.gb1.Controls.Add(cbMaSV);
            this.gb1.Controls.Add(cbMaMH);
            this.gb1.Controls.Add(cbMaGV);
            this.gb1.Controls.Add(cbMaLD);
            this.gb1.Controls.Add(cbTrangThai);

            this.gb2.Controls.Add(this.btnHuy);
            this.gb2.Controls.Add(this.btnLuu);
            this.gb2.Controls.Add(this.btnSua);
            this.gb2.Controls.Add(this.btnThem);
            this.gb2.Controls.Add(this.btnThoat);
            this.gb2.Controls.Add(this.btnXoa);

            this.gb3.Controls.Add(this.dgv);

            //Label
            this.lbl1.Location = new Point(6, 22);
            this.lbl1.Size = new Size(49, 13);
            this.lbl1.Text = "Mã lớp: *";

            this.lbl2.Location = new Point(6, 49);
            this.lbl2.Size = new Size(76, 13);
            this.lbl2.Text = "Mã môn học: *";

            this.lbl3.Location = new Point(307, 49);
            this.lbl3.Size = new Size(78, 13);
            this.lbl3.Text = "Mã giáo viên: *";

            this.lbl4.Location = new Point(6, 76);
            this.lbl4.Size = new Size(77, 13);
            this.lbl4.Text = "Mã loại điểm: *";

            this.lbl5.Location = new Point(437, 76);
            this.lbl5.Size = new Size(58, 13);
            this.lbl5.Text = "Trạng thái:";

            this.lbl6.Location = new Point(307, 22);
            this.lbl6.Size = new Size(77, 13);
            this.lbl6.Text = "Mã sinh viên: *";
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
            this.dgv.Size = new Size(598, 189);
            //End DataGridView

            //ComboBox
            this.cbMaL.Location = new Point(88, 19);
            this.cbMaL.Size = new Size(213, 21);
            this.cbMaL.TabIndex = 1;

            this.cbMaSV.Location = new Point(391, 19);
            this.cbMaSV.Size = new Size(213, 21);
            this.cbMaSV.TabIndex = 2;

            this.cbMaMH.Location = new Point(88, 46);
            this.cbMaMH.Size = new Size(213, 21);
            this.cbMaMH.TabIndex = 3;

            this.cbMaGV.Location = new Point(391, 46);
            this.cbMaGV.Size = new Size(213, 21);
            this.cbMaGV.TabIndex = 4;

            this.cbMaLD.Location = new Point(88, 73);
            this.cbMaLD.Size = new Size(213, 21);
            this.cbMaLD.TabIndex = 5;

            this.cbTrangThai.Location = new Point(501, 73);
            this.cbTrangThai.Size = new Size(103, 21);
            this.cbTrangThai.TabIndex = 6;
            //End ComboBox

            //Button
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new Point(21, 19);
            this.btnThem.Size = new Size(90, 23);
            this.btnThem.TabIndex = 7;

            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new Point(117, 19);
            this.btnSua.Size = new Size(90, 23);
            this.btnSua.TabIndex = 8;

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new Point(309, 19);
            this.btnXoa.Size = new Size(90, 23);
            this.btnXoa.TabIndex = 10;

            this.btnHuy.Text = "Hủy";
            this.btnHuy.Location = new Point(405, 19);
            this.btnHuy.Size = new Size(90, 23);
            this.btnHuy.TabIndex = 11;

            this.btnLuu.Text = "Lưu";
            this.btnLuu.Location = new Point(213, 19);
            this.btnLuu.Size = new Size(90, 23);
            this.btnLuu.TabIndex = 9;

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new Point(501, 19);
            this.btnThoat.Size = new Size(90, 23);
            this.btnThoat.TabIndex = 12;
            //End Button

            //GroupBox
            this.gb1.Anchor = AnchorStyles.Top;
            this.gb1.Location = new Point(12, 12);
            this.gb1.Size = new Size(610, 107);
            this.gb1.Text = "Thông Tin";

            this.gb2.Anchor = AnchorStyles.Top;
            this.gb2.Location = new Point(12, 125);
            this.gb2.Size = new Size(610, 55);
            this.gb2.Text = "Chức Năng";

            this.gb3.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.gb3.Location = new Point(12, 186);
            this.gb3.Size = new Size(610, 214);
            this.gb3.Text = "Hiển Thị";
            //End GroupBox

            //Set up the Form
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(634, 412);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Text = "Điểm";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb3.ResumeLayout(false);
            ((ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            //End set up the form

            this.Load += new EventHandler(this.frmDiem_Load);
            this.dgv.Click += new System.EventHandler(this.dgv_SelectedIndexChange);
            this.cbMaLD.SelectedIndexChanged += new System.EventHandler(this.cbMaLD_SelectedIndexChange);

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
            DataTable dt = new DataTable();
            bus = new BUS_Diem();

            dt = bus.showdata_Lop();

            var item = new Dictionary<string, string>();
            foreach (DataRow dr in dt.Rows)
            {
                item.Add(dr["MaL"].ToString(), dr["MaL"].ToString() + " - " + dr["TenL"].ToString());
            }
            cbMaL.DataSource = new BindingSource(item, null);
            cbMaL.DisplayMember = "Value";
            cbMaL.ValueMember = "Key";
        }

        void NapSinhVien()
        {
            DataTable dt = new DataTable();
            bus = new BUS_Diem();

            dt = bus.showdata_SinhVien();

            var item = new Dictionary<string, string>();
            foreach (DataRow dr in dt.Rows)
            {
                item.Add(dr["MaSV"].ToString(), dr["MaSV"].ToString() + " - " + dr["HoSV"].ToString() + " "+ dr["TenSV"].ToString());
            }
            cbMaSV.DataSource = new BindingSource(item, null);
            cbMaSV.DisplayMember = "Value";
            cbMaSV.ValueMember = "Key";
        }

        void NapMonHoc()
        {
            DataTable dt = new DataTable();
            bus = new BUS_Diem();

            dt = bus.showdata_MonHoc();

            var item = new Dictionary<string, string>();
            foreach (DataRow dr in dt.Rows)
            {
                item.Add(dr["MaMH"].ToString(), dr["MaMH"].ToString() + " - " + dr["TenMH"].ToString());
            }
            cbMaMH.DataSource = new BindingSource(item, null);
            cbMaMH.DisplayMember = "Value";
            cbMaMH.ValueMember = "Key";
        }

        void NapGiaoVien()
        {
            DataTable dt = new DataTable();
            bus = new BUS_Diem();

            dt = bus.showdata_GiaoVien();

            var item = new Dictionary<string, string>();
            foreach (DataRow dr in dt.Rows)
            {
                item.Add(dr["MaGV"].ToString(), dr["MaGV"].ToString() + " - " + dr["TenGV"].ToString());
            }
            cbMaGV.DataSource = new BindingSource(item, null);
            cbMaGV.DisplayMember = "Value";
            cbMaGV.ValueMember = "Key";
        }

        void NapLoaiDiem()
        {
            DataTable dt = new DataTable();
            bus = new BUS_Diem();

            dt = bus.showdata_LoaiDiem();

            var item = new Dictionary<string, string>();
            foreach (DataRow dr in dt.Rows)
            {
                item.Add(dr["MaLD"].ToString(), dr["MaLD"].ToString() + " - " + dr["TenLD"].ToString());
            }
            cbMaLD.DataSource = new BindingSource(item, null);
            cbMaLD.DisplayMember = "Value";
            cbMaLD.ValueMember = "Key";
        }

        void NapDuLieu()
        {
            DataTable dt = new DataTable();
            bus = new BUS_Diem();

            dt = bus.selectdata(cbMaL.SelectedValue.ToString());
            dt = bus.selectdata(cbMaSV.SelectedValue.ToString());
            dt = bus.selectdata(cbMaMH.SelectedValue.ToString());
            dt = bus.selectdata(cbMaGV.SelectedValue.ToString());
            dt = bus.selectdata(cbMaLD.SelectedValue.ToString());
            dgv.DataSource = dt;

            if (dgv.ColumnCount > 0)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "Mã Lớp";
                dgv.Columns[2].HeaderText = "Mã Sinh Viên";
                dgv.Columns[3].HeaderText = "Mã Môn Học";
                dgv.Columns[4].HeaderText = "Mã Giáo Viên";
                dgv.Columns[5].HeaderText = "Mã Loại Điểm";
                dgv.Columns[6].HeaderText = "Điểm";
                dgv.Columns[7].HeaderText = "Trạng Thái";
                dgv.Columns[8].HeaderText = "Ngày Tạo";
                dgv.Columns[9].HeaderText = "Ngày Cập Nhật";
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
                string MaL = dgv.Rows[index].Cells["MaL"].Value.ToString();
                string MaSV = dgv.Rows[index].Cells["MaSV"].Value.ToString();
                string MaMH = dgv.Rows[index].Cells["MaMH"].Value.ToString();
                string MaGV = dgv.Rows[index].Cells["MaGV"].Value.ToString();
                string MaLD = dgv.Rows[index].Cells["MaLD"].Value.ToString();
                string TrangThai = dgv.Rows[index].Cells["TrangThai"].Value.ToString();

                cbMaL.SelectedValue = MaL;
                cbMaSV.SelectedValue = MaSV;
                cbMaMH.SelectedValue = MaMH;
                cbMaGV.SelectedValue = MaGV;
                cbMaLD.SelectedValue = MaLD;
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
                //cbMaL.Enabled = false;
                //cbMaSV.Enabled = false;
                //cbMaMH.Enabled = false;
                //cbMaGV.Enabled = false;
                //cbMaLD.Enabled = false;
                cbTrangThai.Enabled = false;
            }
            else
            {
                //cbMaL.Enabled = true;
                //cbMaSV.Enabled = true;
                //cbMaMH.Enabled = true;
                //cbMaGV.Enabled = true;
                //cbMaLD.Enabled = true;
                cbTrangThai.Enabled = true;
            }
        }

        void XoaForm()
        {
            cbTrangThai.SelectedValue = 0;
        }

        void cbMaLD_SelectedIndexChange(object sender, EventArgs e)
        {
            //NapLop();
            //NapSinhVien();
            //NapMonHoc();
            //NapGiaoVien();
            //NapLoaiDiem();
            //NapTrangThai();
            NapDuLieu();

            EvenButton(0);
            EnableOrDisable(true);
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            en = new En_Diem();

            NapLop();
            NapSinhVien();
            NapMonHoc();
            NapGiaoVien();
            NapLoaiDiem();
            NapTrangThai();
            NapDuLieu();

            EvenButton(0);
            EnableOrDisable(true);
        }

        void InserUpdateData()
        {
            if (cbMaL.Text.Trim().Equals("") || cbMaSV.Text.Trim().Equals("") || cbMaMH.Text.Trim().Equals("") || cbMaGV.Text.Trim().Equals("") || cbMaLD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Điền Mã giáo viên và Họ Tên giáo viên đầy đủ, sau đó thực hiện lại thao tác", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InsertNew == true)
            {
                try
                {
                    en.MaL = cbMaL.SelectedValue.ToString();
                    en.MaSV = cbMaSV.SelectedValue.ToString();
                    en.MaMH = cbMaMH.SelectedValue.ToString();
                    en.MaGV = cbMaGV.SelectedValue.ToString();
                    en.MaLD = cbMaLD.SelectedValue.ToString();
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
                    en.id = Int32.Parse(dgv.Rows[index].Cells["id"].Value.ToString());
                    en.MaL = cbMaL.SelectedValue.ToString();
                    en.MaSV = cbMaSV.SelectedValue.ToString();
                    en.MaMH = cbMaMH.SelectedValue.ToString();
                    en.MaGV = cbMaGV.SelectedValue.ToString();
                    en.MaLD = cbMaLD.SelectedValue.ToString();
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
