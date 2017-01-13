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
        static string _FilepathSel, _Floderpath, _InstallerExeFile, _Parameter, _ZipPath, _Unzipto = null;
        int _ReturnCode = 0;
        static bool _MainThread = true;
        public string[] _StrFilter = { "wifi", "bt", "wlan", "bluetooth", "intel", "nv", "nvidia"};
        public BackgroundWorker backgroundWorker;
        Form2 _ResultForm = new Form2();
        public Form1()
        {
            InitializeComponent();
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
        private string _UnzipFileTo(string source, string destination)
        {
            if (Directory.Exists(destination))
            {
                Directory.Delete(destination, true);
            }

            try
            {
                ZipFile.ExtractToDirectory(source, destination);
                return "Pass";
            }
            
            catch(System.IO.InvalidDataException)
            {
                MessageBox.Show(source +" Not able to unzip ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }

        //Install driver via execution file
        private void _GetInstallerPath (string _ExeLocation)
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
        }

        //Hide button and lab while working
        private void _BadUserDefander(bool _switch)
        {
             btn_add.Visible = !_switch;
             btn_sel.Visible = !_switch;
             btn_Start.Visible = !_switch;
             lab_ReadMe.Visible = !_switch;
             text_FilePatSel.Visible = !_switch;
             pictureBox_processing.Visible = _switch;
             label_ProcessStatus.Visible = _switch;
             dataGridView1.Columns["Item_Del"].Visible = !_switch;
        }

        //Check Return Code
        private string _ReturnCodeCheck(int _ReturnCode)
        {
            if (_ReturnCode == 0)
            {
                return "Sucess";
            }

            else
            {
                return "Fail!! ReturnCode:" + _ReturnCode;
            }
        }

        //Save result to report
        private void _SaveResult(string device, string status)
        {
            Form2._CreateLabel(device, status);
        }

        public void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker.ReportProgress(0);
            while (dataGridView1.RowCount != 0)
            {
                try
                {
                    _ZipPath = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    _Parameter = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    _Unzipto = Path.GetDirectoryName(_ZipPath) + "\\" + Path.GetFileNameWithoutExtension(_ZipPath);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("The list is empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _MainThread = true;
                backgroundWorker.ReportProgress(1);
                while (_MainThread == true);

                //Stop installer if unzip failed
                if (_UnzipFileTo(_ZipPath, _Unzipto) == "Error")
                {
                    return;
                }
                _MainThread = true;
                backgroundWorker.ReportProgress(2);
                while (_MainThread == true);

                _MainThread = true;
                backgroundWorker.ReportProgress(3);
                while (_MainThread == true);

                try
                {
                    Process _installer = Process.Start(_InstallerExeFile, _Parameter);
                    _installer.WaitForExit();
                    _ReturnCode = _installer.ExitCode;
                }

                catch (System.ComponentModel.Win32Exception)
                {
                    _ReturnCode = 1223;
                }
                
                _InstallerExeFile = null;
                _MainThread = true;
                backgroundWorker.ReportProgress(4);
                while (_MainThread == true);
            }

            _MainThread = true;
            backgroundWorker.ReportProgress(5);
            while (_MainThread == true) ;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                _BadUserDefander(true);
                label_ProcessStatus.Text = "Unzipping " + _Floderpath + " driver";
                _MainThread = false;
            }

            else if (e.ProgressPercentage == 2)
            {
                _GetInstallerPath(_Unzipto);
                _MainThread = false;
                label_ProcessStatus.Text = "Installing " + _Floderpath + " driver";
            }

            else if (e.ProgressPercentage == 3)
            {
                _BadUserDefander(true);
                _MainThread = false;
            }

            else if (e.ProgressPercentage == 4)
            {
                _SaveResult(_Floderpath, _ReturnCodeCheck(_ReturnCode));
                dataGridView1.Rows.RemoveAt(0);
                _MainThread = false;
            }

            else if (e.ProgressPercentage == 5)
            {
                _ResultForm.ShowDialog(this);
                _MainThread = false;
            }
        }
        
        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _BadUserDefander(false);
            _MainThread = true;
        }
                
        //||==========================||
        //||==========================||
        //||------ Button Event ------||
        //||==========================||
        //||==========================||

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
                row.Add(new object[] { _Floderpath, _FilepathSel, "-s", "Del" });
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
            _MainThread = false;
            backgroundWorker.RunWorkerAsync();
        }
    }
}
