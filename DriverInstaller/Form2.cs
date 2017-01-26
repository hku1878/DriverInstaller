using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DriverInstaller
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public void _CreateLabel(string DeviceName, string status)
        {
            dataGridView1.Rows.Add(DeviceName+ " driver installed ", status);
            if (status == "Sucess")
            {
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Style = new DataGridViewCellStyle { ForeColor = Color.Green };
            }
            else
            {
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
            }
            dataGridView1.Rows[dataGridView1.RowCount - 1].Height = 20;
            this.Size = new Size(375, 61 + dataGridView1.RowCount * 20);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            dataGridView1.Rows.Clear();
        }
    }
}