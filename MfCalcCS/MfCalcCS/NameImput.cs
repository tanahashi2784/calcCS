using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MfCalcCS
{
    public partial class NameImput : Form
    {
        Calculator _calculatorInstance;

        public NameImput()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //計算結果を持ってくる
            string resultData=_calculatorInstance.resultBox.Text;

            //フォルダの作成
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(),"createTest");
            Directory.CreateDirectory(folderPath);

            ////テキストの作成
            //string textPath = Path.Combine(folderPath, "readTest.txt");
            ////File.WriteAllText(textPath, String.Empty);

            ////テキストの変更           
            //File.AppendAllText(textPath, $"AddData{Environment.NewLine}");

            ////テキスト内容の確認
            //string intext = File.ReadAllText(textPath);
            //MessageBox.Show(intext,
            //    "success",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (_calculatorInstance == null || _calculatorInstance.IsDisposed)
            {
                _calculatorInstance = new Calculator();
            }
            this.Hide();
            //_calculatorInstance.Show(); ハイドしてないから不要
        }
    }
}
