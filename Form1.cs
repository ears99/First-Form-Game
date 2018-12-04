using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormsGame {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            startGame();
        }

        public void startGame() {
            Form2 mainMenu = new Form2();
            DialogResult result = mainMenu.ShowDialog(this);

            string info = mainMenu.textBox1.Text;

            if(result == DialogResult.OK) {

            }
            mainMenu.Dispose();
        }
        
        //Not used
        private void pb_Player_Click(object sender, EventArgs e) {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            int dx, dy = 0; //deltaX, deltaY

            switch(e.KeyCode) {
                case Keys.Up:
                case Keys.W:
                    pb_Player.Image = il_Sprites.Images[0];
                    dx = 0;
                    dy = -5;
                    pb_Player.Location = new Point(pb_Player.Location.X + dx, pb_Player.Location.Y + dy);
                    break;

                case Keys.Down:
                case Keys.S:
                    pb_Player.Image = il_Sprites.Images[1];
                    dx = 0;
                    dy = 5;
                    pb_Player.Location = new Point(pb_Player.Location.X + dx, pb_Player.Location.Y + dy);
                    break;

                case Keys.Left:
                case Keys.A:
                    dx = -5;
                    dy = 0;
                    pb_Player.Location = new Point(pb_Player.Location.X + dx, pb_Player.Location.Y + dy);
                    pb_Player.Image = il_Sprites.Images[2];
                    break;

                case Keys.Right:
                case Keys.D:
                    pb_Player.Image = il_Sprites.Images[3];
                    dx = 5;
                    dy = 0;
                    pb_Player.Location = new Point(pb_Player.Location.X + dx, pb_Player.Location.Y + dy);
                    break;
            }

            //collision detection
            if(pb_Player.Bounds.IntersectsWith(pb_Avoid1.Bounds)) {
                pb_Player.Image = il_Sprites.Images[4]; //explode sprite
                lbl_Win.Text = "You exploded!";
                lbl_Win.Visible = true;

            } else if(pb_Player.Bounds.IntersectsWith(pb_Avoid2.Bounds)) {
                pb_Player.Image = il_Sprites.Images[4]; //explode sprite
                lbl_Win.Text = "You exploded!";
                lbl_Win.Visible = true;
             
            } else if(pb_Player.Bounds.IntersectsWith(pb_Avoid3.Bounds)) {

                pb_Player.Image = il_Sprites.Images[4]; //explode sprite
                lbl_Win.Text = "You exploded!";
                lbl_Win.Visible = true;

            } else if(pb_Player.Bounds.IntersectsWith(pb_Avoid4.Bounds)) {

                pb_Player.Image = il_Sprites.Images[4]; //explode sprite
                lbl_Win.Text = "You exploded!";
                lbl_Win.Visible = true;

            } else if(pb_Player.Bounds.IntersectsWith(pb_Avoid5.Bounds)) {

                pb_Player.Image = il_Sprites.Images[4]; //explode sprite
                lbl_Win.Text = "You exploded!";
                lbl_Win.Visible = true;

            }  else if(pb_Player.Bounds.IntersectsWith(pb_Goal.Bounds)) {
                //don't explode sprite, player won.
                lbl_Win.Visible = true;
            }
        }
    }
}
