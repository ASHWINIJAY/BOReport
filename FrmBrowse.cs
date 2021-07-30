using POScreen.DAL;
using System;
using System.Windows.Forms;
using POScreen.DAL.DTO;
using System.Data.Entity;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;

namespace POScreen
{
    public partial class FrmBrowse : Form
    {
        public string _POOrder;
        public FrmBrowse()
        {
            InitializeComponent();
        }

        private void FrmBrowse_Load(object sender, EventArgs e)
        {
            List<vwPOList> poLst = new List<vwPOList>();
            using (SysproCompanyTEntities db = new SysproCompanyTEntities())
            {
                var lst = db.vwPOLists.ToListAsync();
                string prev="";
                foreach (var item in lst.Result)
                {
                    if (prev == "" || prev != (item.PurchaseOrder.TrimStart('0')))
                    {
                        item.PurchaseOrder = item.PurchaseOrder.TrimStart('0');
                        prev = item.PurchaseOrder;
                        poLst.Add(item);
                    }
                    else
                    {
                      
                    }
                }
                POgridControl.DataSource = poLst;
                POgridView.RefreshData();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vwPOList vw = new vwPOList();
            int idx = POgridView.FocusedRowHandle;
            vw = (vwPOList)POgridControl.DefaultView.GetRow(idx);
            _POOrder = vw.PurchaseOrder;
            this.Close();
        }

        private void POgridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
         
        }
    }
}
