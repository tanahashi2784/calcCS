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
            this.toMainButton = new System.Windows.Forms.Button();
            this.toHistButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toMainButton
            // 
            this.toMainButton.Location = new System.Drawing.Point(463, 223);
            this.toMainButton.Name = "toMainButton";
            this.toMainButton.Size = new System.Drawing.Size(138, 215);
            this.toMainButton.TabIndex = 0;
            this.toMainButton.Text = "メインメニューへ";
            this.toMainButton.UseVisualStyleBackColor = true;
            // 
            // toHistButton
            // 
            this.toHistButton.Location = new System.Drawing.Point(463, 12);
            this.toHistButton.Name = "toHistButton";
            this.toHistButton.Size = new System.Drawing.Size(138, 205);
            this.toHistButton.TabIndex = 1;
            this.toHistButton.Text = "履歴へ";
            this.toHistButton.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 448);
            this.Controls.Add(this.toHistButton);
            this.Controls.Add(this.toMainButton);
            this.Name = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toMainButton;
        private System.Windows.Forms.Button toHistButton;
    }
}