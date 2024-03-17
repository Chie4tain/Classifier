using System;
using System.Xml.Linq;

namespace Classifier
{
    public class Perceptron : IClassifier
    {
        private int numberOfInputs;
        public double[] weights;
        private double bias;
        private double learningRate;
        private int CharsNum;

        public Perceptron(int numberOfInputs, double learningRate)
        {
            this.numberOfInputs = numberOfInputs;
            this.weights = new double[numberOfInputs];
            this.bias = 0;
            this.learningRate = learningRate;
            InitializeWeights();
        }

        private void InitializeWeights()
        {
            Random random = new Random();
            for (int i = 0; i < numberOfInputs; i++)
            {
                weights[i] = random.NextDouble();
            }
        }

        private int ActivationFunction(double sum)
        {
            if (sum >= 0)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        private double DotProduct(double[] inputs)
        {
            double sum = 0;
            for (int i = 0; i < numberOfInputs; i++)
            {
                sum += weights[i] * inputs[i];
            }
            return sum;
        }

        public void Train(MyObjects objects, int numberOfIterations)
        {
            CharsNum = objects.CharsNames.Length;

            for (int i = 0; i < numberOfIterations; i++)
            {
                for (int j = 0; j < objects.Count; j++)
                {
                    double[] inputs = new double[] { };
                    switch (objects.CharsNames.Length)
                    {
                        case 1: inputs = new double[] { (objects[j] as MyObject1st).Char1}; break;
                        case 2: inputs = new double[] { (objects[j] as MyObject2nd).Char1, (objects[j] as MyObject2nd).Char2 }; break;
                        case 3: inputs = new double[] { (objects[j] as MyObject3rd).Char1, (objects[j] as MyObject3rd).Char2, (objects[j] as MyObject3rd).Char3 }; break;
                        case 4: inputs = new double[] { (objects[j] as MyObject4th).Char1, (objects[j] as MyObject4th).Char2, (objects[j] as MyObject4th).Char3, (objects[j] as MyObject4th).Char4 }; break;
                        case 5: inputs = new double[] { (objects[j] as MyObject5th).Char1, (objects[j] as MyObject5th).Char2, (objects[j] as MyObject5th).Char3, (objects[j] as MyObject5th).Char4, (objects[j] as MyObject5th).Char5 }; break;
                    }
                    double sum = DotProduct(inputs) + bias;
                    double output = ActivationFunction(sum);
                    double error = objects[j].Class - output;

                    for (int k = 0; k < numberOfInputs; k++)
                    {
                        weights[k] += learningRate * error * inputs[k];
                    }

                    bias += learningRate * error;
                }
            }
        }

        public int Classify(MyObject obj)
        {
            double[] inputs = new double[] { };
            switch (CharsNum)
            {
                case 1: inputs = new double[] { (obj as MyObject1st).Char1 }; break;
                case 2: inputs = new double[] { (obj as MyObject2nd).Char1, (obj as MyObject2nd).Char2 }; break;
                case 3: inputs = new double[] { (obj as MyObject3rd).Char1, (obj as MyObject3rd).Char2, (obj as MyObject3rd).Char3 }; break;
                case 4: inputs = new double[] { (obj as MyObject4th).Char1, (obj as MyObject4th).Char2, (obj as MyObject4th).Char3, (obj as MyObject4th).Char4 }; break;
                case 5: inputs = new double[] { (obj as MyObject5th).Char1, (obj as MyObject5th).Char2, (obj as MyObject5th).Char3, (obj as MyObject5th).Char4, (obj as MyObject5th).Char5 }; break;
            }
            double sum = DotProduct(inputs) + bias;
            return ActivationFunction(sum);
        }
    }
}
