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

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "Sucess")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.DefaultCellStyle.BackColor = Color.Red;
                if (row.Selected)
                {
                    row.DefaultCellStyle.SelectionForeColor = Color.Green;
                }
            }
        }

        public void _CreateLabel(string DeviceName, string status)
        {
            dataGridView1.Rows.Add(DeviceName+ " driver installed ", status);
        }
    }
}