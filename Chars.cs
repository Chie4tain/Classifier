using System.Collections.Generic;

namespace Classifier
{
    public class Characteristics
    {
        // 0 - Average, 1 - Variance, 2 - InterClassDistance
        public double[] Char1st = new double[3];
        public double[] Char2nd = new double[3];
        public double[] Char3rd = new double[3];
        public double[] Char4th = new double[3];
        public double[] Char5th = new double[3];
    }

    public class Charlist : List<double[]>
    {
        public Charlist(MyObjects objcts, Characteristics chrs)
        {
            switch (objcts.CharsNames.Length - 1)
            {
                case 0: Add(chrs.Char1st); break;
                case 1: Add(chrs.Char1st); Add(chrs.Char2nd); break;
                case 2: Add(chrs.Char1st); Add(chrs.Char2nd); Add(chrs.Char3rd); break;
                case 3: Add(chrs.Char1st); Add(chrs.Char2nd); Add(chrs.Char3rd); Add(chrs.Char4th); break;
                case 4: Add(chrs.Char1st); Add(chrs.Char2nd); Add(chrs.Char3rd); Add(chrs.Char4th); Add(chrs.Char5th); break;
            }
        }
    }
    public class CLassCharacteristics
    {
        public string[] Characters = { "Average", "Variance", "Inter Class Distance" };
        public Characteristics characteristics1stClass = new Characteristics();
        public Characteristics characteristics2stClass = new Characteristics();

        public double[] IntraClassDistances;
        public Charlist charlist1st;
        public Charlist charlist2nd;
        MyObjects objects;

        public CLassCharacteristics(MyObjects ob)
        {
            objects = ob;
        }

        public void SetChars()
        {
            for (int i = 1; i < 3; i++)
            {
                Characteristics charact = new Characteristics();
                if (i == 1)
                {
                    charact = characteristics1stClass;
                    charlist1st = new Charlist(objects, charact);
                }
                    
                else
                {
                    charact = characteristics2stClass;
                    charlist2nd = new Charlist(objects, charact);
                }
                   
                for (int j = 0; j < objects.CharsNames.Length; j++)
                {
                    switch (j)
                    {
                        case 0:
                            {
                                charact.Char1st[0] = objects.CalculateAverage(i, objects.CharsNames[0]);
                                charact.Char1st[1] = objects.CalculateVariance(i, charact.Char1st[0], objects.CharsNames[0]);
                                charact.Char1st[2] = objects.CalculateInterClassDistance(i, objects.CharsNames[0]);
                            }
                            break;
                        case 1:
                            {
                                charact.Char2nd[0] = objects.CalculateAverage(i, objects.CharsNames[1]);
                                charact.Char2nd[1] = objects.CalculateVariance(i, charact.Char2nd[0], objects.CharsNames[1]);
                                charact.Char2nd[2] = objects.CalculateInterClassDistance(i, objects.CharsNames[1]);
                            }
                            break;
                        case 2:
                            {
                                charact.Char3rd[0] = objects.CalculateAverage(i, objects.CharsNames[2]);
                                charact.Char3rd[1] = objects.CalculateVariance(i, charact.Char3rd[0], objects.CharsNames[2]);
                                charact.Char3rd[2] = objects.CalculateInterClassDistance(i, objects.CharsNames[2]);
                            }
                            break;
                        case 3:
                            {
                                charact.Char4th[0] = objects.CalculateAverage(i, objects.CharsNames[3]);
                                charact.Char4th[1] = objects.CalculateVariance(i, charact.Char4th[0], objects.CharsNames[3]);
                                charact.Char4th[2] = objects.CalculateInterClassDistance(i, objects.CharsNames[3]);
                            }
                            break;
                        case 4:
                            {
                                charact.Char5th[0] = objects.CalculateAverage(i, objects.CharsNames[4]);
                                charact.Char5th[1] = objects.CalculateVariance(i, charact.Char5th[0], objects.CharsNames[4]);
                                charact.Char5th[2] = objects.CalculateInterClassDistance(i, objects.CharsNames[4]);
                            }
                            break;
                    }

                }
            }

            IntraClassDistances = new double[objects.CharsNames.Length];

            for (int i = 0; i < IntraClassDistances.Length; i++)
            {
                IntraClassDistances[i] = objects.CalculateIntraClassDistance(1, 2, objects.CharsNames[i]);
            }
        }
    }
}
