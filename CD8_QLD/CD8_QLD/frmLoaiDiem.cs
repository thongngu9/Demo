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
    public partial class frmLoaiDiem : Form
    {
        //Player
        private BUS_LoaiDiem bus;
        private En_LoaiDiem en;
        //End Player

        //Controls
        private GroupBox gb1 = new GroupBox();
        private GroupBox gb2 = new GroupBox();
        private GroupBox gb3 = new GroupBox();

        private Label lbl1 = new Label();
        private Label lbl2 = new Label();
        private Label lbl3 = new Label();

        private DataGridView dgv = new DataGridView();

        private TextBox txtMaLD = new TextBox();
        private TextBox txtTenLD = new TextBox();

        private ComboBox cbTrangThai = new ComboBox();

        private Button btnThem = new Button();
        private Button btnSua = new Button();
        private Button btnXoa = new Button();
        private Button btnHuy = new Button();
        private Button btnLuu = new Button();
        private Button btnThoat = new Button();
        //End Controls

        public frmLoaiDiem()
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
            this.gb1.Controls.Add(this.txtMaLD);
            this.gb1.Controls.Add(this.txtTenLD);
            this.gb1.Controls.Add(this.cbTrangThai);

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
            this.lbl1.Text = "Mã loại điểm: *";

            this.lbl2.Location = new Point(178, 22);
            this.lbl2.Size = new Size(81, 13);
            this.lbl2.Text = "Tên loại điểm: *";

            this.lbl3.Location = new Point(434, 22);
            this.lbl3.Size = new Size(58, 13);
            this.lbl3.Text = "Trạng thái:";
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
            this.dgv.Size = new Size(598, 245);
            //End DataGridView

            //Textbox
            this.txtMaLD.Location = new Point(89, 19);
            this.txtMaLD.Size = new Size(83, 20);
            this.txtMaLD.TabIndex = 1;

            this.txtTenLD.Location = new Point(265, 19);
            this.txtTenLD.Size = new Size(163, 20);
            this.txtTenLD.TabIndex = 2;
            //End Textbox

            //ComboBox
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new Point(498, 19);
            this.cbTrangThai.Size = new Size(103, 21);
            this.cbTrangThai.TabIndex = 3;
            //End ComboBox

            //Button
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new Point(21, 19);
            this.btnThem.Size = new Size(90, 23);
            this.btnThem.TabIndex = 4;

            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new Point(117, 19);
            this.btnSua.Size = new Size(90, 23);
            this.btnSua.TabIndex = 5;

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new Point(309, 19);
            this.btnXoa.Size = new Size(90, 23);
            this.btnXoa.TabIndex = 7;

            this.btnHuy.Text = "Hủy";
            this.btnHuy.Location = new Point(405, 19);
            this.btnHuy.Size = new Size(90, 23);
            this.btnHuy.TabIndex = 8;

            this.btnLuu.Text = "Lưu";
            this.btnLuu.Location = new Point(213, 19);
            this.btnLuu.Size = new Size(90, 23);
            this.btnLuu.TabIndex = 6;

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new Point(501, 19);
            this.btnThoat.Size = new Size(90, 23);
            this.btnThoat.TabIndex = 9;
            //End Button

            //GroupBox
            this.gb1.Anchor = AnchorStyles.Top;
            this.gb1.Location = new Point(12, 12);
            this.gb1.Size = new Size(610, 51);
            this.gb1.Text = "Thông Tin";

            this.gb2.Anchor = AnchorStyles.Top;
            this.gb2.Location = new Point(12, 69);
            this.gb2.Size = new Size(610, 55);
            this.gb2.Text = "Chức Năng";

            this.gb3.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.gb3.Location = new Point(12, 130);
            this.gb3.Size = new Size(610, 270);
            this.gb3.Text = "Hiển Thị";
            //End GroupBox

            //Set up the Form
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(634, 412);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Text = "Loại Điểm";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb3.ResumeLayout(false);
            ((ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            //End set up the form

            this.Load += new EventHandler(this.frmLoaiDiem_Load);
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
            bus = new BUS_LoaiDiem();

            dt = bus.selectdata();
            dgv.DataSource = dt;

            if (dgv.ColumnCount > 0)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "Tên Loại Điểm";
                dgv.Columns[2].HeaderText = "Trạng Thái";
                dgv.Columns[3].HeaderText = "Ngày Tạo";
                dgv.Columns[4].HeaderText = "Ngày Cập Nhật";
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
                string MaLD = dgv.Rows[index].Cells["MaLD"].Value.ToString();
                string TenLD = dgv.Rows[index].Cells["TenLD"].Value.ToString();
                string TrangThai = dgv.Rows[index].Cells["TrangThai"].Value.ToString();

                txtMaLD.Text = MaLD;
                txtTenLD.Text = TenLD;
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
                txtMaLD.ReadOnly = true;
                txtTenLD.ReadOnly = true;
                cbTrangThai.Enabled = false;
            }
            else
            {
                txtMaLD.ReadOnly = false;
                txtTenLD.ReadOnly = false;
                cbTrangThai.Enabled = true;
            }
        }

        void XoaForm()
        {
            txtMaLD.Text = "";
            txtTenLD.Text = "";
            cbTrangThai.SelectedValue = 0;
        }

        private void frmLoaiDiem_Load(object sender, EventArgs e)
        {
            en = new En_LoaiDiem();

            NapTrangThai();
            NapDuLieu();

            EvenButton(0);
            EnableOrDisable(true);
        }

        void InserUpdateData()
        {
            if (txtMaLD.Text.Trim().Equals("") || txtTenLD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Điền Mã loại điểm và Tên loại điểm đầy đủ, sau đó thực hiện lại thao tác", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InsertNew == true)
            {
                try
                {
                    en.MaLD = txtMaLD.Text;
                    en.TenLD = txtTenLD.Text;
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
                    en.MaLD = dgv.Rows[index].Cells["MaLD"].Value.ToString();
                    en.TenLD = txtTenLD.Text;
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
            en.MaLD = dgv.Rows[index].Cells["MaLD"].Value.ToString();

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
