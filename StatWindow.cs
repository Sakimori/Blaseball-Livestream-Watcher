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
    public partial class StatWindow : Form
    {
        public StatWindow(string title, Dictionary<string, Batter> batters, Dictionary<string, Pitcher> pitchers, Dictionary<string, float> teamStats)
        {
            InitializeComponent();
            this.Text = title;
        }

        private void StatWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
