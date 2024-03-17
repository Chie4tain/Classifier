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
            double sum = 0;
            switch(trainingData.CharsNames.Length)
            {
                case 1: sum = Math.Pow((obj1 as MyObject1st).Char1 - (obj2 as MyObject1st).Char1, 2); break;
                case 2: sum = Math.Pow((obj1 as MyObject2nd).Char1 - (obj2 as MyObject2nd).Char1, 2) + Math.Pow((obj1 as MyObject2nd).Char2 - (obj2 as MyObject2nd).Char2, 2); break;
                case 3: sum = Math.Pow((obj1 as MyObject3rd).Char1 - (obj2 as MyObject3rd).Char1, 2) + Math.Pow((obj1 as MyObject3rd).Char2 - (obj2 as MyObject3rd).Char2, 2) +
                        Math.Pow((obj1 as MyObject3rd).Char3 - (obj2 as MyObject3rd).Char3, 2); break;
                case 4:
                    sum = Math.Pow((obj1 as MyObject4th).Char1 - (obj2 as MyObject4th).Char1, 2) + Math.Pow((obj1 as MyObject4th).Char2 - (obj2 as MyObject4th).Char2, 2) +
                    Math.Pow((obj1 as MyObject4th).Char3 - (obj2 as MyObject4th).Char3, 2) + Math.Pow((obj1 as MyObject4th).Char4 - (obj2 as MyObject4th).Char4, 2); break;
                case 5:
                    sum = Math.Pow((obj1 as MyObject5th).Char1 - (obj2 as MyObject5th).Char1, 2) + Math.Pow((obj1 as MyObject5th).Char2 - (obj2 as MyObject5th).Char2, 2) +
                    Math.Pow((obj1 as MyObject5th).Char3 - (obj2 as MyObject5th).Char3, 2) + Math.Pow((obj1 as MyObject5th).Char4 - (obj2 as MyObject5th).Char4, 2) +
                    Math.Pow((obj1 as MyObject5th).Char5 - (obj2 as MyObject5th).Char5, 2); break;
            }

            return Math.Sqrt(sum);
        }
    }
}
