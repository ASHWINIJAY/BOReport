
namespace POScreen
{
    partial class frmBOReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repStart = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repEnd = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.vwFetchBOReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesperson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqShipDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMStockCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMStockDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOrderQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMShipQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMBackOrderQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOrderUom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyOnHand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullfillBO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFetchBOReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Red;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barEditItem1,
            this.barEditItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repStart,
            this.repEnd});
            this.ribbon.Size = new System.Drawing.Size(1364, 200);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Refresh";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = global::POScreen.Properties.Resources.refreshallpivottable;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.SvgImage = global::POScreen.Properties.Resources.clearheaderandfooter;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Export To Excel";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.SvgImage = global::POScreen.Properties.Resources.export;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Stock Report";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.SvgImage = global::POScreen.Properties.Resources.insertlistbox;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Start Date";
            this.barEditItem1.Edit = this.repStart;
            this.barEditItem1.EditWidth = 100;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repStart
            // 
            this.repStart.AutoHeight = false;
            this.repStart.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStart.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStart.Name = "repStart";
            this.repStart.EditValueChanged += new System.EventHandler(this.repStart_EditValueChanged);
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "End Date  ";
            this.barEditItem2.Edit = this.repEnd;
            this.barEditItem2.EditWidth = 100;
            this.barEditItem2.Id = 6;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repEnd
            // 
            this.repEnd.AutoHeight = false;
            this.repEnd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEnd.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEnd.Name = "repEnd";
            this.repEnd.EditValueChanged += new System.EventHandler(this.repEnd_EditValueChanged);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Filters";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 680);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1364, 41);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesOrder,
            this.colSalesperson,
            this.colOrderDate,
            this.colReqShipDate,
            this.colBranch,
            this.colWarehouse,
            this.colCustomerName,
            this.colCustomer,
            this.colMStockCode,
            this.colMStockDes,
            this.colMWarehouse,
            this.colMOrderQty,
            this.colMShipQty,
            this.colMBackOrderQty,
            this.colMOrderUom,
            this.colQtyOnHand,
            this.colFullfillBO,
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colSalesOrder
            // 
            this.colSalesOrder.FieldName = "SalesOrder";
            this.colSalesOrder.MinWidth = 30;
            this.colSalesOrder.Name = "colSalesOrder";
            this.colSalesOrder.Visible = true;
            this.colSalesOrder.VisibleIndex = 0;
            this.colSalesOrder.Width = 112;
            // 
            // colSalesperson
            // 
            this.colSalesperson.FieldName = "Salesperson";
            this.colSalesperson.MinWidth = 30;
            this.colSalesperson.Name = "colSalesperson";
            this.colSalesperson.Visible = true;
            this.colSalesperson.VisibleIndex = 5;
            this.colSalesperson.Width = 112;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.MinWidth = 30;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 1;
            this.colOrderDate.Width = 112;
            // 
            // colReqShipDate
            // 
            this.colReqShipDate.FieldName = "ReqShipDate";
            this.colReqShipDate.MinWidth = 30;
            this.colReqShipDate.Name = "colReqShipDate";
            this.colReqShipDate.Visible = true;
            this.colReqShipDate.VisibleIndex = 2;
            this.colReqShipDate.Width = 112;
            // 
            // colBranch
            // 
            this.colBranch.FieldName = "Branch";
            this.colBranch.MinWidth = 30;
            this.colBranch.Name = "colBranch";
            this.colBranch.Visible = true;
            this.colBranch.VisibleIndex = 3;
            this.colBranch.Width = 112;
            // 
            // colWarehouse
            // 
            this.colWarehouse.FieldName = "Warehouse";
            this.colWarehouse.MinWidth = 30;
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.Visible = true;
            this.colWarehouse.VisibleIndex = 4;
            this.colWarehouse.Width = 112;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.MinWidth = 30;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 7;
            this.colCustomerName.Width = 112;
            // 
            // colCustomer
            // 
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.MinWidth = 30;
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 6;
            this.colCustomer.Width = 112;
            // 
            // colMStockCode
            // 
            this.colMStockCode.FieldName = "MStockCode";
            this.colMStockCode.MinWidth = 30;
            this.colMStockCode.Name = "colMStockCode";
            this.colMStockCode.Visible = true;
            this.colMStockCode.VisibleIndex = 8;
            this.colMStockCode.Width = 112;
            // 
            // colMStockDes
            // 
            this.colMStockDes.FieldName = "MStockDes";
            this.colMStockDes.MinWidth = 30;
            this.colMStockDes.Name = "colMStockDes";
            this.colMStockDes.Visible = true;
            this.colMStockDes.VisibleIndex = 9;
            this.colMStockDes.Width = 112;
            // 
            // colMWarehouse
            // 
            this.colMWarehouse.FieldName = "MWarehouse";
            this.colMWarehouse.MinWidth = 30;
            this.colMWarehouse.Name = "colMWarehouse";
            this.colMWarehouse.Visible = true;
            this.colMWarehouse.VisibleIndex = 10;
            this.colMWarehouse.Width = 112;
            // 
            // colMOrderQty
            // 
            this.colMOrderQty.FieldName = "MOrderQty";
            this.colMOrderQty.MinWidth = 30;
            this.colMOrderQty.Name = "colMOrderQty";
            this.colMOrderQty.Visible = true;
            this.colMOrderQty.VisibleIndex = 12;
            this.colMOrderQty.Width = 112;
            // 
            // colMShipQty
            // 
            this.colMShipQty.FieldName = "MShipQty";
            this.colMShipQty.MinWidth = 30;
            this.colMShipQty.Name = "colMShipQty";
            this.colMShipQty.Visible = true;
            this.colMShipQty.VisibleIndex = 13;
            this.colMShipQty.Width = 112;
            // 
            // colMBackOrderQty
            // 
            this.colMBackOrderQty.FieldName = "MBackOrderQty";
            this.colMBackOrderQty.MinWidth = 30;
            this.colMBackOrderQty.Name = "colMBackOrderQty";
            this.colMBackOrderQty.Visible = true;
            this.colMBackOrderQty.VisibleIndex = 14;
            this.colMBackOrderQty.Width = 112;
            // 
            // colMOrderUom
            // 
            this.colMOrderUom.FieldName = "MOrderUom";
            this.colMOrderUom.MinWidth = 30;
            this.colMOrderUom.Name = "colMOrderUom";
            this.colMOrderUom.Visible = true;
            this.colMOrderUom.VisibleIndex = 11;
            this.colMOrderUom.Width = 112;
            // 
            // colQtyOnHand
            // 
            this.colQtyOnHand.FieldName = "QtyOnHand";
            this.colQtyOnHand.MinWidth = 30;
            this.colQtyOnHand.Name = "colQtyOnHand";
            this.colQtyOnHand.Visible = true;
            this.colQtyOnHand.VisibleIndex = 15;
            this.colQtyOnHand.Width = 112;
            // 
            // colFullfillBO
            // 
            this.colFullfillBO.FieldName = "FullfillBO";
            this.colFullfillBO.MinWidth = 30;
            this.colFullfillBO.Name = "colFullfillBO";
            this.colFullfillBO.Visible = true;
            this.colFullfillBO.VisibleIndex = 16;
            this.colFullfillBO.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Order Status";
            this.gridColumn2.FieldName = "OrderStatus";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 17;
            this.gridColumn2.Width = 112;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Shipping Ins";
            this.gridColumn1.FieldName = "ShippingInstruction";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 18;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Production Status";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 19;
            this.gridColumn3.Width = 112;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Picked By";
            this.gridColumn4.FieldName = "PickedBy";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 20;
            this.gridColumn4.Width = 112;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Courier";
            this.gridColumn5.FieldName = "Courier";
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 21;
            this.gridColumn5.Width = 112;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "ConsNote";
            this.gridColumn6.FieldName = "ConNote";
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 22;
            this.gridColumn6.Width = 112;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vwFetchBOReportBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 200);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1364, 480);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // frmBOReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 721);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmBOReport";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "BO Report - Company Z";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBOReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFetchBOReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource vwFetchBOReportBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesperson;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReqShipDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBranch;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colMStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMStockDes;
        private DevExpress.XtraGrid.Columns.GridColumn colMWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colMOrderQty;
        private DevExpress.XtraGrid.Columns.GridColumn colMShipQty;
        private DevExpress.XtraGrid.Columns.GridColumn colMBackOrderQty;
        private DevExpress.XtraGrid.Columns.GridColumn colMOrderUom;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyOnHand;
        private DevExpress.XtraGrid.Columns.GridColumn colFullfillBO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repStart;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repEnd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}