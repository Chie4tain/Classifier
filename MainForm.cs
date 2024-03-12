using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Classifier
{
    public interface IClassifier
    {
        int Classify(MyObject obj);
    }

    public partial class MainForm : Form
    {
        HelloForm helloForm;
        MyObjects objectsList;
        Perceptron perceptron;
        MinDistanceClassifier distanceClassifier;
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
                distanceClassifier = new MinDistanceClassifier(objectsList);
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
            int numberOfIterations = 10000;

            perceptron = new Perceptron(numberOfInputs, learningRate);

            perceptron.Train(objectsList, numberOfIterations);

            string s = perceptron.weights[0].ToString() + " " + perceptron.weights[1].ToString() + " " + perceptron.weights[2].ToString();
            lblweights.Text = "Weights: " + s;
            textBoxWeight.Enabled = true;
            textBoxHeight.Enabled = true;
            textBoxAge.Enabled = true;

            btnPredict.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            double weight, height;
            int age;

            (weight, height, age) = ValidateInput();
            if (weight > -1)
            {
                PreddictbyPerceptron(weight, height, age);
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

        private void PreddictbyPerceptron(double weight, double height, int age)
        {
            MyObject testObject = new MyObject(default, weight, height, age);

            int result = perceptron.Classify(testObject);

            testObject.Class = result;

            label2.Text = "Prediction result: " + result;
        }

        private void PreddictbyMinDistance(double weight, double height, int age)
        {
            MyObject testObject = new MyObject(default, weight, height, age);

            int result = distanceClassifier.Classify(testObject);

            testObject.Class = result;

            label7.Text = "Prediction result: " + result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double weight, height;
            int age;

            (weight, height, age) = ValidateInput();
            if (weight > -1)
            {
                PreddictbyMinDistance(weight, height, age);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QualityAssessment qualityAssessment = new QualityAssessment();

            qualityAssessment.CalculateMetrics(objectsList, perceptron);
            double[] perceptparam = new double[3];
            perceptparam[0] = qualityAssessment.CalculateSensitivity();
            perceptparam[1] = qualityAssessment.CalculateSpecificity();
            perceptparam[2] = qualityAssessment.CalculateAccuracy();

            qualityAssessment.CalculateMetrics(objectsList, distanceClassifier);

            double[] mindistparam = new double[3];
            mindistparam[0] = qualityAssessment.CalculateSensitivity();
            mindistparam[1] = qualityAssessment.CalculateSpecificity();
            mindistparam[2] = qualityAssessment.CalculateAccuracy();

            string s = "Perceptron:\n Sensitivity: " + perceptparam[0] + "\n" + "Specificity: " + perceptparam[1] + "\n" + "Accuracy: " + perceptparam[2];

            lblpercParams.Text = s;

            s = "Min Distance:\n Sensitivity: " + mindistparam[0] + "\n" + "Specificity: " + mindistparam[1] + "\n" + "Accuracy: " + mindistparam[2];

            lblmindistParams.Text = s;
        }
    }
}
