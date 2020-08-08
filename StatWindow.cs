using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blaseball_Livestream
{
    public partial class StatWindow : Form
    {
        public StatWindow(Team team, Dictionary<string, Batter> batters, Dictionary<string, Pitcher> pitchers, Dictionary<string, float> teamStats, string statRange, int gameCount)
        {
            InitializeComponent();

            this.Text = team.ToString(); //name the dumb box
            
            Point target = new Point(); //init target point

            Font targetFont = new Font("Courier New", 11, FontStyle.Bold);

            Label fullName = new Label();
            fullName.Text = team.fullName;
            fullName.AutoSize = true;
            fullName.Font = targetFont;
            fullName.TextAlign = ContentAlignment.MiddleRight;
            teamInfoPanel.Controls.Add(fullName);
            fullName.Location = new Point(teamInfoPanel.Width - fullName.Width, target.Y);
            target.Offset(0, (int)Math.Round(fullName.Height*1.05));

            Label slogan = new Label();
            slogan.Text = team.slogan;
            slogan.Location = target;
            slogan.AutoSize = true;
            slogan.Font = targetFont;
            slogan.TextAlign = ContentAlignment.MiddleRight;
            teamInfoPanel.Controls.Add(slogan);
            slogan.Location = new Point(teamInfoPanel.Width - slogan.Width, target.Y);
            target.Offset(0, (int)Math.Round(fullName.Height * 3.15));

            Label range = new Label();
            range.Text = statRange;
            range.Location = target;
            range.AutoSize = true;
            range.Font = targetFont;
            range.TextAlign = ContentAlignment.MiddleRight;
            teamInfoPanel.Controls.Add(range);
            range.Location = new Point(teamInfoPanel.Width - range.Width, target.Y);
            target.Offset(0, (int)Math.Round(range.Height * 2.1));

            Label gameCountLabel = new Label();
            gameCountLabel.Text = string.Concat("Games in range: ", gameCount.ToString());
            gameCountLabel.Location = target;
            gameCountLabel.AutoSize = true;
            gameCountLabel.Font = targetFont;
            gameCountLabel.TextAlign = ContentAlignment.MiddleRight;
            teamInfoPanel.Controls.Add(gameCountLabel);
            gameCountLabel.Location = new Point(teamInfoPanel.Width - gameCountLabel.Width, target.Y);

                 
            target = new Point();
            target.Offset(5, 0);
            targetFont = new Font("Courier New", 9);

            foreach (KeyValuePair<string, float> entry in teamStats) //draw team stats to box
            {

                Label newEntryInPanel = new Label();
                newEntryInPanel.Anchor = AnchorStyles.Top;
                newEntryInPanel.Location = target;
                newEntryInPanel.Text = string.Concat(entry.Key, ": ", entry.Value.ToString());
                newEntryInPanel.AutoSize = true;
                newEntryInPanel.Font = targetFont;
                teamStatPanel.Controls.Add(newEntryInPanel);
                target.Offset(0, (int)Math.Round(newEntryInPanel.Height*1.2));
            }

            target = new Point(5, 0);
            foreach (KeyValuePair<string, Batter> entry in batters)
            {
                if (entry.Value.plateAppearances != 0 && entry.Value.OnbasePlusSlugging() != 0 && entry.Value.BattingAverage() < 1)
                {
                    batterTable.RowCount += 1;
                    Label batterNameLabel = CreateTabelLabel(entry.Value.name);
                    batterTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    batterTable.Controls.Add(batterNameLabel, 0, batterTable.RowCount);
                    batterTable.Controls.Add(CreateTabelLabel(entry.Value.BattingAverage().ToString().PadRight(5, '0').TrimStart('0')), 1, batterTable.RowCount);
                    batterTable.Controls.Add(CreateTabelLabel(entry.Value.OnBasePercentage().ToString().PadRight(5, '0').TrimStart('0')), 2, batterTable.RowCount);
                    batterTable.Controls.Add(CreateTabelLabel(entry.Value.SluggingAverage().ToString().PadRight(5, '0')), 3, batterTable.RowCount);
                    batterTable.Controls.Add(CreateTabelLabel(entry.Value.OnbasePlusSlugging().ToString().PadRight(5, '0')), 4, batterTable.RowCount);
                    batterTable.Controls.Add(CreateTabelLabel(entry.Value.outsTaken[OutTypes.Strikeout].ToString()), 5, batterTable.RowCount);
                    batterTable.Controls.Add(CreateTabelLabel(entry.Value.walks.ToString()), 6, batterTable.RowCount);
                    batterTable.Controls.Add(CreateTabelLabel(entry.Value.hits.ToString()), 7, batterTable.RowCount);
                    batterTable.Controls.Add(CreateTabelLabel(entry.Value.homeRuns.ToString()), 8, batterTable.RowCount);
                    batterTable.Controls.Add(CreateTabelLabel(entry.Value.rbis.ToString()), 9, batterTable.RowCount);
                }
            }

            foreach(KeyValuePair<string, Pitcher> entry in pitchers)
            {
                if (entry.Value.inningsPitched > 3)
                {
                    pitcherTable.RowCount += 1;
                    Label pitcherNameLabel = CreateTabelLabel(entry.Value.name);
                    pitcherTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    pitcherTable.Controls.Add(pitcherNameLabel, 0, pitcherTable.RowCount);
                    pitcherTable.Controls.Add(CreateTabelLabel(entry.Value.games.ToString()), 1, pitcherTable.RowCount);
                    pitcherTable.Controls.Add(CreateTabelLabel(entry.Value.inningsPitched.ToString()), 2, pitcherTable.RowCount);
                    pitcherTable.Controls.Add(CreateTabelLabel(entry.Value.ERA().ToString()), 3, pitcherTable.RowCount);
                    pitcherTable.Controls.Add(CreateTabelLabel(entry.Value.strikeouts.ToString()), 4, pitcherTable.RowCount);
                    pitcherTable.Controls.Add(CreateTabelLabel(entry.Value.WalksHitsperInningPitched().ToString().PadRight(5, '0')), 5, pitcherTable.RowCount);
                    pitcherTable.Controls.Add(CreateTabelLabel(entry.Value.wins.ToString()), 6, pitcherTable.RowCount);
                    pitcherTable.Controls.Add(CreateTabelLabel(entry.Value.losses.ToString()), 7, pitcherTable.RowCount);
                }
            }
        }

        private Label CreateTabelLabel(string text)
        {
            Font font = new Font("Courier New", 9);
            Label label = new Label();
            label.Text = text;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = font;

            return label;
        }


        private void StatWindow_Load(object sender, EventArgs e)
        {

        }

        private void pitcherStatPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teamInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
