namespace game
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelScore = new System.Windows.Forms.Label();
            this.labelDebt = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Middle = new System.Windows.Forms.Button();
            this.btn_Сhallenging = new System.Windows.Forms.Button();
            this.btn_Easy = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.btn_Ranking = new System.Windows.Forms.Button();
            this.lable_Log = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 33);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(46, 16);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Score ";
            this.labelScore.Visible = false;
            // 
            // labelDebt
            // 
            this.labelDebt.AutoSize = true;
            this.labelDebt.Location = new System.Drawing.Point(12, 83);
            this.labelDebt.Name = "labelDebt";
            this.labelDebt.Size = new System.Drawing.Size(36, 16);
            this.labelDebt.TabIndex = 1;
            this.labelDebt.Text = "Debt";
            this.labelDebt.Visible = false;
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(15, 33);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(130, 47);
            this.btn_Play.TabIndex = 2;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Location = new System.Drawing.Point(15, 116);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(130, 47);
            this.btn_Settings.TabIndex = 3;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // btn_Middle
            // 
            this.btn_Middle.Location = new System.Drawing.Point(245, 189);
            this.btn_Middle.Name = "btn_Middle";
            this.btn_Middle.Size = new System.Drawing.Size(166, 80);
            this.btn_Middle.TabIndex = 4;
            this.btn_Middle.Text = "Middle";
            this.btn_Middle.UseVisualStyleBackColor = true;
            this.btn_Middle.Visible = false;
            this.btn_Middle.Click += new System.EventHandler(this.btn_Middle_Click);
            // 
            // btn_Сhallenging
            // 
            this.btn_Сhallenging.Location = new System.Drawing.Point(245, 83);
            this.btn_Сhallenging.Name = "btn_Сhallenging";
            this.btn_Сhallenging.Size = new System.Drawing.Size(166, 80);
            this.btn_Сhallenging.TabIndex = 5;
            this.btn_Сhallenging.Text = "Сhallenging";
            this.btn_Сhallenging.UseVisualStyleBackColor = true;
            this.btn_Сhallenging.Visible = false;
            this.btn_Сhallenging.Click += new System.EventHandler(this.btn_Сhallenging_Click);
            // 
            // btn_Easy
            // 
            this.btn_Easy.Location = new System.Drawing.Point(245, 300);
            this.btn_Easy.Name = "btn_Easy";
            this.btn_Easy.Size = new System.Drawing.Size(166, 80);
            this.btn_Easy.TabIndex = 6;
            this.btn_Easy.Text = "Easy";
            this.btn_Easy.UseVisualStyleBackColor = true;
            this.btn_Easy.Visible = false;
            this.btn_Easy.Click += new System.EventHandler(this.btn_Easy_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(594, 23);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(135, 66);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Visible = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(259, 112);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(152, 40);
            this.textBoxLog.TabIndex = 8;
            // 
            // btn_Ranking
            // 
            this.btn_Ranking.Location = new System.Drawing.Point(15, 204);
            this.btn_Ranking.Name = "btn_Ranking";
            this.btn_Ranking.Size = new System.Drawing.Size(130, 45);
            this.btn_Ranking.TabIndex = 9;
            this.btn_Ranking.Text = "Ranking";
            this.btn_Ranking.UseVisualStyleBackColor = true;
            this.btn_Ranking.Click += new System.EventHandler(this.Ranking_best_results_Click);
            // 
            // lable_Log
            // 
            this.lable_Log.AutoSize = true;
            this.lable_Log.Location = new System.Drawing.Point(299, 64);
            this.lable_Log.Name = "lable_Log";
            this.lable_Log.Size = new System.Drawing.Size(0, 16);
            this.lable_Log.TabIndex = 10;
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(287, 54);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(75, 23);
            this.Log.TabIndex = 11;
            this.Log.Text = "Log in ";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 460);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.lable_Log);
            this.Controls.Add(this.btn_Ranking);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Easy);
            this.Controls.Add(this.btn_Сhallenging);
            this.Controls.Add(this.btn_Middle);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.labelDebt);
            this.Controls.Add(this.labelScore);
            this.Name = "Game";
            this.Text = "AimLab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelDebt;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Middle;
        private System.Windows.Forms.Button btn_Сhallenging;
        private System.Windows.Forms.Button btn_Easy;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button btn_Ranking;
        private System.Windows.Forms.Label lable_Log;
        private System.Windows.Forms.Button Log;
    }
}

