using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classifier
{
    public class MinDistanceClassifier : IClassifier
    {
        MyObjects trainingData;

        public MinDistanceClassifier(MyObjects mies) 
        {
            trainingData = mies;
        }
        public int Classify(MyObject obj)
        {
            double minDistance = double.MaxValue;
            int minDistanceClass = -1;

            foreach (MyObject trainObj in trainingData)
            {
                double distance = CalculateDistance(obj, trainObj);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    minDistanceClass = trainObj.Class;
                }
            }

            return minDistanceClass;
        }

        private double CalculateDistance(MyObject obj1, MyObject obj2)
        {
            double weightDiff = obj1.Weight - obj2.Weight;
            double heightDiff = obj1.Height - obj2.Height;
            double ageDiff = obj1.Age - obj2.Age;

            return Math.Sqrt(weightDiff * weightDiff + heightDiff * heightDiff + ageDiff * ageDiff);
        }
    }
}
