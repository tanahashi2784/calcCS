namespace MfCalcCS
{
    partial class Calculator
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
            this.CtoMButton = new System.Windows.Forms.Button();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.no1 = new System.Windows.Forms.Button();
            this.no2 = new System.Windows.Forms.Button();
            this.no3 = new System.Windows.Forms.Button();
            this.no4 = new System.Windows.Forms.Button();
            this.no5 = new System.Windows.Forms.Button();
            this.no6 = new System.Windows.Forms.Button();
            this.no9 = new System.Windows.Forms.Button();
            this.no8 = new System.Windows.Forms.Button();
            this.no7 = new System.Windows.Forms.Button();
            this.no0 = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.calculationFormula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CtoMButton
            // 
            this.CtoMButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtoMButton.Location = new System.Drawing.Point(542, 0);
            this.CtoMButton.Margin = new System.Windows.Forms.Padding(4);
            this.CtoMButton.MaximumSize = new System.Drawing.Size(400, 130);
            this.CtoMButton.MinimumSize = new System.Drawing.Size(100, 100);
            this.CtoMButton.Name = "CtoMButton";
            this.CtoMButton.Size = new System.Drawing.Size(202, 100);
            this.CtoMButton.TabIndex = 0;
            this.CtoMButton.Text = "メインメニューへ";
            this.CtoMButton.UseVisualStyleBackColor = true;
            this.CtoMButton.Click += new System.EventHandler(this.toMainButton_Click);
            // 
            // saveResultButton
            // 
            this.saveResultButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveResultButton.Location = new System.Drawing.Point(542, 250);
            this.saveResultButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveResultButton.MaximumSize = new System.Drawing.Size(400, 130);
            this.saveResultButton.MinimumSize = new System.Drawing.Size(100, 100);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(202, 100);
            this.saveResultButton.TabIndex = 2;
            this.saveResultButton.Text = "計算結果を保存";
            this.saveResultButton.UseVisualStyleBackColor = true;
            // 
            // no1
            // 
            this.no1.Location = new System.Drawing.Point(82, 411);
            this.no1.Name = "no1";
            this.no1.Size = new System.Drawing.Size(72, 63);
            this.no1.TabIndex = 3;
            this.no1.Text = "1";
            this.no1.UseVisualStyleBackColor = true;
            this.no1.Click += new System.EventHandler(this.no1_Click);
            // 
            // no2
            // 
            this.no2.Location = new System.Drawing.Point(160, 411);
            this.no2.Name = "no2";
            this.no2.Size = new System.Drawing.Size(72, 63);
            this.no2.TabIndex = 4;
            this.no2.Text = "2";
            this.no2.UseVisualStyleBackColor = true;
            this.no2.Click += new System.EventHandler(this.no2_Click);
            // 
            // no3
            // 
            this.no3.Location = new System.Drawing.Point(238, 411);
            this.no3.Name = "no3";
            this.no3.Size = new System.Drawing.Size(72, 63);
            this.no3.TabIndex = 5;
            this.no3.Text = "3";
            this.no3.UseVisualStyleBackColor = true;
            this.no3.Click += new System.EventHandler(this.no3_Click);
            // 
            // no4
            // 
            this.no4.Location = new System.Drawing.Point(82, 342);
            this.no4.Name = "no4";
            this.no4.Size = new System.Drawing.Size(72, 63);
            this.no4.TabIndex = 6;
            this.no4.Text = "4";
            this.no4.UseVisualStyleBackColor = true;
            this.no4.Click += new System.EventHandler(this.no4_Click);
            // 
            // no5
            // 
            this.no5.Location = new System.Drawing.Point(160, 342);
            this.no5.Name = "no5";
            this.no5.Size = new System.Drawing.Size(72, 63);
            this.no5.TabIndex = 7;
            this.no5.Text = "5";
            this.no5.UseVisualStyleBackColor = true;
            this.no5.Click += new System.EventHandler(this.no5_Click);
            // 
            // no6
            // 
            this.no6.Location = new System.Drawing.Point(238, 342);
            this.no6.Name = "no6";
            this.no6.Size = new System.Drawing.Size(72, 63);
            this.no6.TabIndex = 8;
            this.no6.Text = "6";
            this.no6.UseVisualStyleBackColor = true;
            this.no6.Click += new System.EventHandler(this.no6_Click);
            // 
            // no9
            // 
            this.no9.Location = new System.Drawing.Point(238, 273);
            this.no9.Name = "no9";
            this.no9.Size = new System.Drawing.Size(72, 63);
            this.no9.TabIndex = 9;
            this.no9.Text = "9";
            this.no9.UseVisualStyleBackColor = true;
            this.no9.Click += new System.EventHandler(this.no9_Click);
            // 
            // no8
            // 
            this.no8.Location = new System.Drawing.Point(160, 273);
            this.no8.Name = "no8";
            this.no8.Size = new System.Drawing.Size(72, 63);
            this.no8.TabIndex = 10;
            this.no8.Text = "8";
            this.no8.UseVisualStyleBackColor = true;
            this.no8.Click += new System.EventHandler(this.no8_Click);
            // 
            // no7
            // 
            this.no7.Location = new System.Drawing.Point(82, 273);
            this.no7.Name = "no7";
            this.no7.Size = new System.Drawing.Size(72, 63);
            this.no7.TabIndex = 11;
            this.no7.Text = "7";
            this.no7.UseVisualStyleBackColor = true;
            this.no7.Click += new System.EventHandler(this.no7_Click);
            // 
            // no0
            // 
            this.no0.Location = new System.Drawing.Point(82, 480);
            this.no0.Name = "no0";
            this.no0.Size = new System.Drawing.Size(150, 63);
            this.no0.TabIndex = 12;
            this.no0.Text = "0";
            this.no0.UseVisualStyleBackColor = true;
            this.no0.Click += new System.EventHandler(this.no0_Click);
            // 
            // dotButton
            // 
            this.dotButton.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dotButton.Location = new System.Drawing.Point(238, 480);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(72, 63);
            this.dotButton.TabIndex = 13;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(316, 411);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(72, 132);
            this.resultButton.TabIndex = 14;
            this.resultButton.Text = "＝";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.White;
            this.plusButton.Location = new System.Drawing.Point(316, 273);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(72, 132);
            this.plusButton.TabIndex = 15;
            this.plusButton.Text = "＋";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(316, 204);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(72, 63);
            this.minusButton.TabIndex = 16;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Location = new System.Drawing.Point(238, 204);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(72, 63);
            this.multiplicationButton.TabIndex = 17;
            this.multiplicationButton.Text = "×";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multipleButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(160, 204);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(72, 63);
            this.divisionButton.TabIndex = 18;
            this.divisionButton.Text = "÷";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(82, 204);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(72, 63);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resultBox.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resultBox.Location = new System.Drawing.Point(82, 85);
            this.resultBox.MaxLength = 10;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(306, 87);
            this.resultBox.TabIndex = 20;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // calculationFormula
            // 
            this.calculationFormula.BackColor = System.Drawing.Color.Gainsboro;
            this.calculationFormula.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.calculationFormula.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.calculationFormula.Location = new System.Drawing.Point(82, 48);
            this.calculationFormula.Name = "calculationFormula";
            this.calculationFormula.ReadOnly = true;
            this.calculationFormula.Size = new System.Drawing.Size(305, 30);
            this.calculationFormula.TabIndex = 21;
            this.calculationFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 589);
            this.Controls.Add(this.calculationFormula);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.no0);
            this.Controls.Add(this.no7);
            this.Controls.Add(this.no8);
            this.Controls.Add(this.no9);
            this.Controls.Add(this.no6);
            this.Controls.Add(this.no5);
            this.Controls.Add(this.no4);
            this.Controls.Add(this.no3);
            this.Controls.Add(this.no2);
            this.Controls.Add(this.no1);
            this.Controls.Add(this.saveResultButton);
            this.Controls.Add(this.CtoMButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CtoMButton;
        private System.Windows.Forms.Button saveResultButton;
        private System.Windows.Forms.Button no1;
        private System.Windows.Forms.Button no2;
        private System.Windows.Forms.Button no3;
        private System.Windows.Forms.Button no4;
        private System.Windows.Forms.Button no5;
        private System.Windows.Forms.Button no6;
        private System.Windows.Forms.Button no9;
        private System.Windows.Forms.Button no8;
        private System.Windows.Forms.Button no7;
        private System.Windows.Forms.Button no0;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox calculationFormula;
    }
}