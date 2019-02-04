using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmiProjekt
{
    class BmiCal
    {
        int weight;
        int height;

        public BmiCal(int weight, int height)
        {
            this.weight = weight;
            this.height = height;
        }

        public double BmiCalculator(BmiCal bmi)
        {
            string message = DB.InsertBmi(bmi);

            double BMI = bmi.weight / (bmi.height * bmi.height);

            return BMI;
        }
    }
}
