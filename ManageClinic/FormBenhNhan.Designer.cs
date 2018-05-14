namespace ManageClinic
{
    partial class FormBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBenhNhan));
            this.gridcontrol1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKetthuc = new DevExpress.XtraEditors.SimpleButton();
            this.dtNgaysinh = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnLammoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemmoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtHovaten = new DevExpress.XtraEditors.TextEdit();
            this.txtSocmnd = new DevExpress.XtraEditors.TextEdit();
            this.txtSodtthannhan = new DevExpress.XtraEditors.TextEdit();
            this.txtHotenthannhan = new DevExpress.XtraEditors.TextEdit();
            this.txtSodienthoai = new DevExpress.XtraEditors.TextEdit();
            this.txtDiachi = new DevExpress.XtraEditors.TextEdit();
            this.txtMabenhnhan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdMaSo = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtKeyWord = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontrol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaysinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaysinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHovaten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSocmnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSodtthannhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotenthannhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSodienthoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMabenhnhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridcontrol1
            // 
            this.gridcontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontrol1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridcontrol1.Location = new System.Drawing.Point(0, 0);
            this.gridcontrol1.MainView = this.gridView1;
            this.gridcontrol1.Name = "gridcontrol1";
            this.gridcontrol1.Size = new System.Drawing.Size(1200, 388);
            this.gridcontrol1.TabIndex = 3;
            this.gridcontrol1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridcontrol1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnKetthuc);
            this.groupControl1.Controls.Add(this.dtNgaysinh);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnLammoi);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.btnThemmoi);
            this.groupControl1.Controls.Add(this.txtHovaten);
            this.groupControl1.Controls.Add(this.txtSocmnd);
            this.groupControl1.Controls.Add(this.txtSodtthannhan);
            this.groupControl1.Controls.Add(this.txtHotenthannhan);
            this.groupControl1.Controls.Add(this.txtSodienthoai);
            this.groupControl1.Controls.Add(this.txtDiachi);
            this.groupControl1.Controls.Add(this.txtMabenhnhan);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(687, 342);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin bệnh nhân";
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnKetthuc.Appearance.Options.UseFont = true;
            this.btnKetthuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKetthuc.ImageOptions.Image")));
            this.btnKetthuc.Location = new System.Drawing.Point(425, 262);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(172, 61);
            this.btnKetthuc.TabIndex = 25;
            this.btnKetthuc.Text = "Kết thúc";
            this.btnKetthuc.Click += new System.EventHandler(this.btnKetthuc_Click);
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.EditValue = null;
            this.dtNgaysinh.Location = new System.Drawing.Point(133, 182);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dtNgaysinh.Properties.Appearance.Options.UseFont = true;
            this.dtNgaysinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaysinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaysinh.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtNgaysinh.Size = new System.Drawing.Size(240, 24);
            this.dtNgaysinh.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 187);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 18);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Ngày sinh";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLammoi.Appearance.Options.UseFont = true;
            this.btnLammoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.ImageOptions.Image")));
            this.btnLammoi.Location = new System.Drawing.Point(425, 203);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(172, 61);
            this.btnLammoi.TabIndex = 24;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(425, 144);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(172, 61);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(425, 85);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 61);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnThemmoi.Appearance.Options.UseFont = true;
            this.btnThemmoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.ImageOptions.Image")));
            this.btnThemmoi.Location = new System.Drawing.Point(425, 26);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(172, 61);
            this.btnThemmoi.TabIndex = 21;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // txtHovaten
            // 
            this.txtHovaten.Location = new System.Drawing.Point(133, 65);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtHovaten.Properties.Appearance.Options.UseFont = true;
            this.txtHovaten.Size = new System.Drawing.Size(240, 24);
            this.txtHovaten.TabIndex = 18;
            // 
            // txtSocmnd
            // 
            this.txtSocmnd.Location = new System.Drawing.Point(133, 221);
            this.txtSocmnd.Name = "txtSocmnd";
            this.txtSocmnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSocmnd.Properties.Appearance.Options.UseFont = true;
            this.txtSocmnd.Properties.Mask.EditMask = "000-00-0000";
            this.txtSocmnd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSocmnd.Size = new System.Drawing.Size(240, 24);
            this.txtSocmnd.TabIndex = 17;
            // 
            // txtSodtthannhan
            // 
            this.txtSodtthannhan.Location = new System.Drawing.Point(133, 299);
            this.txtSodtthannhan.Name = "txtSodtthannhan";
            this.txtSodtthannhan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSodtthannhan.Properties.Appearance.Options.UseFont = true;
            this.txtSodtthannhan.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtSodtthannhan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSodtthannhan.Size = new System.Drawing.Size(240, 24);
            this.txtSodtthannhan.TabIndex = 16;
            // 
            // txtHotenthannhan
            // 
            this.txtHotenthannhan.Location = new System.Drawing.Point(133, 260);
            this.txtHotenthannhan.Name = "txtHotenthannhan";
            this.txtHotenthannhan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtHotenthannhan.Properties.Appearance.Options.UseFont = true;
            this.txtHotenthannhan.Size = new System.Drawing.Size(240, 24);
            this.txtHotenthannhan.TabIndex = 19;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(133, 143);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSodienthoai.Properties.Appearance.Options.UseFont = true;
            this.txtSodienthoai.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtSodienthoai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSodienthoai.Size = new System.Drawing.Size(240, 24);
            this.txtSodienthoai.TabIndex = 15;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(133, 104);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDiachi.Properties.Appearance.Options.UseFont = true;
            this.txtDiachi.Size = new System.Drawing.Size(240, 24);
            this.txtDiachi.TabIndex = 14;
            // 
            // txtMabenhnhan
            // 
            this.txtMabenhnhan.Enabled = false;
            this.txtMabenhnhan.Location = new System.Drawing.Point(133, 26);
            this.txtMabenhnhan.Name = "txtMabenhnhan";
            this.txtMabenhnhan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMabenhnhan.Properties.Appearance.Options.UseFont = true;
            this.txtMabenhnhan.Properties.ReadOnly = true;
            this.txtMabenhnhan.Size = new System.Drawing.Size(240, 24);
            this.txtMabenhnhan.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(13, 307);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(99, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "SDT thân nhân";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(13, 227);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(62, 18);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Số CMND";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 267);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(97, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Tên thân nhân";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 18);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Họ và tên";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(13, 147);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(84, 18);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Số điện thoại";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 18);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 18);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Mã bệnh nhân";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupBox1);
            this.groupControl2.Controls.Add(this.btnTimKiem);
            this.groupControl2.Controls.Add(this.txtKeyWord);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(687, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(513, 342);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Tìm Kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHoTen);
            this.groupBox1.Controls.Add(this.rdMaSo);
            this.groupBox1.Location = new System.Drawing.Point(17, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 100);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kiểu tìm kiếm";
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Location = new System.Drawing.Point(226, 39);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(114, 17);
            this.rdHoTen.TabIndex = 0;
            this.rdHoTen.Text = "Họ Tên Bệnh Nhân";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // rdMaSo
            // 
            this.rdMaSo.AutoSize = true;
            this.rdMaSo.Checked = true;
            this.rdMaSo.Location = new System.Drawing.Point(133, 39);
            this.rdMaSo.Name = "rdMaSo";
            this.rdMaSo.Size = new System.Drawing.Size(53, 17);
            this.rdMaSo.TabIndex = 0;
            this.rdMaSo.TabStop = true;
            this.rdMaSo.Text = "Mã số";
            this.rdMaSo.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(386, 174);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(108, 39);
            this.btnTimKiem.TabIndex = 36;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txtKeyWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtKeyWord.BackgroundImage")));
            this.txtKeyWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtKeyWord.Font = new System.Drawing.Font("Tahoma", 13F);
            this.txtKeyWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKeyWord.Icon = ((System.Drawing.Image)(resources.GetObject("txtKeyWord.Icon")));
            this.txtKeyWord.Location = new System.Drawing.Point(17, 174);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(362, 39);
            this.txtKeyWord.TabIndex = 35;
            this.txtKeyWord.text = "Enter text";
            this.txtKeyWord.OnTextChange += new System.EventHandler(this.txtKeyWord_OnTextChange);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 342);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridcontrol1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 342);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 388);
            this.panel3.TabIndex = 3;
            // 
            // FormBenhNhan
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBenhNhan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontrol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaysinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaysinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHovaten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSocmnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSodtthannhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHotenthannhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSodienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMabenhnhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridcontrol1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKetthuc;
        private DevExpress.XtraEditors.SimpleButton btnLammoi;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThemmoi;
        private DevExpress.XtraEditors.TextEdit txtHovaten;
        private DevExpress.XtraEditors.TextEdit txtSocmnd;
        private DevExpress.XtraEditors.TextEdit txtSodtthannhan;
        private DevExpress.XtraEditors.TextEdit txtHotenthannhan;
        private DevExpress.XtraEditors.TextEdit txtSodienthoai;
        private DevExpress.XtraEditors.TextEdit txtDiachi;
        private DevExpress.XtraEditors.TextEdit txtMabenhnhan;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtNgaysinh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private Bunifu.Framework.UI.BunifuTextbox txtKeyWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMaSo;
    }
}