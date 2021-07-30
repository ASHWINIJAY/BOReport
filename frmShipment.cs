using DevExpress.XtraBars;
using DevExpress.XtraPrinting;
using POScreen.DAL;
using POScreen.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POScreen
{
    public partial class frmShipment : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<ApSupplier> lstSup = new List<ApSupplier>();
        private string logtypes;
        public frmShipment()
        {
            InitializeComponent();
        }
        public frmShipment(string logtype)
        {
            InitializeComponent();
            logtypes = logtype;
        }

        private void load()
        {
            CmbSupplierCode.Items.Clear();
           // List<vwPOList> poLst = new List<vwPOList>();
            using (SysproCompanyTEntities db = new SysproCompanyTEntities())
            {
                var lst = db.ApSuppliers;
               
                lstSup = lst.ToList();
                //string prev = "";
                foreach (var item in lst)
                {

                    CmbSupplierCode.Items.Add(item.Supplier);


                    }
                }
               // CmbSupplierCode.DataSource = poLst;
               // CmbSupplierCode.RefreshData();
            }

        private void loadDeliveryLocation()
        {
            CmbDeliveryLocation.Items.Clear();
            // List<vwPOList> poLst = new List<vwPOList>();
            using (AussieTravellerEntities db = new AussieTravellerEntities())
            {
                var lst = db.DeliveryLocs;

               // lstSup = lst.ToList();
                //string prev = "";
                foreach (var item in lst)
                {

                    CmbDeliveryLocation.Items.Add(item.DeliveryLocation);


                }
            }
            // CmbSupplierCode.DataSource = poLst;
            // CmbSupplierCode.RefreshData();
        }

        private void loadShipmentType()
        {
            CmbshipType.Items.Clear();
            // List<vwPOList> poLst = new List<vwPOList>();
            using (AussieTravellerEntities db = new AussieTravellerEntities())
            {
                var lst = db.ShipTypes;

             //   lstSup = lst.ToList();
                //string prev = "";
                foreach (var item in lst)
                {

                    CmbshipType.Items.Add(item.ShipmentType.TrimStart('0'));


                }
            }
            // CmbSupplierCode.DataSource = poLst;
            // CmbSupplierCode.RefreshData();
        }

        private void frmShipment_Load(object sender, EventArgs e)
        {
            if (logtypes != "Admin")
            {
                btnConfirm.Enabled = false;
                barButtonItem2.Enabled = false;
                btnPOLink.Enabled = false;
            }
               
            load();
            loadShipmentType();
            loadDeliveryLocation();
        }

        //private void CmbSupplierCode_SelectedIndexChanged(object sender, EventArgs e)
        //{
           
        //}
        List<POLine> retPO = new List<POLine>();
      

        private void BindGrid(List<POLine> retvalue)
        {
            if (retvalue == null || retvalue.Count==0)
            {
                objpor = new List<vwPOBrowseList>();
                gridControl1.DataSource = objpor;

                gridView1.RefreshData();
                return;
            }

            using (SysproCompanyTEntities db = new SysproCompanyTEntities())
            {
                var lst = db.vwPOBrowseLists.ToList();


                foreach (var item in lst.ToList())
                {
                    item.PurchaseOrder = item.PurchaseOrder.TrimStart('0');
                }


                objpor = new List<vwPOBrowseList>();

                foreach (var item1 in retvalue )
                    {
                       
                        var result2 = from s1 in lst.ToList()
                                      where s1.PurchaseOrder == item1.PONumber && s1.Line == Convert.ToDecimal(item1.Line)
                                      select s1;
                    objpor.Add(result2.FirstOrDefault());
                    }
                
                    gridControl1.DataSource = objpor;

                gridView1.RefreshData();
            }
           
        }
        List<vwPOBrowseList> objpor = new List<vwPOBrowseList>();
        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)       
        {
            this.Close();
        }
        private void save()
        {
            if (AppUtility.UI.Notification.ConfirmMsg("Are you sure confirm to save the data") != true)
                return;
            using (var context = new AussieTravellerEntities())
            {





                var porLst = context.Shipments.ToList();
                var result = from s in context.Shipments.ToList()
                             where s.ShipmentNumber.ToUpper() == txtShipNumber.Text.ToUpper()
                             select s;


                if (result.Count() > 0)
                {


                    foreach (var shipment in porLst)
                    {
                        if (shipment.ShipmentNumber.ToUpper() == txtShipNumber.Text.ToUpper())
                        {
                            shipment.ShipmentNumber = txtShipNumber.Text;
                            shipment.DueDate = Convert.ToDateTime(txtduedate.Text);


                            shipment.SupplierCode = CmbSupplierCode.Text;
                            shipment.SupplierName = txtSupName.Text;

                            shipment.ContainerNumber = txtContainerName.Text;
                            shipment.ShipmentType = CmbshipType.SelectedItem.ToString();
                            shipment.DeliveryLocation = CmbDeliveryLocation.SelectedItem.ToString();
                            context.SaveChanges();
                            var result1 = from s in context.POLines.ToList()
                                          where s.Shipment.ToUpper() == txtShipNumber.Text.ToUpper()
                                          select s;
                            foreach (var item in result1.ToList())
                            {
                                context.POLines.Remove(item);
                                context.SaveChanges();

                            }
                            using (var contextsyspro = new SysproCompanyTEntities())
                            {
                                var result2 = from s in contextsyspro.PorMasterDetail_.ToList()
                                              where s.Shipment.ToUpper() == txtShipNumber.Text.ToUpper()
                                              select s;
                                foreach (var item in result2.ToList())
                                {
                                    contextsyspro.PorMasterDetail_.Remove(item);
                                    contextsyspro.SaveChanges();

                                }
                            }
                            using (var contextsyspro = new SysproCompanyTEntities())
                            {
                                foreach (var item1 in retPO)
                                {
                                    POLine pOLine = new POLine();
                                    pOLine.Shipment = txtShipNumber.Text;

                                    pOLine.PONumber = item1.PONumber;
                                    pOLine.Line = item1.Line;
                                    context.POLines.Add(pOLine);
                                    context.SaveChanges();
                                    PorMasterDetail_ objporMaster = new PorMasterDetail_();
                                    var result2 = from s in contextsyspro.PorMasterDetails.ToList()
                                                  where s.PurchaseOrder.EndsWith(item1.PONumber)
                                                  select s;
                                    objporMaster.Shipment = txtShipNumber.Text;
                                    objporMaster.PurchaseOrder = result2.FirstOrDefault().PurchaseOrder;
                                    objporMaster.Line = Convert.ToDecimal(item1.Line);
                                    contextsyspro.PorMasterDetail_.Add(objporMaster);
                                    contextsyspro.SaveChanges();
                                }
                            }


                            AppUtility.UI.Notification.InformationMsg("Successfully Updated");



                        }

                    }
                }
                else
                {


                    Shipment shipment = new Shipment();
                    if (txtShipNumber.Text == "")
                    {
                        MessageBox.Show("Enter Shipment Number ");
                        return;
                    }
                    shipment.ShipmentNumber = txtShipNumber.Text;
                    if (txtduedate.Text == "")

                    {
                        MessageBox.Show("Select Due Date ");
                        return;
                    }
                    shipment.DueDate = Convert.ToDateTime((txtduedate.Text.ToString())).Date;


                    shipment.SupplierCode = CmbSupplierCode.Text;
                    shipment.SupplierName = txtSupName.Text;
                    if (txtContainerName.Text == "")
                    {
                        MessageBox.Show("Enter Container Name");
                        return;
                    }
                    shipment.ContainerNumber = txtContainerName.Text;
                    shipment.ShipmentType = CmbshipType.SelectedItem.ToString();
                    shipment.DeliveryLocation = CmbDeliveryLocation.SelectedItem.ToString();
                    context.Shipments.Add(shipment);

                    context.SaveChanges();
                    

                    if (retPO != null || retPO.Count != 0)
                    {
                        using (var contextsyspro = new SysproCompanyTEntities())
                        {

                            foreach (var item1 in retPO)
                            {
                                PorMasterDetail_ objporMaster = new PorMasterDetail_();
                                POLine pOLine = new POLine();
                                pOLine.Shipment = txtShipNumber.Text;
                               
                                pOLine.PONumber = item1.PONumber;
                                pOLine.Line = item1.Line;
                                context.POLines.Add(pOLine);
                                context.SaveChanges();
                                var result2 = from s in contextsyspro.PorMasterDetails.ToList()
                                              where s.PurchaseOrder.EndsWith(item1.PONumber)
                                              select s;
                                objporMaster.Shipment = txtShipNumber.Text;
                                objporMaster.PurchaseOrder = result2.FirstOrDefault().PurchaseOrder;
                                objporMaster.Line = Convert.ToDecimal(item1.Line);
                                contextsyspro.PorMasterDetail_.Add(objporMaster);
                                contextsyspro.SaveChanges();
                            }
                        }
                    }


                    AppUtility.UI.Notification.InformationMsg("Successfully Confirmed");

                }
            }

            List<POLine> oLines = new List<POLine>();
            using (var context = new AussieTravellerEntities())
            {

                var result = from s in context.POLines.ToList()
                             where s.Shipment == txtShipNumber.Text
                             select s;

                oLines = result.ToList();
            }

            using (var context = new SysproCompanyTEntities())
            {


                var porLst = context.PorMasterDetails.ToList();

                foreach (var por in porLst.ToList())
                {
                    foreach (var item in oLines)
                    {
                        if (por.PurchaseOrder.TrimStart('0') == item.PONumber && por.Line == Convert.ToDecimal(item.Line))
                        {
                            por.MLatestDueDate = DateTime.Parse(txtduedate.Text.ToString());
                            context.SaveChanges();
                        }
                    }
                }
                getdetails();

            }

        }
        private void btnConfirm_ItemClick(object sender, ItemClickEventArgs e)
        {
            save();
            }

        private void txtShipNumber_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void getdetails()
        {
            using (var context = new AussieTravellerEntities())
            {

                var result = from s in context.Shipments.ToList()
                             where s.ShipmentNumber.ToUpper() == txtShipNumber.Text.ToUpper()
                             select s;
                if (result.Count() > 0)
                {
                    txtduedate.Text = Convert.ToDateTime(result.FirstOrDefault().DueDate.ToString()).Date.ToString ("yyyy/MM/dd") ;
                    CmbSupplierCode .SelectedItem =result.FirstOrDefault().SupplierCode .ToString();
                    txtSupName .Text = result.FirstOrDefault().SupplierName .ToString();
                    CmbshipType .SelectedItem = result.FirstOrDefault().ShipmentType .ToString();
                    txtContainerName .Text = result.FirstOrDefault().ContainerNumber .ToString();
                   CmbDeliveryLocation .SelectedItem = result.FirstOrDefault().DeliveryLocation .ToString();
                  var  retPO1 = from s in context.POLines.ToList()
                             where s.Shipment.ToUpper() == txtShipNumber.Text.ToUpper()
                             select s;
                    retPO = retPO1.ToList();
                    BindGrid(retPO1.ToList());
                    //  MessageBox.Show("ShipmentNumber (" + txtShipNumber.Text + ")  already exists. ");
                    //  txtShipNumber.Focus();
                    // return;

                }
                else
                {
                    retPO = new List<POLine>();
                    txtduedate.Text = "";
                    txtSupName.Text = "";
                    txtContainerName.Text = "";
                    objpor = new List<vwPOBrowseList>();
                    gridControl1.DataSource = objpor;

                    gridView1.RefreshData();
                    
                    load();
                    loadShipmentType();
                    loadDeliveryLocation();
                    CmbDeliveryLocation.Items.Add("");
                    CmbSupplierCode.Items.Add("");
                    CmbshipType.Items.Add("");
                    CmbSupplierCode.SelectedIndex = CmbSupplierCode.Items.Count-1;
                    CmbshipType.SelectedIndex = CmbshipType.Items.Count - 1;
                    CmbDeliveryLocation.SelectedIndex = CmbDeliveryLocation.Items.Count - 1;

                }
            }
        }

        private void btnBrowse_EditValueChanged(object sender, EventArgs e)
        {
           
        }

         

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try {
               
                //AppUtility.DevEx.GridUtility.ExportToXLSX(ref gridView1 , "Shipment");
                List<POList> pOLists = new List<POList>();
                foreach (var item in objpor)
                {
                    POList obj = new POList()
                    {
                        ShipmentNumber = txtShipNumber.Text,
                        DueDate = Convert.ToDateTime(txtduedate.Text).Date,
                        SupplierCode = CmbSupplierCode.SelectedItem.ToString(),
                        SupplierName = txtSupName.Text,
                        ShipmentType = CmbshipType.SelectedItem.ToString(),
                        ContainerNumber = txtContainerName.Text,
                        DeliveryLocation = CmbDeliveryLocation.SelectedItem.ToString(),
                        PurchaseOrderNo = Convert.ToInt32(item.PurchaseOrder),
                        Line = Convert.ToDecimal(item.Line),
                        MStockCode = item.MStockCode,
                        MStockDes = item.MStockDes,
                        MOrderQty = item.MOrderQty,
                        MWarehouse = item.MWarehouse

                    };
                    pOLists.Add(obj);
                }
                rptShipment rpt = new rptShipment(pOLists);
                rpt.CreateDocument();

                rpt.PrintingSystem.ContinuousPageNumbering = true;
                DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(rpt) { AutoShowParametersPanel = false };
                XlsxExportOptions xlsxExportOptions = new XlsxExportOptions() { ExportMode = XlsxExportMode.SingleFile, ShowGridLines = true, FitToPrintedPageHeight = true };

                // Specify the path for the exported XLSX file.
                // 
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string xlsxExportFile = fbd.SelectedPath + @"\Shipment Report_" + DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.ToString("hhmmss") + ".xlsx";


                        rpt.ExportToXlsx(xlsxExportFile, xlsxExportOptions);
                        AppUtility.UI.Notification.InformationMsg("File Downloaded Sucessfully...");
                    }
                }
               
               
            }
            catch
            {
                AppUtility.UI.Notification.InformationMsg("File is already open ,please close and download again");
            }
        }

        private void txtShipNumber_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtShipNumber_LocationChanged(object sender, EventArgs e)
        {
           
        }

        private void txtShipNumber_EditValueChanged(object sender, EventArgs e)
        {
            getdetails();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                vwPOBrowseList vw = new vwPOBrowseList();
                List<POLine> lstmas = new List<POLine>();
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    //  int idx = POgridView.FocusedRowHandle;
                    //  var cellValue = POgridView.GetDataRowHandleByGroupRowHandle(i, "pocheck");
                    //GridColumn myColumn = gridView1.Columns["forignkey"];
                    //var a= POgridView.GetFocusedRowCellValue("pocheck");
                    if (gridView1.IsRowSelected(i))
                    {

                        vw = (vwPOBrowseList)gridControl1.DefaultView.GetRow(i);
                        POLine objPoline = new POLine();
                        objPoline.PONumber = vw.PurchaseOrder;
                        objPoline.Line = vw.Line.ToString();

                        lstmas.Add(objPoline);
                        // code when checked
                    }
                    else
                    {
                        // code when not checked
                    }
                }

                //string po = gridView1.GetFocusedRowCellValue(gridColumn1).ToString();

                //string line = gridView1.GetFocusedRowCellValue(gridColumn8).ToString();
                //var  retPO2 = retPO;
                // retPO = new List<POLine>();
                // retPO = result.ToList();
                foreach (var pol in lstmas)
                {
                    for(int i=0;i<retPO.Count;i++)
                    { 

                        if (retPO[i].PONumber == pol.PONumber && retPO[i].Line == pol.Line && retPO[i].Shipment.ToUpper() == txtShipNumber.Text.ToUpper())
                        {
                            retPO.RemoveAt(i);
                        }


                    }
                }
                BindGrid(retPO);
                save();
            }
            catch
            {

            }

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //AppUtility.DevEx.GridUtility.ExportToXLSX(ref gridView1 , "Shipment");
                List<POList> pOLists = new List<POList>();
                foreach (var item in objpor)
                {
                    POList obj = new POList()
                    {
                        ShipmentNumber = txtShipNumber.Text,
                        DueDate = Convert.ToDateTime(txtduedate.Text).Date,
                        SupplierCode = CmbSupplierCode.SelectedItem.ToString(),
                        SupplierName = txtSupName.Text,
                        ShipmentType = CmbshipType.SelectedItem.ToString(),
                        ContainerNumber = txtContainerName.Text,
                        DeliveryLocation = CmbDeliveryLocation.SelectedItem.ToString(),
                        PurchaseOrderNo = Convert.ToInt32(item.PurchaseOrder),
                        Line = Convert.ToDecimal(item.Line),
                        MStockCode = item.MStockCode,
                       
                        MStockDes = item.MStockDes,
                        MOrderQty = item.MOrderQty,
                       MWarehouse = item.MWarehouse

                    };
                    pOLists.Add(obj);
                }
                rptShipment rpt = new rptShipment(pOLists);
                rpt.CreateDocument();

                rpt.PrintingSystem.ContinuousPageNumbering = true;
                DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(rpt) { AutoShowParametersPanel = false };
                PdfExportOptions xlsxExportOptions = new PdfExportOptions();

                // Specify the path for the exported XLSX file.  
               
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string xlsxExportFile = fbd.SelectedPath + @"\Shipment Report_" + DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.ToString("hhmmss") + ".pdf";


                        //string xlsxExportFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\Shipment Report_" + DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.ToString("hhmmss") + ".pdf";

                        // Export the report.
                        rpt.ExportToPdf(xlsxExportFile, xlsxExportOptions);
                        AppUtility.UI.Notification.InformationMsg("File Downloaded Sucessfully...");
                    }
                }
            }
            catch
            {
                AppUtility.UI.Notification.InformationMsg("File is already open ,please close and download again");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (frmShipmentBrowse frm = new frmShipmentBrowse())
            {
                frm.ShowDialog();
                txtShipNumber.Text = frm._shipment;
                //txtduedate.Text = frm._shipment;
                //txtSupName.Text = frm._shipment;
                //CmbSupplierCode.Text = frm._shipment;
                getdetails();
            }
        
    }

        private void btnPOLink_Click(object sender, EventArgs e)
        {
            

                FrmPOBrowse frmPO = new FrmPOBrowse();
                frmPO.ShowDialog();
                // retPO = new List<POLine>();
                var ret1 = frmPO.lstPoline;
                foreach (var item in ret1)
                {

                    using (AussieTravellerEntities db = new AussieTravellerEntities())
                    {
                        var lst = db.POLines.ToList();
                        var result2 = from s1 in lst.ToList()
                                      where s1.PONumber == item.PONumber && s1.Line == (item.Line)
                                      select s1;
                        if (result2.ToList().Count == 0)
                            retPO.Add(item);
                        else
                        {
                            MessageBox.Show("The Po Number: " + item.PONumber + " Line Number: " + item.Line + " is  linked in the Shipment Number: " + result2.FirstOrDefault().Shipment);
                        }
                    }
                }
                BindGrid(retPO);
            }

        private void CmbSupplierCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var result = from s in lstSup
                             where s.Supplier == CmbSupplierCode.SelectedItem.ToString()
                             select s;
                if (result.ToList().Count > 0)
                    txtSupName.Text = result.FirstOrDefault().SupplierName;
            }
            catch
            {
                txtSupName.Text = "";
            }
        }

        private void txtShipNumber_EditValueChanged_1(object sender, EventArgs e)
        {
                getdetails();


        }

        private void CmbSupplierCode_TextChanged(object sender, EventArgs e)
        {
           
            //var employees = from emps in sqlObj.tblEmployees
            //                where emps.EmployeeName.EndsWith("ms")
        }

        private void CmbSupplierCode_Enter(object sender, EventArgs e)
        {
           
        }

        private void CmbSupplierCode_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CmbSupplierCode_Leave(object sender, EventArgs e)
        {
            try
            {
                var result = from s in lstSup
                             where s.Supplier.EndsWith(CmbSupplierCode.Text)
                             select s;
                if (result.ToList().Count > 0)
                {
                    txtSupName.Text = result.FirstOrDefault().SupplierName;
                    CmbSupplierCode.Text = result.FirstOrDefault().Supplier;
                }
                else
                {
                    txtSupName.Text = "";
                    CmbSupplierCode.Text = "";
                }
            }
            catch
            {
                txtSupName.Text = "";
            }
        }
    }
    }
