using POScreen.DAL;
using System;
using System.Windows.Forms;
using POScreen.DAL.DTO;
using System.Data.Entity;
using System.Collections.Generic;

namespace POScreen
{
    public partial class Form1 : Form
    {

        List<vwPOList> _poList = new List<vwPOList>();
        public Form1()
        {
            InitializeComponent();
        }
        private string logtypes;
        public Form1(string logtype)
        {
            InitializeComponent();
            logtypes = logtype;
        }
        private void POgridControl_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (logtypes != "Admin")
                simpleButton1.Enabled = false;
        }

        private List<vwPOList> dataload()
        {
            _poList = new List<vwPOList>();
            using (var context = new SysproCompanyTEntities())
            {
                var lst = context.vwPOLists.ToListAsync();
                
                foreach (var item in lst.Result)
                {
                    if (item.PurchaseOrder.TrimStart('0') == txtSrchPO.Text)
                    {
                        item.PurchaseOrder = item.PurchaseOrder.TrimStart('0');
                        _poList.Add(item);
                    }
                }
            }
            return _poList;
        }

        private void srchPO_Click(object sender, EventArgs e)
        {
            using (FrmBrowse frm =new FrmBrowse())
            {
                frm.ShowDialog();
                txtSrchPO.Text = frm._POOrder;
                dataload();
                POgridControl.DataSource = _poList;
                POgridView.RefreshData();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            using (var context = new SysproCompanyTEntities())
            {
                

                var porLst = context.PorMasterDetails.ToListAsync();             
               
                foreach (var por in porLst.Result)
                {
                    if (por.PurchaseOrder.TrimStart('0') == txtSrchPO.Text)
                    {
                        por.MLatestDueDate = DateTime.Parse(NewDateEdit.Text.ToString());
                        context.SaveChangesAsync();
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

        //private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    this.Close();
        //}
    }
}
