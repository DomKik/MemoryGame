using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameLab3
{
    public partial class allResults : Form
    {
        private Label[] resultsLabel;
        private string[] resultsLines;

        public allResults(string name, int result)
        {
            InitializeComponent();

            string path = "./results.txt";
            string newLine = name + " " + result.ToString();

            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path);
            }

            while (!System.IO.File.Exists(path)) { Thread.Sleep(10); }

            File.AppendAllText(path, newLine);
            resultsLines = File.ReadAllLines(path);

            File.WriteAllLinesAsync(path, resultsLines);

            initializeLabels();
        }

        private void initializeLabels()
        {
            resultsLabel = new Label[resultsLines.Length];

            for (int i=0; i<resultsLabel.Length; i++)
            {
                this.resultsLabel[i] = new Label();

                this.resultsLabel[i].AutoSize = true;
                this.resultsLabel[i].Location = new System.Drawing.Point(20, 25*(i+1));
                this.resultsLabel[i].Text = resultsLines[i];

                this.Controls.Add(this.resultsLabel[i]);
            }

        }

        private void allResults_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
