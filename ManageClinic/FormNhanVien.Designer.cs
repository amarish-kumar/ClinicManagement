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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableChucDanh = new ManageClinic.TableChucDanh();
            this.chucDanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chucDanhTableAdapter = new ManageClinic.TableChucDanhTableAdapters.ChucDanhTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKetthuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnLammoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.cbbMachucdanh = new System.Windows.Forms.ComboBox();
            this.btnChucDanh = new DevExpress.XtraEditors.SimpleButton();
            this.dtNgaynghilam = new DevExpress.XtraEditors.DateEdit();
            this.dtNgayvaolam = new DevExpress.XtraEditors.DateEdit();
            this.dtNgaysinh = new DevExpress.XtraEditors.DateEdit();
            this.txtSodienthoai = new DevExpress.XtraEditors.TextEdit();
            this.txtDiachi = new DevExpress.XtraEditors.TextEdit();
            this.txtHovaten = new DevExpress.XtraEditors.TextEdit();
            this.txtManhanvien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSocmnd = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableChucDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucDanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaynghilam.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaynghilam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayvaolam.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayvaolam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaysinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaysinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSodienthoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHovaten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSocmnd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridControl1.Location = new System.Drawing.Point(0, 385);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1100, 390);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            this.groupControl1.Controls.Add(this.btnKetthuc);
            this.groupControl1.Controls.Add(this.btnLammoi);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.cbbMachucdanh);
            this.groupControl1.Controls.Add(this.btnChucDanh);
            this.groupControl1.Controls.Add(this.dtNgaynghilam);
            this.groupControl1.Controls.Add(this.dtNgayvaolam);
            this.groupControl1.Controls.Add(this.dtNgaysinh);
            this.groupControl1.Controls.Add(this.txtSodienthoai);
            this.groupControl1.Controls.Add(this.txtSocmnd);
            this.groupControl1.Controls.Add(this.txtDiachi);
            this.groupControl1.Controls.Add(this.txtHovaten);
            this.groupControl1.Controls.Add(this.txtManhanvien);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1100, 353);
            this.groupControl1.TabIndex = 8;
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetthuc.Appearance.Options.UseFont = true;
            this.btnKetthuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKetthuc.ImageOptions.Image")));
            this.btnKetthuc.Location = new System.Drawing.Point(740, 256);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(108, 35);
            this.btnKetthuc.TabIndex = 29;
            this.btnKetthuc.Text = "Kết thúc";
            this.btnKetthuc.Click += new System.EventHandler(this.btnKetthuc_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Appearance.Options.UseFont = true;
            this.btnLammoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.ImageOptions.Image")));
            this.btnLammoi.Location = new System.Drawing.Point(626, 256);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(108, 35);
            this.btnLammoi.TabIndex = 28;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(512, 256);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 35);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(398, 256);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 35);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(284, 256);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 35);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbMachucdanh
            // 
            this.cbbMachucdanh.DataSource = this.chucDanhBindingSource;
            this.cbbMachucdanh.DisplayMember = "TenChucDanh";
            this.cbbMachucdanh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbMachucdanh.FormattingEnabled = true;
            this.cbbMachucdanh.Location = new System.Drawing.Point(264, 80);
            this.cbbMachucdanh.Name = "cbbMachucdanh";
            this.cbbMachucdanh.Size = new System.Drawing.Size(161, 27);
            this.cbbMachucdanh.TabIndex = 24;
            this.cbbMachucdanh.ValueMember = "MaChucDanh";
            // 
            // btnChucDanh
            // 
            this.btnChucDanh.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChucDanh.Appearance.Options.UseFont = true;
            this.btnChucDanh.Location = new System.Drawing.Point(431, 79);
            this.btnChucDanh.Name = "btnChucDanh";
            this.btnChucDanh.Size = new System.Drawing.Size(75, 31);
            this.btnChucDanh.TabIndex = 23;
            this.btnChucDanh.Text = "Thêm";
            // 
            // dtNgaynghilam
            // 
            this.dtNgaynghilam.EditValue = null;
            this.dtNgaynghilam.Location = new System.Drawing.Point(711, 116);
            this.dtNgaynghilam.Name = "dtNgaynghilam";
            this.dtNgaynghilam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaynghilam.Properties.Appearance.Options.UseFont = true;
            this.dtNgaynghilam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaynghilam.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaynghilam.Properties.Mask.EditMask = "f";
            this.dtNgaynghilam.Size = new System.Drawing.Size(222, 26);
            this.dtNgaynghilam.TabIndex = 21;
            // 
            // dtNgayvaolam
            // 
            this.dtNgayvaolam.EditValue = null;
            this.dtNgayvaolam.Location = new System.Drawing.Point(711, 76);
            this.dtNgayvaolam.Name = "dtNgayvaolam";
            this.dtNgayvaolam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayvaolam.Properties.Appearance.Options.UseFont = true;
            this.dtNgayvaolam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayvaolam.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayvaolam.Properties.Mask.EditMask = "f";
            this.dtNgayvaolam.Size = new System.Drawing.Size(222, 26);
            this.dtNgayvaolam.TabIndex = 20;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.EditValue = null;
            this.dtNgaysinh.Location = new System.Drawing.Point(711, 40);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaysinh.Properties.Appearance.Options.UseFont = true;
            this.dtNgaysinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaysinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaysinh.Properties.Mask.EditMask = "f";
            this.dtNgaysinh.Size = new System.Drawing.Size(222, 26);
            this.dtNgaysinh.TabIndex = 22;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(711, 153);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSodienthoai.Properties.Appearance.Options.UseFont = true;
            this.txtSodienthoai.Properties.Mask.EditMask = "(0263) 000-0000";
            this.txtSodienthoai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSodienthoai.Size = new System.Drawing.Size(222, 26);
            this.txtSodienthoai.TabIndex = 19;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(264, 153);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Properties.Appearance.Options.UseFont = true;
            this.txtDiachi.Size = new System.Drawing.Size(242, 26);
            this.txtDiachi.TabIndex = 18;
            // 
            // txtHovaten
            // 
            this.txtHovaten.Location = new System.Drawing.Point(264, 116);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHovaten.Properties.Appearance.Options.UseFont = true;
            this.txtHovaten.Size = new System.Drawing.Size(242, 26);
            this.txtHovaten.TabIndex = 17;
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(264, 44);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManhanvien.Properties.Appearance.Options.UseFont = true;
            this.txtManhanvien.Size = new System.Drawing.Size(242, 26);
            this.txtManhanvien.TabIndex = 16;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(579, 119);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(103, 19);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Ngày nghỉ làm";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(579, 83);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 19);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Ngày vào làm";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(152, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 19);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Họ và tên";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(152, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 19);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Mã chức danh";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(152, 160);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 19);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Địa chỉ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(579, 160);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(93, 19);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Số điện thoại";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(579, 47);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 19);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Ngày sinh";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(152, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 19);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Mã nhân viên";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(152, 199);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(67, 19);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Số CMND";
            // 
            // txtSocmnd
            // 
            this.txtSocmnd.Location = new System.Drawing.Point(264, 192);
            this.txtSocmnd.Name = "txtSocmnd";
            this.txtSocmnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSocmnd.Properties.Appearance.Options.UseFont = true;
            this.txtSocmnd.Size = new System.Drawing.Size(242, 26);
            this.txtSocmnd.TabIndex = 18;
            // 
            // FormNhanVien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1100, 775);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
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
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaynghilam.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaynghilam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayvaolam.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayvaolam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaysinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaysinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSodienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHovaten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSocmnd.Properties)).EndInit();
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
    }
}