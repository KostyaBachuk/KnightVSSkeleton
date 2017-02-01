using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightVSSkeleton
{
    public class Fighter
    {
        PictureBox sprite;
        private int health;

        public Fighter(PictureBox sprite)
        {
            this.sprite = sprite;
            this.health = 100;
        }
        public int MakeDamage()
        {
          Random random = new Random();
        return random.Next(10, 20);
        
        }
        public void ReceiveDemage(int howMachDemage)
        {
            health -= howMachDemage;
            if (health <= 0)
            {
                Die();
                health = 0;
            }
            
        }
        public int TellHealth()
        {
            return health;
        }

        private async void Die()
        {
            sprite.Image = Image.FromFile(@"C:\Users\Work\Desktop\KnightVSSkeleton-master\Assets/Skeleton_Death.gif");
            await Task.Delay(900);
            sprite.Enabled = false;
        }

        public bool isDead()
        {
            if (health <= 0) return true;
            else return false;
        }
    }
}
