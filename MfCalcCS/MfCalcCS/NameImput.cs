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
        string saveData=null;
        string saveFormula = null;


        public NameImput(string resultValue,string calcFormulaText)
        {
            InitializeComponent();
            saveData = resultValue;
            saveFormula = calcFormulaText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //計算結果を持ってくる
            if (saveData == ""||saveFormula=="")
            {
                MessageBox.Show("数値が入力されていません",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Dispose();
                return;
            }

            //フォルダの作成
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(),"SaveData");
            Directory.CreateDirectory(folderPath);

            //テキストの作成
            string textPath = Path.Combine(folderPath, "Result.txt");
            string saveName = resultName.Text;
            if(saveName=="")
            {
                MessageBox.Show("データ名が入力されていません",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            File.AppendAllText(textPath,$"{saveName}{Environment.NewLine}{saveFormula}{saveData}{Environment.NewLine}");


            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //if (_calculatorInstance == null || _calculatorInstance.IsDisposed)
            //{
            //    _calculatorInstance = new Calculator();
            //}
            this.Hide();
            //_calculatorInstance.Show(); ハイドしてないから不要
        }
    }
}
