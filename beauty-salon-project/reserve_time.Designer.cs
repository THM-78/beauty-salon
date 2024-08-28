namespace beauty_salon_project
{
    partial class reserve_time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reserve_time));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.reserveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subscription_txtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneNumber_txtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastName_txtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_txtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.homePicBx = new System.Windows.Forms.PictureBox();
            this.mainDataSet = new beauty_salon_project.mainDataSet();
            this.tbpersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_personnelTableAdapter = new beauty_salon_project.mainDataSetTableAdapters.tb_personnelTableAdapter();
            this.personnelCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edittingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpersonnelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "شماره اشتراک:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.reserveBtn);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(20, 177);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(751, 367);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب آرایشگر و سرویس";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 302);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // reserveBtn
            // 
            this.reserveBtn.Location = new System.Drawing.Point(219, 302);
            this.reserveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(135, 39);
            this.reserveBtn.TabIndex = 9;
            this.reserveBtn.Text = "رزرو کردن نوبت";
            this.reserveBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personnelCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.nationalCodeDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn,
            this.workDaysDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.employeDateDataGridViewTextBoxColumn,
            this.edittingDateDataGridViewTextBoxColumn,
            this.adminIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbpersonnelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(80, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(598, 207);
            this.dataGridView1.TabIndex = 27;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 41);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "ساعت:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(265, 41);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "تاریخ:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(512, 41);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 20);
            this.textBox5.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "نام آرایشگر:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subscription_txtBx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.phoneNumber_txtBx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lastName_txtBx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name_txtBx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(812, 63);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات مشتری";
            // 
            // subscription_txtBx
            // 
            this.subscription_txtBx.Location = new System.Drawing.Point(30, 24);
            this.subscription_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.subscription_txtBx.Name = "subscription_txtBx";
            this.subscription_txtBx.Size = new System.Drawing.Size(108, 20);
            this.subscription_txtBx.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "شماره اشتراک:";
            // 
            // phoneNumber_txtBx
            // 
            this.phoneNumber_txtBx.Location = new System.Drawing.Point(225, 24);
            this.phoneNumber_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNumber_txtBx.Name = "phoneNumber_txtBx";
            this.phoneNumber_txtBx.Size = new System.Drawing.Size(108, 20);
            this.phoneNumber_txtBx.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "شماره تلفن:";
            // 
            // lastName_txtBx
            // 
            this.lastName_txtBx.Location = new System.Drawing.Point(409, 24);
            this.lastName_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.lastName_txtBx.Name = "lastName_txtBx";
            this.lastName_txtBx.Size = new System.Drawing.Size(108, 20);
            this.lastName_txtBx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "نام خانوادگی:";
            // 
            // name_txtBx
            // 
            this.name_txtBx.Location = new System.Drawing.Point(595, 24);
            this.name_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.name_txtBx.Name = "name_txtBx";
            this.name_txtBx.Size = new System.Drawing.Size(108, 20);
            this.name_txtBx.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "نام:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 19);
            this.button1.TabIndex = 30;
            this.button1.Text = "جستجو";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 29;
            // 
            // homePicBx
            // 
            this.homePicBx.Image = ((System.Drawing.Image)(resources.GetObject("homePicBx.Image")));
            this.homePicBx.Location = new System.Drawing.Point(797, 17);
            this.homePicBx.Name = "homePicBx";
            this.homePicBx.Size = new System.Drawing.Size(38, 41);
            this.homePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.homePicBx.TabIndex = 32;
            this.homePicBx.TabStop = false;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "mainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbpersonnelBindingSource
            // 
            this.tbpersonnelBindingSource.DataMember = "tb_personnel";
            this.tbpersonnelBindingSource.DataSource = this.mainDataSet;
            // 
            // tb_personnelTableAdapter
            // 
            this.tb_personnelTableAdapter.ClearBeforeFill = true;
            // 
            // personnelCodeDataGridViewTextBoxColumn
            // 
            this.personnelCodeDataGridViewTextBoxColumn.DataPropertyName = "personnelCode";
            this.personnelCodeDataGridViewTextBoxColumn.HeaderText = "personnelCode";
            this.personnelCodeDataGridViewTextBoxColumn.Name = "personnelCodeDataGridViewTextBoxColumn";
            this.personnelCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // nationalCodeDataGridViewTextBoxColumn
            // 
            this.nationalCodeDataGridViewTextBoxColumn.DataPropertyName = "nationalCode";
            this.nationalCodeDataGridViewTextBoxColumn.HeaderText = "nationalCode";
            this.nationalCodeDataGridViewTextBoxColumn.Name = "nationalCodeDataGridViewTextBoxColumn";
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "birthDay";
            this.birthDayDataGridViewTextBoxColumn.HeaderText = "birthDay";
            this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            // 
            // workDaysDataGridViewTextBoxColumn
            // 
            this.workDaysDataGridViewTextBoxColumn.DataPropertyName = "workDays";
            this.workDaysDataGridViewTextBoxColumn.HeaderText = "workDays";
            this.workDaysDataGridViewTextBoxColumn.Name = "workDaysDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // employeDateDataGridViewTextBoxColumn
            // 
            this.employeDateDataGridViewTextBoxColumn.DataPropertyName = "employeDate";
            this.employeDateDataGridViewTextBoxColumn.HeaderText = "employeDate";
            this.employeDateDataGridViewTextBoxColumn.Name = "employeDateDataGridViewTextBoxColumn";
            // 
            // edittingDateDataGridViewTextBoxColumn
            // 
            this.edittingDateDataGridViewTextBoxColumn.DataPropertyName = "edittingDate";
            this.edittingDateDataGridViewTextBoxColumn.HeaderText = "edittingDate";
            this.edittingDateDataGridViewTextBoxColumn.Name = "edittingDateDataGridViewTextBoxColumn";
            // 
            // adminIdDataGridViewTextBoxColumn
            // 
            this.adminIdDataGridViewTextBoxColumn.DataPropertyName = "adminId";
            this.adminIdDataGridViewTextBoxColumn.HeaderText = "adminId";
            this.adminIdDataGridViewTextBoxColumn.Name = "adminIdDataGridViewTextBoxColumn";
            // 
            // reserve_time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.homePicBx);
            this.Name = "reserve_time";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رزرو وقت آرایشگاه";
            this.Load += new System.EventHandler(this.reserve_time_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpersonnelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button reserveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox subscription_txtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneNumber_txtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastName_txtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_txtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox homePicBx;
        private mainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource tbpersonnelBindingSource;
        private mainDataSetTableAdapters.tb_personnelTableAdapter tb_personnelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edittingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIdDataGridViewTextBoxColumn;
    }
}