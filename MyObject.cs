using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Classifier
{
    public abstract class MyObject
    {
        public int Class { get; set; }

        public MyObject(int _class = 1)
        {
            Class = _class;
        }
    }
    public class MyObject1st : MyObject
    {
        public double Char1 { get; set; }

        public MyObject1st(int _class = 1, double _char1 = 0) : base(_class)
        { Char1 = _char1; }
    }

    public class MyObject2nd : MyObject1st
    {
        public double Char2 { get; set; }
        public MyObject2nd(int _class = 1, double _char1 = 0, double _char2 = 0) : base(_class, _char1)
        { Char2 = _char2; }
    }

    public class MyObject3rd : MyObject2nd
    {
        public double Char3 { get; set; }

        public MyObject3rd(int _class = 1, double _char1 = 0, double _char2 = 0, double _char3 = 0) : base(_class, _char1, _char2)
        { Char3 = _char3; }
    }

    public class MyObject4th : MyObject3rd
    {
        public double Char4 { get; set; }

        public MyObject4th(int _class = 1, double _char1 = 0, double _char2 = 0, double _char3 = 0, double _char4 = 0) : base(_class, _char1, _char2, _char3)
        { Char4 = _char4; }
    }

    public class MyObject5th : MyObject4th
    {
        public double Char5 { get; set; }

        public MyObject5th(int _class = 1, double _char1 = 0, double _char2 = 0, double _char3 = 0, double _char4 = 0, double _char5 = 0) : base(_class, _char1, _char2, _char3, _char4)
        { Char5 = _char5; }
    }

    public class MyObjects : List<MyObject>
    {
        public string[] CharsNames;
        public MyObjects(string filename)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excelApp.Workbooks.Open(filename);
            Worksheet worksheet = workbook.Sheets[1];

            int rowCount = worksheet.UsedRange.Rows.Count;
            int colCount = worksheet.UsedRange.Columns.Count;

            CharsNames = new string[colCount - 1];
            for (int i = 2; i <= colCount; i++)
            {
                CharsNames[i - 2] = (string)(worksheet.Cells[1, i] as Range).Value;
            }

            for (int row = 2; row <= rowCount; row++)
            {
                MyObject obj = null;
                switch (colCount)
                {
                    case 2:
                        {
                            int classValue = (int)(worksheet.Cells[row, 1] as Range).Value;
                            double char1 = (double)(worksheet.Cells[row, 2] as Range).Value;
                            obj = new MyObject1st(classValue, char1);
                        }
                        break;
                    case 3:
                        {
                            int classValue = (int)(worksheet.Cells[row, 1] as Range).Value;
                            double char1 = (double)(worksheet.Cells[row, 2] as Range).Value;
                            double char2 = (double)(worksheet.Cells[row, 3] as Range).Value;
                            obj = new MyObject2nd(classValue, char1, char2);
                        }
                        break;
                    case 4:
                        {
                            int classValue = (int)(worksheet.Cells[row, 1] as Range).Value;
                            double char1 = (double)(worksheet.Cells[row, 2] as Range).Value;
                            double char2 = (double)(worksheet.Cells[row, 3] as Range).Value;
                            double char3 = (double)(worksheet.Cells[row, 4] as Range).Value;
                            obj = new MyObject3rd(classValue, char1, char2, char3);
                        }
                        break;
                    case 5:
                        {
                            int classValue = (int)(worksheet.Cells[row, 1] as Range).Value;
                            double char1 = (double)(worksheet.Cells[row, 2] as Range).Value;
                            double char2 = (double)(worksheet.Cells[row, 3] as Range).Value;
                            double char3 = (double)(worksheet.Cells[row, 4] as Range).Value;
                            double char4 = (double)(worksheet.Cells[row, 5] as Range).Value;
                            obj = new MyObject4th(classValue, char1, char2, char3, char4);
                        }
                        break;
                    case 6:
                        {
                            int classValue = (int)(worksheet.Cells[row, 1] as Range).Value;
                            double char1 = (double)(worksheet.Cells[row, 2] as Range).Value;
                            double char2 = (double)(worksheet.Cells[row, 3] as Range).Value;
                            double char3 = (double)(worksheet.Cells[row, 4] as Range).Value;
                            double char4 = (double)(worksheet.Cells[row, 5] as Range).Value;
                            double char5 = (double)(worksheet.Cells[row, 6] as Range).Value;
                            obj = new MyObject5th(classValue, char1, char2, char3, char4, char5);
                        }
                        break;
                    default:
                        break;
                }
                Add(obj);
            }

            workbook.Close();
            excelApp.Quit();
        }

        private double GetCharacteristicValue(MyObject obj, string characteristic)
        {
            double value;
            if (characteristic == CharsNames[0])
            {
                value = (obj as MyObject1st).Char1;
            }
            else if (characteristic == CharsNames[1])
            {
                value = (obj as MyObject2nd).Char2;
            }
            else if (characteristic == CharsNames[2])
            {
                value = (obj as MyObject3rd).Char3;
            }
            else if (characteristic == CharsNames[3])
            {
                value = (obj as MyObject4th).Char4;
            }
            else if (characteristic == CharsNames[4])
            {
                value = (obj as MyObject5th).Char5;
            }
            else
            {
                throw new ArgumentException("Неверная характеристика", nameof(characteristic));
            }
            return value;
        }

        private int CountObjectsOfClass(int targetClass)
        {
            return this.Count(obj => obj.Class == targetClass);
        }

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

        public double CalculateIntraClassDistance(Charlist list_1st, Charlist list_2nd)
        {
            double result = 0.0;

            for(int i = 0; i < CharsNames.Length; i++)
            {
                result += Math.Abs(list_1st[i][0] - list_2nd[i][0]);
            }

            return result;
        }
    }
}
