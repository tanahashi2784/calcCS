using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();

            this.Controls.Add(tableLayoutPanel);

            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
