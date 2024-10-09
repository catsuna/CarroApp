using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Server;

namespace CarroApp
{
    public partial class FrmLogin : Form
    {
        ProcessDatabase database = new ProcessDatabase();
        int checkLogin = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if(checkRegister(txt_name.Text, txt_pass.Text))
            {
                String insert = "insert into tblUser values('" + txt_name.Text + "'," + "'" + txt_pass.Text + "',0)";
                database.CapNhatDuLieu(insert);
                lbl_status.Text = txt_name.Text + " Đăng ký thành công";
            }
            else
            {
                lbl_status.Text = "Đăng ký thất bại  userName đã tồn tại trong hệ thống vui lòng chọn userName khác";
            }
          

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (checkLoginForm(txt_name.Text, txt_pass.Text))
            {
                lbl_status.Text = txt_name.Text+" Đăng nhập thành công";
                Cons.player1 = txt_name.Text;
                Cons.markPlayer1 =Convert.ToInt32( database.DocBang("select UserName,Mark from tblUser where UserName='" + Cons.player1 + "'").Rows[0]["Mark"].ToString());
                checkLogin++;
            }
            else
            {
                lbl_status.Text = "Đăng nhập thất bại kiểm tra lại userName hoặc passWord";
            }
        }

        private bool checkLoginForm(string name, string pass)
        {
            if (name != "" && pass != "")
            {
                String check = "select* from tblUser where UserName = '" + name + "'" + " and PassWord = '" + pass + "'";
                DataTable table = database.DocBang(check);
                if (table.Rows.Count == 1)
                    return true;
            }

            return false;
        }

        private void btn_register2_Click(object sender, EventArgs e)
        {
            if (checkRegister(txt_name2.Text, txt_pass2.Text))
            {
                String insert = "insert into tblUser values('" + txt_name2.Text + "'," + "'" + txt_pass2.Text + "',0)";
                database.CapNhatDuLieu(insert);
                lbl_status.Text = txt_name2.Text + " Đăng ký thành công";
            }
            else
            {
                lbl_status.Text = "Đăng ký thất bại Có thể userName đã tồn tại trong hệ thống vui lòng chọn userName khác";
            }
           
        }

        private bool checkRegister(string name, string pass)
        {
            if (name != "" && pass != "")
            {
                if (database.DocBang("select UserName,Mark from tblUser where UserName='" + name + "'").Rows.Count>0)
                {
                    if(database.DocBang("select UserName,Mark from tblUser where UserName='" + name + "'").Rows[0]["UserName"].ToString() == "")
                    return true;
                }
            }
          
            return false;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (checkLogin == 1)
            {

                MessageBox.Show("Bạn không thể chơi 1 người");
            }
            if (checkLogin == 2)
            {
                FrmClient frmClient = new FrmClient();
                FrmServer frmServer = new FrmServer();
                frmServer.Show();
                frmClient.Show();
            }

           
        }

        private void btn_login2_Click(object sender, EventArgs e)
        {
            if (checkLoginForm(txt_name2.Text, txt_pass2.Text))
            {
                lbl_status.Text = txt_name2.Text + " Đăng nhập thành công";
                checkLogin++;
                Cons.player2 = txt_name2.Text;
                Cons.markPlayer2 = Convert.ToInt32(database.DocBang("select UserName,Mark from tblUser where UserName='" + Cons.player2 + "'").Rows[0]["Mark"].ToString());
            }
            else
            {
                lbl_status.Text = "Đăng nhập thất bại kiểm tra lại userName hoặc passWord";
            }
        }

    }
}
