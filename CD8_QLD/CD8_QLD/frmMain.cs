using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add Directory
using System.IO;

namespace CD8_QLD
{
    public partial class frmMain : Form
    {
        //Controls
        private Ribbon ribbon1 = new Ribbon();

        private RibbonTab ribbonTab1 = new RibbonTab();
        private RibbonTab ribbonTab2 = new RibbonTab();
        private RibbonTab ribbonTab3 = new RibbonTab();
        private RibbonTab ribbonTab4 = new RibbonTab();
        private RibbonTab ribbonTab5 = new RibbonTab();
        private RibbonTab ribbonTab6 = new RibbonTab();

        private RibbonPanel ribbonPanel1 = new RibbonPanel();
        private RibbonPanel ribbonPanel2 = new RibbonPanel();
        private RibbonPanel ribbonPanel3 = new RibbonPanel();
        private RibbonPanel ribbonPanel4 = new RibbonPanel();
        private RibbonPanel ribbonPanel5 = new RibbonPanel();
        private RibbonPanel ribbonPanel6 = new RibbonPanel();
        private RibbonPanel ribbonPanel7 = new RibbonPanel();
        private RibbonPanel ribbonPanel8 = new RibbonPanel();

        private RibbonButton ribbonButton1 = new RibbonButton();
        private RibbonButton ribbonButton2 = new RibbonButton();
        private RibbonButton ribbonButton3 = new RibbonButton();
        private RibbonButton ribbonButton5 = new RibbonButton();
        private RibbonButton ribbonButton4 = new RibbonButton();
        private RibbonButton ribbonButton6 = new RibbonButton();
        private RibbonButton ribbonButton7 = new RibbonButton();
        private RibbonButton ribbonButton8 = new RibbonButton();
        private RibbonButton ribbonButton9 = new RibbonButton();
        private RibbonButton ribbonButton10 = new RibbonButton();
        private RibbonButton ribbonButton11 = new RibbonButton();
        private RibbonButton ribbonButton12 = new RibbonButton();
        private RibbonButton ribbonButton13 = new RibbonButton();
        //End Controls

