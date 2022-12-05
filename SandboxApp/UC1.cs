using System;
using System.Windows.Forms;

namespace SandboxApp
{
    public partial class UC1 : UserControl
    {        

        public UC1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string testText = "This is some sample text for the textbox";
            var breakPrompt = new BreakPrompt(testText);
            breakPrompt.Show();
        }        
    }    
}
