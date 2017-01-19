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
            Label _Devicelabel = new Label();
            _Devicelabel.Dock = DockStyle.Top;
            _Devicelabel.Text = DeviceName + " driver installed ";
            Label _Resultlabel = new Label();
            _Resultlabel.Dock = DockStyle.Top;
            _Resultlabel.Text = status;
            if (status == "Sucess")
            {
                _Resultlabel.ForeColor = Color.Green;
            }
            else
            {
                _Resultlabel.ForeColor = Color.Red;
            }
            panel1.Controls.Add(_Devicelabel);
            panel2.Controls.Add(_Resultlabel);
        }
    }
}
