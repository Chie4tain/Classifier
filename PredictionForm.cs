using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System;

namespace Classifier
{
    public partial class PredictionForm : Form
    {
        MyObjects objectsList;
        Perceptron perceptron;
        MinDistanceClassifier distanceClassifier;
        double[] InputsParams;

        List<TextBox> textBoxes;
        public PredictionForm(MyObjects _objectsList, Perceptron _perceptron, MinDistanceClassifier _distanceClassifier)
        {
            InitializeComponent();

            objectsList = _objectsList;
            perceptron = _perceptron;
            distanceClassifier = _distanceClassifier;
            InitTextBoxes(pnlTextBoxes);
            InputsParams = new double[objectsList.CharsNames.Length];
        }

        private void InitTextBoxes(Panel panel)
        {
            panel.Controls.Clear();
            int x = 10;
            Point locPoint = new Point(x, 30);
            Point locPointlbl = new Point(x, 0);
            textBoxes = new List<TextBox>();
            for (int i = 0; i < objectsList.CharsNames.Length; i++)
            {
                
                TextBox tb = new TextBox();
                Label lbl = new Label();
                lbl.Text = objectsList.CharsNames[i];
                lbl.Parent = panel;
                tb.Parent = panel;
                textBoxes.Add(tb);
                tb.Location = locPoint;
                lbl.Location = locPointlbl;
                x += 120;
                locPoint = new Point(x, 30);
                locPointlbl = new Point(x, 0);
            }
        }

        private void Predictperc_Click(object sender, System.EventArgs e)
        {
            if(ValidateInput())
            {
                PredictbyPerceptron();
            }

        }

        private void predictMindistance_Click(object sender, System.EventArgs e)
        {
            if (ValidateInput())
            {
                PredictbyMinDistance();
            }
        }

        private void PredictbyPerceptron()
        {
            MyObject testObject = InitObject();

            int result = perceptron.Classify(testObject);

            testObject.Class = result;

            initDgvRes(dataGridViewresperc, result);
        }

        private void PredictbyMinDistance()
        {
            MyObject testObject = InitObject();

            int result = distanceClassifier.Classify(testObject);

            testObject.Class = result;

            initDgvRes(dataGridViewresdist, result);
        }

        private MyObject InitObject()
        {
            MyObject obj = null;
            switch (InputsParams.Length)
            {
                case 1: obj = new MyObject1st(default, InputsParams[0]); break;
                    case 2: obj = new MyObject2nd(default, InputsParams[0], InputsParams[1]); break;
                    case 3: obj = new MyObject3rd(default, InputsParams[0], InputsParams[1], InputsParams[2]); break;
                    case 4: obj = new MyObject4th(default, InputsParams[0], InputsParams[1], InputsParams[2], InputsParams[3]); break;
                    case 5: obj = new MyObject5th(default, InputsParams[0], InputsParams[1], InputsParams[2], InputsParams[3], InputsParams[4]); break;
            }
            return obj;
        }

        private void initDgvRes(DataGridView dgv, int res)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Columns.Add("Result", "Result");
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgv, res.ToString());
            dgv.Rows.Add(row);
        }
        private bool ValidateInput()
        {
            double param = 0;
            bool valid = true;
            for(int i = 0;i < objectsList.CharsNames.Length;i++)
            {
                if (!double.TryParse(textBoxes[i].Text, out param) || param <= 0)
                {
                    MessageBox.Show("Введите корректное значение.");
                    textBoxes[i].Focus();
                    valid = false;
                    param = -1;
                }
                InputsParams[i] = param;
            }
            return valid;
        }

        private void btnQualAssess_Click(object sender, EventArgs e)
        {
            QualityAssessment qualityAssessment = new QualityAssessment();

            qualityAssessment.CalculateMetrics(objectsList, perceptron);
            double[] perceptparam = new double[3];
            perceptparam[0] = qualityAssessment.CalculateSensitivity();
            perceptparam[1] = qualityAssessment.CalculateSpecificity();
            perceptparam[2] = qualityAssessment.CalculateAccuracy();
            InitDgv(perceptparam, dataGridViewperc);

            qualityAssessment.CalculateMetrics(objectsList, distanceClassifier);

            double[] mindistparam = new double[3];
            mindistparam[0] = qualityAssessment.CalculateSensitivity();
            mindistparam[1] = qualityAssessment.CalculateSpecificity();
            mindistparam[2] = qualityAssessment.CalculateAccuracy();
            InitDgv(mindistparam, dataGridViewdist);
        }

        private void InitDgv(double[] arr, DataGridView dgv)
        {
            string[] arrs = { "Sensitivity", "Specificity", "Accuracy" };
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Columns.Add("", "");
            dgv.Columns.Add("Value", "Value");
            for (int i = 0; i < arrs.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv, arrs[i], arr[i]);
                dgv.Rows.Add(row);
            }

        }
    }
}
