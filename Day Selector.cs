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
    public partial class Day_Selector : Form
    {
        SelectedGame selector;
        public Day_Selector(List<SaveGame> saveGames, SelectedGame newSelector)
        {
            InitializeComponent();
            selector = newSelector;
            saveGames.Sort();
            foreach (SaveGame game in saveGames)
            {
                listBoxSelector.Items.Add(game);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selector.selectedGame = listBoxSelector.SelectedItem as SaveGame;
            if(selector.selectedGame != null) { Close(); }
        }
    }
}
