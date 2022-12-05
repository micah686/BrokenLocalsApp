using System;
using System.Windows.Forms;

namespace SandboxApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var uc1 = new UC1();
            tabPage1.Controls.Add(uc1);
        }        
    }    
}
