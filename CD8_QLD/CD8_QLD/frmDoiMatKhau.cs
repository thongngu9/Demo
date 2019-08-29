using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD8_QLD
{
    public partial class frmDoiMatKhau : Form
    {
        //Controls
        private Label lbl1 = new Label();
        private Label lbl2 = new Label();

        private TextBox txtPassWord = new TextBox();
        private TextBox txtRePassWord = new TextBox();

        private Button btnLuu = new Button();
        private Button btnHuy = new Button();
        //End Controls

        public frmDoiMatKhau()
        {
            InitializeComponent();

            //Label
            this.lbl1.Location = new Point(12, 15);
            this.lbl1.Size = new Size(74, 13);
            this.lbl1.Text = "Mật khẩu mới:";

            this.lbl2.Location = new Point(12, 67);
            this.lbl2.Size = new Size(115, 13);
            this.lbl2.Text = "Nhập lại mật khẩu mới:";
            //End Label

            //TextBox
            this.txtPassWord.Location = new Point(15, 38);
            this.txtPassWord.Size = new Size(257, 20);
            this.txtPassWord.TabIndex = 1;

            this.txtRePassWord.Location = new Point(15, 90);
            this.txtRePassWord.Size = new Size(257, 20);
            this.txtRePassWord.TabIndex = 2;
            //End TextBox

            //Button
            this.btnLuu.Location = new Point(64, 116);
            this.btnLuu.Size = new Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";

            this.btnHuy.Location = new Point(145, 116);
            this.btnHuy.Size = new Size(75, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            //End Button

            //Set up the Form
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new Size(284, 157);
            this.Text = "Đổi Mật Khẩu";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            //End set up the form

            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtRePassWord);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
        }
    }
}
