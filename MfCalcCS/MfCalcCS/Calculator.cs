using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MfCalcCS
{
    public partial class Calculator : Form
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        int ope = -1;
        bool beforeNum = false;
        bool dotflg = false;

        enum Operator
        {
            plus,
            minus,
            multiple,
            division,
        }

        public Calculator()
        {
            InitializeComponent();
        }

        private MainMenu _mainMenuInstance;
        private void toMainButton_Click(object sender, EventArgs e)
        {

            if (_mainMenuInstance == null || _mainMenuInstance.IsDisposed)
            {
                _mainMenuInstance = new MainMenu();
            }
            this.Hide();
            _mainMenuInstance.Show();
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void no0_Click(object sender, EventArgs e)
        {
            //もし前回の入力が数字だったら*10＋入力した数字　以下同
            if(resultBox.Text!=null)
            {
                resultBox.Text = "0";
                num1 = 0;
            }

            if (beforeNum == true)
            {
                num1 *= 10;
                resultBox.Text = num1.ToString();
            }

            //数字フラグをtrueに
            beforeNum = true;

        }

        private void no1_Click(object sender, EventArgs e)
        {
            //数字フラグをtrueに
            beforeNum = true;
        }

        private void no2_Click(object sender, EventArgs e)
        {
            //もし前回の入力が数字だったら*10＋入力した数字　以下同
            if (resultBox.Text != null)
            {
                resultBox.Text = "2";
                num1 = 2;
            }

            if (beforeNum == true)
            {
                num1 *= 10;
                num1 += 2;
                resultBox.Text = num1.ToString();
            }

            //数字フラグをtrueに
            beforeNum = true;
        }

        private void no3_Click(object sender, EventArgs e)
        {
            //もし前回の入力が数字だったら*10＋入力した数字　以下同
            if (resultBox.Text != null)
            {
                resultBox.Text = "3";
                num1 = 3;
            }
            else if (beforeNum == true)
            {
                num1 *= 10;
                num1 += 3;
                resultBox.Text = num1.ToString();
            }

            //数字フラグをtrueに
            beforeNum = true;
        }

        private void no4_Click(object sender, EventArgs e)
        {
            //数字フラグをtrueに
            beforeNum = true;


        }

        private void no5_Click(object sender, EventArgs e)
        {
            //数字フラグをtrueに
            beforeNum = true;

        }

        private void no6_Click(object sender, EventArgs e)
        {
            //数字フラグをtrueに
            beforeNum = true;

        }

        private void no7_Click(object sender, EventArgs e)
        {
            //数字フラグをtrueに
            beforeNum = true;

        }

        private void no8_Click(object sender, EventArgs e)
        {
            //数字フラグをtrueに
            beforeNum = true;

        }

        private void no9_Click(object sender, EventArgs e)
        {
            //数字フラグをtrueに
            beforeNum = true;

        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            //ドットフラグを立てる、以降入力される数字に0.1*n
            dotflg = true;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            //結果を出力したのち、すべてを初期化（クリア呼び出せばいいかも）
            if (ope == (int)Operator.plus)
            {

            }
            if (ope == (int)Operator.minus)
            {

            }
            if (ope == (int)Operator.multiple)
            {

            }
            if (ope == (int)Operator.division)
            {

            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            //一時的に要素を保存し、プラスフラグを立てる、数字フラグをfalseに
            ope = (int)Operator.plus;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            //一時的に要素を保存し、マイナスフラグを立てる、数字フラグをfalseに
            ope = (int)Operator.minus;
        }

        private void multipleButton_Click(object sender, EventArgs e)
        {
            //一時的に要素を保存し、掛け算フラグを立てる、数字フラグをfalseに
            ope = (int)Operator.multiple;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            //一時的に要素を保存し、割り算フラグを立てる、数字フラグをfalseに
            ope = (int)Operator.division;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //全てを初期化する
            num1 = 0;
            num2 = 0;
            ope = -1;
            result = 0;
            beforeNum = false;
            dotflg = false;
            resultBox.Text = "";
        }
    }

}
