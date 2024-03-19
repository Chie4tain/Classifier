using System;
using System.Linq;
using System.Windows.Forms;

namespace Classifier
{
    public interface IClassifier
    {
        int Classify(MyObject obj);
    }

    public partial class MainForm : Form
    {
        HelloForm helloForm;
        PredictionForm predictionForm;
        MyObjects objectsList;
        Perceptron perceptron;
        MinDistanceClassifier distanceClassifier;
        public MainForm(HelloForm form)
        {
            InitializeComponent();
            helloForm = form;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oFD.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                btnPredict.Enabled = false;

                string filePath = oFD.FileName;
                objectsList = new MyObjects(filePath);

                DGVClear();

                dataGridView.Columns.Add("Class", "Class");
                for (int i = 0; i < objectsList.CharsNames.Length; i++)
                {
                    dataGridView.Columns.Add(objectsList.CharsNames[i], objectsList.CharsNames[i]);
                }

                for (int i = 0; i < objectsList.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    switch (objectsList.CharsNames.Length)
                    {
                        case 1:
                            row.CreateCells(dataGridView, (objectsList[i] as MyObject1st).Class.ToString(), (objectsList[i] as MyObject1st).Char1.ToString());
                            break;
                        case 2:
                            row.CreateCells(dataGridView, (objectsList[i] as MyObject2nd).Class.ToString(), (objectsList[i] as MyObject2nd).Char1.ToString(), (objectsList[i] as MyObject2nd).Char2.ToString());
                            break;
                        case 3:
                            row.CreateCells(dataGridView, (objectsList[i] as MyObject3rd).Class.ToString(), (objectsList[i] as MyObject3rd).Char1.ToString(), (objectsList[i] as MyObject3rd).Char2.ToString(), (objectsList[i] as MyObject3rd).Char3.ToString());
                            break;
                        case 4:
                            row.CreateCells(dataGridView, (objectsList[i] as MyObject4th).Class.ToString(), (objectsList[i] as MyObject4th).Char1.ToString(), (objectsList[i] as MyObject4th).Char2.ToString(), (objectsList[i] as MyObject4th).Char3.ToString(), (objectsList[i] as MyObject4th).Char4.ToString());
                            break;
                        case 5:
                            row.CreateCells(dataGridView, (objectsList[i] as MyObject5th).Class.ToString(), (objectsList[i] as MyObject5th).Char1.ToString(), (objectsList[i] as MyObject5th).Char2.ToString(), (objectsList[i] as MyObject5th).Char3.ToString(), (objectsList[i] as MyObject5th).Char4.ToString(), (objectsList[i] as MyObject5th).Char5.ToString());
                            break;
                    }
                    dataGridView.Rows.Add(row);
                }
                btnStart.Enabled = true;
                btnTrain.Enabled = true;
                numericUpDownIters.Enabled = true;
                numericUpDownLearninrate.Enabled = true;

                distanceClassifier = new MinDistanceClassifier(objectsList);

                if(predictionForm != null)
                    predictionForm.Close();

            }
        }

        private void DGVClear()
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView1st.Columns.Clear();
            dataGridView1st.Rows.Clear();
            dataGridView2nd.Columns.Clear();
            dataGridView2nd.Rows.Clear();
            dataGridViewWeights.Columns.Clear();
            dataGridViewWeights.Rows.Clear();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CLassCharacteristics characteristics = new CLassCharacteristics(objectsList);
            characteristics.SetChars();

            lblInter1ClassDistance.Text = "Inter 1st Class Distance: " + $"{characteristics.characteristics1stClass.InterClassDistance}";
            lblInter2ClassDistance.Text = "Inter 2nd Class Distance: " + $"{characteristics.characteristics2stClass.InterClassDistance}";

            FillDgv(dataGridView1st, characteristics, characteristics.charlist1st);
            FillDgv(dataGridView2nd, characteristics, characteristics.charlist2nd);

            lblIntraClassDistance.Text = "Intra Class Distance: " + $"{characteristics.IntraClassDistances}";
        }
        private void FillDgv(Control c, CLassCharacteristics chars, Charlist chrlst)
        {
            DataGridView dtg = c as DataGridView;
            dtg.Columns.Add("Characteristic", "Characteristic");
            for (int i = 0; i < chars.Characters.Length; i++)
            {
                dtg.Columns.Add(chars.Characters[i], chars.Characters[i]);
            }
            for (int i = 0; i < objectsList.CharsNames.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtg, objectsList.CharsNames[i].ToString(), chrlst[i][0], chrlst[i][1]);

                dtg.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            helloForm.Close();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            dataGridViewWeights.Columns.Clear();
            dataGridViewWeights.Rows.Clear();
            int numberOfInputs = objectsList.CharsNames.Length;
            double learningRate = (double)numericUpDownLearninrate.Value;
            int numberOfIterations = (int)numericUpDownIters.Value;

            perceptron = new Perceptron(numberOfInputs, learningRate);

            perceptron.Train(objectsList, numberOfIterations);

            for (int i = 0; i < objectsList.CharsNames.Length; i++)
            {
                dataGridViewWeights.Columns.Add(objectsList.CharsNames[i], objectsList.CharsNames[i]);
            }
            DataGridViewRow row = new DataGridViewRow();
            switch (perceptron.weights.Count())
            {
                case 1: row.CreateCells(dataGridViewWeights, perceptron.weights[0].ToString()); break;
                case 2: row.CreateCells(dataGridViewWeights, perceptron.weights[0].ToString(), perceptron.weights[1].ToString()); break;
                case 3: row.CreateCells(dataGridViewWeights, perceptron.weights[0].ToString(), perceptron.weights[1].ToString(), perceptron.weights[2].ToString()); break;
                case 4: row.CreateCells(dataGridViewWeights, perceptron.weights[0].ToString(), perceptron.weights[1].ToString(), perceptron.weights[2].ToString(), perceptron.weights[3].ToString()); break;
                case 5: row.CreateCells(dataGridViewWeights, perceptron.weights[0].ToString(), perceptron.weights[1].ToString(), perceptron.weights[2].ToString(), perceptron.weights[3].ToString(), perceptron.weights[4].ToString()); break;
            }

            dataGridViewWeights.Rows.Add(row);
            btnPredict.Enabled = true;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            predictionForm = new PredictionForm(objectsList, perceptron, distanceClassifier);
            predictionForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
