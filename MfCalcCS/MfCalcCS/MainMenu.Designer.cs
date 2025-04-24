namespace MfCalcCS
{
    partial class MainMenu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.calcButton = new System.Windows.Forms.Button();
            this.histButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.calcButton.Location = new System.Drawing.Point(312, 100);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(273, 138);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "電卓";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // histButton
            // 
            this.histButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.histButton.Location = new System.Drawing.Point(312, 338);
            this.histButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histButton.Name = "histButton";
            this.histButton.Size = new System.Drawing.Size(273, 138);
            this.histButton.TabIndex = 1;
            this.histButton.Text = "履歴";
            this.histButton.UseVisualStyleBackColor = true;
            this.histButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 566);
            this.Controls.Add(this.histButton);
            this.Controls.Add(this.calcButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button histButton;
    }
}

