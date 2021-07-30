
namespace POScreen
{
    partial class FrmPOBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPOBrowse));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSelect = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.POgridControl = new DevExpress.XtraGrid.GridControl();
            this.POgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(903, 141);
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
            this.POgridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.POgridControl.Size = new System.Drawing.Size(903, 380);
            this.POgridControl.TabIndex = 2;
            this.POgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.POgridView});
            this.POgridControl.DataSourceChanged += new System.EventHandler(this.POgridControl_DataSourceChanged);
            this.POgridControl.Click += new System.EventHandler(this.POgridControl_Click);
            // 
            // POgridView
            // 
            this.POgridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQty,
            this.colLine,
            this.colPoNo,
            this.colSupplier,
            this.colSupplierName,
            this.colCurrency,
            this.colMLastReceiptDate,
            this.colMLatestDueDate,
            this.colMCompleteFlag,
            this.colMStockCodeDesc,
            this.colMStockCode,
            this.gridColumn1});
            this.POgridView.GridControl = this.POgridControl;
            this.POgridView.GroupCount = 1;
            this.POgridView.GroupFormat = "[#image]{1} {2}";
            this.POgridView.GroupPanelText = "test";
            this.POgridView.Name = "POgridView";
            this.POgridView.OptionsFind.AlwaysVisible = true;
            this.POgridView.OptionsFind.FindFilterColumns = "PurchaseOrder";
            this.POgridView.OptionsSelection.MultiSelect = true;
            this.POgridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.POgridView.OptionsView.ShowAutoFilterRow = true;
            this.POgridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPoNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.POgridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.POgridView_FocusedRowChanged);
            this.POgridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.POgridView_CellValueChanged);
            // 
            // colQty
            // 
            this.colQty.Caption = "Quantity";
            this.colQty.DisplayFormat.FormatString = "{0:n0}";
            this.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQty.FieldName = "MOrderQty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 2;
            // 
            // colLine
            // 
            this.colLine.Caption = "Line";
            this.colLine.FieldName = "Line";
            this.colLine.Name = "colLine";
            this.colLine.Visible = true;
            this.colLine.VisibleIndex = 1;
            // 
            // colPoNo
            // 
            this.colPoNo.FieldName = "PurchaseOrder";
            this.colPoNo.Name = "colPoNo";
            this.colPoNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colPoNo.Visible = true;
            this.colPoNo.VisibleIndex = 9;
            // 
            // colSupplier
            // 
            this.colSupplier.Caption = "Supplier";
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 6;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Supplier Name";
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 7;
            // 
            // colCurrency
            // 
            this.colCurrency.Caption = "Currency";
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            // 
            // colMLastReceiptDate
            // 
            this.colMLastReceiptDate.Caption = " Receipt";
            this.colMLastReceiptDate.FieldName = "MLastReceiptDat";
            this.colMLastReceiptDate.Name = "colMLastReceiptDate";
            this.colMLastReceiptDate.Visible = true;
            this.colMLastReceiptDate.VisibleIndex = 8;
            // 
            // colMLatestDueDate
            // 
            this.colMLatestDueDate.Caption = "DueDate";
            this.colMLatestDueDate.FieldName = "MLatestDueDate";
            this.colMLatestDueDate.Name = "colMLatestDueDate";
            this.colMLatestDueDate.Visible = true;
            this.colMLatestDueDate.VisibleIndex = 3;
            // 
            // colMCompleteFlag
            // 
            this.colMCompleteFlag.Caption = "MCompleteFlag";
            this.colMCompleteFlag.FieldName = "MCompleteFlag";
            this.colMCompleteFlag.Name = "colMCompleteFlag";
            // 
            // colMStockCodeDesc
            // 
            this.colMStockCodeDesc.Caption = "Stock Code Decsription";
            this.colMStockCodeDesc.FieldName = "MStockDes";
            this.colMStockCodeDesc.Name = "colMStockCodeDesc";
            this.colMStockCodeDesc.Visible = true;
            this.colMStockCodeDesc.VisibleIndex = 4;
            // 
            // colMStockCode
            // 
            this.colMStockCode.Caption = "StockCode";
            this.colMStockCode.FieldName = "MStockCode";
            this.colMStockCode.Name = "colMStockCode";
            this.colMStockCode.Visible = true;
            this.colMStockCode.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "pocheck";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.FieldName = "pocheck";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // FrmPOBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 521);
            this.Controls.Add(this.POgridControl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmPOBrowse";
            this.Text = "FrmBrowse";
            this.Load += new System.EventHandler(this.FrmBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
    }
}