using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DriverInstaller
{
    public partial class Form1 : Form
    {
        public string _FilepathSel, _Floderpath, _InstallerExeFile, _DeviceName, _ZipPath, _Unzipto = null;
        public DataTable dt;
        public string[] _StrFilter = { "wifi", "bt", "wlan", "bluetooth"};
        public BackgroundWorker backgroundWorker;
        public Form1()
        {
            InitializeComponent();
            //Create Data table
            dt = new DataTable("Driverlist");
            dt.Columns.Add("ItemNumber", typeof(Byte));
            dt.Columns.Add("DriverPath", typeof(String));
            //Arrange file path length
            dt.Columns["ItemNumber"].Unique = true;
            dt.Columns["DriverPath"].MaxLength = 1000;
            dt.Columns["DriverPath"].AllowDBNull = false;

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
        }
        //Get Zip File Path function
        private string _GetFilePath(string _FilterType, string _InitialDirectory)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (_FilterType == "zip")
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    dialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
                }
                dialog.Filter = "Zip files (*.zip)| *.zip";
            }
            else
            {
                dialog.Filter = "Installer files (*.exe; *.msi)| *.exe; *.msi";
                dialog.InitialDirectory = _InitialDirectory;
            }
                        
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               return dialog.FileName;
            }
            return null;
        }
        //Unzip file to folder
        private void _UnzipFileTo(string source, string destination)
        {
            if (Directory.Exists(destination))
            {
                Directory.Delete(destination, true);
            }
            ZipFile.ExtractToDirectory(source, destination);
        }

        //Install driver via execution file
        private void _InstallDriver (string _ExeLocation)
        {
            if (File.Exists(_ExeLocation + "\\setup.exe"))
            {
                _InstallerExeFile = _ExeLocation+"\\setup.exe";              
            }

            else if (File.Exists(_ExeLocation + "\\install.exe"))
            {
                _InstallerExeFile = _ExeLocation + "\\install.exe";
            }

            else
            {
                do
                {
                    _InstallerExeFile = _GetFilePath("exe", _Unzipto);
                    if (_InstallerExeFile == null)
                        MessageBox.Show("Please select Installer!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                while (_InstallerExeFile == null);
            }
            label_ProcessStatus.Text = "Installing " + _DeviceName + " driver";
            MessageBox.Show(_InstallerExeFile);
            //Process.Start(_InstallerExeFile, "/?");
        }

        //Hide button and lab while working
        private void _BadUserDefander()
        {
            btn_add.Visible = !btn_add.Visible;
            btn_sel.Visible = !btn_sel.Visible;
            btn_Start.Visible = !btn_Start.Visible;
            lab_ReadMe.Visible = !lab_ReadMe.Visible;
            text_FilePatSel.Visible = !text_FilePatSel.Visible;
            pictureBox_processing.Visible = !pictureBox_processing.Visible;
            label_ProcessStatus.Visible = !label_ProcessStatus.Visible;
            label_ProcessStatus.Text = "Unzipping " + _DeviceName + " driver";
        }
        //------ Button Event ------ 

        //Select zip file(Select Button)
        private void btn_sel_Click(object sender, EventArgs e)
        {
            _FilepathSel = _GetFilePath("zip", "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}");
            if (_FilepathSel != null)
            {
                _FilepathSel = _FilepathSel.ToLower();
                text_FilePatSel.Text = _FilepathSel;
            }
            
        }
        
        //Delete driver in list(Datagrid Delete Button)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        //Add zip file path in list(Add Button)
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (_FilepathSel != null)
            {
                DataGridViewRowCollection row = dataGridView1.Rows;
                //Get device naem from _FilepathSel
                _Floderpath = Path.GetFileName(Path.GetDirectoryName(_FilepathSel));
                //Add select zip into Datagrid
                row.Add(new object[] { _Floderpath, _FilepathSel, "Del" });
                _FilepathSel = text_FilePatSel.Text = null;
                return;
            }
            //Shows error message if not select file before click add button
            MessageBox.Show("Didn't select any file!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Start to install(Start Button)
        private void btn_Start_Click(object sender, EventArgs e)
        {
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.RunWorkerAsync();
        }

        public void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker.ReportProgress(0);
            try
            {
                _DeviceName = dataGridView1.Rows[0].Cells[0].Value.ToString();
                _ZipPath = dataGridView1.Rows[0].Cells[1].Value.ToString();
                _Unzipto = Path.GetDirectoryName(_ZipPath) + "\\" + Path.GetFileNameWithoutExtension(_ZipPath);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("The list is empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _UnzipFileTo(_ZipPath, _Unzipto);
            _InstallDriver(_Unzipto);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _BadUserDefander();
        }
        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _BadUserDefander();
        }
    }
}
