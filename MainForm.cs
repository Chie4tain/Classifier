using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;

namespace Classifier
{
    public partial class MainForm : Form
    {
        HelloForm helloForm;
        MyObjects objectsList;
        public MainForm( HelloForm form)
        {
            InitializeComponent();
            helloForm = form;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oFD.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                string filePath = oFD.FileName;
                objectsList = new MyObjects(filePath);

                bindingSource.DataSource = objectsList;
                dataGridView.DataSource = bindingSource;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CLassCharacteristics characteristics = new CLassCharacteristics(objectsList);
            characteristics.SetChars();
            label1.Text = characteristics.returndata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            helloForm.Close();
        }
    }
}
