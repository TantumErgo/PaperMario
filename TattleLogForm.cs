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
    public partial class TattleLogForm : Form
    {
        public TattleLogForm()
        {
            InitializeComponent();
        }

        private void TattleLogForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'enemyDatabaseDataSet.Enemy' table. You can move, or remove it, as needed.
                this.enemyTableAdapter.Fill(this.enemyDatabaseDataSet.Enemy);                                
            }
            catch
            {
                MessageBox.Show("Something went wrong. Try opening the Tattle Log again.");
                this.Close(); 
            }
        }
        
        private void sortByEnemyIdButton_Click(object sender, EventArgs e)
        {
            this.enemyTableAdapter.FillByEnemyId(this.enemyDatabaseDataSet.Enemy);
        }

        private void sortAlphabeticallyButton_Click(object sender, EventArgs e)
        {
            this.enemyTableAdapter.FillByAlphabetical(this.enemyDatabaseDataSet.Enemy);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.enemyTableAdapter.FillBySearch(this.enemyDatabaseDataSet.Enemy, searchTextBox.Text);
        }
    }
}