        public frmMain()
        {
            InitializeComponent();

            this.SuspendLayout();
            // 
            // ribbon1
            //
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(734, 163);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Tabs.Add(this.ribbonTab4);
            this.ribbon1.Tabs.Add(this.ribbonTab5);
            this.ribbon1.Tabs.Add(this.ribbonTab6);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue_2010;
            // 
            // ribbonTab1
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Text = "Hệ Thống";
            // ribbonPanel1
            this.ribbonPanel1.ButtonMoreEnabled = false;
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.ribbonButton1);
            this.ribbonPanel1.Items.Add(this.ribbonButton2);
            this.ribbonPanel1.Text = "Hệ Thống";
            // 
            // ribbonTab2
            this.ribbonTab2.Panels.Add(this.ribbonPanel2);
            this.ribbonTab2.Text = "Người Dùng Hệ Thống";
            // ribbonPanel2
            this.ribbonPanel2.ButtonMoreEnabled = false;
            this.ribbonPanel2.ButtonMoreVisible = false;
            this.ribbonPanel2.Items.Add(this.ribbonButton3);
            this.ribbonPanel2.Items.Add(this.ribbonButton4);
            this.ribbonPanel2.Text = "Thông Tin Tài Khoản";
            // 
            // ribbonTab3
            this.ribbonTab3.Panels.Add(this.ribbonPanel3);
            this.ribbonTab3.Text = "Quản Lý Người Dùng";
            // ribbonPanel3
            this.ribbonPanel3.ButtonMoreEnabled = false;
            this.ribbonPanel3.ButtonMoreVisible = false;
            this.ribbonPanel3.Items.Add(this.ribbonButton5);
            this.ribbonPanel3.Items.Add(this.ribbonButton6);
            this.ribbonPanel3.Text = "Người Dùng";
            // 
            // ribbonTab4
            this.ribbonTab4.Panels.Add(this.ribbonPanel4);
            this.ribbonTab4.Panels.Add(this.ribbonPanel5);
            this.ribbonTab4.Text = "Cập Nhật Hệ Thống";
            // ribbonPanel4
            this.ribbonPanel4.ButtonMoreEnabled = false;
            this.ribbonPanel4.ButtonMoreVisible = false;
            this.ribbonPanel4.Items.Add(this.ribbonButton7);
            this.ribbonPanel4.Items.Add(this.ribbonButton8);
            this.ribbonPanel4.Text = "Lớp - Môn Học";
            // ribbonPanel5
            this.ribbonPanel5.ButtonMoreEnabled = false;
            this.ribbonPanel5.ButtonMoreVisible = false;
            this.ribbonPanel5.Items.Add(this.ribbonButton9);
            this.ribbonPanel5.Items.Add(this.ribbonButton10);
            this.ribbonPanel5.Text = "Điểm";
            // 
            // ribbonTab5
            this.ribbonTab5.Panels.Add(this.ribbonPanel6);
            this.ribbonTab5.Text = "Tra Cứu";
            // ribbonPanel6
            this.ribbonPanel6.ButtonMoreEnabled = false;
            this.ribbonPanel6.ButtonMoreVisible = false;
            this.ribbonPanel6.Items.Add(this.ribbonButton11);
            this.ribbonPanel6.Text = "Tra Cứu";
            // 
            // ribbonTab6
            this.ribbonTab6.Panels.Add(this.ribbonPanel7);
            this.ribbonTab6.Text = "Thoát Hệ Thống";
            // ribbonPanel7
            this.ribbonPanel7.ButtonMoreEnabled = false;
            this.ribbonPanel7.ButtonMoreVisible = false;
            this.ribbonPanel7.Items.Add(this.ribbonButton12);
            this.ribbonPanel7.Items.Add(this.ribbonButton13);
            this.ribbonPanel7.Text = "Thoát Hệ Thống";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = Image.FromFile(@"../../res/login48.png");
            this.ribbonButton1.LargeImage = Image.FromFile(@"../../res/login48.png");
            this.ribbonButton1.Text = "Đăng nhập";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = Image.FromFile(@"../../res/signup48.png");
            this.ribbonButton2.LargeImage = Image.FromFile(@"../../res/signup48.png");
            this.ribbonButton2.Text = "Đăng ký";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = Image.FromFile(@"../../res/user482.png");
            this.ribbonButton3.LargeImage = Image.FromFile(@"../../res/user482.png");
            this.ribbonButton3.Text = "Người dùng";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = Image.FromFile(@"../../res/password48.png");
            this.ribbonButton4.LargeImage = Image.FromFile(@"../../res/password48.png");
            this.ribbonButton4.Text = "Đổi mật khẩu";
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = Image.FromFile(@"../../res/teacher48.png");
            this.ribbonButton5.LargeImage = Image.FromFile(@"../../res/teacher48.png");
            this.ribbonButton5.Text = "Giáo viên";
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = Image.FromFile(@"../../res/student48.png");
            this.ribbonButton6.LargeImage = Image.FromFile(@"../../res/student48.png");
            this.ribbonButton6.Text = "Sinh viên";
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Image = Image.FromFile(@"../../res/classroom48.png");
            this.ribbonButton7.LargeImage = Image.FromFile(@"../../res/classroom48.png");
            this.ribbonButton7.Text = "Lớp";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.Image = Image.FromFile(@"../../res/subjects48.png");
            this.ribbonButton8.LargeImage = Image.FromFile(@"../../res/subjects48.png");
            this.ribbonButton8.Text = "Môn học";
            // 
            // ribbonButton9
            // 
            this.ribbonButton9.Image = Image.FromFile(@"../../res/point482.png");
            this.ribbonButton9.LargeImage = Image.FromFile(@"../../res/point482.png");
            this.ribbonButton9.Text = "Loại điểm";
            // 
            // ribbonButton10
            // 
            this.ribbonButton10.Image = Image.FromFile(@"../../res/point48.png");
            this.ribbonButton10.LargeImage = Image.FromFile(@"../../res/point48.png");
            this.ribbonButton10.Text = "Điểm";
            // 
            // ribbonButton11
            // 
            this.ribbonButton11.Image = Image.FromFile(@"../../res/search48.png");
            this.ribbonButton11.LargeImage = Image.FromFile(@"../../res/search48.png");
            this.ribbonButton11.Text = "Điểm";
            // 
            // ribbonButton12
            // 
            this.ribbonButton12.Image = Image.FromFile(@"../../res/logout48.png");
            this.ribbonButton12.LargeImage = Image.FromFile(@"../../res/logout48.png");
            this.ribbonButton12.Text = "Đăng xuất";
            // 
            // ribbonButton13
            // 
            this.ribbonButton13.Image = Image.FromFile(@"../../res/shutdown48.png");
            this.ribbonButton13.LargeImage = Image.FromFile(@"../../res/shutdown48.png");
            this.ribbonButton13.Text = "Thoát";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Text = "Phần mềm quản lý điểm";
            this.ResumeLayout(false);

            this.Load += new EventHandler(this.frmMain_Load);

