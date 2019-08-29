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
    public partial class frmDangNhap : Form
    {
        //Player
        private BUS_User bus;
        private En_User en;
        //End Player

        //Controls
        private Label lbl1 = new Label();
        private Label lbl2 = new Label();

        private TextBox txtTaiKhoan = new TextBox();
        private TextBox txtMatKhau = new TextBox();

        private Button btnDangNhap = new Button();
        private Button btnHuy = new Button();
        //End Controls

        public frmDangNhap()
        {
            InitializeComponent();

            //Set up the form.
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(300, 155);
            this.Text = "Đăng Nhập";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            //Label
            this.lbl1.Text = "Tài khoản:";
            this.lbl1.Location = new System.Drawing.Point(12, 24);
            this.lbl1.Size = new System.Drawing.Size(58, 13);

            this.lbl2.Text = "Mật khẩu:";
            this.lbl2.Location = new System.Drawing.Point(12, 50);
            this.lbl2.Size = new System.Drawing.Size(55, 13);
            //End Label

            //Textbox
            this.txtTaiKhoan.Location = new System.Drawing.Point(76, 21);
            this.txtTaiKhoan.Size = new System.Drawing.Size(196, 20);
            this.txtTaiKhoan.TabIndex = 1;

            this.txtMatKhau.Location = new System.Drawing.Point(76, 47);
            this.txtMatKhau.Size = new System.Drawing.Size(196, 20);
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.TabIndex = 2;
            //End Textbox

            //Button
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Location = new System.Drawing.Point(62, 73);
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 3;

            this.btnHuy.Text = "Hủy";
            this.btnHuy.Location = new System.Drawing.Point(143, 73);
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 4;
            //End Button

            this.Controls.Add(lbl1);
            this.Controls.Add(lbl2);
            this.Controls.Add(txtTaiKhoan);
            this.Controls.Add(txtMatKhau);
            this.Controls.Add(btnDangNhap);
            this.Controls.Add(btnHuy);

            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
        }

        void Setnull()
        {
            txtTaiKhoan.ResetText();
            txtMatKhau.ResetText();
            txtTaiKhoan.Focus();
        }

        //private void frmDangNhap_Load(object sender, EventArgs e)
        //{
        //    en = new En_User();

        //    NapLop();
        //    NapSinhVien();
        //    NapMonHoc();
        //    NapGiaoVien();
        //    NapLoaiDiem();
        //    NapTrangThai();
        //    NapDuLieu();

        //    EvenButton(0);
        //    EnableOrDisable(true);
        //}

        void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Xin vui lòng nhập đủ thông tin.", "Thông báo!!!");
                return;
            }

            //if (KNDL.GetData("Select * from [User] where UserName = N'" + txtUserName.Text + "' and Pass_Word = '" + txtPass_Word.Text + "'").Rows.Count == 1)
            //{
            //    MessageBox.Show("Đăng nhập thành công.", "Thông báo!!!");

            //    formMain.Quyen = KNDL.Field("Select Quyen from [User] where UserName = N'" + txtUserName.Text + "' and Pass_Word = '" + txtPass_Word.Text + "'");
            //    frmMain f = new frmMain();
            //    f.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Đăng nhập thất bại, sai thông tin tài khoản hoặc tài khoản chưa được đăng kí.", "Thông báo!!!");
            //    Setnull();
            //}

            try
            {
                DataTable dt = new DataTable();
                bus = new BUS_User();

                dt = bus.selectlevel(txtTaiKhoan.Text, txtMatKhau.Text);
                DataGridView dgv = new DataGridView();
                dgv.DataSource = dt;
                if (dgv.ColumnCount > 0)
                {
                    MessageBox.Show("Đăng nhập thành công.", "Thông báo!!!");
                    //dgv.Columns[0].Visible = false;
                    //int index = dgv.CurrentCell.RowIndex;
                    frmMain.Quyen = dgv.Rows[0].Cells["Quyen"].Value.ToString();
                    frmMain f = new frmMain();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, sai thông tin tài khoản hoặc tài khoản chưa được đăng kí.", "Thông báo!!!");
                    Setnull();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message.ToString());
            }
        }

        void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
