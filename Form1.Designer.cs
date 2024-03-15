namespace Assignment_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textYourName = new TextBox();
            Your_Name_Label = new Label();
            labelHeight = new Label();
            textBoxHeight = new TextBox();
            groupBoxUnit = new GroupBox();
            radioButtonImperrial = new RadioButton();
            radioButtonMetric = new RadioButton();
            textBoxWeight = new TextBox();
            labelWeight = new Label();
            buttonCalculate = new Button();
            groupBoxResult = new GroupBox();
            labelWeightCategory = new Label();
            labelYourBmi = new Label();
            labelResWeightCategory = new Label();
            labelResBmi = new Label();
            groupBoxUnit.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // textYourName
            // 
            textYourName.Location = new Point(159, 44);
            textYourName.Name = "textYourName";
            textYourName.Size = new Size(220, 23);
            textYourName.TabIndex = 0;
            textYourName.TextChanged += Your_Name;
            // 
            // Your_Name_Label
            // 
            Your_Name_Label.AutoSize = true;
            Your_Name_Label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Your_Name_Label.Location = new Point(27, 42);
            Your_Name_Label.Name = "Your_Name_Label";
            Your_Name_Label.Size = new Size(111, 25);
            Your_Name_Label.TabIndex = 1;
            Your_Name_Label.Text = "Your Name";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(95, 103);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(43, 15);
            labelHeight.TabIndex = 2;
            labelHeight.Text = "Height";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(159, 100);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(63, 23);
            textBoxHeight.TabIndex = 3;
            // 
            // groupBoxUnit
            // 
            groupBoxUnit.Controls.Add(radioButtonImperrial);
            groupBoxUnit.Controls.Add(radioButtonMetric);
            groupBoxUnit.Location = new Point(244, 100);
            groupBoxUnit.Name = "groupBoxUnit";
            groupBoxUnit.Size = new Size(135, 74);
            groupBoxUnit.TabIndex = 4;
            groupBoxUnit.TabStop = false;
            groupBoxUnit.Text = "Unit";
            // 
            // radioButtonImperrial
            // 
            radioButtonImperrial.AutoSize = true;
            radioButtonImperrial.Location = new Point(16, 47);
            radioButtonImperrial.Name = "radioButtonImperrial";
            radioButtonImperrial.Size = new Size(108, 19);
            radioButtonImperrial.TabIndex = 1;
            radioButtonImperrial.TabStop = true;
            radioButtonImperrial.Text = "Imperial (ft, lbs)";
            radioButtonImperrial.UseVisualStyleBackColor = true;
            // 
            // radioButtonMetric
            // 
            radioButtonMetric.AutoSize = true;
            radioButtonMetric.Location = new Point(16, 22);
            radioButtonMetric.Name = "radioButtonMetric";
            radioButtonMetric.Size = new Size(106, 19);
            radioButtonMetric.TabIndex = 0;
            radioButtonMetric.TabStop = true;
            radioButtonMetric.Text = "Metric (kg, cm)";
            radioButtonMetric.UseVisualStyleBackColor = true;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(159, 141);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(63, 23);
            textBoxWeight.TabIndex = 6;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(93, 149);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(45, 15);
            labelWeight.TabIndex = 5;
            labelWeight.Text = "Weight";
            labelWeight.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(159, 195);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(220, 47);
            buttonCalculate.TabIndex = 7;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(labelWeightCategory);
            groupBoxResult.Controls.Add(labelYourBmi);
            groupBoxResult.Controls.Add(labelResWeightCategory);
            groupBoxResult.Controls.Add(labelResBmi);
            groupBoxResult.Location = new Point(159, 274);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(220, 124);
            groupBoxResult.TabIndex = 5;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Results For";
            // 
            // labelWeightCategory
            // 
            labelWeightCategory.AutoSize = true;
            labelWeightCategory.Location = new Point(16, 81);
            labelWeightCategory.Name = "labelWeightCategory";
            labelWeightCategory.Size = new Size(96, 15);
            labelWeightCategory.TabIndex = 3;
            labelWeightCategory.Text = "Weight Category";
            // 
            // labelYourBmi
            // 
            labelYourBmi.AutoSize = true;
            labelYourBmi.Location = new Point(16, 29);
            labelYourBmi.Name = "labelYourBmi";
            labelYourBmi.Size = new Size(55, 15);
            labelYourBmi.TabIndex = 2;
            labelYourBmi.Text = "Your BMI";
            // 
            // labelResWeightCategory
            // 
            labelResWeightCategory.BackColor = SystemColors.Control;
            labelResWeightCategory.BorderStyle = BorderStyle.Fixed3D;
            labelResWeightCategory.Location = new Point(119, 80);
            labelResWeightCategory.Name = "labelResWeightCategory";
            labelResWeightCategory.Size = new Size(88, 24);
            labelResWeightCategory.TabIndex = 1;
            // 
            // labelResBmi
            // 
            labelResBmi.BackColor = SystemColors.Control;
            labelResBmi.BorderStyle = BorderStyle.Fixed3D;
            labelResBmi.Location = new Point(119, 28);
            labelResBmi.Name = "labelResBmi";
            labelResBmi.Size = new Size(88, 24);
            labelResBmi.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 447);
            Controls.Add(groupBoxResult);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxWeight);
            Controls.Add(labelWeight);
            Controls.Add(groupBoxUnit);
            Controls.Add(textBoxHeight);
            Controls.Add(labelHeight);
            Controls.Add(Your_Name_Label);
            Controls.Add(textYourName);
            Name = "Form1";
            Text = "BMI Calculator";
            Load += Form1_Load;
            groupBoxUnit.ResumeLayout(false);
            groupBoxUnit.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textYourName;
        private Label Your_Name_Label;
        private Label labelHeight;
        private TextBox textBoxHeight;
        private GroupBox groupBoxUnit;
        private TextBox textBoxWeight;
        private Label labelWeight;
        private Button buttonCalculate;
        private GroupBox groupBoxResult;
        private Label labelResBmi;
        private Label labelWeightCategory;
        private Label labelYourBmi;
        private Label labelResWeightCategory;
        private RadioButton radioButtonImperrial;
        private RadioButton radioButtonMetric;
    }
}
