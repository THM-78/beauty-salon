namespace beauty_salon_project
{
    partial class add_services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_services));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_submit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_canceled = new System.Windows.Forms.ToolStripButton();
            this.homePicBx = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_submitServices = new System.Windows.Forms.GroupBox();
            this.timeTextBx = new System.Windows.Forms.TextBox();
            this.stylistTextBx = new System.Windows.Forms.TextBox();
            this.priceTextBx = new System.Windows.Forms.TextBox();
            this.serviceNameTextBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.makeup_salon_dbDataSet = new beauty_salon_project.makeup_salon_dbDataSet();
            this.tbservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_servicesTableAdapter = new beauty_salon_project.makeup_salon_dbDataSetTableAdapters.tb_servicesTableAdapter();
            this.serviceCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_submitServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makeup_salon_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbservicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_submit,
            this.toolStripSeparator1,
            this.toolStripButton_edit,
            this.toolStripSeparator3,
            this.toolStripButton_delete,
            this.toolStripSeparator2,
            this.toolStripButton_canceled});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(854, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_submit
            // 
            this.toolStripButton_submit.AutoToolTip = false;
            this.toolStripButton_submit.Image = global::beauty_salon_project.Properties.Resources.submit_ico;
            this.toolStripButton_submit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_submit.Name = "toolStripButton_submit";
            this.toolStripButton_submit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton_submit.Size = new System.Drawing.Size(50, 24);
            this.toolStripButton_submit.Text = "ثبت";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_edit
            // 
            this.toolStripButton_edit.AutoToolTip = false;
            this.toolStripButton_edit.Image = global::beauty_salon_project.Properties.Resources.edit_ico__1_;
            this.toolStripButton_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_edit.Name = "toolStripButton_edit";
            this.toolStripButton_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton_edit.Size = new System.Drawing.Size(67, 24);
            this.toolStripButton_edit.Text = "ویرایش";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_delete
            // 
            this.toolStripButton_delete.AutoToolTip = false;
            this.toolStripButton_delete.Image = global::beauty_salon_project.Properties.Resources.trash_ico;
            this.toolStripButton_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_delete.Name = "toolStripButton_delete";
            this.toolStripButton_delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton_delete.Size = new System.Drawing.Size(56, 24);
            this.toolStripButton_delete.Text = "حذف";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_canceled
            // 
            this.toolStripButton_canceled.AutoToolTip = false;
            this.toolStripButton_canceled.Image = global::beauty_salon_project.Properties.Resources.cancel_ico;
            this.toolStripButton_canceled.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_canceled.Name = "toolStripButton_canceled";
            this.toolStripButton_canceled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton_canceled.Size = new System.Drawing.Size(87, 24);
            this.toolStripButton_canceled.Text = "لغو عملیات";
            // 
            // homePicBx
            // 
            this.homePicBx.Image = ((System.Drawing.Image)(resources.GetObject("homePicBx.Image")));
            this.homePicBx.Location = new System.Drawing.Point(786, 5);
            this.homePicBx.Name = "homePicBx";
            this.homePicBx.Size = new System.Drawing.Size(38, 41);
            this.homePicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.homePicBx.TabIndex = 22;
            this.homePicBx.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceCodeDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.timeSpendDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.adminIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbservicesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(360, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(481, 300);
            this.dataGridView1.TabIndex = 25;
            // 
            // gb_submitServices
            // 
            this.gb_submitServices.Controls.Add(this.timeTextBx);
            this.gb_submitServices.Controls.Add(this.stylistTextBx);
            this.gb_submitServices.Controls.Add(this.priceTextBx);
            this.gb_submitServices.Controls.Add(this.serviceNameTextBx);
            this.gb_submitServices.Controls.Add(this.label4);
            this.gb_submitServices.Controls.Add(this.label3);
            this.gb_submitServices.Controls.Add(this.label2);
            this.gb_submitServices.Controls.Add(this.label1);
            this.gb_submitServices.Location = new System.Drawing.Point(13, 128);
            this.gb_submitServices.Margin = new System.Windows.Forms.Padding(2);
            this.gb_submitServices.Name = "gb_submitServices";
            this.gb_submitServices.Padding = new System.Windows.Forms.Padding(2);
            this.gb_submitServices.Size = new System.Drawing.Size(342, 305);
            this.gb_submitServices.TabIndex = 24;
            this.gb_submitServices.TabStop = false;
            this.gb_submitServices.Text = "ثبت خدمات";
            // 
            // timeTextBx
            // 
            this.timeTextBx.Location = new System.Drawing.Point(184, 220);
            this.timeTextBx.Margin = new System.Windows.Forms.Padding(2);
            this.timeTextBx.Name = "timeTextBx";
            this.timeTextBx.Size = new System.Drawing.Size(135, 20);
            this.timeTextBx.TabIndex = 4;
            // 
            // stylistTextBx
            // 
            this.stylistTextBx.Location = new System.Drawing.Point(184, 164);
            this.stylistTextBx.Margin = new System.Windows.Forms.Padding(2);
            this.stylistTextBx.Name = "stylistTextBx";
            this.stylistTextBx.Size = new System.Drawing.Size(135, 20);
            this.stylistTextBx.TabIndex = 3;
            // 
            // priceTextBx
            // 
            this.priceTextBx.Location = new System.Drawing.Point(184, 106);
            this.priceTextBx.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBx.Name = "priceTextBx";
            this.priceTextBx.Size = new System.Drawing.Size(135, 20);
            this.priceTextBx.TabIndex = 2;
            // 
            // serviceNameTextBx
            // 
            this.serviceNameTextBx.Location = new System.Drawing.Point(184, 53);
            this.serviceNameTextBx.Margin = new System.Windows.Forms.Padding(2);
            this.serviceNameTextBx.Name = "serviceNameTextBx";
            this.serviceNameTextBx.Size = new System.Drawing.Size(135, 20);
            this.serviceNameTextBx.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "زمان مورد نیاز (به دقیقه):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "آرایشگر:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "قیمت:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان خدمات:";
            // 
            // makeup_salon_dbDataSet
            // 
            this.makeup_salon_dbDataSet.DataSetName = "makeup_salon_dbDataSet";
            this.makeup_salon_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbservicesBindingSource
            // 
            this.tbservicesBindingSource.DataMember = "tb_services";
            this.tbservicesBindingSource.DataSource = this.makeup_salon_dbDataSet;
            // 
            // tb_servicesTableAdapter
            // 
            this.tb_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // serviceCodeDataGridViewTextBoxColumn
            // 
            this.serviceCodeDataGridViewTextBoxColumn.DataPropertyName = "serviceCode";
            this.serviceCodeDataGridViewTextBoxColumn.HeaderText = "serviceCode";
            this.serviceCodeDataGridViewTextBoxColumn.Name = "serviceCodeDataGridViewTextBoxColumn";
            this.serviceCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "serviceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "serviceName";
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // timeSpendDataGridViewTextBoxColumn
            // 
            this.timeSpendDataGridViewTextBoxColumn.DataPropertyName = "timeSpend";
            this.timeSpendDataGridViewTextBoxColumn.HeaderText = "timeSpend";
            this.timeSpendDataGridViewTextBoxColumn.Name = "timeSpendDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // adminIdDataGridViewTextBoxColumn
            // 
            this.adminIdDataGridViewTextBoxColumn.DataPropertyName = "adminId";
            this.adminIdDataGridViewTextBoxColumn.HeaderText = "adminId";
            this.adminIdDataGridViewTextBoxColumn.Name = "adminIdDataGridViewTextBoxColumn";
            // 
            // add_services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_submitServices);
            this.Controls.Add(this.homePicBx);
            this.Controls.Add(this.toolStrip1);
            this.Name = "add_services";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ثبت خدمات";
            this.Load += new System.EventHandler(this.add_services_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_submitServices.ResumeLayout(false);
            this.gb_submitServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makeup_salon_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbservicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_submit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_canceled;
        private System.Windows.Forms.PictureBox homePicBx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_submitServices;
        private System.Windows.Forms.TextBox timeTextBx;
        private System.Windows.Forms.TextBox stylistTextBx;
        private System.Windows.Forms.TextBox priceTextBx;
        private System.Windows.Forms.TextBox serviceNameTextBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private makeup_salon_dbDataSet makeup_salon_dbDataSet;
        private System.Windows.Forms.BindingSource tbservicesBindingSource;
        private makeup_salon_dbDataSetTableAdapters.tb_servicesTableAdapter tb_servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSpendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIdDataGridViewTextBoxColumn;
    }
}