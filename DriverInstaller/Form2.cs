using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverInstaller
{

    public partial class Form2 : Form
    {
        static Panel panel1 = new Panel();
        public Form2()
        {
            InitializeComponent();
            panel1.Location = new Point(13, 13);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(259, 236);
            panel1.TabIndex = 0;
        }

        public static void _CreateLabel(string DeviceName, string status)
        {
            Label _Resultlabel = new Label();
            _Resultlabel.Text = DeviceName + " driver installed " + status;
            _Resultlabel.AutoSize = true;
            panel1.Controls.Add(_Resultlabel);
        }
    }
}
