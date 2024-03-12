using System;

namespace Classifier
{
    public class Perceptron : IClassifier
    {
        private int numberOfInputs;
        public double[] weights;
        private double bias;
        private double learningRate;

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
            for (int i = 0; i < numberOfIterations; i++)
            {
                for (int j = 0; j < objects.Count; j++)
                {
                    double[] inputs = new double[] { objects[j].Weight, objects[j].Height, objects[j].Age };
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
            double[] inputs = new double[] { obj.Weight, obj.Height, obj.Age };
            double sum = DotProduct(inputs) + bias;
            return ActivationFunction(sum);
        }
    }
}
