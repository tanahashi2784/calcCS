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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();

        }

        private MainMenu _mainMenuInstance;

        void ErrorMessage(string errorType)
        {
            MessageBox.Show($"{errorType}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            return;
        }

        private void HtoMButton_Click(object sender, EventArgs e)
        {
            if (_mainMenuInstance == null || _mainMenuInstance.IsDisposed)
            {
                _mainMenuInstance = new MainMenu();
            }
            this.Hide();
            _mainMenuInstance.Show();
        }

        private void callResultButton_Click(object sender, EventArgs e)
        {
            int boxNum = 0;
            string textPath = Path.Combine(Directory.GetCurrentDirectory(), "SaveData", "Result.txt");
            List<string> lines = new List<string>();

            //一覧を作成
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();

            //テキスト内容の読み込み
            try
            {
                foreach (string line in File.ReadLines(textPath))
                {
                    // 読み込んだ1行を処理するコード
                    lines.Add(line);
                    boxNum++;
                }
            }
            catch (FileNotFoundException)
            {
                ErrorMessage("NO FILE");
                return;
            }
            catch (IOException ex)
            {
                ErrorMessage(ex.Message);
                return;
            }

            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = lines.Count;
            tableLayoutPanel.Location = new Point(100, 100);
            tableLayoutPanel.Size = new Size(500, 500);

            this.Controls.Add(tableLayoutPanel);

            TextBox[] textBoxes = new TextBox[boxNum];

            for (int i = 0,locationX=0,locationY=0,addY=20 ; i < boxNum; i++)
            {
                textBoxes[i] = new TextBox();      // ← ここが重要！
                textBoxes[i].Text = lines[i];
                textBoxes[i].Location=new Point(locationX,locationY);
                textBoxes[i].Size = new Size(100, 30);
                this.Controls.Add(textBoxes[i]);
                locationY = locationY + addY;

            }
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
