namespace bartenderexpressReloaded
{
    partial class Form1
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
            this.DrinksNameBox = new DevExpress.XtraEditors.ListBoxControl();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource();
            this.bartenderExpressDataSet = new bartenderexpressReloaded.bartenderExpressDataSet();
            this.recipesTableAdapter = new bartenderexpressReloaded.bartenderExpressDataSetTableAdapters.recipesTableAdapter();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.TheBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.DrinksBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.ShotsBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.LiqueursBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.PunchesBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.CocktailsBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.BeerAleBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.NonAlcoholicBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.CoffeeTeaBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.ShotsNameBox = new DevExpress.XtraEditors.ListBoxControl();
            this.LiqueursNameBox = new DevExpress.XtraEditors.ListBoxControl();
            this.PunchesNameBox = new DevExpress.XtraEditors.ListBoxControl();
            this.CocktailsNameBox = new DevExpress.XtraEditors.ListBoxControl();
            this.BeerAleNameBox = new DevExpress.XtraEditors.ListBoxControl();
            this.NonAlcoholicNameBox = new DevExpress.XtraEditors.ListBoxControl();
            this.CoffeeTeaNameBox = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.DrinksNameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderExpressDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShotsNameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiqueursNameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PunchesNameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CocktailsNameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeerAleNameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NonAlcoholicNameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeTeaNameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DrinksNameBox
            // 
            this.DrinksNameBox.DataSource = this.recipesBindingSource;
            this.DrinksNameBox.DisplayMember = "name";
            this.DrinksNameBox.Location = new System.Drawing.Point(794, 144);
            this.DrinksNameBox.Name = "DrinksNameBox";
            this.DrinksNameBox.Size = new System.Drawing.Size(193, 382);
            this.DrinksNameBox.TabIndex = 1;
            this.DrinksNameBox.ValueMember = "name";
            this.DrinksNameBox.DoubleClick += new System.EventHandler(this.nameListCount);
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "recipes";
            this.recipesBindingSource.DataSource = this.bartenderExpressDataSet;
            // 
            // bartenderExpressDataSet
            // 
            this.bartenderExpressDataSet.DataSetName = "bartenderExpressDataSet";
            this.bartenderExpressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.PinPageButtonShowMode = DevExpress.XtraTab.PinPageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtraTabbedMdiManager1.ShowToolTips = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(987, 144);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.TheBarGroup;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.TheBarGroup,
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.DrinksBarItem,
            this.ShotsBarItem,
            this.LiqueursBarItem,
            this.PunchesBarItem,
            this.CocktailsBarItem,
            this.BeerAleBarItem,
            this.NonAlcoholicBarItem,
            this.CoffeeTeaBarItem,
            this.navBarItem9});
            this.navBarControl1.Location = new System.Drawing.Point(0, 144);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 175;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(175, 382);
            this.navBarControl1.TabIndex = 3;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // TheBarGroup
            // 
            this.TheBarGroup.Caption = "Bartender Recipes";
            this.TheBarGroup.Expanded = true;
            this.TheBarGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.DrinksBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ShotsBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.LiqueursBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.PunchesBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.CocktailsBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.BeerAleBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.NonAlcoholicBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.CoffeeTeaBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9)});
            this.TheBarGroup.Name = "TheBarGroup";
            // 
            // DrinksBarItem
            // 
            this.DrinksBarItem.Caption = "Drinks";
            this.DrinksBarItem.Name = "DrinksBarItem";
            this.DrinksBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.DrinksBoxItem_LinkClicked);
            // 
            // ShotsBarItem
            // 
            this.ShotsBarItem.Caption = "Shots";
            this.ShotsBarItem.Name = "ShotsBarItem";
            this.ShotsBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ShotsBarItem_LinkClicked);
            // 
            // LiqueursBarItem
            // 
            this.LiqueursBarItem.Caption = "Liqueurs";
            this.LiqueursBarItem.Name = "LiqueursBarItem";
            this.LiqueursBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.LiqueursBarItem_LinkClicked);
            // 
            // PunchesBarItem
            // 
            this.PunchesBarItem.Caption = "Punches";
            this.PunchesBarItem.Name = "PunchesBarItem";
            this.PunchesBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.PunchesBarItem_LinkClicked);
            // 
            // CocktailsBarItem
            // 
            this.CocktailsBarItem.Caption = "Cocktails";
            this.CocktailsBarItem.Name = "CocktailsBarItem";
            this.CocktailsBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.CocktailsBarItem_LinkClicked);
            // 
            // BeerAleBarItem
            // 
            this.BeerAleBarItem.Caption = "Beer and Ales";
            this.BeerAleBarItem.Name = "BeerAleBarItem";
            this.BeerAleBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.BeerAleBarItem_LinkClicked);
            // 
            // NonAlcoholicBarItem
            // 
            this.NonAlcoholicBarItem.Caption = "non-Alcoholic";
            this.NonAlcoholicBarItem.Name = "NonAlcoholicBarItem";
            this.NonAlcoholicBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NonAlcoholicBarItem_LinkClicked);
            // 
            // CoffeeTeaBarItem
            // 
            this.CoffeeTeaBarItem.Caption = "Coffee and Teas";
            this.CoffeeTeaBarItem.Name = "CoffeeTeaBarItem";
            this.CoffeeTeaBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.CoffeeTeaBarItem_LinkClicked);
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "Custom Recipies";
            this.navBarItem9.Name = "navBarItem9";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Favorites";
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "My Recipes";
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // ShotsNameBox
            // 
            this.ShotsNameBox.Location = new System.Drawing.Point(794, 144);
            this.ShotsNameBox.Name = "ShotsNameBox";
            this.ShotsNameBox.Size = new System.Drawing.Size(193, 382);
            this.ShotsNameBox.TabIndex = 5;
            // 
            // LiqueursNameBox
            // 
            this.LiqueursNameBox.Location = new System.Drawing.Point(794, 144);
            this.LiqueursNameBox.Name = "LiqueursNameBox";
            this.LiqueursNameBox.Size = new System.Drawing.Size(193, 382);
            this.LiqueursNameBox.TabIndex = 6;
            // 
            // PunchesNameBox
            // 
            this.PunchesNameBox.Location = new System.Drawing.Point(794, 144);
            this.PunchesNameBox.Name = "PunchesNameBox";
            this.PunchesNameBox.Size = new System.Drawing.Size(193, 382);
            this.PunchesNameBox.TabIndex = 7;
            // 
            // CocktailsNameBox
            // 
            this.CocktailsNameBox.Location = new System.Drawing.Point(794, 144);
            this.CocktailsNameBox.Name = "CocktailsNameBox";
            this.CocktailsNameBox.Size = new System.Drawing.Size(193, 382);
            this.CocktailsNameBox.TabIndex = 8;
            // 
            // BeerAleNameBox
            // 
            this.BeerAleNameBox.Location = new System.Drawing.Point(794, 144);
            this.BeerAleNameBox.Name = "BeerAleNameBox";
            this.BeerAleNameBox.Size = new System.Drawing.Size(193, 382);
            this.BeerAleNameBox.TabIndex = 9;
            // 
            // NonAlcoholicNameBox
            // 
            this.NonAlcoholicNameBox.Location = new System.Drawing.Point(794, 144);
            this.NonAlcoholicNameBox.Name = "NonAlcoholicNameBox";
            this.NonAlcoholicNameBox.Size = new System.Drawing.Size(193, 382);
            this.NonAlcoholicNameBox.TabIndex = 10;
            // 
            // CoffeeTeaNameBox
            // 
            this.CoffeeTeaNameBox.Location = new System.Drawing.Point(794, 144);
            this.CoffeeTeaNameBox.Name = "CoffeeTeaNameBox";
            this.CoffeeTeaNameBox.Size = new System.Drawing.Size(193, 382);
            this.CoffeeTeaNameBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 526);
            this.Controls.Add(this.CoffeeTeaNameBox);
            this.Controls.Add(this.NonAlcoholicNameBox);
            this.Controls.Add(this.BeerAleNameBox);
            this.Controls.Add(this.CocktailsNameBox);
            this.Controls.Add(this.PunchesNameBox);
            this.Controls.Add(this.LiqueursNameBox);
            this.Controls.Add(this.ShotsNameBox);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.DrinksNameBox);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Bartender Express Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrinksNameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderExpressDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShotsNameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiqueursNameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PunchesNameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CocktailsNameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeerAleNameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NonAlcoholicNameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeTeaNameBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl DrinksNameBox;
        private bartenderExpressDataSet bartenderExpressDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private bartenderExpressDataSetTableAdapters.recipesTableAdapter recipesTableAdapter;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup TheBarGroup;
        private DevExpress.XtraNavBar.NavBarItem DrinksBarItem;
        private DevExpress.XtraNavBar.NavBarItem ShotsBarItem;
        private DevExpress.XtraNavBar.NavBarItem LiqueursBarItem;
        private DevExpress.XtraNavBar.NavBarItem PunchesBarItem;
        private DevExpress.XtraNavBar.NavBarItem CocktailsBarItem;
        private DevExpress.XtraNavBar.NavBarItem BeerAleBarItem;
        private DevExpress.XtraNavBar.NavBarItem NonAlcoholicBarItem;
        private DevExpress.XtraNavBar.NavBarItem CoffeeTeaBarItem;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraEditors.ListBoxControl CoffeeTeaNameBox;
        private DevExpress.XtraEditors.ListBoxControl NonAlcoholicNameBox;
        private DevExpress.XtraEditors.ListBoxControl BeerAleNameBox;
        private DevExpress.XtraEditors.ListBoxControl CocktailsNameBox;
        private DevExpress.XtraEditors.ListBoxControl PunchesNameBox;
        private DevExpress.XtraEditors.ListBoxControl LiqueursNameBox;
        private DevExpress.XtraEditors.ListBoxControl ShotsNameBox;
    }
}

