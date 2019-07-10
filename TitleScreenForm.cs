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
    public partial class TitleScreenForm : Form
    {
        public TitleScreenForm()
        {
            InitializeComponent();                        
        }

        private void tattleLogButton_Click(object sender, EventArgs e)
        {
            TattleLogForm tattleLog = new TattleLogForm();
            tattleLog.ShowDialog();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            EnemyAppearsForm enemyAppears = new EnemyAppearsForm();
            enemyAppears.ShowDialog();
            this.Close();
        }
    }
}
