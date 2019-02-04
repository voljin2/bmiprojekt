using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bmiProjekt
{
    public class BmiCal
    {
        int weight;
        int height;

        public BmiCal(int weight, int height)
        {
            this.weight = weight;
            this.height = height;
        }

        public BmiCal()
        {
        }

        public double BmiCalculator(BmiCal bmi)
        {
            int witght = bmi.weight;
            int hight = bmi.height;

            double bMI = 0;
            bMI = ((hight * hight)/ witght);

            return bMI;
        }

    }
}
