using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Numerics;
using System.Drawing.Text;

namespace Evader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            end.Left = -300;
            end.Top = 800;
            Inst1.Left = 57;
            Inst1.Top = 114;
            Inst2.Left = 273;
            Inst2.Top = 385;
        }

        int seconds;
        int numOfTicks = 0;
        int flierSpeed;
        int groundSpeed;
        int obstacleSpeed;
        int mode = 1;
        bool flierLeft, flierRight;
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            end.Left = -300;
            end.Top = 800;
            numOfTicks++;

            if (numOfTicks == 10)
            {
                time.Text = (++seconds).ToString();
                numOfTicks = 0;
            }

            // moves the ground
            ground1.Top += groundSpeed;
            ground2.Top += groundSpeed;

            // background loop
            if (ground1.Top > 420)
            {
                ground1.Top = -420;
            }
            if (ground2.Top > 420)
            {
                ground2.Top = -420;
            }

            // flier movement left<->right
            if (flierLeft)
            {
                flier.Left -= flierSpeed;
            }
            if (flierRight)
            {
                flier.Left += flierSpeed;
            }

            // flier boundaries left<->right
            if (flier.Left < 2)
            {
                flierLeft = false;
            }
            else if (flier.Left + flier.Width > 429)
            {
                flierRight = false;
            }

            // moves obstacles down
            obs1.Top += obstacleSpeed;
            obs2.Top += obstacleSpeed;
            obs3.Top += obstacleSpeed;
            obs4.Top += obstacleSpeed;

            // respawns obstacles
            if (obs1.Top > panel1.Height)
            {
                ChangeObstacle(obs1);
                obs1.Left = rnd.Next(5, 24);
                obs1.Top = rnd.Next(100, 130) * -1;
            }

            if (obs2.Top > panel1.Height)
            {
                ChangeObstacle(obs2);
                obs2.Left = rnd.Next(115, 147);
                obs2.Top = rnd.Next(351, 380) * -1;
            }

            if (obs3.Top > panel1.Height)
            {
                ChangeObstacle(obs3);
                obs3.Left = rnd.Next(238, 265);
                obs3.Top = rnd.Next(481, 500) * -1;
            }

            if (obs4.Top > panel1.Height)
            {
                ChangeObstacle(obs4);
                obs4.Left = rnd.Next(356, 384);
                obs4.Top = rnd.Next(231, 250) * -1;
            }

            // collision checks
            if (flier.Bounds.IntersectsWith(obs1.Bounds)
                || flier.Bounds.IntersectsWith(obs2.Bounds)
                || flier.Bounds.IntersectsWith(obs3.Bounds)
                || flier.Bounds.IntersectsWith(obs4.Bounds))
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            end.Left = 17;
            end.Top = 178;
            end.BringToFront();
            buttonFirefly.Enabled = true;
            buttonFly.Enabled = true;
        }

        private void ChangeFlier(PictureBox flier)
        {
            if (mode == 1)
            {
                flier.Image = Properties.Resources.firefly;
            }
            else
            {
                flier.Image = Properties.Resources.fly;
            }
        }

        private void ChangeObstacle(PictureBox obs)
        {
            int num = rnd.Next(1, 4);

            if (mode == 1)
            {
                switch (num)
                {
                    case 1:
                        obs.Image = Properties.Resources.mushroom_1;
                        break;
                    case 2:
                        obs.Image = Properties.Resources.mushroom_2;
                        break;
                    case 3:
                        obs.Image = Properties.Resources.mushroom_3;
                        break;
                    default: break;
                }
            }
            else
            {
                switch (num)
                {
                    case 1:
                        obs.Image = Properties.Resources.cobweb_1;
                        break;
                    case 2:
                        obs.Image = Properties.Resources.cobweb_2;
                        break;
                    case 3:
                        obs.Image = Properties.Resources.cobweb_3;
                        break;
                    default: break;
                }
            }
        }

        private void MoveFlier(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && flier.Left > 0)
            {
                flierLeft = true;
            }
            if (e.KeyCode == Keys.Right && flier.Left + flier.Width < panel1.Width)
            {
                flierRight = true;
            }
        }

        private void StopFlier(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                flierLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                flierRight = false;
            }
        }

        private void buttonFirefly_Click(object sender, EventArgs e)
        {
            mode = 1;
            Reset();
        }

        private void buttonFly_Click(object sender, EventArgs e)
        {
            mode = 2;
            Reset();
        }

        private void Reset()
        {
            seconds = 0;
            end.Left = -300;
            end.Top = 800;

            Inst1.Left = -300;
            Inst1.Top = 800;
            Inst2.Left = -300;
            Inst2.Top = 800;

            buttonFirefly.Enabled = false;
            buttonFly.Enabled = false;
            flierSpeed = 10;
            obstacleSpeed = 10;
            groundSpeed = 10;

            flier.Left = 223;
            flier.Top = 354;
            flierLeft = false;
            flierRight = false;

            obs1.Left = -300;
            obs1.Top = 800;
            obs2.Left = -300;
            obs2.Top = 800;
            obs3.Left = -300;
            obs3.Top = 800;

            ground1.Left = 0;
            ground1.Top = 0;
            ground2.Left = 0;
            ground2.Top = -420;

            picture1.Left = -300;
            picture1.Top = 800;
            picture2.Left = -300;
            picture2.Top = 800;
            picture3.Left = -300;
            picture3.Top = 800;

            flypic.Left = -300;
            flypic.Top = 800;

            ChangeFlier(flier);
            timer1.Start();
        }
    }
}