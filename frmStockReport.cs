using DevExpress.XtraBars;
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
    public partial class frmStockReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmStockReport()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmStockReport_Load(object sender, EventArgs e)
        {
            filldata();
        }
        private void filldata()
        {
            using (var context = new SysproCompanyTEntities())
            {
                //  var porLst = context.Logins.ToList();
                var result = from s in context.vw_FetchInvWarehouse.ToList() select s;
                vwFetchInvWarehouseBindingSource.DataSource = result;
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(folderBrowserDialog.SelectedPath + "/StockReport.xlsx");
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            filldata();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBOReport frmform = new frmBOReport();
            frmform.Show();
        }
    }
}