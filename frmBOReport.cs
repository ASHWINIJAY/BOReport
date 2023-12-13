using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POScreen.DAL;
using DevExpress.XtraEditors;

namespace POScreen
{
    public partial class frmBOReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmBOReport()
        {
            InitializeComponent();
        }

        private void frmBOReport_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            filldata();
        }
        DateTime startdate;
        DateTime enddate;
        private void filldata()
        {
            AppUtility.UI.Notification.ShowWaitForm(this, "Please wait..");
            List<vw_FetchBOReport> listvw_FetchCusSorMaster;
            using (var context = new SysproCompanyTEntities())
            {
                if (startdate.Year != 1 && enddate.Year != 1)
                {
                    listvw_FetchCusSorMaster = context.vw_FetchBOReport.Where(c => c.ODate >= startdate && c.ODate <= enddate).ToList();

                    vwFetchBOReportBindingSource.DataSource = listvw_FetchCusSorMaster;
                }
            }
            AppUtility.UI.Notification.CloseWaitForm();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(folderBrowserDialog.SelectedPath + "/BOReport.xlsx");
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            filldata();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStockReport frmform = new frmStockReport();
            frmform.Show();
        }

        private void repStart_EditValueChanged(object sender, EventArgs e)
        {
            DateEdit rep = (DateEdit)sender;
            if (rep.EditValue != null)
                startdate = (DateTime)rep.EditValue;
            filldata();
        }

        private void repEnd_EditValueChanged(object sender, EventArgs e)
        {
            DateEdit rep = (DateEdit)sender;
            enddate = (DateTime)rep.EditValue;
            filldata();
        }
    }
}