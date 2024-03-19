using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classifier
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            richTextBox1.LoadFile(Path.Combine(Application.StartupPath, "Help.rtf"));
        }
    }
}
