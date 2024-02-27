using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classifier
{
    class Characteristics
    {
        // 0 - Average, 1 - Variance, 2 - InterClassDistance
        public double[] Weight = new double[3];
        public double[] Height = new double[3];
        public double[] Age = new double[3];
    }
    public class CLassCharacteristics
    {
        Characteristics characteristics1stClass = new Characteristics();
        Characteristics characteristics2stClass = new Characteristics();

        double WeightIntraClassDistance;
        double HeightIntraClassDistance;
        double AgeIntraClassDistance;

        double EuclideanDistance;

        MyObjects objects;

        string[] arr = { "Weight", "Height", "Age" };

        public CLassCharacteristics(MyObjects ob)
        {
            objects = ob;
        }

        public void SetChars()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            characteristics1stClass.Weight[0] = objects.CalculateAverage(1, arr[0]);
                            characteristics1stClass.Weight[1] = objects.CalculateVariance(1, characteristics1stClass.Weight[0], arr[0]);
                            characteristics1stClass.Weight[2] = objects.CalculateInterClassDistance(1, arr[0]);
                        }
                        break;
                    case 1:
                        {
                            characteristics1stClass.Height[0] = objects.CalculateAverage(1, arr[1]);
                            characteristics1stClass.Height[1] = objects.CalculateVariance(1, characteristics1stClass.Height[0], arr[1]);
                            characteristics1stClass.Height[2] = objects.CalculateInterClassDistance(1, arr[1]);
                        }
                        break;
                    case 2:
                        {
                            characteristics1stClass.Age[0] = objects.CalculateAverage(1, arr[2]);
                            characteristics1stClass.Age[1] = objects.CalculateVariance(1, characteristics1stClass.Age[0], arr[2]);
                            characteristics1stClass.Age[2] = objects.CalculateInterClassDistance(1, arr[2]);
                        }
                        break;
                }
                
            }

            WeightIntraClassDistance = objects.CalculateIntraClassDistance(1, 2, arr[0]);
            HeightIntraClassDistance = objects.CalculateIntraClassDistance(1, 2, arr[1]);
            AgeIntraClassDistance = objects.CalculateIntraClassDistance(1, 2, arr[2]);
        }

        public string returndata()
        {
            string result = "";
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if(i == 0)
                        result += characteristics1stClass.Weight[j].ToString() + " ";
                    if(i == 1)
                        result += characteristics1stClass.Height[j].ToString() + " ";
                    if (i == 2)
                        result += characteristics1stClass.Age[j].ToString() + " ";
                }
                

            result += "\n" + WeightIntraClassDistance.ToString() + 
                " " + HeightIntraClassDistance.ToString() + " " + AgeIntraClassDistance.ToString();
            return result;
        }
    }
    public class MyObject
    {
        public int Class { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public MyObject(int _class = 0, double _weight = 0, double _height = 0, int _age = 0)
        {
            Class = _class;
            Weight = _weight;
            Height = _height;
            Age = _age;
        }

    }

    public class MyObjects : List<MyObject>
    {
        public MyObjects(string filename)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excelApp.Workbooks.Open(filename);
            Worksheet worksheet = workbook.Sheets[1];

            int rowCount = worksheet.UsedRange.Rows.Count;
            int colCount = worksheet.UsedRange.Columns.Count;

            for (int row = 2; row <= rowCount; row++)
            {

                int classValue = (int)(worksheet.Cells[row, 1] as Range).Value;
                double weight = (double)(worksheet.Cells[row, 2] as Range).Value;
                double height = (double)(worksheet.Cells[row, 3] as Range).Value;
                int age = (int)(worksheet.Cells[row, 4] as Range).Value;

                MyObject obj = new MyObject(classValue, weight, height, age);
                Add(obj);
            }

            workbook.Close();
            excelApp.Quit();
        }

        private double GetCharacteristicValue(MyObject obj, string characteristic)
        {
            switch (characteristic)
            {
                case "Weight":
                    return obj.Weight;
                case "Height":
                    return obj.Height;
                case "Age":
                    return obj.Age;
                default:
                    throw new ArgumentException("Неверная характеристика", nameof(characteristic));
            }
        }

        private int CountObjectsOfClass(int targetClass)
        {
            return this.Count(obj => obj.Class == targetClass);
        }

        // среднее значение
        public double CalculateAverage(int targetClass, string characteristic)
        {
            var classObjects = this.Where(obj => obj.Class == targetClass);
            int count = classObjects.Count();

            if (count == 0)
                return 0.0;

            double sum = classObjects.Sum(obj => GetCharacteristicValue(obj, characteristic));
            return sum / count;
        }

        public double CalculateVariance(int targetClass, double average, string characteristic)
        {
            var classObjects = this.Where(obj => obj.Class == targetClass);
            int count = classObjects.Count();

            if (count == 0)
                return 0.0;

            double sumOfSquares = classObjects.Sum(obj => Math.Pow(GetCharacteristicValue(obj, characteristic) - average, 2));
            return sumOfSquares / count;
        }

        public double CalculateInterClassDistance(int targetClass, string characteristic)
        {
            var classObjects = this.Where(obj => obj.Class == targetClass);
            int count = classObjects.Count();

            if (count <= 1)
                return 0.0;

            double sumOfDistances = 0.0;
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    double distance = Math.Abs(GetCharacteristicValue(classObjects.ElementAt(i), characteristic) - GetCharacteristicValue(classObjects.ElementAt(j), characteristic));
                    sumOfDistances += distance;
                }
            }

            return sumOfDistances / (count * (count - 1) / 2);
        }

        public double CalculateIntraClassDistance(int class1, int class2, string characteristic)
        {
            var class1Objects = this.Where(obj => obj.Class == class1);
            var class2Objects = this.Where(obj => obj.Class == class2);

            int count1 = class1Objects.Count();
            int count2 = class2Objects.Count();

            if (count1 == 0 || count2 == 0)
                return 0.0;

            double sumOfDistances = 0.0;
            foreach (var obj1 in class1Objects)
            {
                foreach (var obj2 in class2Objects)
                {
                    double distance = Math.Abs(GetCharacteristicValue(obj1, characteristic) - GetCharacteristicValue(obj2, characteristic));
                    sumOfDistances += distance;
                }
            }

            return sumOfDistances / (count1 * count2);
        }

        public double CalculateEuclideanDistance(MyObject obj1, MyObject obj2)
        {
            double distance = Math.Sqrt(Math.Pow(obj1.Weight - obj2.Weight, 2) + Math.Pow(obj1.Height - obj2.Height, 2) + Math.Pow(obj1.Age - obj2.Age, 2));
            return distance;
        }
    }
}
