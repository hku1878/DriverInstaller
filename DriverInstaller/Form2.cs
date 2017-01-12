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
        public static ListBox _listBox1 = new ListBox();
        public Form2()
        {
            InitializeComponent();
            

            panel1.Controls.Add(_listBox1);

        }

        public static void _CreateLabel(string DeviceName, string status)
        {
            
        }
    }
}
