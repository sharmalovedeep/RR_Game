using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Media;

namespace RR_Game
{
    public partial class RRGame : Form
    {
        GameRR game = new GameRR(); //Defining the object of Game inm GameRR class
        Random randomspin = new Random(); // Defining the an object as randomespin
        public RRGame()
        {
            InitializeComponent();
        }
        private void Btn_laod_Click(object sender, EventArgs e)
        {
            //disabling and enabling the buttons
            btn_load.Enabled = false;
            btn_spin.Enabled = true;
            btn_shoot.Enabled = false;
            btn_shootAway.Enabled = false;
   
            //Adding a Image by clicking the load button in to the picture box
            Assembly loadpic = Assembly.GetExecutingAssembly();
            Stream myStream = loadpic.GetManifestResourceStream("AessementRRG.Resources.load.gif");
            Bitmap bmp = new Bitmap(myStream);
            pic_change_box.Image = bmp;
            // addinng a wav audio using resource file with try and catch method 
            try
            {
                SoundPlayer player = new SoundPlayer(RR_Game.Resource1.load_tone);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
        }

        private void Btn_spin_Click(object sender, EventArgs e)
        {
            //disabling and enabling the buttons
            btn_load.Enabled = false;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootAway.Enabled = true;
           
            //Adding a Image by clicking the spin button in to the picture box
            Assembly spinpic = Assembly.GetExecutingAssembly();
            Stream myStream = spinpic.GetManifestResourceStream("AessementRRG.Resources.spining.gif");
            Bitmap bmp = new Bitmap(myStream);
            pic_change_box.Image = bmp;
            // addinng a wav audio using resource file with try and catch method 
            try
            {
                SoundPlayer player = new SoundPlayer(RR_Game.Resource1.spin_tone);
                player.Play();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
            // generating a random number from 1 to 6 when spining
            // next is used to ge  a random number between 1 to 6
            //choosebullet is a variable defined in class GameRR
            game.choosebullet = randomspin.Next(1, 6);
        }

        private void Btn_shoot_Click(object sender, EventArgs e)
        {
            //Adding a Image by clicking the shoot button in to the picture box
            Assembly shootpic = Assembly.GetExecutingAssembly();
            Stream myStream = shootpic.GetManifestResourceStream("AessementRRG.Resources.shooting.gif");
            Bitmap bmp = new Bitmap(myStream);
            pic_change_box.Image = bmp;
            // addinng a wav audio using resource file with try and catch method 
            try
            {
                SoundPlayer player = new SoundPlayer(RR_Game.Resource1.shoot_tone);
                player.Play();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
            //calling the variable totshot 
            //if the choosed champer got the choosebullet then you lose
            if (game.totshot > 0 && game.choosebullet == 1)
            {
                MessageBox.Show("You Lost");
                //disabling and enabling the buttons
                btn_load.Enabled = false;
                btn_spin.Enabled = false;
                btn_shoot.Enabled = false;
                btn_shootAway.Enabled = false;
            }
            // if the choosed champer didnt have the choosebullet  then your champer is empty and will get another chance to shoot
            else if (game.totshot > 0 && game.choosebullet != 1)
            {
                game.totshot = game.totshot - 1;
                //changechamper function will change the champer
                game.choosebullet = game.changechamper(game.choosebullet);
                MessageBox.Show("Champer Empty");
            }
        }
        private void Btn_shootAway_Click(object sender, EventArgs e)
        {
            if (game.bulletout >= 1)
            {
                //Adding a Image by clicking the shoot away button in to the picture box
                Assembly shootawaypic = Assembly.GetExecutingAssembly();
                Stream myStream = shootawaypic.GetManifestResourceStream("AessementRRG.Resources.shoot away.gif");
                Bitmap bmp = new Bitmap(myStream);
                pic_change_box.Image = bmp;
                // addinng a wav audio using resource file with try and catch method 
                try
                {
                    SoundPlayer player = new SoundPlayer(RR_Game.Resource1.shoot_away_tone);
                    player.Play();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Message" + ex.Message);
                }
                // score is varibel used to call the shootaway function form class Game RR
                int score = game.shootaway();
               
                if (score == 10)
                {
                    MessageBox.Show("You Won✌✌✌ " + "Your score is 10");
                    //disabling and enabling the buttons
                    btn_shootAway.Enabled = false;
                    btn_spin.Enabled = true;
                    btn_shoot.Enabled = false;
                    btn_load.Enabled = false;
                }
                if (score == 5)
                {
                    MessageBox.Show("You Won By half✌" + "Your score is 5");
                    //disabling and enabling the buttons
                    btn_shootAway.Enabled = false;
                    btn_spin.Enabled = true;
                    btn_shoot.Enabled = false;
                    btn_load.Enabled = false;
                }
                if (score == 0)
                {
                    MessageBox.Show("Champer Empty");
                    if (game.totshot == 0)
                    {
                        MessageBox.Show("you lost😔😔");
                        btn_shootAway.Enabled = false;

                    }

                }
            }
            else
            {
                MessageBox.Show("you have already lost 2 life lines😔😔");
                btn_shootAway.Enabled = false;
            }

        }

        private void Btn_playAgain_Click(object sender, EventArgs e)
        {
            (new RRGame()).Show();
            this.Hide();
          
            //this.Controls.Clear();
            //this.InitializeComponent();
            //disabling and enabling the buttons
            btn_load.Enabled = true;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = false;
            btn_shootAway.Enabled = false;
            btn_playAgain.Enabled = true;
            
           //
            //
        }

        private void Pic_change_box_Click(object sender, EventArgs e)
        {

        }
    }
}
