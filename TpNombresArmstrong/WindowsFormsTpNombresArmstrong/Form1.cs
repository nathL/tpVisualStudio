using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTpNombresArmstrong
{
    public partial class TxtNbrArmstrong : Form
    {
        public TxtNbrArmstrong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 100; i <= 999; i++)
            {
                string conversion = i.ToString();
                string premierCaractere = conversion.Substring(0, 1);
                string deuxiemeCaractere = conversion.Substring(1, 1);
                string troisiemeCaractere = conversion.Substring(2, 1);
                int premierChiffre = int.Parse(premierCaractere);
                int deuxiemeChiffre = int.Parse(deuxiemeCaractere);
                int troisiemeChiffre = int.Parse(troisiemeCaractere);
                if (Math.Pow(premierChiffre, 3) + Math.Pow(deuxiemeChiffre, 3) + Math.Pow(troisiemeChiffre, 3) == i)
                {
                    this.listBoxNbrArmstrong.Items.Add(i + "");
                }
            }
        }
    }
}
