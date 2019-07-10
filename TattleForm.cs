using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paper_Mario.Properties;
using System.IO;

namespace Paper_Mario
{
    public partial class TattleForm : Form
    {
        public TattleForm(Enemy enemy)
        {
            InitializeComponent();
            this.tattleNameLabel.Text = enemy.Name;
            this.tattleMaxHPLabel.Text = "Max HP: " + enemy.MaxHP;
            this.tattleAttackLabel.Text = "Attack: " + enemy.Attack;
            this.tattleDefenseLabel.Text = "Defense: " + enemy.Defense;
            this.tattleTextbox.Text = enemy.Tattle;
                        
            //calls a function to convert byte array in database to image
            //then sets the return value to the Image property of the control
            this.tattlePictureBox.Image = byteArrayToImage(enemy.EnemyImage);
        }

        public Image byteArrayToImage (byte[] arrayToConvert)
        {
            using (MemoryStream mStream = new MemoryStream(arrayToConvert))
            {
                return Image.FromStream(mStream);
            }
        }
    }
}
