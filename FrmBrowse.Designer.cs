
namespace POScreen
{
    partial class FrmBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrowse));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSelect = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.POgridControl = new DevExpress.XtraGrid.GridControl();
            this.POgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMLastReceiptDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMLatestDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMCompleteFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMStockCodeDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMStockCode = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.ribbonControl1.Size = new System.Drawing.Size(800, 141);
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
            this.POgridControl.Location = new System.Drawing.Point(0, 136);
            this.POgridControl.MainView = this.POgridView;
            this.POgridControl.MenuManager = this.ribbonControl1;
            this.POgridControl.Name = "POgridControl";
            this.POgridControl.Size = new System.Drawing.Size(800, 256);
            this.POgridControl.TabIndex = 2;
            this.POgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.POgridView});
            // 
            // POgridView
            // 
            this.POgridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLine,
            this.colPoNo,
            this.colSupplier,
            this.colSupplierName,
            this.colCurrency,
            this.colMLastReceiptDate,
            this.colMLatestDueDate,
            this.colMCompleteFlag,
            this.colMStockCodeDesc,
            this.colMStockCode});
            this.POgridView.GridControl = this.POgridControl;
            this.POgridView.Name = "POgridView";
            this.POgridView.OptionsView.ShowAutoFilterRow = true;
            this.POgridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.POgridView_FocusedRowChanged);
            // 
            // colLine
            // 
            this.colLine.Caption = "Line";
            this.colLine.FieldName = "Line";
            this.colLine.Name = "colLine";
            // 
            // colPoNo
            // 
            this.colPoNo.Caption = "PO Number";
            this.colPoNo.FieldName = "PurchaseOrder";
            this.colPoNo.Name = "colPoNo";
            this.colPoNo.Visible = true;
            this.colPoNo.VisibleIndex = 8;
            // 
            // colSupplier
            // 
            this.colSupplier.Caption = "Supplier";
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 0;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Supplier Name";
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 1;
            // 
            // colCurrency
            // 
            this.colCurrency.Caption = "Currency";
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 2;
            // 
            // colMLastReceiptDate
            // 
            this.colMLastReceiptDate.Caption = "M Last Receipt Date";
            this.colMLastReceiptDate.FieldName = "MLastReceiptDat";
            this.colMLastReceiptDate.Name = "colMLastReceiptDate";
            this.colMLastReceiptDate.Visible = true;
            this.colMLastReceiptDate.VisibleIndex = 3;
            // 
            // colMLatestDueDate
            // 
            this.colMLatestDueDate.Caption = "MLatestDueDate";
            this.colMLatestDueDate.FieldName = "MLatestDueDate";
            this.colMLatestDueDate.Name = "colMLatestDueDate";
            this.colMLatestDueDate.Visible = true;
            this.colMLatestDueDate.VisibleIndex = 4;
            // 
            // colMCompleteFlag
            // 
            this.colMCompleteFlag.Caption = "MCompleteFlag";
            this.colMCompleteFlag.FieldName = "MCompleteFlag";
            this.colMCompleteFlag.Name = "colMCompleteFlag";
            this.colMCompleteFlag.Visible = true;
            this.colMCompleteFlag.VisibleIndex = 5;
            // 
            // colMStockCodeDesc
            // 
            this.colMStockCodeDesc.Caption = "M Stock Code Decsription";
            this.colMStockCodeDesc.FieldName = "MStockDes";
            this.colMStockCodeDesc.Name = "colMStockCodeDesc";
            this.colMStockCodeDesc.Visible = true;
            this.colMStockCodeDesc.VisibleIndex = 6;
            // 
            // colMStockCode
            // 
            this.colMStockCode.Caption = "MStockCode";
            this.colMStockCode.FieldName = "MStockCode";
            this.colMStockCode.Name = "colMStockCode";
            this.colMStockCode.Visible = true;
            this.colMStockCode.VisibleIndex = 7;
            // 
            // FrmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.POgridControl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmBrowse";
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
        private DevExpress.XtraGrid.Columns.GridColumn colLine;
        private DevExpress.XtraGrid.Columns.GridColumn colPoNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colMLastReceiptDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMLatestDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMCompleteFlag;
        private DevExpress.XtraGrid.Columns.GridColumn colMStockCodeDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colMStockCode;
    }
}