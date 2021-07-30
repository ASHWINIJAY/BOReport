using POScreen.DAL;
using System;
using System.Windows.Forms;
using POScreen.DAL.DTO;
using System.Data.Entity;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Linq;

namespace POScreen
{
    public partial class frmShipmentBrowse : Form
    {
        public string _shipment;
        public frmShipmentBrowse()
        {
            InitializeComponent();
        }

        private void FrmBrowse_Load(object sender, EventArgs e)
        {
            // List<vwPOList> poLst = new List<vwPOList>();
            using (var context = new AussieTravellerEntities())
            {

                var lst = context.Shipments.ToList();

                POgridControl.DataSource = lst;
                    POgridView.RefreshData();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Shipment vw = new Shipment ();
            int idx = POgridView.FocusedRowHandle;
            vw = (Shipment )POgridControl.DefaultView.GetRow(idx);
            _shipment = vw.ShipmentNumber ;
            this.Close();
        }

        private void POgridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
         
        }
    }
}
