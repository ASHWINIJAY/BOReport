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
    public partial class FrmPOBrowse : Form
    {
        public string _POOrders;
        public List<POLine> lstPoline = new List<POLine>();
        public FrmPOBrowse()
        { 
            InitializeComponent();
        }
        List<vwPOBrowseList> poLst = new List<vwPOBrowseList>();
        private void FrmBrowse_Load(object sender, EventArgs e)
        {
            
            using (SysproCompanyTEntities db = new SysproCompanyTEntities())
            {
                var lst = db.vwPOBrowseLists.ToListAsync();
                //string prev="";
                foreach (var item in lst.Result)
                {

                    item.PurchaseOrder = item.PurchaseOrder.TrimStart('0');
                    if (item.PurchaseOrder.Length == 1)
                        item.PurchaseOrder = "0" + item.PurchaseOrder;
                    // prev = item.PurchaseOrder;
                    // item.MOriginalLine = Convert.ToInt32(item.PurchaseOrder);
                    poLst.Add(item);

                }
                POgridControl.DataSource = poLst;
                //POgridView.SelectRow(0) = true;
                POgridView.RefreshData();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();   
        }

        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vwPOBrowseList vw = new vwPOBrowseList();
            // int idx = POgridView.FocusedRowHandle;
           
            for (int i = 0; i < POgridView.DataRowCount; i++)
            {
                //  int idx = POgridView.FocusedRowHandle;
                //  var cellValue = POgridView.GetDataRowHandleByGroupRowHandle(i, "pocheck");
                //GridColumn myColumn = gridView1.Columns["forignkey"];
               //var a= POgridView.GetFocusedRowCellValue("pocheck");
                if (POgridView.IsRowSelected(i))
                {

                    vw = (vwPOBrowseList)POgridControl.DefaultView.GetRow(i);
                    POLine objPoline = new POLine();
                    objPoline.PONumber = vw.PurchaseOrder.TrimStart('0');
                    objPoline.Line = vw.Line.ToString();

                    lstPoline.Add(objPoline);
                    // code when checked
                }
                else
                {
                    // code when not checked
                }
            }
           
            this.Close();
           // int[] selValue = POgridView.GetSelectedRows();

        }

        private void POgridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
         
        }

        private void POgridControl_Click(object sender, EventArgs e)
        {

        }

        private void POgridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var es = e.Value;
          
        }

        private void POgridControl_DataSourceChanged(object sender, EventArgs e)
        {
         
        }
    }
}
