using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightVSSkeleton
{
    public partial class MainForm : Form
    {
        Fighter Knight;
        Fighter Skeleton;

        public MainForm()
        {
            InitializeComponent();
            Knight = new Fighter(knightPictureBox);
            Skeleton = new Fighter(skeletonPictureBox);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            skeletonPictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        /// <summary>
        /// После того, как рыцарь и скелет проивзаимодействовали, нужно обновить их здоровье и картинки
        /// </summary>
        public void Update_All()
        {
            throw new System.NotImplementedException();
        }

        private async void skeletonAttacks_Click(object sender, EventArgs e)
        {
            Knight.ReceiveDemage(Skeleton.MakeDamage());
            knightsHealth.Text = Knight.TellHealth().ToString();
            if (Knight.isDead())
            {
                skeletonAttacks.Enabled = false;
                button1.Enabled = false;
                await Task.Delay(900);
                MessageBox.Show("Winner Skeleton", "game over");
                Knight = new Fighter(knightPictureBox);
                Skeleton = new Fighter(skeletonPictureBox);
                knightsHealth.Text = Knight.TellHealth().ToString();
                skeletonsHealth.Text = Skeleton.TellHealth().ToString();
                button1.Enabled = true;
                skeletonAttacks.Enabled = true;
                skeletonPictureBox.Image = Image.FromFile(@"C:\Users\Work\Desktop\KnightVSSkeleton-master\Assets/Skeleton_Idle.gif");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Skeleton.ReceiveDemage(Knight.MakeDamage());
            skeletonsHealth.Text = Skeleton.TellHealth().ToString();
if (Skeleton.isDead())
            {
                button1.Enabled = false;
                skeletonAttacks.Enabled = false;
                await Task.Delay(900);if (Skeleton.isDead())

                    if(Skeleton.isDead())MessageBox.Show("Winner Knight", "game over");
                Knight = new Fighter(knightPictureBox);
                Skeleton = new Fighter(skeletonPictureBox);
                knightsHealth.Text = Knight.TellHealth().ToString();
                skeletonsHealth.Text = Skeleton.TellHealth().ToString();
                skeletonAttacks.Enabled = true;
                button1.Enabled = true;
                knightPictureBox.Image = Image.FromFile(@"C:\Users\Work\Desktop\KnightVSSkeleton-master\Assets/Knight_Idle.gif");
                
            }
            
        }

        private void knightsHealth_Click(object sender, EventArgs e)
        {

        }

        private void skeletonsHealth_Click(object sender, EventArgs e)
        {

        }
    }
}
