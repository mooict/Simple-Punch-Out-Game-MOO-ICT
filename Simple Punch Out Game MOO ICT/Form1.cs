namespace Simple_Punch_Out_Game_MOO_ICT
{
    public partial class Form1 : Form
    {

        bool playerBlock = false;
        bool enemyBlock = false;
        Random random = new Random();
        int enemySpeed = 5;
        int index = 0;
        int playerHealth = 100;
        int enemyHealth = 100;
        List<string> enemyAttack = new List<string> { "left", "right", "block"};



        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void BoxerAttackTImerEvent(object sender, EventArgs e)
        {

            index = random.Next(0, enemyAttack.Count);

            switch (enemyAttack[index].ToString())
            {
                case "left":
                    boxer.Image = Properties.Resources.enemy_punch1;
                    enemyBlock = false;

                    if (boxer.Bounds.IntersectsWith(player.Bounds) && playerBlock == false)
                    {
                        playerHealth -= 5;
                    }

                break;

                case "right":

                    boxer.Image = Properties.Resources.enemy_punch2;
                    enemyBlock = false;

                    if (boxer.Bounds.IntersectsWith(player.Bounds) && playerBlock == false)
                    {
                        playerHealth -= 5;
                    }
                break;

                case "block":

                    boxer.Image = Properties.Resources.enemy_block;
                    enemyBlock = true;

                break;
            }


        }

        private void BoxerMoveTimerEvent(object sender, EventArgs e)
        {
            // set up both health bars
            if (playerHealth > 1)
            {
                playerHealthBar.Value = playerHealth;
            }
            if (enemyHealth > 1)
            {
                boxerHealthBar.Value = enemyHealth;
            }


            // move the boxer

            boxer.Left += enemySpeed;

            if (boxer.Left > 430)
            {
                enemySpeed = -5;
            }
            if (boxer.Left < 220)
            {
                enemySpeed = 5;
            }

            // check for the end of game scenario

            if (enemyHealth < 1)
            {
                BoxerAttackTimer.Stop();
                BoxerMoveTimer.Stop();
                MessageBox.Show("You Win, Click OK to Play Again", "Moo Says: ");
                ResetGame();
            }
            if (playerHealth < 1)
            {
                BoxerAttackTimer.Stop();
                BoxerMoveTimer.Stop();
                MessageBox.Show("Tough Rob Wins, Click OK to Play Again", "Moo Says: ");
                ResetGame();
            }


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.Image = Properties.Resources.boxer_left_punch;
                playerBlock = false;

                if (player.Bounds.IntersectsWith(boxer.Bounds) && enemyBlock == false)
                {
                    enemyHealth -= 5;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                player.Image = Properties.Resources.boxer_right_punch;
                playerBlock = false;

                if (player.Bounds.IntersectsWith(boxer.Bounds) && enemyBlock == false)
                {
                    enemyHealth -= 5;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                player.Image = Properties.Resources.boxer_block;
                playerBlock = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            player.Image = Properties.Resources.boxer_stand;
            playerBlock = false;
        }

        private void ResetGame()
        {
            BoxerAttackTimer.Start();
            BoxerMoveTimer.Start();
            playerHealth = 100;
            enemyHealth = 100;

            boxer.Left = 400;
        }
    }
}