
namespace POScreen
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnShipment = new DevExpress.XtraBars.BarButtonItem();
            this.btnDueDate = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.lblVersion = new DevExpress.XtraBars.BarStaticItem();
            this.lblUsername = new DevExpress.XtraBars.BarStaticItem();
            this.lblDepartment = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnShipment,
            this.btnDueDate,
            this.barButtonItem1,
            this.lblVersion,
            this.lblUsername,
            this.lblDepartment,
            this.barStaticItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(786, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnShipment
            // 
            this.btnShipment.Caption = "Shipment";
            this.btnShipment.Id = 1;
            this.btnShipment.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShipment.ImageOptions.SvgImage")));
            this.btnShipment.Name = "btnShipment";
            this.btnShipment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShipment_ItemClick);
            // 
            // btnDueDate
            // 
            this.btnDueDate.Caption = "DueDate";
            this.btnDueDate.Id = 2;
            this.btnDueDate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDueDate.ImageOptions.SvgImage")));
            this.btnDueDate.Name = "btnDueDate";
            this.btnDueDate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDueDate_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Shipment PO Update";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Main Menu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnShipment);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDueDate);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lblVersion);
            this.ribbonStatusBar.ItemLinks.Add(this.lblUsername);
            this.ribbonStatusBar.ItemLinks.Add(this.lblDepartment);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(786, 31);
            // 
            // lblVersion
            // 
            this.lblVersion.Caption = "App Version";
            this.lblVersion.Id = 4;
            this.lblVersion.Name = "lblVersion";
            // 
            // lblUsername
            // 
            this.lblUsername.Caption = "User Name";
            this.lblUsername.Id = 5;
            this.lblUsername.Name = "lblUsername";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Caption = "Department";
            this.lblDepartment.Id = 6;
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "Xtreme Business Synergy";
            this.barStaticItem1.Id = 7;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmHome";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnShipment;
        private DevExpress.XtraBars.BarButtonItem btnDueDate;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem lblVersion;
        private DevExpress.XtraBars.BarStaticItem lblUsername;
        private DevExpress.XtraBars.BarStaticItem lblDepartment;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}