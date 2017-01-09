namespace DriverInstaller
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_ReadMe = new System.Windows.Forms.Label();
            this.btn_sel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.text_FilePatSel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item_Dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Start = new System.Windows.Forms.Button();
            this.pictureBox_processing = new System.Windows.Forms.PictureBox();
            this.label_ProcessStatus = new System.Windows.Forms.Label();
            this.label_List = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_processing)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_ReadMe
            // 
            this.lab_ReadMe.AutoSize = true;
            this.lab_ReadMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ReadMe.Location = new System.Drawing.Point(12, 18);
            this.lab_ReadMe.Name = "lab_ReadMe";
            this.lab_ReadMe.Size = new System.Drawing.Size(356, 20);
            this.lab_ReadMe.TabIndex = 0;
            this.lab_ReadMe.Text = "Click \"Select\" to select driver zip, then click \"Add\".";
            // 
            // btn_sel
            // 
            this.btn_sel.Location = new System.Drawing.Point(315, 76);
            this.btn_sel.Name = "btn_sel";
            this.btn_sel.Size = new System.Drawing.Size(75, 23);
            this.btn_sel.TabIndex = 1;
            this.btn_sel.Text = "Select";
            this.btn_sel.UseVisualStyleBackColor = true;
            this.btn_sel.Click += new System.EventHandler(this.btn_sel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(396, 76);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // text_FilePatSel
            // 
            this.text_FilePatSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_FilePatSel.Location = new System.Drawing.Point(9, 44);
            this.text_FilePatSel.Name = "text_FilePatSel";
            this.text_FilePatSel.ReadOnly = true;
            this.text_FilePatSel.Size = new System.Drawing.Size(463, 23);
            this.text_FilePatSel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Dev,
            this.Item_Path,
            this.Item_Del});
            this.dataGridView1.Location = new System.Drawing.Point(9, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Item_Dev
            // 
            this.Item_Dev.HeaderText = "Device";
            this.Item_Dev.Name = "Item_Dev";
            this.Item_Dev.ReadOnly = true;
            // 
            // Item_Path
            // 
            this.Item_Path.HeaderText = "Path";
            this.Item_Path.Name = "Item_Path";
            this.Item_Path.ReadOnly = true;
            this.Item_Path.Width = 290;
            // 
            // Item_Del
            // 
            this.Item_Del.HeaderText = "Del";
            this.Item_Del.Name = "Item_Del";
            this.Item_Del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Item_Del.Width = 30;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(396, 284);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // pictureBox_processing
            // 
            this.pictureBox_processing.Image = global::DriverInstaller.Properties.Resources.oie_5173511yFNPNZCI;
            this.pictureBox_processing.Location = new System.Drawing.Point(196, -1);
            this.pictureBox_processing.Name = "pictureBox_processing";
            this.pictureBox_processing.Size = new System.Drawing.Size(104, 85);
            this.pictureBox_processing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_processing.TabIndex = 0;
            this.pictureBox_processing.TabStop = false;
            this.pictureBox_processing.Visible = false;
            // 
            // label_ProcessStatus
            // 
            this.label_ProcessStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProcessStatus.Location = new System.Drawing.Point(111, 87);
            this.label_ProcessStatus.Name = "label_ProcessStatus";
            this.label_ProcessStatus.Size = new System.Drawing.Size(262, 24);
            this.label_ProcessStatus.TabIndex = 5;
            this.label_ProcessStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ProcessStatus.Visible = false;
            // 
            // label_List
            // 
            this.label_List.AutoSize = true;
            this.label_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_List.Location = new System.Drawing.Point(12, 110);
            this.label_List.Name = "label_List";
            this.label_List.Size = new System.Drawing.Size(93, 17);
            this.label_List.TabIndex = 6;
            this.label_List.Text = "Selected List:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(481, 312);
            this.Controls.Add(this.label_List);
            this.Controls.Add(this.label_ProcessStatus);
            this.Controls.Add(this.pictureBox_processing);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_FilePatSel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_sel);
            this.Controls.Add(this.lab_ReadMe);
            this.MaximumSize = new System.Drawing.Size(497, 351);
            this.MinimumSize = new System.Drawing.Size(497, 351);
            this.Name = "Form1";
            this.Text = "Driver Installer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_processing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_ReadMe;
        private System.Windows.Forms.Button btn_sel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox text_FilePatSel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Path;
        private System.Windows.Forms.DataGridViewButtonColumn Item_Del;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.PictureBox pictureBox_processing;
        private System.Windows.Forms.Label label_ProcessStatus;
        private System.Windows.Forms.Label label_List;
    }
}

