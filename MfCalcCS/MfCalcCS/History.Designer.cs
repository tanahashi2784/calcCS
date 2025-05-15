namespace MfCalcCS
{
    partial class History
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
            this.HtoMButton = new System.Windows.Forms.Button();
            this.callResultButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // HtoMButton
            // 
            this.HtoMButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HtoMButton.AutoSize = true;
            this.HtoMButton.Location = new System.Drawing.Point(522, 13);
            this.HtoMButton.Margin = new System.Windows.Forms.Padding(4);
            this.HtoMButton.MaximumSize = new System.Drawing.Size(147, 250);
            this.HtoMButton.Name = "HtoMButton";
            this.HtoMButton.Size = new System.Drawing.Size(147, 203);
            this.HtoMButton.TabIndex = 0;
            this.HtoMButton.Text = "メインメニューへ";
            this.HtoMButton.UseVisualStyleBackColor = true;
            this.HtoMButton.Click += new System.EventHandler(this.HtoMButton_Click);
            // 
            // callResultButton
            // 
            this.callResultButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.callResultButton.Location = new System.Drawing.Point(522, 481);
            this.callResultButton.Margin = new System.Windows.Forms.Padding(4);
            this.callResultButton.MaximumSize = new System.Drawing.Size(400, 130);
            this.callResultButton.MinimumSize = new System.Drawing.Size(100, 100);
            this.callResultButton.Name = "callResultButton";
            this.callResultButton.Size = new System.Drawing.Size(147, 109);
            this.callResultButton.TabIndex = 1;
            this.callResultButton.Text = "計算結果を呼び出し";
            this.callResultButton.UseVisualStyleBackColor = true;
            this.callResultButton.Click += new System.EventHandler(this.callResultButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(179, 226);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 183);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(682, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.callResultButton);
            this.Controls.Add(this.HtoMButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "History";
            this.Text = "History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HtoMButton;
        private System.Windows.Forms.Button callResultButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}