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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Classifier
{
    public partial class MainForm : Form
    {
        HelloForm helloForm;
        MyObjects objectsList;
        Perceptron perceptron;
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
                btnStart.Enabled = true;
                btnTrain.Enabled = true;
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

        private void btnTrain_Click(object sender, EventArgs e)
        {
            int numberOfInputs = 3;
            double learningRate = 0.1;
            int numberOfIterations = 1000;

            perceptron = new Perceptron(numberOfInputs, learningRate);

            perceptron.Train(objectsList, numberOfIterations);

            textBoxWeight.Enabled = true;
            textBoxHeight.Enabled = true;
            textBoxAge.Enabled = true;

            btnPredict.Enabled = true;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            double weight, height;
            int age;

            (weight, height, age) = ValidateInput();
            if (weight > -1)
            {
                Preddict(weight, height, age);
            }
        }

        private (double,double, int) ValidateInput()
        {
            double weight, height;
            int age;

            if (!double.TryParse(textBoxWeight.Text, out weight) || weight <= 0)
            {
                MessageBox.Show("Введите корректное значение веса.");
                textBoxWeight.Focus();
                return (-1, -1, -1);
            }

            if (!double.TryParse(textBoxHeight.Text, out height) || height <= 0)
            {
                MessageBox.Show("Введите корректное значение роста.");
                textBoxHeight.Focus();
                return (-1, -1, -1);
            }

            if (!int.TryParse(textBoxAge.Text, out age) || age < 0)
            {
                MessageBox.Show("Введите корректное значение возраста.");
                textBoxAge.Focus();
                return (-1, -1, -1);
            }

            // Создание объекта testObject после успешной валидации
            return (weight, height, age);
        }

        private void Preddict(double weight, double height, int age)
        {
            MyObject testObject = new MyObject(default, weight, height, age);

            int result = perceptron.Predict(testObject);

            testObject.Class = result;

            label2.Text = "Prediction result: " + result;
        }
    }
}
