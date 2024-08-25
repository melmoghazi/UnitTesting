using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR
{
    public class BMICalculator
    {
        public double CalculateBMI(double heightInMeters, double weightInKilos)
        {
            if (heightInMeters == 0 || weightInKilos == 0)
                return 0;
            else
                return weightInKilos / (heightInMeters * heightInMeters);
        }
    }
}
