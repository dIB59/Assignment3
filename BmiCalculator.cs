using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_3
{
    internal class BmiCalculator
    {
        private string name = "No name";
        private double height = 0; //m, feet
        private double weight = 0; //kg, lbs
        private MeasurementUnit unit;

        public string Name => name;

        public double Height => height;

        public double Weight => weight;

        public MeasurementUnit Unit => unit;
  

        public void SetHeight(double value)
        {
            if (value > 0)
            {
                height = value;
            }
        }

        public void SetName(string value)
        {
            if (value.Equals(""))
            {
                name = "No name";
                return;
            }
            name = value;
        }

        public void SetWeight(double value)
        {
            if (value > 0)
            {
                weight = value;
            }
        }

        public void SetUnit(MeasurementUnit value)
        {
            unit = value;
        }


        public string BmiWeightCategory()
        {
            double bmi = CalculateBmi();

            return bmi switch
            {
                < 18.5 => "Underweight", 
                < 25 => "Normal weight",
                < 30 => "Overweight (Pre-Obesity)",
                < 35 => "Overweight (Obesity class I)",
                < 40 => "Overweight (Obesity class II)",
                _ => "Overweight (Obesity class III)"
            };
        }

        public double CalculateBmi()
        {
            return unit switch
            {
                MeasurementUnit.Metric => weight / (height * height),
                MeasurementUnit.Imperial => 703.0 * weight / (height * height),
                _ => 0
            };
        }

        public string NormalWeight() =>
             unit switch
             {
                 MeasurementUnit.Metric => CalculateNormalWeight(18.50, 24.90, 1, "kg"),
                 MeasurementUnit.Imperial => CalculateNormalWeight(18.50, 24.90, 703, "lbs"),
                 _ => "Invalid unit"
             };

        private string CalculateNormalWeight(double lowerBound, double upperBound, double factor, string unitString)
        {
            double w1 = height * height / factor * lowerBound;
            double w2 = height * height / factor * upperBound;

            Console.WriteLine($"{w1} {w2}");

            return $"Normal BMI is between {lowerBound} and {upperBound}\n" +
                   $"Normal weight should be between {w1} and {w2} {unitString}";
        }
    }
}
