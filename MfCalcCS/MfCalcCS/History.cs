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
        private CustomTextBox1[] textBoxes;
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
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Size = new Size(500, 500);

            //this.Controls.Add(tableLayoutPanel);

            textBoxes = new CustomTextBox1[boxNum];
            for (int i = 0,locationX=0,locationY=0,addY=30,addX=150; i < boxNum; i++)
            {
                textBoxes[i] = new CustomTextBox1();      // ← ここが重要！
                textBoxes[i].Text = lines[i];
                textBoxes[i].Location=new Point(locationX,locationY);
                textBoxes[i].Size = new Size(addX, addY);
                textBoxes[i].Font = new Font(Font.FontFamily, 16);
                textBoxes[i].textID = i;
                textBoxes[i].ReadOnly = true;
                this.Controls.Add(textBoxes[i]);
                textBoxes[i].ContextMenuStrip = contextMenuStrip1;
                if (i % 2 == 1)
                {
                    locationY = locationY + addY;
                    if(i!=0)locationX = locationX - addX;
                }
                else locationX = locationX + addX;

            }

            tableLayoutPanel.SendToBack();

        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            string textPath = Path.Combine(Directory.GetCurrentDirectory(), "SaveData", "Result.txt");
            List<string> lines = new List<string>();
            

            // クリックされたメニュー項目 (ToolStripMenuItem) を取得
            ToolStripMenuItem clickedMenuItem = sender as ToolStripMenuItem;

            if (clickedMenuItem != null)
            {
                // クリックされたメニュー項目から、その親の ContextMenuStrip を取得
                ContextMenuStrip ownerContextMenu = clickedMenuItem.Owner as ContextMenuStrip;

                if (ownerContextMenu != null)
                {
                    // ContextMenuStripから、メニューが表示された元のコントロールを取得！
                    Control sourceControl = ownerContextMenu.SourceControl;

                    CustomTextBox1 sourceTextBox= (CustomTextBox1)sourceControl;

                    if (sourceControl != null)
                    {
                        if (sourceTextBox.textID < 2)
                        {
                            if (sourceTextBox.textID % 2 == 0)
                            {
                                //テキスト内容の
                                try
                                {
                                    //lines[sourceTextBox.textID].
                                    
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
                                textBoxes[sourceTextBox.textID].Dispose();
                                textBoxes[sourceTextBox.textID + 1].Dispose();
                            }
                        }
                    }
                }
            }
        }
    }
}
