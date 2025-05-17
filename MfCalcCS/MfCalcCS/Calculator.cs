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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace MfCalcCS
{
    public partial class Calculator : Form
    {
        double num = 0;         //値を一時的に格納
        double num1 = 0;        //値1を格納
        double result = 0;      //結果
        int ope = -1;           //演算子をenumに基づいて判別
        bool afterNum = false;  //以前の入力が数字かどうか
        bool dotFlg = false;    //ドットを入力したか
        bool wasDot = false;    //既にドット入力したか
        int dotCount = 0;       //ドット入力後〇桁目
        int zeroCount = 0;      //末尾0の処理用
        double addNum = 0;      //末尾0の処理用
        string zeros = "error";
        bool equalFlg = false;

        enum Operator
        {
            plus,           //加算
            minus,          //減算
            multiplication, //乗算
            division,       //除算
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

        private string addZero(int zeroNum)　//小数点以下末尾に０を追加する関数
        {
            if (wasDot == true)
            {
                for (int i = 0; i < dotCount; i++)
                {
                    zeros = string.Concat(Enumerable.Repeat("0", zeroNum));
                }
                return zeros;
            }
            else
            {
                for (int i = 0; i < dotCount; i++)
                {
                    zeros = string.Concat(Enumerable.Repeat("0", zeroNum));
                }
                zeros = "." + zeros;
                return zeros;
            }
        }

        private void colorChange()  //演算子ボタン背景色変更
        {
            plusButton.BackColor = Color.White;
            minusButton.BackColor = Color.White;
            multiplicationButton.BackColor = Color.White;
            divisionButton.BackColor = Color.White;
            if (ope == (int)Operator.plus)
            {
                plusButton.BackColor = Color.LightGray;
            }
            if (ope == (int)Operator.minus)
            {
                minusButton.BackColor = Color.LightGray;
            }
            if (ope == (int)Operator.multiplication)
            {
                multiplicationButton.BackColor = Color.LightGray;
            }
            if (ope == (int)Operator.division)
            {
                divisionButton.BackColor = Color.LightGray;
            }
        }



        //***************************************

        #region //数字ボタンがクリックされたときの処理

        private void no0_Click(object sender, EventArgs e)
        {
            calculationFormula.Text = "";
            //もし前回の入力が数字だったら*10＋入力した数字　以下同
            if (afterNum == true)
            {

                if (equalFlg == true)
                {

                }
                else if (dotFlg == true)
                {
                    dotCount++;
                    zeroCount++;
                    resultBox.Text = num.ToString() + addZero(zeroCount);
                }
                else
                {
                    num *= 10;
                    resultBox.Text = num.ToString();
                }
            }
            else
            {
                resultBox.Text = "0";
                num = 0;
            }

            //数字フラグをtrueに
            afterNum = true;

        }

        #region //1-9のクリック処理
        private void no1_Click(object sender, EventArgs e)
        {
            calculationFormula.Text = "";
            addNum = 1;

            if (equalFlg == true)
            {

            }
            else if (afterNum == true)
            {
                if (dotFlg == true)
                {
                    dotCount++;
                    zeroCount = 0;
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

            if(dotFlg == true)
            {
                wasDot = true;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;
        }

        private void no2_Click(object sender, EventArgs e)
        {
            calculationFormula.Text = "";
            addNum = 2;
            if (equalFlg == true)
            {

            }
            else if (afterNum == true)
            {
                if (dotFlg == true)
                {
                    dotCount++;
                    zeroCount = 0;
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

            if (dotFlg == true)
            {
                wasDot = true;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;
        }

        private void no3_Click(object sender, EventArgs e)
        {
            calculationFormula.Text = "";
            addNum = 3;
            if (equalFlg == true)
            {

            }
            else if (afterNum == true)
            {
                if (dotFlg == true)
                {
                    dotCount++;
                    zeroCount = 0;
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

            if (dotFlg == true)
            {
                wasDot = true;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;
        }

        private void no4_Click(object sender, EventArgs e)
        {
            calculationFormula.Text = "";
            addNum = 4;
            if (equalFlg == true)
            {

            }
            else if (afterNum == true)
            {
                if (dotFlg == true)
                {
                    dotCount++;
                    zeroCount = 0;
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

            if (dotFlg == true)
            {
                wasDot = true;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;

        }

        private void no5_Click(object sender, EventArgs e)
        {
            calculationFormula.Text = "";
            addNum = 5;
            if (equalFlg == true)
            {

            }
            else if (afterNum == true)
            {
                if (dotFlg == true)
                {
                    dotCount++;
                    zeroCount = 0;
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

            if (dotFlg == true)
            {
                wasDot = true;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;

        }

        private void no6_Click(object sender, EventArgs e)
        {
            calculationFormula.Text = "";
            addNum = 6;
            if (equalFlg == true)
            {

            }
            else if (afterNum == true)
            {
                if (dotFlg == true)
                {
                    dotCount++;
                    zeroCount = 0;
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

            if (dotFlg == true)
            {
                wasDot = true;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;
        }

        private void no7_Click(object sender, EventArgs e)
        {
            calculationFormula.Text = "";
            addNum = 7;
            if (equalFlg == true)
            {

            }
            else if (afterNum == true)
            {
                if (dotFlg == true)
                {
                    dotCount++;
                    zeroCount = 0;
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

            if (dotFlg == true)
            {
                wasDot = true;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;

        }

        private void no8_Click(object sender, EventArgs e)
        {
            calculationFormula.Text = "";
            addNum = 8;
            if (equalFlg == true)
            {

            }
            else if (afterNum == true)
            {
                if (dotFlg == true)
                {
                    dotCount++;
                    zeroCount = 0;
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

            if (dotFlg == true)
            {
                wasDot = true;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;

        }

        private void no9_Click(object sender, EventArgs e)
        {
            calculationFormula.Text = "";
            addNum = 9;
            if (equalFlg == true)
            {

            }
            else if (afterNum == true)
            {
                if (dotFlg == true)
                {
                    dotCount++;
                    zeroCount = 0;
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

            if (dotFlg == true)
            {
                wasDot = true;
            }

            resultBox.Text = num.ToString();

            //数字フラグをtrueに
            afterNum = true;

        }
        #endregion
        #endregion


        //****************************************


        private void dotButton_Click(object sender, EventArgs e)
        {
            //ドットフラグを立てる、以降入力される数字に0.1*n
            dotFlg = true;
        }


        private void plusButton_Click(object sender, EventArgs e)
        {
            //一時的に要素を保存し、プラスフラグを立てる、数字フラグ・ドットフラグをfalseに
            ope = (int)Operator.plus;
            if (equalFlg == true)
            {

            }
            else
            {
                num1 = num;
            }
            num = 0;
            resultBox.Text = "+";
            colorChange();

            //初期化用
            afterNum = false;   //以前の入力が数字かどうか
            dotFlg = false;     //ドットを入力したか
            wasDot = false;     //既にドット入力をしたか
            equalFlg = false;
            dotCount = 0;       //ドット入力後〇桁目
            zeroCount = 0;      //末尾0の処理用
            zeros = "error";    //末尾0の処理用
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            //一時的に要素を保存し、マイナスフラグを立てる、数字フラグをfalseに
            ope = (int)Operator.minus;
            if (equalFlg == true)
            {

            }
            else
            {
                num1 = num;
            }
            num = 0;
            resultBox.Text = "-";
            colorChange();

            //初期化用
            afterNum = false;   //以前の入力が数字かどうか
            dotFlg = false;     //ドットを入力したか
            wasDot = false;     //既にドット入力をしたか
            equalFlg = false;
            dotCount = 0;       //ドット入力後〇桁目
            zeroCount = 0;      //末尾0の処理用
            zeros = "error";    //末尾0の処理用
        }

        private void multipleButton_Click(object sender, EventArgs e)
        {
            //一時的に要素を保存し、掛け算フラグを立てる、数字フラグをfalseに
            ope = (int)Operator.multiplication;
            if (equalFlg == true)
            {

            }
            else
            {
                num1 = num;
            }
            num = 0;
            resultBox.Text = "×";
            colorChange();

            //初期化用
            afterNum = false;   //以前の入力が数字かどうか
            dotFlg = false;     //ドットを入力したか
            wasDot = false;     //既にドット入力をしたか
            equalFlg = false;
            dotCount = 0;       //ドット入力後〇桁目
            zeroCount = 0;      //末尾0の処理用
            zeros = "error";    //末尾0の処理用
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            //一時的に要素を保存し、割り算フラグを立てる、数字フラグをfalseに
            ope = (int)Operator.division;
            if(equalFlg==true)
            {

            }
            else
            {
                num1 = num;
            }
            num = 0;
            resultBox.Text = "÷";
            colorChange();

            //初期化用
            afterNum = false;   //以前の入力が数字かどうか
            dotFlg = false;     //ドットを入力したか
            wasDot = false;     //既にドット入力をしたか
            equalFlg = false;
            dotCount = 0;       //ドット入力後〇桁目
            zeroCount = 0;      //末尾0の処理用
            zeros = "error";    //末尾0の処理用
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            //結果を出力したのち、一時保存用の変数を初期化
            if (ope == (int)Operator.plus)
            {
                calculationFormula.Text = num1.ToString() + "+" + num.ToString() + "=";
                result = num1 + num;
            }
            if (ope == (int)Operator.minus)
            {
                calculationFormula.Text = num1.ToString() + "-" + num.ToString() + "=";
                result = num1 - num;
            }
            if (ope == (int)Operator.multiplication)
            {
                calculationFormula.Text = num1.ToString() + "×" + num.ToString() + "=";
                result = num1 * num;
            }
            if (ope == (int)Operator.division)
            {
                calculationFormula.Text = num1.ToString() + "÷" + num.ToString() + "=";
                result = num1 / num;
            }
            num1 = result;
            equalFlg = true;
            resultBox.Text = result.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //全てを初期化する
            num = 0;            //値を一時的に格納
            num1 = 0;           //値1を格納
            result = 0;         //結果
            ope = -1;           //演算子をenumに基づいて判別
            afterNum = false;   //以前の入力が数字かどうか
            dotFlg = false;     //ドットを入力したか
            wasDot = false;     //既にドット入力をしたか
            dotCount = 0;       //ドット入力後〇桁目
            zeroCount = 0;      //末尾0の処理用
            zeros = "error";    //末尾0の処理用
            addNum = 0;         //追加する数字
            resultBox.Text = "";
            calculationFormula.Text = "";
            equalFlg = false;

            plusButton.BackColor = Color.White;
            minusButton.BackColor = Color.White;
            multiplicationButton.BackColor = Color.White;
            divisionButton.BackColor = Color.White;
        }

        private NameImput _nameInputInstance;

        public void saveResultButton_Click(object sender, EventArgs e)
        {
            //計算結果を保存

            
            

            //ポップアップウィンドウ→名前入力を受け付け
            if (_nameInputInstance == null || _nameInputInstance.IsDisposed)
            {
                _nameInputInstance = new NameImput(resultBox.Text,calculationFormula.Text);
            }
            //this.Hide();　ResultBox.txtを保持するため
            _nameInputInstance.ShowDialog();

        } 
    }
}
