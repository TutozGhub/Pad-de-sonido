using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pad_de_sonido
{
    public partial class config : Form
    {
        public config()
        {
            InitializeComponent();
        }

        private void config_Load(object sender, EventArgs e)
        {

        }

        private void btnAudacityConfig_Click(object sender, EventArgs e)
        {
            programa prg = new programa();
            prg.audacity_dir();
        }
    }
}
