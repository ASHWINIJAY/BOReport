
namespace POScreen
{
    partial class frmShipmentBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShipmentBrowse));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSelect = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.POgridControl = new DevExpress.XtraGrid.GridControl();
            this.POgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colShipmentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipmenttype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContainerNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POgridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnSelect,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(963, 141);
            // 
            // btnSelect
            // 
            this.btnSelect.Caption = "Select";
            this.btnSelect.Id = 1;
            this.btnSelect.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSelect.ImageOptions.SvgImage")));
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSelect_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "CLose";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "POBrowse";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSelect);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tools";
            // 
            // POgridControl
            // 
            this.POgridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POgridControl.Location = new System.Drawing.Point(0, 141);
            this.POgridControl.MainView = this.POgridView;
            this.POgridControl.MenuManager = this.ribbonControl1;
            this.POgridControl.Name = "POgridControl";
            this.POgridControl.Size = new System.Drawing.Size(963, 309);
            this.POgridControl.TabIndex = 2;
            this.POgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.POgridView});
            // 
            // POgridView
            // 
            this.POgridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShipmentNo,
            this.colDueDate,
            this.colSupplierCode,
            this.colSupplierName,
            this.colShipmenttype,
            this.colContainerNumber,
            this.colDeliveryLocation});
            this.POgridView.GridControl = this.POgridControl;
            this.POgridView.Name = "POgridView";
            this.POgridView.OptionsView.ShowAutoFilterRow = true;
            this.POgridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.POgridView_FocusedRowChanged);
            // 
            // colShipmentNo
            // 
            this.colShipmentNo.Caption = "Shipment Number";
            this.colShipmentNo.FieldName = "ShipmentNumber";
            this.colShipmentNo.Name = "colShipmentNo";
            this.colShipmentNo.Visible = true;
            this.colShipmentNo.VisibleIndex = 0;
            // 
            // colDueDate
            // 
            this.colDueDate.Caption = "Due Date";
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 1;
            // 
            // colSupplierCode
            // 
            this.colSupplierCode.Caption = "Supplier Code";
            this.colSupplierCode.FieldName = "SupplierCode";
            this.colSupplierCode.Name = "colSupplierCode";
            this.colSupplierCode.Visible = true;
            this.colSupplierCode.VisibleIndex = 2;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Supplier Name";
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 3;
            // 
            // colShipmenttype
            // 
            this.colShipmenttype.Caption = "Shipment Type";
            this.colShipmenttype.FieldName = "ShipmentType";
            this.colShipmenttype.Name = "colShipmenttype";
            this.colShipmenttype.Visible = true;
            this.colShipmenttype.VisibleIndex = 4;
            // 
            // colContainerNumber
            // 
            this.colContainerNumber.Caption = "Container Number";
            this.colContainerNumber.FieldName = "ContainerNumber";
            this.colContainerNumber.Name = "colContainerNumber";
            this.colContainerNumber.Visible = true;
            this.colContainerNumber.VisibleIndex = 5;
            // 
            // colDeliveryLocation
            // 
            this.colDeliveryLocation.Caption = "Delivery Location";
            this.colDeliveryLocation.FieldName = "DeliveryLocation";
            this.colDeliveryLocation.Name = "colDeliveryLocation";
            this.colDeliveryLocation.Visible = true;
            this.colDeliveryLocation.VisibleIndex = 6;
            // 
            // frmShipmentBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.POgridControl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmShipmentBrowse";
            this.Text = "FrmBrowse";
            this.Load += new System.EventHandler(this.FrmBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POgridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSelect;
        private DevExpress.XtraGrid.GridControl POgridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView POgridView;
        private DevExpress.XtraGrid.Columns.GridColumn colShipmentNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierCode;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colShipmenttype;
        private DevExpress.XtraGrid.Columns.GridColumn colContainerNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryLocation;
    }
}