            this.ribbonButton1.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.ribbonButton4.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            this.ribbonButton5.Click += new System.EventHandler(this.btnGiaoVien_Click);
            this.ribbonButton6.Click += new System.EventHandler(this.btnSinhVien_Click);
            this.ribbonButton7.Click += new System.EventHandler(this.btnLop_Click);
            this.ribbonButton8.Click += new System.EventHandler(this.btnMonHoc_Click);
            this.ribbonButton9.Click += new System.EventHandler(this.btnLoaiDiem_Click);
            this.ribbonButton10.Click += new System.EventHandler(this.btnDiem_Click);
            this.ribbonButton13.Click += new System.EventHandler(this.btnThoat_Click);
        }

        //Function
        public static string Quyen;

        void PhanQuyen_PhongDaoTao()
        {
            this.ribbonTab2.Enabled = true;
            this.ribbonTab2.Visible = true;
            this.ribbonTab3.Enabled = true;
            this.ribbonTab3.Visible = true;
            this.ribbonTab4.Enabled = true;
            this.ribbonTab4.Visible = true;
            this.ribbonTab5.Enabled = true;
            this.ribbonTab5.Visible = true;
        }

        void PhanQuyen_GiaoVien()
        {
            this.ribbonTab2.Enabled = true;
            this.ribbonTab2.Visible = true;
            this.ribbonTab3.Enabled = true;
            this.ribbonTab3.Visible = true;
            this.ribbonTab4.Enabled = true;
            this.ribbonTab4.Visible = true;
            this.ribbonTab5.Enabled = true;
            this.ribbonTab5.Visible = true;
        }

        void PhanQuyen_SinhVien()
        {
            this.ribbonTab2.Enabled = false;
            this.ribbonTab2.Visible = false;
            this.ribbonTab3.Enabled = false;
            this.ribbonTab3.Visible = false;
            this.ribbonTab4.Enabled = false;
            this.ribbonTab4.Visible = false;
            this.ribbonTab5.Enabled = true;
            this.ribbonTab5.Visible = true;
        }

        void PhanQuyen_Khac()
        {
            this.ribbonTab2.Enabled = false;
            this.ribbonTab2.Visible = false;
            this.ribbonTab3.Enabled = false;
            this.ribbonTab3.Visible = false;
            this.ribbonTab4.Enabled = false;
            this.ribbonTab4.Visible = false;
            this.ribbonTab5.Enabled = false;
            this.ribbonTab5.Visible = false;
                this.ribbonButton12.Visible = false;
        }

        Form KiemTraTonTaiForm(string nameform)
        {
            Form check = null;
            foreach (Form f in MdiChildren)
            {
                if (f.Name == nameform)
                {
                    check = f;
                    break;
                }
            }
            return check;
        }

        void frmMain_Load(object sender, EventArgs e)
        {
            if (Quyen == "1")
            {
                PhanQuyen_PhongDaoTao();
            }
            else if (Quyen == "2")
            {
                PhanQuyen_GiaoVien();
            }
            else if (Quyen == "3")
            {
                PhanQuyen_SinhVien();
            }
            else
            {
                PhanQuyen_Khac();
            }
        }

        //Hệ Thống <01>
        //Đăng Nhập
        void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmDangNhap") == null)
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                KiemTraTonTaiForm("frmDangNhap").Activate();
            }
        }

        //Quản Lý Người Dùng <02>
        //Đổi mật khẩu
        void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmDoiMatKhau") == null)
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                KiemTraTonTaiForm("frmDoiMatKhau").Activate();
            }
        }

        //Quản Lý Người Dùng <03>
        //Giáo viên
        void btnGiaoVien_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmGiaoVien") == null)
            {
                frmGiaoVien f = new frmGiaoVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                KiemTraTonTaiForm("frmGiaoVien").Activate();
            }
        }
        //Sinh viên
        void btnSinhVien_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmSinhVien") == null)
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                KiemTraTonTaiForm("frmSinhVien").Activate();
            }
        }

        //Cập Nhật Hệ Thống <04>
        //Lớp
        void btnLop_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmLop") == null)
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                KiemTraTonTaiForm("frmLop").Activate();
            }
        }
        //Môn Học
        void btnMonHoc_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmMonHoc") == null)
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                KiemTraTonTaiForm("frmMonHoc").Activate();
            }
        }
        //Loại Điểm
        void btnLoaiDiem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmLoaiDiem") == null)
            {
                frmLoaiDiem f = new frmLoaiDiem();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                KiemTraTonTaiForm("frmLoaiDiem").Activate();
            }
        }
        //Điểm
        void btnDiem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmDiem") == null)
            {
                frmDiem f = new frmDiem();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                KiemTraTonTaiForm("frmDiem").Activate();
            }
        }

        //Thoát Hệ Thống <06>
        //Thoát
        void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //End Function
    }
}
