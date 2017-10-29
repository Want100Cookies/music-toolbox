using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Toolbox
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_retrieve_playlist_Click(object sender, EventArgs e)
        {
            Screens.RetrievePlaylist screen = new Screens.RetrievePlaylist();
            screen.Show();
        }
    }
}
