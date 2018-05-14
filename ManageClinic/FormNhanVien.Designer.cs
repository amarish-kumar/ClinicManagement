namespace ManageClinic
{
    partial class FormNhanVien
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableChucDanh = new ManageClinic.TableChucDanh();
            this.chucDanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chucDanhTableAdapter = new ManageClinic.TableChucDanhTableAdapters.ChucDanhTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbChucDanhTimKiem = new System.Windows.Forms.ComboBox();
            this.rdChucDanh = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdMaSo = new System.Windows.Forms.RadioButton();
            this.txtKeyWord = new Bunifu.Framework.UI.BunifuTextbox();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbbMachucdanh = new System.Windows.Forms.ComboBox();
            this.txtSocmnd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnKetthuc = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSodienthoai = new DevExpress.XtraEditors.TextEdit();
            this.btnChucDanh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtDiachi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnLammoi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgaysinh = new DevExpress.XtraEditors.DateEdit();
            this.dtNgaynghilam = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.txtHovaten = new DevExpress.XtraEditors.TextEdit();
            this.txtManhanvien = new DevExpress.XtraEditors.TextEdit();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayvaolam = new DevExpress.XtraEditors.DateEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableChucDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucDanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSocmnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSodienthoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaysinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaysinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaynghilam.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaynghilam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHovaten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayvaolam.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayvaolam.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 11F);
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.LookAndFeel.SkinName = "Dark Side";
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1154, 419);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 413;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // tableChucDanh
            // 
            this.tableChucDanh.DataSetName = "TableChucDanh";
            this.tableChucDanh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chucDanhBindingSource
            // 
            this.chucDanhBindingSource.DataMember = "ChucDanh";
            this.chucDanhBindingSource.DataSource = this.tableChucDanh;
            // 
            // chucDanhTableAdapter
            // 
            this.chucDanhTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1154, 369);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Quản Lý Nhân Viên";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnTimKiem);
            this.groupControl2.Controls.Add(this.groupBox1);
            this.groupControl2.Controls.Add(this.txtKeyWord);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(655, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(499, 365);
            this.groupControl2.TabIndex = 33;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(347, 155);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(108, 39);
            this.btnTimKiem.TabIndex = 34;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbChucDanhTimKiem);
            this.groupBox1.Controls.Add(this.rdChucDanh);
            this.groupBox1.Controls.Add(this.rdHoTen);
            this.groupBox1.Controls.Add(this.rdMaSo);
            this.groupBox1.Location = new System.Drawing.Point(10, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 100);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kiểu tìm kiếm";
            // 
            // cbbChucDanhTimKiem
            // 
            this.cbbChucDanhTimKiem.DataSource = this.chucDanhBindingSource;
            this.cbbChucDanhTimKiem.DisplayMember = "TenChucDanh";
            this.cbbChucDanhTimKiem.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.cbbChucDanhTimKiem.FormattingEnabled = true;
            this.cbbChucDanhTimKiem.Location = new System.Drawing.Point(301, 38);
            this.cbbChucDanhTimKiem.Name = "cbbChucDanhTimKiem";
            this.cbbChucDanhTimKiem.Size = new System.Drawing.Size(121, 25);
            this.cbbChucDanhTimKiem.TabIndex = 1;
            this.cbbChucDanhTimKiem.ValueMember = "MaChucDanh";
            this.cbbChucDanhTimKiem.Visible = false;
            // 
            // rdChucDanh
            // 
            this.rdChucDanh.AutoSize = true;
            this.rdChucDanh.Location = new System.Drawing.Point(202, 41);
            this.rdChucDanh.Name = "rdChucDanh";
            this.rdChucDanh.Size = new System.Drawing.Size(77, 17);
            this.rdChucDanh.TabIndex = 0;
            this.rdChucDanh.Text = "Chức danh";
            this.rdChucDanh.UseVisualStyleBackColor = true;
            this.rdChucDanh.CheckedChanged += new System.EventHandler(this.rdChucDanh_CheckedChanged);
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Location = new System.Drawing.Point(109, 41);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(59, 17);
            this.rdHoTen.TabIndex = 0;
            this.rdHoTen.Text = "Họ Tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // rdMaSo
            // 
            this.rdMaSo.AutoSize = true;
            this.rdMaSo.Checked = true;
            this.rdMaSo.Location = new System.Drawing.Point(16, 41);
            this.rdMaSo.Name = "rdMaSo";
            this.rdMaSo.Size = new System.Drawing.Size(53, 17);
            this.rdMaSo.TabIndex = 0;
            this.rdMaSo.TabStop = true;
            this.rdMaSo.Text = "Mã số";
            this.rdMaSo.UseVisualStyleBackColor = true;
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txtKeyWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtKeyWord.BackgroundImage")));
            this.txtKeyWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtKeyWord.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtKeyWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKeyWord.Icon = ((System.Drawing.Image)(resources.GetObject("txtKeyWord.Icon")));
            this.txtKeyWord.Location = new System.Drawing.Point(26, 155);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(319, 39);
            this.txtKeyWord.TabIndex = 32;
            this.txtKeyWord.text = "Enter text";
            this.txtKeyWord.OnTextChange += new System.EventHandler(this.txtKeyWord_OnTextChange);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.labelControl1);
            this.groupControl4.Controls.Add(this.labelControl6);
            this.groupControl4.Controls.Add(this.cbbMachucdanh);
            this.groupControl4.Controls.Add(this.txtSocmnd);
            this.groupControl4.Controls.Add(this.labelControl4);
            this.groupControl4.Controls.Add(this.btnKetthuc);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Controls.Add(this.txtSodienthoai);
            this.groupControl4.Controls.Add(this.btnChucDanh);
            this.groupControl4.Controls.Add(this.labelControl7);
            this.groupControl4.Controls.Add(this.btnThem);
            this.groupControl4.Controls.Add(this.txtDiachi);
            this.groupControl4.Controls.Add(this.labelControl5);
            this.groupControl4.Controls.Add(this.btnLammoi);
            this.groupControl4.Controls.Add(this.labelControl2);
            this.groupControl4.Controls.Add(this.dtNgaysinh);
            this.groupControl4.Controls.Add(this.dtNgaynghilam);
            this.groupControl4.Controls.Add(this.labelControl8);
            this.groupControl4.Controls.Add(this.btnXoa);
            this.groupControl4.Controls.Add(this.txtHovaten);
            this.groupControl4.Controls.Add(this.txtManhanvien);
            this.groupControl4.Controls.Add(this.btnSua);
            this.groupControl4.Controls.Add(this.labelControl9);
            this.groupControl4.Controls.Add(this.dtNgayvaolam);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl4.Location = new System.Drawing.Point(2, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(653, 365);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Thông Tin Nhân Viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 18);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Mã nhân viên";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 211);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 18);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Ngày sinh";
            // 
            // cbbMachucdanh
            // 
            this.cbbMachucdanh.DataSource = this.chucDanhBindingSource;
            this.cbbMachucdanh.DisplayMember = "TenChucDanh";
            this.cbbMachucdanh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbMachucdanh.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.cbbMachucdanh.FormattingEnabled = true;
            this.cbbMachucdanh.Location = new System.Drawing.Point(135, 56);
            this.cbbMachucdanh.Name = "cbbMachucdanh";
            this.cbbMachucdanh.Size = new System.Drawing.Size(161, 26);
            this.cbbMachucdanh.TabIndex = 24;
            this.cbbMachucdanh.ValueMember = "MaChucDanh";
            // 
            // txtSocmnd
            // 
            this.txtSocmnd.Location = new System.Drawing.Point(135, 168);
            this.txtSocmnd.Name = "txtSocmnd";
            this.txtSocmnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSocmnd.Properties.Appearance.Options.UseFont = true;
            this.txtSocmnd.Size = new System.Drawing.Size(242, 26);
            this.txtSocmnd.TabIndex = 18;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 247);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 18);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Ngày vào làm";
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnKetthuc.Appearance.Options.UseFont = true;
            this.btnKetthuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKetthuc.ImageOptions.Image")));
            this.btnKetthuc.Location = new System.Drawing.Point(433, 276);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(165, 62);
            this.btnKetthuc.TabIndex = 29;
            this.btnKetthuc.Text = "Kết thúc";
            this.btnKetthuc.Click += new System.EventHandler(this.btnKetthuc_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 95);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 18);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Họ và tên";
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(135, 321);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSodienthoai.Properties.Appearance.Options.UseFont = true;
            this.txtSodienthoai.Properties.Mask.EditMask = "(0263) 000-0000";
            this.txtSodienthoai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSodienthoai.Size = new System.Drawing.Size(242, 26);
            this.txtSodienthoai.TabIndex = 19;
            // 
            // btnChucDanh
            // 
            this.btnChucDanh.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnChucDanh.Appearance.Options.UseFont = true;
            this.btnChucDanh.Location = new System.Drawing.Point(302, 54);
            this.btnChucDanh.Name = "btnChucDanh";
            this.btnChucDanh.Size = new System.Drawing.Size(75, 30);
            this.btnChucDanh.TabIndex = 23;
            this.btnChucDanh.Text = "Thêm";
            this.btnChucDanh.Click += new System.EventHandler(this.btnChucDanh_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 324);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(84, 18);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Số điện thoại";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(433, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 62);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(135, 129);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Properties.Appearance.Options.UseFont = true;
            this.txtDiachi.Size = new System.Drawing.Size(242, 26);
            this.txtDiachi.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 283);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(93, 18);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Ngày nghỉ làm";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLammoi.Appearance.Options.UseFont = true;
            this.btnLammoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.ImageOptions.Image")));
            this.btnLammoi.Location = new System.Drawing.Point(433, 214);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(165, 62);
            this.btnLammoi.TabIndex = 28;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 18);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Mã chức danh";
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.EditValue = null;
            this.dtNgaysinh.Location = new System.Drawing.Point(135, 208);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaysinh.Properties.Appearance.Options.UseFont = true;
            this.dtNgaysinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaysinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaysinh.Properties.Mask.EditMask = "f";
            this.dtNgaysinh.Size = new System.Drawing.Size(242, 26);
            this.dtNgaysinh.TabIndex = 22;
            // 
            // dtNgaynghilam
            // 
            this.dtNgaynghilam.EditValue = null;
            this.dtNgaynghilam.Location = new System.Drawing.Point(135, 284);
            this.dtNgaynghilam.Name = "dtNgaynghilam";
            this.dtNgaynghilam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaynghilam.Properties.Appearance.Options.UseFont = true;
            this.dtNgaynghilam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaynghilam.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaynghilam.Properties.Mask.EditMask = "f";
            this.dtNgaynghilam.Size = new System.Drawing.Size(242, 26);
            this.dtNgaynghilam.TabIndex = 21;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(5, 132);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 18);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Địa chỉ";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(433, 90);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 62);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtHovaten
            // 
            this.txtHovaten.Location = new System.Drawing.Point(135, 92);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHovaten.Properties.Appearance.Options.UseFont = true;
            this.txtHovaten.Size = new System.Drawing.Size(242, 26);
            this.txtHovaten.TabIndex = 17;
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Enabled = false;
            this.txtManhanvien.Location = new System.Drawing.Point(135, 20);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManhanvien.Properties.Appearance.Options.UseFont = true;
            this.txtManhanvien.Size = new System.Drawing.Size(242, 26);
            this.txtManhanvien.TabIndex = 16;
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(433, 152);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(165, 62);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(5, 171);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(62, 18);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Số CMND";
            // 
            // dtNgayvaolam
            // 
            this.dtNgayvaolam.EditValue = null;
            this.dtNgayvaolam.Location = new System.Drawing.Point(135, 244);
            this.dtNgayvaolam.Name = "dtNgayvaolam";
            this.dtNgayvaolam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayvaolam.Properties.Appearance.Options.UseFont = true;
            this.dtNgayvaolam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayvaolam.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayvaolam.Properties.Mask.EditMask = "f";
            this.dtNgayvaolam.Size = new System.Drawing.Size(242, 26);
            this.dtNgayvaolam.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 369);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 419);
            this.panel2.TabIndex = 10;
            // 
            // FormNhanVien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1154, 775);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableChucDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucDanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSocmnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSodienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaysinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaysinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaynghilam.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaynghilam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHovaten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayvaolam.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayvaolam.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private TableChucDanh tableChucDanh;
        private System.Windows.Forms.BindingSource chucDanhBindingSource;
        private TableChucDanhTableAdapters.ChucDanhTableAdapter chucDanhTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKetthuc;
        private DevExpress.XtraEditors.SimpleButton btnLammoi;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.ComboBox cbbMachucdanh;
        private DevExpress.XtraEditors.SimpleButton btnChucDanh;
        private DevExpress.XtraEditors.DateEdit dtNgaynghilam;
        private DevExpress.XtraEditors.DateEdit dtNgayvaolam;
        private DevExpress.XtraEditors.DateEdit dtNgaysinh;
        private DevExpress.XtraEditors.TextEdit txtSodienthoai;
        private DevExpress.XtraEditors.TextEdit txtDiachi;
        private DevExpress.XtraEditors.TextEdit txtHovaten;
        private DevExpress.XtraEditors.TextEdit txtManhanvien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSocmnd;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Bunifu.Framework.UI.BunifuTextbox txtKeyWord;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdChucDanh;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMaSo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbChucDanhTimKiem;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.Panel panel2;
    }
}