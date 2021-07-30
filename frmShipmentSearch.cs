using POScreen.DAL;
using System;
using System.Windows.Forms;
using POScreen.DAL.DTO;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace POScreen
{
    public partial class frmShipmentSearch : Form
    {

        List<Shipment> _poList = new List<Shipment>();
        public frmShipmentSearch()
        {
            InitializeComponent();
        }
         private string logtypes;
        public frmShipmentSearch(string logtype)
        {
            InitializeComponent();
            logtypes = logtype;
        }

        private void POgridControl_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            dataload();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (logtypes != "Admin")
                simpleButton1.Enabled = false;
        }

        private List<Shipment> dataload()
        {
            _poList = new List<Shipment>();
            using (var context = new AussieTravellerEntities())
            {

                var result = from s in context.Shipments.ToList()
                             where s.ShipmentNumber == txtSrchPO.Text
                             select s;
                _poList = result.ToList();
            }
            //using (var context = new SysproCompanyTEntities())
            //{
            //    var lst = context.vwPOLists.ToListAsync();
                
            //    foreach (var item in lst.Result)
            //    {
            //        if (item.PurchaseOrder.TrimStart('0') == txtSrchPO.Text)
            //        {
            //            item.PurchaseOrder = item.PurchaseOrder.TrimStart('0');
            //            _poList.Add(item);
            //        }
            //    }
            //}
            return _poList;
        }

        private void srchPO_Click(object sender, EventArgs e)
        {
            using (frmShipmentBrowse frm =new frmShipmentBrowse())
            {
                frm.ShowDialog();
                txtSrchPO.Text = frm._shipment;
                dataload();
                POgridControl.DataSource = _poList;
                POgridView.RefreshData();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<POLine> oLines = new List<POLine>();
            using (var context = new AussieTravellerEntities())
            {

                var result = from s in context.POLines.ToList()
                             where s.Shipment == txtSrchPO.Text
                             select s;

                oLines = result.ToList();
                var porLst = context.Shipments.ToList();
                foreach (var por in porLst.ToList())
                {
                    if(por.ShipmentNumber==txtSrchPO.Text)
                    {
                        por.DueDate= DateTime.Parse(NewDateEdit.Text.ToString());
                        context.SaveChanges();
                    }
                }
                }

            using (var context = new SysproCompanyTEntities())
            {
                

                var porLst = context.PorMasterDetails.ToList();             
               
                foreach (var por in porLst)
                {
                    foreach (var item in oLines)
                    {
                        if (por.PurchaseOrder.TrimStart('0') == item.PONumber && por.Line==Convert.ToDecimal(item.Line))
                        {
                            por.MLatestDueDate = DateTime.Parse(NewDateEdit.Text.ToString());
                            context.SaveChanges();
                        }
                    }
                }
               
                dataload();
                POgridControl.DataSource = _poList;
                POgridView.RefreshData();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void NewDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dataload();
            POgridControl.DataSource = _poList;
            POgridView.RefreshData();
        }

        private void txtSrchPO_TextChanged(object sender, EventArgs e)
        {
            dataload();
            POgridControl.DataSource = _poList;
            POgridView.RefreshData();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmShipment frmship = new frmShipment();
            //frmship.Show();
        }

        private void btnclose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnExcelExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppUtility.DevEx.GridUtility.ExportToXLSX(ref POgridView, "Shipment");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    this.Close();
        //}
    }
}
