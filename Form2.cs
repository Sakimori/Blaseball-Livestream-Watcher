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
        SelectedSeason selectedSeason;
        public Form2(List<SaveGame> saveGames, SelectedSeason selector)
        {
            InitializeComponent();

            selectedSeason = selector;
            List<int> seasons = new List<int>();
            foreach(SaveGame game in saveGames)
            {
                if (!seasons.Contains(game.seasonTracked)) { seasons.Add(game.seasonTracked); }
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
            selectedSeason.seasonDisplay = listBoxSeasons.SelectedItem as SeasonDisplay;
            if (selectedSeason.seasonDisplay != null) { Close(); }
        }
    }

    public class SeasonDisplay : IComparable<SeasonDisplay>
    {
        public SeasonDisplay(int newIndex)
        {
            index = newIndex;
        }

        public int index;
        public override string ToString()
        {
            if(index == -1) { return "All seasons"; }
            else if (index % 10000 == 0) { return string.Concat("Season ", ((index / 10000) + 1).ToString()); }
            else { return string.Concat("Postseason ", ((index - 5000) / 10000) + 1).ToString(); }
        }

        public int CompareTo(SeasonDisplay other)
        {
            return other.index.CompareTo(index);
        }
    }
}
