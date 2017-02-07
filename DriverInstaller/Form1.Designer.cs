using DriverInstaller.Functions;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_processing = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item_Dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Del = new DriverInstaller.Functions.DataGridViewDisableButtonColumn();
            this.label_List = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label_ProcessStatus = new System.Windows.Forms.Label();
            this.chkBox1_DefPar = new System.Windows.Forms.CheckBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_sel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.text_FilePatSel = new System.Windows.Forms.TextBox();
            this.lab_ReadMe = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewDisableButtonColumn1 = new DriverInstaller.Functions.DataGridViewDisableButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_processing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_processing
            // 
            this.pictureBox_processing.ErrorImage = null;
            this.pictureBox_processing.Image = global::DriverInstaller.Properties.Resources.oie_5173511yFNPNZCI;
            this.pictureBox_processing.Location = new System.Drawing.Point(247, 3);
            this.pictureBox_processing.Name = "pictureBox_processing";
            this.pictureBox_processing.Size = new System.Drawing.Size(102, 87);
            this.pictureBox_processing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_processing.TabIndex = 1;
            this.pictureBox_processing.TabStop = false;
            this.pictureBox_processing.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Dev,
            this.Item_Path,
            this.parameter,
            this.Del});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(533, 145);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Item_Dev
            // 
            this.Item_Dev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Dev.HeaderText = "Device";
            this.Item_Dev.MinimumWidth = 100;
            this.Item_Dev.Name = "Item_Dev";
            this.Item_Dev.ReadOnly = true;
            this.Item_Dev.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Item_Dev.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Item_Path
            // 
            this.Item_Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Path.HeaderText = "Path";
            this.Item_Path.MinimumWidth = 300;
            this.Item_Path.Name = "Item_Path";
            this.Item_Path.ReadOnly = true;
            this.Item_Path.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // parameter
            // 
            this.parameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parameter.HeaderText = "Parameter";
            this.parameter.MinimumWidth = 80;
            this.parameter.Name = "parameter";
            this.parameter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.parameter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Del
            // 
            this.Del.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Del.HeaderText = "Del";
            this.Del.MinimumWidth = 50;
            this.Del.Name = "Del";
            // 
            // label_List
            // 
            this.label_List.AutoSize = true;
            this.label_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_List.Location = new System.Drawing.Point(0, 0);
            this.label_List.Name = "label_List";
            this.label_List.Size = new System.Drawing.Size(93, 17);
            this.label_List.TabIndex = 7;
            this.label_List.Text = "Selected List:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label_List);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(10, 113);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(533, 21);
            this.panel10.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label_ProcessStatus);
            this.panel9.Controls.Add(this.chkBox1_DefPar);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(10, 93);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(533, 20);
            this.panel9.TabIndex = 12;
            // 
            // label_ProcessStatus
            // 
            this.label_ProcessStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ProcessStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProcessStatus.Location = new System.Drawing.Point(0, 0);
            this.label_ProcessStatus.Name = "label_ProcessStatus";
            this.label_ProcessStatus.Size = new System.Drawing.Size(370, 20);
            this.label_ProcessStatus.TabIndex = 6;
            this.label_ProcessStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ProcessStatus.Visible = false;
            // 
            // chkBox1_DefPar
            // 
            this.chkBox1_DefPar.AutoSize = true;
            this.chkBox1_DefPar.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkBox1_DefPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox1_DefPar.Location = new System.Drawing.Point(370, 0);
            this.chkBox1_DefPar.Name = "chkBox1_DefPar";
            this.chkBox1_DefPar.Size = new System.Drawing.Size(163, 20);
            this.chkBox1_DefPar.TabIndex = 0;
            this.chkBox1_DefPar.Text = "Set parameter to \"-s\".";
            this.chkBox1_DefPar.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(458, 5);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_Start);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(10, 279);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel8.Size = new System.Drawing.Size(533, 33);
            this.panel8.TabIndex = 18;
            // 
            // btn_sel
            // 
            this.btn_sel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sel.Location = new System.Drawing.Point(383, 5);
            this.btn_sel.Margin = new System.Windows.Forms.Padding(10);
            this.btn_sel.Name = "btn_sel";
            this.btn_sel.Size = new System.Drawing.Size(75, 25);
            this.btn_sel.TabIndex = 0;
            this.btn_sel.Text = "Select";
            this.btn_sel.UseVisualStyleBackColor = true;
            this.btn_sel.Click += new System.EventHandler(this.btn_sel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(458, 5);
            this.btn_add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 25);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.text_FilePatSel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(533, 22);
            this.panel6.TabIndex = 16;
            // 
            // text_FilePatSel
            // 
            this.text_FilePatSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_FilePatSel.Location = new System.Drawing.Point(0, 0);
            this.text_FilePatSel.Name = "text_FilePatSel";
            this.text_FilePatSel.Size = new System.Drawing.Size(533, 20);
            this.text_FilePatSel.TabIndex = 1;
            // 
            // lab_ReadMe
            // 
            this.lab_ReadMe.AutoSize = true;
            this.lab_ReadMe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_ReadMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab_ReadMe.Location = new System.Drawing.Point(0, 0);
            this.lab_ReadMe.Name = "lab_ReadMe";
            this.lab_ReadMe.Size = new System.Drawing.Size(356, 20);
            this.lab_ReadMe.TabIndex = 0;
            this.lab_ReadMe.Text = "Click \"Select\" to select driver zip, then click \"Add\".";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_sel);
            this.panel7.Controls.Add(this.btn_add);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(10, 36);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panel7.Size = new System.Drawing.Size(533, 35);
            this.panel7.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lab_ReadMe);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(533, 26);
            this.panel5.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 10);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(543, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 312);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 312);
            this.panel1.TabIndex = 10;
            // 
            // dataGridViewDisableButtonColumn1
            // 
            this.dataGridViewDisableButtonColumn1.HeaderText = "Del";
            this.dataGridViewDisableButtonColumn1.Name = "dataGridViewDisableButtonColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(553, 312);
            this.Controls.Add(this.pictureBox_processing);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(569, 351);
            this.Name = "Form1";
            this.Text = "Driver Installer 1.10 by Kuanyu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_processing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_processing;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_List;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.CheckBox chkBox1_DefPar;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label_ProcessStatus;
        private System.Windows.Forms.Button btn_sel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox text_FilePatSel;
        private System.Windows.Forms.Label lab_ReadMe;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DataGridViewDisableButtonColumn dataGridViewDisableButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameter;
        private DataGridViewDisableButtonColumn Del;
    }
}

