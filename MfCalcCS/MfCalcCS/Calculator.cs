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
        double num = 0;         //値を一時的に格納
        double num1 = 0;        //値1を格納
        double num2 = 0;        //値2を格納
        double result = 0;      //結果
        int ope = -1;           //演算子をenumに基づいて判別
        bool afterNum = false; //以前の入力が数字かどうか
        bool dotflg = false;    //ドットを入力したか
        int dotCount = 0;       //ドット入力後〇桁目
        double addNum = 0;

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

        #region //数字ボタンがクリックされたときの処理

        private void no0_Click(object sender, EventArgs e)
        {
            //もし前回の入力が数字だったら*10＋入力した数字　以下同
            if (afterNum == true)
            {

            }
            else 
            {
                resultBox.Text = "0";
                num = 0;
            }

            //数字フラグをtrueに
            afterNum = true;

        }

        private void no1_Click(object sender, EventArgs e)
        {
            addNum = 1;
            if (afterNum == true)
            {
                if (dotflg == true)
                {
                    dotCount++;
                    for (int i = 0;i < dotCount; i++)
                    {
                        addNum *= 0.1;
                    }
                    num += addNum;
                }
                else
                {
                    num *= 10;
                    num += addNum;
                }
            }
            else 
            {
                num = addNum;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;
        }

        private void no2_Click(object sender, EventArgs e)
        {
            addNum = 2;
            if (afterNum == true)
            {
                if (dotflg == true)
                {
                    dotCount++;
                    for (int i = 0; i < dotCount; i++)
                    {
                        addNum *= 0.1;
                    }
                    num += addNum;
                }
                else
                {
                    num *= 10;
                    num += addNum;
                }
            }
            else
            {
                num = addNum;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;
        }

        private void no3_Click(object sender, EventArgs e)
        {
            addNum = 3;
            if (afterNum == true)
            {
                if (dotflg == true)
                {
                    dotCount++;
                    for (int i = 0; i < dotCount; i++)
                    {
                        addNum *= 0.1;
                    }
                    num += addNum;
                }
                else
                {
                    num *= 10;
                    num += addNum;
                }
            }
            else
            {
                num = addNum;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;
        }

        private void no4_Click(object sender, EventArgs e)
        {
            addNum = 4;
            if (afterNum == true)
            {
                if (dotflg == true)
                {
                    dotCount++;
                    for (int i = 0; i < dotCount; i++)
                    {
                        addNum *= 0.1;
                    }
                    num += addNum;
                }
                else
                {
                    num *= 10;
                    num += addNum;
                }
            }
            else
            {
                num = addNum;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;

        }

        private void no5_Click(object sender, EventArgs e)
        {
            addNum = 5;
            if (afterNum == true)
            {
                if (dotflg == true)
                {
                    dotCount++;
                    for (int i = 0; i < dotCount; i++)
                    {
                        addNum *= 0.1;
                    }
                    num += addNum;
                }
                else
                {
                    num *= 10;
                    num += addNum;
                }
            }
            else
            {
                num = addNum;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;

        }

        private void no6_Click(object sender, EventArgs e)
        {
            addNum = 6;
            if (afterNum == true)
            {
                if (dotflg == true)
                {
                    dotCount++;
                    for (int i = 0; i < dotCount; i++)
                    {
                        addNum *= 0.1;
                    }
                    num += addNum;
                }
                else
                {
                    num *= 10;
                    num += addNum;
                }
            }
            else
            {
                num = addNum;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;
        }

        private void no7_Click(object sender, EventArgs e)
        {
            addNum = 7;
            if (afterNum == true)
            {
                if (dotflg == true)
                {
                    dotCount++;
                    for (int i = 0; i < dotCount; i++)
                    {
                        addNum *= 0.1;
                    }
                    num += addNum;
                }
                else
                {
                    num *= 10;
                    num += addNum;
                }
            }
            else
            {
                num = addNum;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;

        }

        private void no8_Click(object sender, EventArgs e)
        {
            addNum = 8;
            if (afterNum == true)
            {
                if (dotflg == true)
                {
                    dotCount++;
                    for (int i = 0; i < dotCount; i++)
                    {
                        addNum *= 0.1;
                    }
                    num += addNum;
                }
                else
                {
                    num *= 10;
                    num += addNum;
                }
            }
            else
            {
                num = addNum;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;

        }

        private void no9_Click(object sender, EventArgs e)
        {
            addNum = 9;
            if (afterNum == true)
            {
                if (dotflg == true)
                {
                    dotCount++;
                    for (int i = 0; i < dotCount; i++)
                    {
                        addNum *= 0.1;
                    }
                    num += addNum;
                }
                else
                {
                    num *= 10;
                    num += addNum;
                }
            }
            else
            {
                num = addNum;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;

        }

        #endregion 

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
            num = 0;         //値を一時的に格納
            num1 = 0;        //値1を格納
            num2 = 0;        //値2を格納
            result = 0;      //結果
            ope = -1;           //演算子をenumに基づいて判別
            afterNum = false; //以前の入力が数字かどうか
            dotflg = false;    //ドットを入力したか
            dotCount = 0;       //ドット入力後〇桁目
            resultBox.Text = "";
        }
    }

}
