using DevExpress.XtraEditors;
using POScreen.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POScreen
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public string logintype;
        public string loginname;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new AussieTravellerEntities())
            {

               

              //  var porLst = context.Logins.ToList();
                var result = from s in context.Logins.ToList()
                             where s.UserName == textEdit1.Text &&  s.Password==textEdit2.Text
                             select s;
                if(result.ToList().Count>0) 
                {
                    logintype = result.FirstOrDefault().LoginType;
                    loginname = result.FirstOrDefault().UserName;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");
                    logintype = "";
                    textEdit2.Text = "";
                    textEdit2.Focus();
                }
            }
        }

        private void textEdit2_Enter(object sender, EventArgs e)
        {
            btnLogin.Click += new EventHandler(btnLogin_Click);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}