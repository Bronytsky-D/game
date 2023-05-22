using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using game.Properties;

namespace game
{

    public partial class Game : Form
    {
        private List<Target> targets;
        private Graphics g;
        private string nickname;
        private uint score;
        private uint debt;
        private uint End_debt = 50;
        private int level_radius = 50;

        public Game()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private Target CreateTarget(int temp_radius,Color color, uint points)
        {
            Random random = new Random();

            int left = random.Next(ClientSize.Width - level_radius * 2);
            int top = random.Next(ClientSize.Height - level_radius * 2);
            Target target = new Target(left, top, temp_radius, color, points);

            return target;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Target target in targets)
            {
                target.Draw(g);
            }
        }
        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
            uint count =0;
            foreach (Target target in targets)
            {
                if (target.IsPointInside(e.X, e.Y))
                {
                    count++;
                    score += target.Points_price;
                    labelScore.Text = "Score: " + score;
                    Random random = new Random();
                    int newLeft = random.Next(ClientSize.Width - level_radius * 2);
                    int newTop = random.Next(ClientSize.Height - level_radius * 2);
                    newLeft = Math.Max(0, newLeft);
                    newLeft = Math.Min(newLeft, ClientSize.Width - level_radius * 2);
                    newTop = Math.Max(0, newTop);
                    newTop = Math.Min(newTop, ClientSize.Height - level_radius * 2);
                    target.SetPosition(newLeft, newTop);
                    Refresh();
                }
            }
            if(count==0)
            {
                debt += 10;
                labelDebt.Text = "Debt: " + debt;
                if (debt >= End_debt)
                {
                    string filePath = Path.Combine(Environment.CurrentDirectory, "save\\gameranking.txt");
                    List<string> lines = File.ReadAllLines(filePath).ToList();
                    List<KeyValuePair<string, uint>> scores = lines.Select(line =>
                    {
                        string[] parts = line.Split('-');
                        string name = parts[0].Trim();
                        uint temp_score = uint.Parse(parts[1].Trim());
                        return new KeyValuePair<string, uint>(name, temp_score);
                    }).ToList();
                    scores.Add(new KeyValuePair<string, uint>(nickname, score));
                    scores = scores.OrderByDescending(pair => pair.Value).ToList();
                    File.WriteAllLines(filePath, scores.Select(pair => $"{pair.Key}- {pair.Value}"));
                    Close();
                }
            }
        }
        private void button_Play_Click(object sender, EventArgs e)
        {
            btn_Play.Visible = false; labelDebt.Visible = true; labelScore.Visible = true;
            btn_Ranking.Visible = false; textBoxLog.Visible = false; Log.Visible = false;
            btn_Settings.Visible = false;
            targets = new List<Target>();

            Target target = CreateTarget(level_radius - 25, Color.Red, 40);
            targets.Add(target);
            target = CreateTarget(level_radius - 10,Color.Green, 20);
            targets.Add(target);
            target = CreateTarget(level_radius - 10,Color.Green, 20);
            targets.Add(target);
            target = CreateTarget(level_radius - 5,Color.Yellow, 10);
            targets.Add(target);
            target = CreateTarget(level_radius - 5,Color.Yellow, 10);
            targets.Add(target);
            score = 0;
            labelScore.Text = "Score: " + score;
            MouseClick += Game_MouseClick;
            g = CreateGraphics();
            Paint += Form1_Paint;
        }
        private void Settings_Click(object sender, EventArgs e)
        {
            btn_Play.Visible = false; btn_Settings.Visible = false; textBoxLog.Visible = false;
            btn_Ranking.Visible = false; Log.Visible=false;
            btn_Сhallenging.Visible = true; btn_Middle.Visible = true; btn_Easy.Visible = true;
            btn_Back.Visible = true;
        }

        private void btn_Сhallenging_Click(object sender, EventArgs e)
        {
            End_debt = 20;
            level_radius= 20;
            btn_Back_Click(sender,e);
        }
        private void btn_Middle_Click(object sender, EventArgs e)
        {
            End_debt = 40;
            level_radius = 30;
            btn_Back_Click(sender, e);
        }
        private void btn_Easy_Click(object sender, EventArgs e)
        {
            End_debt = 60;
            level_radius = 40;
            btn_Back_Click(sender, e);
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            btn_Play.Visible = true; btn_Settings.Visible = true; textBoxLog.Visible = true;
            btn_Ranking.Visible = true; Log.Visible = true;
            btn_Сhallenging.Visible = false; btn_Middle.Visible = false; btn_Easy.Visible = false;
            btn_Back.Visible = false;
        }

        private void textBoxLog_Click(object sender, EventArgs e)
        {
            textBoxLog.Text = " ";
        }

        private void Ranking_best_results_Click(object sender, EventArgs e)
        {
            Ranking Task1 = new Ranking();
            Task1.Activate();
            Task1.Show();

        }

        private void Log_Click(object sender, EventArgs e)
        {
            nickname = textBoxLog.Text.Trim();
            if (string.IsNullOrEmpty(nickname))
            {
                MessageBox.Show("You need a nickname to get into the ranking table");
            }
        }
    }

}
