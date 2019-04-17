using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAdventure
{
    public partial class Form1 : Form
    {
        int roomCheck = 1;
        Boolean redKeyCheck = false;
        Boolean blueKeyCheck = false;
        Boolean greenKeyCheck = false;
        //You have 20 button clicks to complete the game or the ghost will get you. The keys are in the dining room, kitchen, and bedroom.
        int ghostCheck = 20; 

        public Form1()
        {
            InitializeComponent();
        }

        //If you are in the correct room the examine button will give you a key.
        private void ExamineButton_Click(object sender, EventArgs e)
        {
            ghostCheck--;
            if(roomCheck == 3 && !redKeyCheck)
            {
                redKeyCheck = true;
                redKey.Visible = true;
                MessageBox.Show("You found a red key!");
            }
            else if(roomCheck == 5 && !blueKeyCheck)
            {
                blueKeyCheck = true;
                blueKey.Visible = true;
                MessageBox.Show("You found a blue key!");
            }
            else if(roomCheck == 6 && !greenKeyCheck)
            {
                greenKeyCheck = true;
                greenKey.Visible = true;
                MessageBox.Show("You found a green key!");
            }
        }

        //If you click do something in room 1 with all items you escape unless you ran out of clicks.
        private void DoSomethingButton_Click(object sender, EventArgs e)
        {
            ghostCheck--;
            if(roomCheck == 1 && redKeyCheck && blueKeyCheck && greenKeyCheck && ghostCheck > 0)
            {
                MessageBox.Show("Congratulations you have escaped that dreaded place!\n It is time to head to the safety of your home.\n You feel as if something is following you though...");
                this.Close();
            }
            else if(roomCheck == 1 && redKeyCheck && blueKeyCheck && greenKeyCheck && ghostCheck <= 0)
            {
                MessageBox.Show("You were too late and the ghost has gotten you!\n \t\tGAME OVER");
                this.Close();
            }
        }

        //Go north from current room
        private void NorthButton_Click(object sender, EventArgs e)
        {
            ResetRoom();
            ghostCheck--;

            if(roomCheck == 1)
            {
                DrawRoom2();
                roomCheck = 2;
            }
            else if(roomCheck == 6)
            {                
                DrawRoom5();
                roomCheck = 5;
            }
        }

        //Go south
        private void SouthButton_Click(object sender, EventArgs e)
        {
            ResetRoom();
            ghostCheck--;

            if(roomCheck == 2)
            {                
                DrawRoom1();
                roomCheck = 1;
            }
            else if(roomCheck == 5)
            {                
                DrawRoom6();
                roomCheck = 6;
            }
        }

        //Go east
        private void EastButton_Click(object sender, EventArgs e)
        {
            ResetRoom();
            ghostCheck--;

            if(roomCheck == 1)
            {
                
                DrawRoom4();
                roomCheck = 4;
            }
            else if(roomCheck == 6)
            {
                DrawRoom1();
                roomCheck = 1;
            }
            else if(roomCheck == 5)
            {
                DrawRoom2();
                roomCheck = 2;
            }
            else if(roomCheck == 2)
            {
                DrawRoom3();
                roomCheck = 3;
            }
        }

        //Go west
        private void WestButton_Click(object sender, EventArgs e)
        {
            ResetRoom();
            ghostCheck--;

            if(roomCheck == 4)
            {
                DrawRoom1();
                roomCheck = 1;
            }
            else if(roomCheck == 1)
            {
                DrawRoom6();
                roomCheck = 6;
            }
            else if(roomCheck == 3)
            {
                DrawRoom2();
                roomCheck = 2;
            }
            else if(roomCheck == 2)
            {
                DrawRoom5();
                roomCheck = 5;
            }
        }

        //Called each time you change rooms
        private void ResetRoom()
        {
            descriptionLabel.Text = "";
            bathroomPicBox.Visible = false;
            bedroomPicBox.Visible = false;
            diningPicBox.Visible = false;
            entrancePicBox.Visible = false;
            kitchenPicBox.Visible = false;
            livingPicBox.Visible = false;
            northButton.Enabled = false;
            southButton.Enabled = false;
            eastButton.Enabled = false;
            westButton.Enabled = false;

        }

        //Creates room 1
        private void DrawRoom1()
        {
            descriptionLabel.Text = "The door is shut tight. It appears to have three different locks to open.";
            entrancePicBox.Visible = true;
            northButton.Enabled = true;
            eastButton.Enabled = true;
            westButton.Enabled = true;
        }

        //Creates room 2
        private void DrawRoom2()
        {
            descriptionLabel.Text = "You have walked into what looks like a living area. It gives you chills.";
            livingPicBox.Visible = true;
            southButton.Enabled = true;
            eastButton.Enabled = true;
            westButton.Enabled = true;
        }

        //Creates room 3
        private void DrawRoom3()
        {
            descriptionLabel.Text = "This is a bedroom. You should not linger here.";
            bedroomPicBox.Visible = true;
            westButton.Enabled = true;
        }

        //Creates room 4
        private void DrawRoom4()
        {
            descriptionLabel.Text = "You have found a bathroom. It is the grosssest.";
            bathroomPicBox.Visible = true;
            westButton.Enabled = true;
        }

        //Creates room 5
        private void DrawRoom5()
        {
            descriptionLabel.Text = "This is the kitchen. There is a strange smell that is unsettling to you.";
            kitchenPicBox.Visible = true;
            eastButton.Enabled = true;
            southButton.Enabled = true;
        }

        //Creates room 6
        private void DrawRoom6()
        {
            descriptionLabel.Text = "This dining room seems nice compared to the rest of the house. You feel like you are being watched while in this room.";
            diningPicBox.Visible = true;
            northButton.Enabled = true;
            eastButton.Enabled = true;
        }
    }
}
