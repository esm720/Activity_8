namespace Activity_8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExitBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CarbsBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CaloriesGroup = new System.Windows.Forms.GroupBox();
            this.CaloriesBut = new System.Windows.Forms.Button();
            this.outputFatLab = new System.Windows.Forms.Label();
            this.outputCarbsBut = new System.Windows.Forms.Label();
            this.FatTextInput = new System.Windows.Forms.TextBox();
            this.CarbsTextInput = new System.Windows.Forms.TextBox();
            this.CaloriesFromFatOutput = new System.Windows.Forms.Label();
            this.CaloriesFromCarbsOutput = new System.Windows.Forms.Label();
            this.CaloriesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBut
            // 
            this.ExitBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBut.Location = new System.Drawing.Point(423, 249);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(156, 80);
            this.ExitBut.TabIndex = 5;
            this.ExitBut.Text = "Exit";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(105, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grams of Fat:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(105, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grams from Carbs:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(105, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calories from Fat:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CarbsBut
            // 
            this.CarbsBut.Location = new System.Drawing.Point(226, 249);
            this.CarbsBut.Name = "CarbsBut";
            this.CarbsBut.Size = new System.Drawing.Size(167, 80);
            this.CarbsBut.TabIndex = 4;
            this.CarbsBut.Text = "Convert Carbs to Cal";
            this.CarbsBut.UseVisualStyleBackColor = true;
            this.CarbsBut.Click += new System.EventHandler(this.CarbsBut_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(96, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calories from Carbs:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CaloriesGroup
            // 
            this.CaloriesGroup.Controls.Add(this.CaloriesFromCarbsOutput);
            this.CaloriesGroup.Controls.Add(this.CaloriesFromFatOutput);
            this.CaloriesGroup.Controls.Add(this.CarbsTextInput);
            this.CaloriesGroup.Controls.Add(this.FatTextInput);
            this.CaloriesGroup.Controls.Add(this.outputCarbsBut);
            this.CaloriesGroup.Controls.Add(this.outputFatLab);
            this.CaloriesGroup.Controls.Add(this.CaloriesBut);
            this.CaloriesGroup.Controls.Add(this.ExitBut);
            this.CaloriesGroup.Controls.Add(this.label4);
            this.CaloriesGroup.Controls.Add(this.CarbsBut);
            this.CaloriesGroup.Controls.Add(this.label3);
            this.CaloriesGroup.Controls.Add(this.label1);
            this.CaloriesGroup.Controls.Add(this.label2);
            this.CaloriesGroup.Location = new System.Drawing.Point(43, 29);
            this.CaloriesGroup.Name = "CaloriesGroup";
            this.CaloriesGroup.Size = new System.Drawing.Size(591, 371);
            this.CaloriesGroup.TabIndex = 6;
            this.CaloriesGroup.TabStop = false;
            this.CaloriesGroup.Text = "Calories Calculator";
            // 
            // CaloriesBut
            // 
            this.CaloriesBut.Location = new System.Drawing.Point(39, 249);
            this.CaloriesBut.Name = "CaloriesBut";
            this.CaloriesBut.Size = new System.Drawing.Size(148, 80);
            this.CaloriesBut.TabIndex = 3;
            this.CaloriesBut.Text = "Convert Fat to Cal";
            this.CaloriesBut.UseVisualStyleBackColor = true;
            this.CaloriesBut.Click += new System.EventHandler(this.CaloriesBut_Click);
            // 
            // outputFatLab
            // 
            this.outputFatLab.AutoSize = true;
            this.outputFatLab.Location = new System.Drawing.Point(314, 150);
            this.outputFatLab.Name = "outputFatLab";
            this.outputFatLab.Size = new System.Drawing.Size(24, 33);
            this.outputFatLab.TabIndex = 7;
            this.outputFatLab.Text = " ";
            // 
            // outputCarbsBut
            // 
            this.outputCarbsBut.AutoSize = true;
            this.outputCarbsBut.Location = new System.Drawing.Point(314, 188);
            this.outputCarbsBut.Name = "outputCarbsBut";
            this.outputCarbsBut.Size = new System.Drawing.Size(24, 33);
            this.outputCarbsBut.TabIndex = 8;
            this.outputCarbsBut.Text = " ";
            // 
            // FatTextInput
            // 
            this.FatTextInput.Location = new System.Drawing.Point(319, 79);
            this.FatTextInput.Multiline = true;
            this.FatTextInput.Name = "FatTextInput";
            this.FatTextInput.Size = new System.Drawing.Size(195, 31);
            this.FatTextInput.TabIndex = 0;
            // 
            // CarbsTextInput
            // 
            this.CarbsTextInput.Location = new System.Drawing.Point(319, 116);
            this.CarbsTextInput.Multiline = true;
            this.CarbsTextInput.Name = "CarbsTextInput";
            this.CarbsTextInput.Size = new System.Drawing.Size(195, 31);
            this.CarbsTextInput.TabIndex = 2;
            // 
            // CaloriesFromFatOutput
            // 
            this.CaloriesFromFatOutput.AutoSize = true;
            this.CaloriesFromFatOutput.Location = new System.Drawing.Point(314, 154);
            this.CaloriesFromFatOutput.Name = "CaloriesFromFatOutput";
            this.CaloriesFromFatOutput.Size = new System.Drawing.Size(121, 33);
            this.CaloriesFromFatOutput.TabIndex = 11;
            this.CaloriesFromFatOutput.Text = "Calories";
            this.CaloriesFromFatOutput.Visible = false;
            // 
            // CaloriesFromCarbsOutput
            // 
            this.CaloriesFromCarbsOutput.AutoSize = true;
            this.CaloriesFromCarbsOutput.Location = new System.Drawing.Point(314, 188);
            this.CaloriesFromCarbsOutput.Name = "CaloriesFromCarbsOutput";
            this.CaloriesFromCarbsOutput.Size = new System.Drawing.Size(121, 33);
            this.CaloriesFromCarbsOutput.TabIndex = 12;
            this.CaloriesFromCarbsOutput.Text = "Calories";
            this.CaloriesFromCarbsOutput.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBut;
            this.ClientSize = new System.Drawing.Size(689, 443);
            this.Controls.Add(this.CaloriesGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.CaloriesGroup.ResumeLayout(false);
            this.CaloriesGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CarbsBut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox CaloriesGroup;
        private System.Windows.Forms.Button CaloriesBut;
        private System.Windows.Forms.TextBox CarbsTextInput;
        private System.Windows.Forms.TextBox FatTextInput;
        private System.Windows.Forms.Label outputCarbsBut;
        private System.Windows.Forms.Label outputFatLab;
        private System.Windows.Forms.Label CaloriesFromCarbsOutput;
        private System.Windows.Forms.Label CaloriesFromFatOutput;
    }
}

