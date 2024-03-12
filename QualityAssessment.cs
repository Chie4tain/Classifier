using System.Collections.Generic;

namespace Classifier
{
    public class QualityAssessment
    {
        public int TruePositives { get; set; }
        public int FalsePositives { get; set; }
        public int TrueNegatives { get; set; }
        public int FalseNegatives { get; set; }

        public void CalculateMetrics(MyObjects testData, IClassifier classifier)
        {
            foreach (var obj in testData)
            {
                int predictedClass = classifier.Classify(obj);

                if (predictedClass == 2 && obj.Class == 2)
                {
                    TruePositives++;
                }
                else if (predictedClass == 2 && obj.Class == 1)
                {
                    FalsePositives++;
                }
                else if (predictedClass == 1 && obj.Class == 1)
                {
                    TrueNegatives++;
                }
                else if (predictedClass == 1 && obj.Class == 2)
                {
                    FalseNegatives++;
                }
            }
        }

        public double CalculateSensitivity()
        {
            return (double)TruePositives / (TruePositives + FalseNegatives);
        }

        public double CalculateSpecificity()
        {
            return (double)TrueNegatives / (TrueNegatives + FalsePositives);
        }

        public double CalculateAccuracy()
        {
            return (double)(TruePositives + TrueNegatives) / (TruePositives + FalsePositives + TrueNegatives + FalseNegatives);
        }
    }
}
