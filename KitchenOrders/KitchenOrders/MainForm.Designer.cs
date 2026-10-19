namespace KitchenOrders
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlWaiter = new System.Windows.Forms.Panel();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.txtWaiter = new System.Windows.Forms.TextBox();
            this.pnlHall = new System.Windows.Forms.Panel();
            this.flpTables = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHall = new System.Windows.Forms.Label();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.squareFree = new System.Windows.Forms.Panel();
            this.legendFree = new System.Windows.Forms.Label();
            this.squareBusy = new System.Windows.Forms.Panel();
            this.legendBusy = new System.Windows.Forms.Label();
            this.squareSelected = new System.Windows.Forms.Panel();
            this.legendSelected = new System.Windows.Forms.Label();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategories = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.pnlOrderScroll = new System.Windows.Forms.Panel();
            this.pnlOrderFields = new System.Windows.Forms.Panel();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.flpMods = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMods = new System.Windows.Forms.Label();
            this.pnlQuantity = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lvOrder = new System.Windows.Forms.ListView();
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTable = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.flpDishes = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlExtra = new System.Windows.Forms.Panel();
            this.pnlExtraEntry = new System.Windows.Forms.Panel();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.btnExtra = new System.Windows.Forms.Button();
            this.lblExtra = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlWaiter.SuspendLayout();
            this.pnlHall.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlOrderScroll.SuspendLayout();
            this.pnlOrderFields.SuspendLayout();
            this.pnlQuantity.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlExtra.SuspendLayout();
            this.pnlExtraEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pnlWaiter);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.pnlHeader.Size = new System.Drawing.Size(1100, 56);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(776, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ресторант · Поръчки по маси";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlWaiter
            // 
            this.pnlWaiter.Controls.Add(this.lblWaiter);
            this.pnlWaiter.Controls.Add(this.txtWaiter);
            this.pnlWaiter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlWaiter.Location = new System.Drawing.Point(788, 6);
            this.pnlWaiter.Name = "pnlWaiter";
            this.pnlWaiter.Size = new System.Drawing.Size(300, 44);
            this.pnlWaiter.TabIndex = 0;
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Location = new System.Drawing.Point(0, 11);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(99, 23);
            this.lblWaiter.TabIndex = 0;
            this.lblWaiter.Text = "Сервитьор:";
            // 
            // txtWaiter
            // 
            this.txtWaiter.AccessibleName = "Сервитьор";
            this.txtWaiter.ForeColor = System.Drawing.Color.Black;
            this.txtWaiter.Location = new System.Drawing.Point(94, 8);
            this.txtWaiter.MaxLength = 40;
            this.txtWaiter.Name = "txtWaiter";
            this.txtWaiter.Size = new System.Drawing.Size(200, 30);
            this.txtWaiter.TabIndex = 0;
            // 
            // pnlHall
            // 
            this.pnlHall.BackColor = System.Drawing.Color.White;
            this.pnlHall.Controls.Add(this.flpTables);
            this.pnlHall.Controls.Add(this.lblHall);
            this.pnlHall.Controls.Add(this.pnlLegend);
            this.pnlHall.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHall.Location = new System.Drawing.Point(0, 56);
            this.pnlHall.Name = "pnlHall";
            this.pnlHall.Padding = new System.Windows.Forms.Padding(6, 3, 6, 0);
            this.pnlHall.Size = new System.Drawing.Size(1100, 96);
            this.pnlHall.TabIndex = 1;
            // 
            // flpTables
            // 
            this.flpTables.AutoScroll = true;
            this.flpTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTables.Location = new System.Drawing.Point(66, 3);
            this.flpTables.Name = "flpTables";
            this.flpTables.Size = new System.Drawing.Size(918, 93);
            this.flpTables.TabIndex = 0;
            this.flpTables.WrapContents = false;
            // 
            // lblHall
            // 
            this.lblHall.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHall.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHall.Location = new System.Drawing.Point(6, 3);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(60, 93);
            this.lblHall.TabIndex = 1;
            this.lblHall.Text = "ЗАЛА";
            this.lblHall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLegend
            // 
            this.pnlLegend.Controls.Add(this.squareFree);
            this.pnlLegend.Controls.Add(this.legendFree);
            this.pnlLegend.Controls.Add(this.squareBusy);
            this.pnlLegend.Controls.Add(this.legendBusy);
            this.pnlLegend.Controls.Add(this.squareSelected);
            this.pnlLegend.Controls.Add(this.legendSelected);
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLegend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pnlLegend.Location = new System.Drawing.Point(984, 3);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(110, 93);
            this.pnlLegend.TabIndex = 2;
            // 
            // squareFree
            // 
            this.squareFree.BackColor = System.Drawing.Color.White;
            this.squareFree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.squareFree.Location = new System.Drawing.Point(6, 5);
            this.squareFree.Name = "squareFree";
            this.squareFree.Size = new System.Drawing.Size(14, 14);
            this.squareFree.TabIndex = 0;
            // 
            // legendFree
            // 
            this.legendFree.Location = new System.Drawing.Point(25, 2);
            this.legendFree.Name = "legendFree";
            this.legendFree.Size = new System.Drawing.Size(85, 22);
            this.legendFree.TabIndex = 1;
            this.legendFree.Text = "Свободна";
            // 
            // squareBusy
            // 
            this.squareBusy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
            this.squareBusy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.squareBusy.Location = new System.Drawing.Point(6, 28);
            this.squareBusy.Name = "squareBusy";
            this.squareBusy.Size = new System.Drawing.Size(14, 14);
            this.squareBusy.TabIndex = 2;
            // 
            // legendBusy
            // 
            this.legendBusy.Location = new System.Drawing.Point(25, 25);
            this.legendBusy.Name = "legendBusy";
            this.legendBusy.Size = new System.Drawing.Size(85, 22);
            this.legendBusy.TabIndex = 3;
            this.legendBusy.Text = "С поръчка";
            // 
            // squareSelected
            // 
            this.squareSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(127)))), ((int)(((byte)(98)))));
            this.squareSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.squareSelected.Location = new System.Drawing.Point(6, 51);
            this.squareSelected.Name = "squareSelected";
            this.squareSelected.Size = new System.Drawing.Size(14, 14);
            this.squareSelected.TabIndex = 4;
            // 
            // legendSelected
            // 
            this.legendSelected.Location = new System.Drawing.Point(25, 48);
            this.legendSelected.Name = "legendSelected";
            this.legendSelected.Size = new System.Drawing.Size(85, 22);
            this.legendSelected.TabIndex = 5;
            this.legendSelected.Text = "Избрана";
            // 
            // pnlCategories
            // 
            this.pnlCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(233)))));
            this.pnlCategories.Controls.Add(this.flpCategories);
            this.pnlCategories.Controls.Add(this.lblCategories);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCategories.Location = new System.Drawing.Point(0, 152);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.pnlCategories.Size = new System.Drawing.Size(170, 548);
            this.pnlCategories.TabIndex = 2;
            // 
            // flpCategories
            // 
            this.flpCategories.AutoScroll = true;
            this.flpCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCategories.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCategories.Location = new System.Drawing.Point(7, 42);
            this.flpCategories.Name = "flpCategories";
            this.flpCategories.Size = new System.Drawing.Size(156, 496);
            this.flpCategories.TabIndex = 0;
            this.flpCategories.WrapContents = false;
            // 
            // lblCategories
            // 
            this.lblCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCategories.Location = new System.Drawing.Point(7, 10);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(156, 32);
            this.lblCategories.TabIndex = 1;
            this.lblCategories.Text = "Категории";
            this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.White;
            this.pnlOrder.Controls.Add(this.pnlOrderScroll);
            this.pnlOrder.Controls.Add(this.btnSend);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOrder.Location = new System.Drawing.Point(720, 152);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Padding = new System.Windows.Forms.Padding(12);
            this.pnlOrder.Size = new System.Drawing.Size(380, 548);
            this.pnlOrder.TabIndex = 4;
            // 
            // pnlOrderScroll
            // 
            this.pnlOrderScroll.AutoScroll = true;
            this.pnlOrderScroll.Controls.Add(this.pnlOrderFields);
            this.pnlOrderScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderScroll.Location = new System.Drawing.Point(12, 12);
            this.pnlOrderScroll.Name = "pnlOrderScroll";
            this.pnlOrderScroll.Size = new System.Drawing.Size(356, 468);
            this.pnlOrderScroll.TabIndex = 0;
            // 
            // pnlOrderFields
            // 
            this.pnlOrderFields.Controls.Add(this.txtNote);
            this.pnlOrderFields.Controls.Add(this.lblNote);
            this.pnlOrderFields.Controls.Add(this.flpMods);
            this.pnlOrderFields.Controls.Add(this.lblMods);
            this.pnlOrderFields.Controls.Add(this.pnlQuantity);
            this.pnlOrderFields.Controls.Add(this.lvOrder);
            this.pnlOrderFields.Controls.Add(this.lblTable);
            this.pnlOrderFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderFields.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderFields.Name = "pnlOrderFields";
            this.pnlOrderFields.Size = new System.Drawing.Size(356, 455);
            this.pnlOrderFields.TabIndex = 0;
            // 
            // txtNote
            // 
            this.txtNote.AccessibleName = "Специална бележка";
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNote.Location = new System.Drawing.Point(0, 424);
            this.txtNote.MaxLength = 40;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(356, 30);
            this.txtNote.TabIndex = 3;
            this.txtNote.TextChanged += new System.EventHandler(this.DetailsChanged);
            // 
            // lblNote
            // 
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNote.Location = new System.Drawing.Point(0, 400);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(356, 24);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "Специална бележка";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpMods
            // 
            this.flpMods.AutoScroll = true;
            this.flpMods.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpMods.Location = new System.Drawing.Point(0, 308);
            this.flpMods.Name = "flpMods";
            this.flpMods.Size = new System.Drawing.Size(356, 92);
            this.flpMods.TabIndex = 2;
            // 
            // lblMods
            // 
            this.lblMods.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMods.Location = new System.Drawing.Point(0, 284);
            this.lblMods.Name = "lblMods";
            this.lblMods.Size = new System.Drawing.Size(356, 24);
            this.lblMods.TabIndex = 5;
            this.lblMods.Text = "Към кухнята:";
            this.lblMods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlQuantity
            // 
            this.pnlQuantity.Controls.Add(this.btnMinus);
            this.pnlQuantity.Controls.Add(this.btnPlus);
            this.pnlQuantity.Controls.Add(this.btnRemove);
            this.pnlQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuantity.Location = new System.Drawing.Point(0, 234);
            this.pnlQuantity.Name = "pnlQuantity";
            this.pnlQuantity.Size = new System.Drawing.Size(356, 50);
            this.pnlQuantity.TabIndex = 1;
            this.pnlQuantity.WrapContents = false;
            // 
            // btnMinus
            // 
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Location = new System.Drawing.Point(3, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(54, 44);
            this.btnMinus.TabIndex = 0;
            this.btnMinus.Text = "−";
            this.btnMinus.Click += new System.EventHandler(this.QuantityClick);
            // 
            // btnPlus
            // 
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Location = new System.Drawing.Point(63, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(54, 44);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.Click += new System.EventHandler(this.QuantityClick);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(123, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(190, 44);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "× Премахни";
            this.btnRemove.Click += new System.EventHandler(this.RemoveClick);
            // 
            // lvOrder
            // 
            this.lvOrder.AccessibleName = "Поръчка";
            this.lvOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colQty,
            this.colItem,
            this.colNotes});
            this.lvOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvOrder.FullRowSelect = true;
            this.lvOrder.HideSelection = false;
            this.lvOrder.Location = new System.Drawing.Point(0, 34);
            this.lvOrder.MultiSelect = false;
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.Size = new System.Drawing.Size(356, 200);
            this.lvOrder.TabIndex = 0;
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            this.lvOrder.View = System.Windows.Forms.View.Details;
            this.lvOrder.SelectedIndexChanged += new System.EventHandler(this.SelectionChanged);
            this.lvOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderKeyDown);
            // 
            // colQty
            // 
            this.colQty.Text = "Кол.";
            this.colQty.Width = 50;
            // 
            // colItem
            // 
            this.colItem.Text = "Артикул";
            this.colItem.Width = 150;
            // 
            // colNotes
            // 
            this.colNotes.Text = "Бележки";
            this.colNotes.Width = 150;
            // 
            // lblTable
            // 
            this.lblTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTable.Location = new System.Drawing.Point(0, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(356, 34);
            this.lblTable.TabIndex = 6;
            this.lblTable.Text = "Изберете маса";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(127)))), ((int)(((byte)(98)))));
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(12, 480);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(356, 56);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "&Изпрати към кухнята";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.SendClick);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.flpDishes);
            this.pnlCenter.Controls.Add(this.lblCategory);
            this.pnlCenter.Controls.Add(this.pnlExtra);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(170, 152);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCenter.Size = new System.Drawing.Size(550, 548);
            this.pnlCenter.TabIndex = 3;
            // 
            // flpDishes
            // 
            this.flpDishes.AutoScroll = true;
            this.flpDishes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDishes.Location = new System.Drawing.Point(12, 48);
            this.flpDishes.Name = "flpDishes";
            this.flpDishes.Size = new System.Drawing.Size(526, 412);
            this.flpDishes.TabIndex = 0;
            this.flpDishes.Paint += new System.Windows.Forms.PaintEventHandler(this.flpDishes_Paint);
            // 
            // lblCategory
            // 
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(12, 12);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(526, 36);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Предястия";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlExtra
            // 
            this.pnlExtra.Controls.Add(this.pnlExtraEntry);
            this.pnlExtra.Controls.Add(this.lblExtra);
            this.pnlExtra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExtra.Location = new System.Drawing.Point(12, 460);
            this.pnlExtra.Name = "pnlExtra";
            this.pnlExtra.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlExtra.Size = new System.Drawing.Size(526, 76);
            this.pnlExtra.TabIndex = 1;
            // 
            // pnlExtraEntry
            // 
            this.pnlExtraEntry.Controls.Add(this.txtExtra);
            this.pnlExtraEntry.Controls.Add(this.btnExtra);
            this.pnlExtraEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExtraEntry.Location = new System.Drawing.Point(0, 32);
            this.pnlExtraEntry.Name = "pnlExtraEntry";
            this.pnlExtraEntry.Size = new System.Drawing.Size(526, 44);
            this.pnlExtraEntry.TabIndex = 0;
            // 
            // txtExtra
            // 
            this.txtExtra.AccessibleName = "Артикул извън менюто";
            this.txtExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExtra.Location = new System.Drawing.Point(0, 0);
            this.txtExtra.MaxLength = 40;
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(430, 30);
            this.txtExtra.TabIndex = 0;
            this.txtExtra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExtraKeyDown);
            // 
            // btnExtra
            // 
            this.btnExtra.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtra.Location = new System.Drawing.Point(430, 0);
            this.btnExtra.Name = "btnExtra";
            this.btnExtra.Size = new System.Drawing.Size(96, 44);
            this.btnExtra.TabIndex = 1;
            this.btnExtra.Text = "&Добави";
            this.btnExtra.Click += new System.EventHandler(this.ExtraClick);
            // 
            // lblExtra
            // 
            this.lblExtra.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExtra.Location = new System.Drawing.Point(0, 6);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(526, 26);
            this.lblExtra.TabIndex = 1;
            this.lblExtra.Text = "Артикул извън менюто";
            this.lblExtra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.pnlCategories);
            this.Controls.Add(this.pnlHall);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(59)))), ((int)(((byte)(58)))));
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ресторант · Поръчки по маси";
            this.pnlHeader.ResumeLayout(false);
            this.pnlWaiter.ResumeLayout(false);
            this.pnlWaiter.PerformLayout();
            this.pnlHall.ResumeLayout(false);
            this.pnlLegend.ResumeLayout(false);
            this.pnlCategories.ResumeLayout(false);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrderScroll.ResumeLayout(false);
            this.pnlOrderFields.ResumeLayout(false);
            this.pnlOrderFields.PerformLayout();
            this.pnlQuantity.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlExtra.ResumeLayout(false);
            this.pnlExtraEntry.ResumeLayout(false);
            this.pnlExtraEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlWaiter;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.TextBox txtWaiter;
        private System.Windows.Forms.Panel pnlHall;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.FlowLayoutPanel flpTables;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Panel squareFree;
        private System.Windows.Forms.Label legendFree;
        private System.Windows.Forms.Panel squareBusy;
        private System.Windows.Forms.Label legendBusy;
        private System.Windows.Forms.Panel squareSelected;
        private System.Windows.Forms.Label legendSelected;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel pnlOrderScroll;
        private System.Windows.Forms.Panel pnlOrderFields;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.FlowLayoutPanel pnlQuantity;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblMods;
        private System.Windows.Forms.FlowLayoutPanel flpMods;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.FlowLayoutPanel flpDishes;
        private System.Windows.Forms.Panel pnlExtra;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.Panel pnlExtraEntry;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Button btnExtra;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ColumnHeader colItem;
        private System.Windows.Forms.ColumnHeader colNotes;
    }
}
