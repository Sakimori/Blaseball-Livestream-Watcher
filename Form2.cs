using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blaseball_Livestream
{
    public partial class Form2 : Form
    {
        SeasonDisplay selectedSeason;
        public Form2(List<SaveGame> saveGames, int season)
        {
            InitializeComponent();

            List<int> seasons = new List<int>();
            foreach(SaveGame game in saveGames)
            {
                if (!seasons.Contains(game.season)) { seasons.Add(game.season); }
            }
            foreach(int seasonNum in seasons)
            {
                listBoxSeasons.Items.Add(new SeasonDisplay(seasonNum));
            }
            listBoxSeasons.Items.Add(new SeasonDisplay(-1));
            listBoxSeasons.SetSelected(0, true);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SeasonAccept_Click(object sender, EventArgs e)
        {
            selectedSeason = listBoxSeasons.SelectedItem as SeasonDisplay;
            Close();
        }
    }

    class SeasonDisplay : IComparable<SeasonDisplay>
    {
        public SeasonDisplay(int newIndex)
        {
            index = newIndex;
        }

        int index;
        public override string ToString()
        {
            if(index == -1) { return "All seasons."; }
            return string.Concat("Season ", (index+1).ToString());
        }

        public int CompareTo(SeasonDisplay other)
        {
            return index.CompareTo(other.index);
        }
    }
}
