using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using POScreen.DAL.DTO;
namespace POScreen
{
    public partial class rptShipment : DevExpress.XtraReports.UI.XtraReport
    {
        private List<POList> pOLists;

        public rptShipment()
        {
            InitializeComponent();
        }

        public rptShipment(List<POList> data)
        {
            InitializeComponent();
            this.DataSource = data;
        }

        private void rptShipment_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
