using static System.Double;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        private BmiCalculator bmiCalc = new BmiCalculator();

        public Form1()
        {
            InitializeComponent();
            radioButtonMetric.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGuiBmi();
        }

        private void Your_Name(object sender, EventArgs e)
        {

        }




        private void radioButtonImperrial_CheckedChanged(object sender, EventArgs e)
        {
            bmiCalc.SetUnit(MeasurementUnit.Imperial);
            labelHeight.Text = "Height (cm)";
            labelWeight.Text = "Weight (kg)";
            Console.WriteLine(labelWeight.Text);
            Console.WriteLine(labelHeight.Text);

        }


        private void radioButtonMetric_CheckedChanged(object sender, EventArgs e)
        {
            bmiCalc.SetUnit(MeasurementUnit.Metric);
            textBoxHeight.Text = "Height (ft and in)";
            textBoxWeight.Text = "Weight (lbs)";
            Console.WriteLine(labelWeight.Text);
            Console.WriteLine(textBoxHeight.Text);

        }

        private void UpdateGuiBmi()
        {
            ReadName();
            ReadHeight();
            ReadWeight();
            labelResWeightCategory.Text = bmiCalc.BmiWeightCategory();
            labelResBmi.Text = bmiCalc.CalculateBmi().ToString("N2");
            Console.WriteLine(labelResBmi.Text);
            Console.WriteLine(labelResWeightCategory.Text);
        }

        private void ReadName()
        {
            var res = textYourName.Text.Trim();
            if (!string.IsNullOrEmpty(res))
            {
                bmiCalc.SetName(textYourName.Text);
                groupBoxResult.Text = "Results for " + bmiCalc.Name;
            }
            else
            {
                bmiCalc.SetName("No name");
            }
        }

        private void ReadHeight()
        {
            if (bmiCalc.Unit == MeasurementUnit.Metric)
            {
                if (TryParse(textBoxHeight.Text, out var cmValue))
                {
                    bmiCalc.SetHeight(cmValue / 100);
                }
            }


            if (bmiCalc.Unit != MeasurementUnit.Imperial) return;
            const double inchValue = 0;
            TryParse(textBoxHeight.Text, out var ftValue);
            //double.TryParse(heightTextBoxInches.Text, out inchValue);
            bmiCalc.SetHeight((ftValue * 12.00) + inchValue);
        }

        private void ReadWeight()
        {
            if (TryParse(textBoxWeight.Text, out var weight))
            {
                bmiCalc.SetWeight(weight);
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            UpdateGuiBmi();
        }
    }
}
