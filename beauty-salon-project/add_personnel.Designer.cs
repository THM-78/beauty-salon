namespace beauty_salon_project
{
    partial class add_personnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_personnel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personnelCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makeup_salon_dbDataSet = new beauty_salon_project.makeup_salon_dbDataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gb_userInfo = new System.Windows.Forms.GroupBox();
            this.birthDay_datePicker = new System.Windows.Forms.PersianDatePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saturday_chkBx = new System.Windows.Forms.CheckBox();
            this.sunday_chkBx = new System.Windows.Forms.CheckBox();
            this.monday_chkBx = new System.Windows.Forms.CheckBox();
            this.tuesday_chkBx = new System.Windows.Forms.CheckBox();
            this.wednesday_chkBx = new System.Windows.Forms.CheckBox();
            this.thursday_chkBx = new System.Windows.Forms.CheckBox();
            this.address_txtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mobile_txtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nationalCode_txtBx = new System.Windows.Forms.TextBox();
            this.lastName_txtBx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name_txtBx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.homePicBx = new System.Windows.Forms.PictureBox();
            this.tb_personnelTableAdapter = new beauty_salon_project.makeup_salon_dbDataSetTableAdapters.tb_personnelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpersonnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeup_salon_dbDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gb_userInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personnelCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.nationalCodeDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn,
            this.workDaysDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbpersonnelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 229);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(854, 331);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // personnelCodeDataGridViewTextBoxColumn
            // 
            this.personnelCodeDataGridViewTextBoxColumn.DataPropertyName = "personnelCode";
            this.personnelCodeDataGridViewTextBoxColumn.HeaderText = "کد پرسنلی";
            this.personnelCodeDataGridViewTextBoxColumn.Name = "personnelCodeDataGridViewTextBoxColumn";
            this.personnelCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // nationalCodeDataGridViewTextBoxColumn
            // 
            this.nationalCodeDataGridViewTextBoxColumn.DataPropertyName = "nationalCode";
            this.nationalCodeDataGridViewTextBoxColumn.HeaderText = "کد ملی";
            this.nationalCodeDataGridViewTextBoxColumn.Name = "nationalCodeDataGridViewTextBoxColumn";
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "birthDay";
            this.birthDayDataGridViewTextBoxColumn.HeaderText = "تاریخ تولد";
            this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            // 
            // workDaysDataGridViewTextBoxColumn
            // 
            this.workDaysDataGridViewTextBoxColumn.DataPropertyName = "workDays";
            this.workDaysDataGridViewTextBoxColumn.HeaderText = "روز های کاری";
            this.workDaysDataGridViewTextBoxColumn.Name = "workDaysDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "شماره همراه";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // tbpersonnelBindingSource
            // 
            this.tbpersonnelBindingSource.DataMember = "tb_personnel";
            this.tbpersonnelBindingSource.DataSource = this.makeup_salon_dbDataSet;
            // 
            // makeup_salon_dbDataSet
            // 
            this.makeup_salon_dbDataSet.DataSetName = "makeup_salon_dbDataSet";
            this.makeup_salon_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(854, 27);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoToolTip = false;
            this.toolStripButton3.Image = global::beauty_salon_project.Properties.Resources.submit_ico;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton3.Size = new System.Drawing.Size(50, 24);
            this.toolStripButton3.Text = "ثبت";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoToolTip = false;
            this.toolStripButton4.Image = global::beauty_salon_project.Properties.Resources.edit_ico__1_;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton4.Size = new System.Drawing.Size(67, 24);
            this.toolStripButton4.Text = "ویرایش";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoToolTip = false;
            this.toolStripButton2.Image = global::beauty_salon_project.Properties.Resources.trash_ico;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton2.Size = new System.Drawing.Size(56, 24);
            this.toolStripButton2.Text = "حذف";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoToolTip = false;
            this.toolStripButton1.Image = global::beauty_salon_project.Properties.Resources.cancel_ico;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton1.Size = new System.Drawing.Size(87, 24);
            this.toolStripButton1.Text = "لغو عملیات";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // gb_userInfo
            // 
            this.gb_userInfo.BackColor = System.Drawing.Color.Transparent;
            this.gb_userInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_userInfo.Controls.Add(this.birthDay_datePicker);
            this.gb_userInfo.Controls.Add(this.groupBox1);
            this.gb_userInfo.Controls.Add(this.address_txtBx);
            this.gb_userInfo.Controls.Add(this.label1);
            this.gb_userInfo.Controls.Add(this.mobile_txtBx);
            this.gb_userInfo.Controls.Add(this.label2);
            this.gb_userInfo.Controls.Add(this.label3);
            this.gb_userInfo.Controls.Add(this.label4);
            this.gb_userInfo.Controls.Add(this.nationalCode_txtBx);
            this.gb_userInfo.Controls.Add(this.lastName_txtBx);
            this.gb_userInfo.Controls.Add(this.label6);
            this.gb_userInfo.Controls.Add(this.name_txtBx);
            this.gb_userInfo.Controls.Add(this.label8);
            this.gb_userInfo.Location = new System.Drawing.Point(12, 43);
            this.gb_userInfo.Name = "gb_userInfo";
            this.gb_userInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_userInfo.Size = new System.Drawing.Size(830, 180);
            this.gb_userInfo.TabIndex = 23;
            this.gb_userInfo.TabStop = false;
            this.gb_userInfo.Text = "ثبت اطلاعات آرایشگر";
            // 
            // birthDay_datePicker
            // 
            this.birthDay_datePicker.AutoSize = true;
            this.birthDay_datePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.birthDay_datePicker.BackColor = System.Drawing.Color.White;
            this.birthDay_datePicker.GeorgianDate = null;
            this.birthDay_datePicker.Location = new System.Drawing.Point(478, 124);
            this.birthDay_datePicker.Margin = new System.Windows.Forms.Padding(0);
            this.birthDay_datePicker.Name = "birthDay_datePicker";
            this.birthDay_datePicker.PersianDate.Day = 0;
            this.birthDay_datePicker.PersianDate.Month = 0;
            this.birthDay_datePicker.PersianDate.Year = 0;
            this.birthDay_datePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.birthDay_datePicker.Size = new System.Drawing.Size(248, 21);
            this.birthDay_datePicker.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.saturday_chkBx);
            this.groupBox1.Controls.Add(this.sunday_chkBx);
            this.groupBox1.Controls.Add(this.monday_chkBx);
            this.groupBox1.Controls.Add(this.tuesday_chkBx);
            this.groupBox1.Controls.Add(this.wednesday_chkBx);
            this.groupBox1.Controls.Add(this.thursday_chkBx);
            this.groupBox1.Location = new System.Drawing.Point(48, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(209, 119);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "روزهای کاری:";
            // 
            // saturday_chkBx
            // 
            this.saturday_chkBx.AutoSize = true;
            this.saturday_chkBx.Location = new System.Drawing.Point(140, 29);
            this.saturday_chkBx.Name = "saturday_chkBx";
            this.saturday_chkBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.saturday_chkBx.Size = new System.Drawing.Size(48, 17);
            this.saturday_chkBx.TabIndex = 19;
            this.saturday_chkBx.Text = "شنبه";
            this.saturday_chkBx.UseVisualStyleBackColor = true;
            // 
            // sunday_chkBx
            // 
            this.sunday_chkBx.AutoSize = true;
            this.sunday_chkBx.Location = new System.Drawing.Point(134, 52);
            this.sunday_chkBx.Name = "sunday_chkBx";
            this.sunday_chkBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sunday_chkBx.Size = new System.Drawing.Size(59, 17);
            this.sunday_chkBx.TabIndex = 20;
            this.sunday_chkBx.Text = "یکشنبه";
            this.sunday_chkBx.UseVisualStyleBackColor = true;
            // 
            // monday_chkBx
            // 
            this.monday_chkBx.AutoSize = true;
            this.monday_chkBx.Location = new System.Drawing.Point(132, 75);
            this.monday_chkBx.Name = "monday_chkBx";
            this.monday_chkBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monday_chkBx.Size = new System.Drawing.Size(59, 17);
            this.monday_chkBx.TabIndex = 21;
            this.monday_chkBx.Text = "دوشنبه";
            this.monday_chkBx.UseVisualStyleBackColor = true;
            // 
            // tuesday_chkBx
            // 
            this.tuesday_chkBx.AutoSize = true;
            this.tuesday_chkBx.Location = new System.Drawing.Point(34, 29);
            this.tuesday_chkBx.Name = "tuesday_chkBx";
            this.tuesday_chkBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tuesday_chkBx.Size = new System.Drawing.Size(65, 17);
            this.tuesday_chkBx.TabIndex = 22;
            this.tuesday_chkBx.Text = "سه شنبه";
            this.tuesday_chkBx.UseVisualStyleBackColor = true;
            // 
            // wednesday_chkBx
            // 
            this.wednesday_chkBx.AutoSize = true;
            this.wednesday_chkBx.Location = new System.Drawing.Point(29, 52);
            this.wednesday_chkBx.Name = "wednesday_chkBx";
            this.wednesday_chkBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wednesday_chkBx.Size = new System.Drawing.Size(70, 17);
            this.wednesday_chkBx.TabIndex = 23;
            this.wednesday_chkBx.Text = "چهارشنبه";
            this.wednesday_chkBx.UseVisualStyleBackColor = true;
            // 
            // thursday_chkBx
            // 
            this.thursday_chkBx.AutoSize = true;
            this.thursday_chkBx.Location = new System.Drawing.Point(36, 75);
            this.thursday_chkBx.Name = "thursday_chkBx";
            this.thursday_chkBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.thursday_chkBx.Size = new System.Drawing.Size(63, 17);
            this.thursday_chkBx.TabIndex = 24;
            this.thursday_chkBx.Text = "پنجشنبه";
            this.thursday_chkBx.UseVisualStyleBackColor = true;
            // 
            // address_txtBx
            // 
            this.address_txtBx.Location = new System.Drawing.Point(293, 86);
            this.address_txtBx.Multiline = true;
            this.address_txtBx.Name = "address_txtBx";
            this.address_txtBx.Size = new System.Drawing.Size(135, 59);
            this.address_txtBx.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(729, 37);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام:";
            // 
            // mobile_txtBx
            // 
            this.mobile_txtBx.Location = new System.Drawing.Point(293, 36);
            this.mobile_txtBx.Name = "mobile_txtBx";
            this.mobile_txtBx.Size = new System.Drawing.Size(135, 20);
            this.mobile_txtBx.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(729, 67);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(729, 97);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "کد ملی:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(729, 127);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "تاریخ تولد:";
            // 
            // nationalCode_txtBx
            // 
            this.nationalCode_txtBx.Location = new System.Drawing.Point(587, 94);
            this.nationalCode_txtBx.Name = "nationalCode_txtBx";
            this.nationalCode_txtBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nationalCode_txtBx.Size = new System.Drawing.Size(135, 20);
            this.nationalCode_txtBx.TabIndex = 12;
            // 
            // lastName_txtBx
            // 
            this.lastName_txtBx.Location = new System.Drawing.Point(587, 64);
            this.lastName_txtBx.Name = "lastName_txtBx";
            this.lastName_txtBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lastName_txtBx.Size = new System.Drawing.Size(135, 20);
            this.lastName_txtBx.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(435, 37);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "شماره همراه:";
            // 
            // name_txtBx
            // 
            this.name_txtBx.Location = new System.Drawing.Point(587, 34);
            this.name_txtBx.Name = "name_txtBx";
            this.name_txtBx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txtBx.Size = new System.Drawing.Size(135, 20);
            this.name_txtBx.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(435, 90);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "آدرس:";
            // 
            // homePicBx
            // 
            this.homePicBx.Image = ((System.Drawing.Image)(resources.GetObject("homePicBx.Image")));
            this.homePicBx.Location = new System.Drawing.Point(12, 4);
            this.homePicBx.Name = "homePicBx";
            this.homePicBx.Size = new System.Drawing.Size(38, 41);
            this.homePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.homePicBx.TabIndex = 24;
            this.homePicBx.TabStop = false;
            this.homePicBx.Click += new System.EventHandler(this.homePicBx_Click);
            // 
            // tb_personnelTableAdapter
            // 
            this.tb_personnelTableAdapter.ClearBeforeFill = true;
            // 
            // add_personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.homePicBx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gb_userInfo);
            this.Name = "add_personnel";
            this.Text = "add_personnel";
            this.Load += new System.EventHandler(this.add_personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpersonnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeup_salon_dbDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gb_userInfo.ResumeLayout(false);
            this.gb_userInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePicBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox homePicBx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox gb_userInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox saturday_chkBx;
        private System.Windows.Forms.CheckBox sunday_chkBx;
        private System.Windows.Forms.CheckBox monday_chkBx;
        private System.Windows.Forms.CheckBox tuesday_chkBx;
        private System.Windows.Forms.CheckBox wednesday_chkBx;
        private System.Windows.Forms.CheckBox thursday_chkBx;
        private System.Windows.Forms.TextBox address_txtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mobile_txtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nationalCode_txtBx;
        private System.Windows.Forms.TextBox lastName_txtBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_txtBx;
        private System.Windows.Forms.Label label8;
        private makeup_salon_dbDataSet makeup_salon_dbDataSet;
        private System.Windows.Forms.BindingSource tbpersonnelBindingSource;
        private makeup_salon_dbDataSetTableAdapters.tb_personnelTableAdapter tb_personnelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.PersianDatePicker birthDay_datePicker;
    }
}