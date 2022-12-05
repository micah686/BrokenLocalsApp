using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandboxApp
{
    public partial class BreakPrompt : Form
    {
        public BreakPrompt()
        {
            InitializeComponent();
        }
        /*
         If you put a breakpoint at var textSize =... and Debug.WriteLine..., and then launch the app
         When you hit the breakpoints, var topSize and var textSize do not show in Autos or Locals.
         If you try to add it to the Watch, you get this:   error CS0103: The name 'topSize/textSize' does not exist in the current context
        This only happens in VS 2022. 2019 works just fine
         */
        public BreakPrompt(string text)
        {
            InitializeComponent();
            txtMessage.Text = text;
            var topSize = pnlTop.Size;
            var textSize = TextRenderer.MeasureText(txtMessage.Text, txtMessage.Font);
            Debug.WriteLine($"textSize:{textSize.Width}x{textSize.Height}, pnlTop:{topSize.Width}x{topSize.Height}");
        }
    }
}
