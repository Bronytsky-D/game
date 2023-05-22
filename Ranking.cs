using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace game
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            

        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "save\\gameranking.txt");
            try
            {
                string fileContents = File.ReadAllText(filePath);

                text_reit.Text = fileContents;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the file: " + ex.Message);
            }
        }
    }
}
