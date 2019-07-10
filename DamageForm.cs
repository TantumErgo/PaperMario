using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paper_Mario
{
    public partial class DamageForm : Form
    {
        public DamageForm()
        {
            InitializeComponent();
            damageMessageLabel.Text = "You took Damage! Your HP is down to " + BattleForm.CURRENT_MARIO_HP.ToString() + "!";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
