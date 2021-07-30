using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POScreen
{
    public partial class frmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string logtypes;
        public frmHome()
        {
            InitializeComponent();
        }
        public frmHome(string logtype,string loginname)
        {
            InitializeComponent();
            logtypes = logtype;
            lblUsername.Caption = "LOGGED IN AS  " + loginname.ToUpper();
        }
//        Private InitStatusBarInfo()
//        {
//            lblUsername.Caption = "Logged in as " + Environment.UserName.ToString()+  " on " + DateTime.Now.ToString("yyyy/MM/dd");
//       // lblDepartment.Caption = "Department = " & _department
//        Try
//                {
//                lblVersion.Caption = "INSIMBI - V" & this..Application.Deployment.CurrentVersion.ToString
      
//       }
//            Catch(System.Deployment.Application.InvalidDeploymentException inv)
//                {
//                lblVersion.Caption = "INSIMBI - V" & this.ve.Info.Version.ToString;
//                    }
//}
        private void btnShipment_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmShipment  frmship= new frmShipment (logtypes);
            frmship .Show();
        }

        private void btnDueDate_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form1 frmform = new Form1(logtypes);
            frmform.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmShipmentSearch frmship = new frmShipmentSearch(logtypes);
            frmship.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //set version info
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersion.Caption = "AUSSIE TRAVELLER - V"+  version.Major+":"+ version.Minor + ":" + version.Build + ":" + version.Revision;
          
            if (logtypes != "Admin")
            {
                barButtonItem1 .Enabled = false;
                btnDueDate.Enabled = false;
            }
        }
    }
}