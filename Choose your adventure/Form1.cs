using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Choose_your_adventure
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        bool car = false;
        bool friend = false;
        bool walking = false;
        int page = 1;
        int investigate = 0;
        int chance;
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You awake in the night to the sound of someone  screaming. What do you do?";
            option1.Text = "Investigate";
            option2.Text = "Go back to sleep";
            option3.Text = "";
            option3Button.Enabled = false;
            pictureBox.BackgroundImage = Properties.Resources.Bedroom;

        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                car = true;
                page = 4;
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 4)
            {
                chance = random.Next(1, 11);
                if (chance < 2)
                {
                    page = 14;
                }
                else
                {
                    page = 9;
                }
            }
            /* else if (page == 6)
             {
                 page = ;
             }
             else if (page == 7)
             {
                 page = ;
             }*/
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                chance = random.Next(1, 21);
                if (chance < 2)
                {
                    page = 14;
                }
                else
                {
                    page = 15;
                }
            }
            else if (page == 10)
            {
                chance = random.Next(1, 21);
                if (chance < 6)
                {
                    page = 98;
                }
                else
                {
                    page = 17;
                }
            }
            else if (page == 11)
            {
                page = 1;
            }
            /* else if (page == 12)
             {
                 page = 97;
             }*/
            else if (page == 13)
            {
                page = 97;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                chance = random.Next(1, 21);
                if (chance > 6)
                {
                    page = 98;
                }
                else
                {
                    page = 20;
                }
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 22;
            }
            else if (page == 20)
            {
                page = 23;
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                chance = random.Next(1, 21);
                if (chance > 2)
                {
                    page = 98;
                }
                else
                {
                    page = 25;
                }
            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 1;
            }
            else if (page == 27)
            {
                chance = random.Next(1, 21);
                if (chance > 6)
                {
                    page = 98;
                }
                else
                {
                    page = 30;
                }
            }
            else if (page == 28)
            {
                page = 1;
            }
            else if (page == 30)
            {
                page = 1;
            }
            else if (page == 97)
            {
                if (car == true)
                {
                    chance = random.Next(1, 11);
                    if (chance < 2)
                    {
                        page = 14;
                    }
                    else
                    {
                        page = 9;
                    }
                }
                else
                {
                    option1.Text = "";
                }
            }


            switch (page)
            {
                case 1:
                    outputLabel.Text = "You awake in the night to the sound of someone screaming. What do you do?";
                    option1.Text = "Investigate";
                    option2.Text = "Go back to sleep";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.Bedroom;
                    break;
                case 2:
                    outputLabel.Text = "You get up and prepare to leave. Do you take your car or walk?";
                    option1.Text = "Car";
                    option2.Text = "Walk";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.keyorshoe;
                    break;
                case 3:
                    outputLabel.Text = "You are too anxious to fall asleep. How do you pass the time?";
                    option1.Text = "Watch TV";
                    option2.Text = "Lay and Think";
                    option3.Text = "Read";
                    option3Button.Enabled = true;
                    break;
                case 4:
                    outputLabel.Text = "You grab your keys and head to your car. You begin to drive down the street. Where do you investigate?";
                    option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";
                    option3Button.Enabled = true;
                    pictureBox.BackgroundImage = Properties.Resources.car;
                    break;
                case 5:
                    outputLabel.Text = "You head out the door and begin to walk down the street, listening intently. As you walk down you see a couple suspicious places to investigate. Where do you go?";
                    option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";
                    option3Button.Enabled = true;
                    pictureBox.BackgroundImage = Properties.Resources.walking;
                    break;
                case 6:
                    outputLabel.Text = "Incomplete section";
                    /*option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";*/
                    break;
                case 7:
                    outputLabel.Text = "Incomplete section";
                    /*option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";*/
                    break;
                case 8:
                    outputLabel.Text = "The book is so boring it put you to sleep. You Die.\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.Book_Pictures;
                    break;
                case 9:
                    outputLabel.Text = "You continue on. As you travel down the road, you spot a group of people hanging out on the side of the road. Maybe they know what's up. Do you approach them?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.people;
                    break;
                case 10:
                    outputLabel.Text = "As you approach the abandoned house, you spot movement in the window. Do you proceed?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.window;
                    break;
                case 11:
                    outputLabel.Text = "You arrive at the grocery store to find it looted and empty. A group of looters sees you and charges you, beating you to death.\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.store;
                    break;
                case 12:
                    outputLabel.Text = "You find the grocery store is being looted. One of the looters sees your headlights and runs at your car. You drive away.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.store;
                    break;
                case 13:
                    outputLabel.Text = "The people seem wary of you at first, but they eventually warm up to you and give you some information. You have made some friends.";
                    option1.Text = "Investigate elsewhere";
                    option2.Text = "Return home";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.people2;
                    break;
                case 14:
                    outputLabel.Text = "As you are driving, a semi-truck runs a red light as you are crossing and absolutely obliterates your car. You are gone.\r\n\r\nThis was a random chance.\r\nYou don't get to play again.\r\nCry about it.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.tbone;
                    Refresh();
                    Thread.Sleep(15000);
                    Application.Restart();
                    break;
                case 15:
                    outputLabel.Text = "You drive away into the distance, leaving your old life behind. It was time to start something new.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    pictureBox.BackgroundImage = Properties.Resources.car_driving_away;
                    break;
                case 16:
                    outputLabel.Text = "You drive off happy with what you learned. you go to sleep happy.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.car_driving_away;
                    break;
                case 17:
                    outputLabel.Text = "You decide to press on and investigate. Since you have not found anything you decide it might be a good idea to call out to the figure you saw.\r\nDo you take the chance?";
                    option1.Text = "Call out";
                    option2.Text = "Don't call out";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.investigate;
                    break;
                case 18:
                    outputLabel.Text = "As you back away from the house, your foot catches a rock. You fall backwards and hit your head off the ground. You experience severe head trauma and die. Play Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.unconscious;
                    break;
                case 19:
                    outputLabel.Text = "You back away, deciding maybe it's not such a good idea to go into the house. Do you investigate somewhere else or return home?";
                    option1.Text = "Return home";
                    option2.Text = "Investigate elsewhere";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.walkingaway;
                    break;
                case 20:
                    outputLabel.Text = "A dark figure appears from the shadows. You decide to start a conversation.";
                    option1.Text = "Hey, how's it going?";
                    option2.Text = "Stay where you are!";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.figure;
                    break;
                case 21:
                    outputLabel.Text = "Something jumps on you from behind. You grab the first object you can get your hands on and attack whatever it is. As you hurt it, it pushes you to the ground. Your head takes the brunt of the impact. As you lie there, vision fading, you find solace as your assailant falls to the ground.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.figure2;
                    break;
                case 22:
                    outputLabel.Text = "You realize it's probably a better idea to just stay at home and let it be.\r\nYou go on with your life.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.house;
                    break;
                case 23:
                    outputLabel.Text = "The figure tells you everything is going well. They ask you how you are doing.\r\nHow do you respond?";
                    option1.Text = "Not so good";
                    option2.Text = "Good";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.figure;
                    break;
                case 24:
                    outputLabel.Text = "You are grabbed from behind and stabbed multiple times. You fall to the ground, bleeding out, you never got to see your assailant.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.unconscious;
                    break;
                case 25:
                    outputLabel.Text = "You and the figure converse about the night's events. They tell you everything they know. You go home, satisfied.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.house;
                    break;
                case 26:
                    outputLabel.Text = "The figure jumps at you, knocking you to the ground. As you lie there stunned, the figure turns and runs. You call out for help.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.grab;
                    Refresh();
                    Thread.Sleep(20000);
                    if (friend == true)
                    {
                        page = 29;
                    }
                    else
                    {
                        page = 28;
                    }
                    break;
                case 27:
                    outputLabel.Text = "You and the figure have a nice conversation, talking about the night. The figure seems very friendly.";
                    option1.Text = "Return home";
                    option2.Text = "Investigate elsewhere";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.figure;
                    break;
                case 28:
                    outputLabel.Text = "You lie there, no one comes. You die... alone...\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.unconscious;
                    break;
                case 29:
                    outputLabel.Text = "Your friend from earlier rushes to your aid, rushing you to the hospital. You live, but they couldn't save your memory.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.hospital;
                    Refresh();
                    Thread.Sleep(15000);
                    Application.Restart();
                    break;
                case 30:
                    outputLabel.Text = "You decide to return home, satisfied with how everything has gone. You no longer desire to know what woke you up.\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.house;
                    break;
                case 95:
                    outputLabel.Text = "You have died from multiple battle wounds. \r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.dead;
                    break;
                case 96:
                    outputLabel.Text = "Your friend rushes to your aid, saving you. Scarred from the terrifying experience you return home.\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.house;
                    break;
                case 97:
                    outputLabel.Text = "Investigate elsewhere";
                    option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";
                    option3Button.Enabled = false;
                    if (car == true)
                    {
                        pictureBox.BackgroundImage = Properties.Resources.car_driving_away;
                    }
                    else if(walking == true)
                    {
                        pictureBox.BackgroundImage = Properties.Resources.walking;
                    }
                    break;
                case 98:
                    outputLabel.Text = "You were attacked";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.attacked;
                    Refresh();
                    Thread.Sleep(5000);
                    if (friend == true)
                    {
                        page = 96;
                    }
                    else
                    {
                        page = 95;
                    }
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing!";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.Visible = false;
                    Refresh();
                    Thread.Sleep(5000);
                    Application.Exit();
                    break;

            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                walking = true;
                page = 5;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 4)
            {
                page = 10;
            }
            else if (page == 5)
            {
                if (walking == true)
                {
                    chance = random.Next(1, 21);
                    if (chance > 11)
                    {
                        page = 98;
                    }
                    else
                    {
                        page = 10;
                    }

                }
                else
                {
                    page = 10;
                }
            }
            /* else if (page == 6)
             {
                 page = ;
             }
             else if (page == 7)
             {
                 page = ;
             }*/
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                chance = random.Next(1, 21);
                if (chance < 11)
                {
                    page = 98;
                }
                else
                {
                    friend = true;
                    page = 13;
                }
            }
            else if (page == 10)
            {
                chance = random.Next(1, 21);
                if (chance < 6)
                {
                    page = 18;
                }
                else
                {
                    page = 19;
                }
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                chance = random.Next(1, 21);
                if (chance > 11)
                {
                    page = 24;
                }
                else
                {
                    page = 21;
                }
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 97;
            }
            else if (page == 20)
            {
                page = 26;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 23)
            {
                friend = true;
                page = 27;
            }
            else if (page == 24)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 99;
            }
            else if (page == 27)
            {
                page = 97;
            }
            else if (page == 28)
            {
                page = 99;
            }
            else if (page == 30)
            {
                page = 1;
            }
            else if (page == 97)
            {
                if (walking == true)
                {
                    if (walking == true)
                    {
                        chance = random.Next(1, 21);
                        if (chance > 11)
                        {
                            page = 98;
                        }
                        else
                        {
                            page = 10;
                        }
                    }
                }
                else
                {
                    page = 10;
                }
            }

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You awake in the night to the sound of someone screaming. What do you do?";
                    option1.Text = "Investigate";
                    option2.Text = "Go back to sleep";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.Bedroom;
                    break;
                case 2:
                    outputLabel.Text = "You get up and prepare to leave. Do you take your car or walk?";
                    option1.Text = "Car";
                    option2.Text = "Walk";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.keyorshoe;
                    break;
                case 3:
                    outputLabel.Text = "You are too anxious to fall asleep. How do you pass the time?";
                    option1.Text = "Watch TV";
                    option2.Text = "Lay and Think";
                    option3.Text = "Read";
                    option3Button.Enabled = true;
                    break;
                case 4:
                    outputLabel.Text = "You grab your keys and head to your car. You begin to drive down the street. Where do you investigate?";
                    option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";
                    option3Button.Enabled = true;
                    pictureBox.BackgroundImage = Properties.Resources.car;
                    break;
                case 5:
                    outputLabel.Text = "You head out the door and begin to walk down the street, listening intently. As you walk down you see a couple suspicious places to investigate. Where do you go?";
                    option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";
                    option3Button.Enabled = true;
                    pictureBox.BackgroundImage = Properties.Resources.walking;
                    break;
                case 6:
                    outputLabel.Text = "Incomplete section";
                    /*option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";*/
                    break;
                case 7:
                    outputLabel.Text = "Incomplete section";
                    /*option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";*/
                    break;
                case 8:
                    outputLabel.Text = "The book is so boring it put you to sleep. You Die.\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.Book_Pictures;
                    break;
                case 9:
                    outputLabel.Text = "You continue on. As you travel down the road, you spot a group of people hanging out on the side of the road. Maybe they know what's up. Do you approach them?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.people;
                    break;
                case 10:
                    outputLabel.Text = "As you approach the abandoned house, you spot movement in the window. Do you proceed?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.window;
                    break;
                case 11:
                    outputLabel.Text = "You arrive at the grocery store to find it looted and empty. A group of looters sees you and charges you, beating you to death.\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.store;
                    break;
                case 12:
                    outputLabel.Text = "You find the grocery store is being looted. One of the looters sees your headlights and runs at your car. You drive away.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.store;
                    break;
                case 13:
                    outputLabel.Text = "The people seem wary of you at first, but they eventually warm up to you and give you some information. You have made some friends.";
                    option1.Text = "Investigate elsewhere";
                    option2.Text = "Return home";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.people2;
                    break;
                case 14:
                    outputLabel.Text = "As you are driving, a semi-truck runs a red light as you are crossing and absolutely obliterates your car. You are gone.\r\n\r\nThis was a random chance.\r\nYou don't get to play again.\r\nCry about it.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.tbone;
                    Refresh();
                    Thread.Sleep(15000);
                    Application.Restart();
                    break;
                case 15:
                    outputLabel.Text = "You drive away into the distance, leaving your old life behind. It was time to start something new.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    pictureBox.BackgroundImage = Properties.Resources.car_driving_away;
                    break;
                case 16:
                    outputLabel.Text = "You drive off happy with what you learned. you go to sleep happy.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.car_driving_away;
                    break;
                case 17:
                    outputLabel.Text = "You decide to press on and investigate. Since you have not found anything you decide it might be a good idea to call out to the figure you saw.\r\nDo you take the chance?";
                    option1.Text = "Call out";
                    option2.Text = "Don't call out";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.investigate;
                    break;
                case 18:
                    outputLabel.Text = "As you back away from the house, your foot catches a rock. You fall backwards and hit your head off the ground. You experience severe head trauma and die. Play Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.unconscious;
                    break;
                case 19:
                    outputLabel.Text = "You back away, deciding maybe it's not such a good idea to go into the house. Do you investigate somewhere else or return home?";
                    option1.Text = "Return home";
                    option2.Text = "Investigate elsewhere";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.walkingaway;
                    break;
                case 20:
                    outputLabel.Text = "A dark figure appears from the shadows. You decide to start a conversation.";
                    option1.Text = "Hey, how's it going?";
                    option2.Text = "Stay where you are!";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.figure;
                    break;
                case 21:
                    outputLabel.Text = "Something jumps on you from behind. You grab the first object you can get your hands on and attack whatever it is. As you hurt it, it pushes you to the ground. Your head takes the brunt of the impact. As you lie there, vision fading, you find solace as your assailant falls to the ground.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.figure2;
                    break;
                case 22:
                    outputLabel.Text = "You realize it's probably a better idea to just stay at home and let it be.\r\nYou go on with your life.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.house;
                    break;
                case 23:
                    outputLabel.Text = "The figure tells you everything is going well. They ask you how you are doing.\r\nHow do you respond?";
                    option1.Text = "Not so good";
                    option2.Text = "Good";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.figure;
                    break;
                case 24:
                    outputLabel.Text = "You are grabbed from behind and stabbed multiple times. You fall to the ground, bleeding out, you never got to see your assailant.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.unconscious;
                    break;
                case 25:
                    outputLabel.Text = "You and the figure converse about the night's events. They tell you everything they know. You go home, satisfied.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.house;
                    break;
                case 26:
                    outputLabel.Text = "The figure jumps at you, knocking you to the ground. As you lie there stunned, the figure turns and runs. You call out for help.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.grab;
                    Refresh();
                    Thread.Sleep(20000);
                    if (friend == true)
                    {
                        page = 29;
                    }
                    else
                    {
                        page = 28;
                    }
                    break;
                case 27:
                    outputLabel.Text = "You and the figure have a nice conversation, talking about the night. The figure seems very friendly.";
                    option1.Text = "Return home";
                    option2.Text = "Investigate elsewhere";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.figure;
                    break;
                case 28:
                    outputLabel.Text = "You lie there, no one comes. You die... alone...\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.unconscious;
                    break;
                case 29:
                    outputLabel.Text = "Your friend from earlier rushes to your aid, rushing you to the hospital. You live, but they couldn't save your memory.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.hospital;
                    Refresh();
                    Thread.Sleep(15000);
                    Application.Restart();
                    break;
                case 30:
                    outputLabel.Text = "You decide to return home, satisfied with how everything has gone. You no longer desire to know what woke you up.\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.house;
                    break;
                case 95:
                    outputLabel.Text = "You have died from multiple battle wounds. Play Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.dead;
                    break;
                case 96:
                    outputLabel.Text = "Your friend rushes to your aid, saving you. Scarred from the terrifying experience you return home.\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.house;
                    break;
                case 97:
                    outputLabel.Text = "Investigate elsewhere";
                    option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";
                    option3Button.Enabled = false;
                    if (car == true)
                    {
                        pictureBox.BackgroundImage = Properties.Resources.car_driving_away;
                    }
                    else if (walking == true)
                    {
                        pictureBox.BackgroundImage = Properties.Resources.walking;
                    }
                    break;
                case 98:
                    outputLabel.Text = "You were attacked";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.attacked;
                    Refresh();
                    Thread.Sleep(5000);
                    if (friend == true)
                    {
                        page = 96;
                    }
                    else
                    {
                        page = 95;
                    }
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing!";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.Visible = false;
                    Refresh();
                    Thread.Sleep(5000);
                    Application.Exit();
                    break;

            }
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 3)
            {
                page = 8;
            }
            else if (page == 4)
            {
                page = 12;
            }
            else if (page == 5)
            {
                chance = random.Next(1, 21);
                if (chance < 11)
                {
                    page = 98;
                }
                else
                {
                    page = 11;
                }
            }
            else if (page == 97)
            {
                if (walking == true)
                {
                    chance = random.Next(1, 21);
                    if (chance < 11)
                    {
                        page = 98;
                    }
                    else
                    {
                        page = 11;
                    }
                }
                else
                {
                    page = 12;
                }
            }


            switch (page)
            {
                case 1:
                    outputLabel.Text = "You awake in the night to the sound of someone screaming. What do you do?";
                    option1.Text = "Investigate";
                    option2.Text = "Go back to sleep";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.Bedroom;
                    break;
                case 2:
                    outputLabel.Text = "You get up and prepare to leave. Do you take your car or walk?";
                    option1.Text = "Car";
                    option2.Text = "Walk";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.keyorshoe;
                    break;
                case 3:
                    outputLabel.Text = "You are too anxious to fall asleep. How do you pass the time?";
                    option1.Text = "Watch TV";
                    option2.Text = "Lay and Think";
                    option3.Text = "Read";
                    option3Button.Enabled = true;
                    break;
                case 4:
                    outputLabel.Text = "You grab your keys and head to your car. You begin to drive down the street. Where do you investigate?";
                    option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";
                    option3Button.Enabled = true;
                    pictureBox.BackgroundImage = Properties.Resources.car;
                    break;
                case 5:
                    outputLabel.Text = "You head out the door and begin to walk down the street, listening intently. As you walk down you see a couple suspicious places to investigate. Where do you go?";
                    option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";
                    option3Button.Enabled = true;
                    pictureBox.BackgroundImage = Properties.Resources.walking;
                    break;
                case 6:
                    outputLabel.Text = "Incomplete section";
                    /*option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";*/
                    break;
                case 7:
                    outputLabel.Text = "Incomplete section";
                    /*option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";*/
                    break;
                case 8:
                    outputLabel.Text = "The book is so boring it put you to sleep. You Die.\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.Book_Pictures;
                    break;
                case 9:
                    outputLabel.Text = "You continue on. As you travel down the road, you spot a group of people hanging out on the side of the road. Maybe they know what's up. Do you approach them?";
                    option1.Text = "No";
                    option2.Text = "Yes";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.people;
                    break;
                case 10:
                    outputLabel.Text = "As you approach the abandoned house, you spot movement in the window. Do you proceed?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.window;
                    break;
                case 11:
                    outputLabel.Text = "You arrive at the grocery store to find it looted and empty. A group of looters sees you and charges you, beating you to death.\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.store;
                    break;
                case 12:
                    outputLabel.Text = "You find the grocery store is being looted. One of the looters sees your headlights and runs at your car. You drive away.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.store;
                    break;
                case 13:
                    outputLabel.Text = "The people seem wary of you at first, but they eventually warm up to you and give you some information. You have made some friends.";
                    option1.Text = "Investigate elsewhere";
                    option2.Text = "Return home";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.people2;
                    break;
                case 14:
                    outputLabel.Text = "As you are driving, a semi-truck runs a red light as you are crossing and absolutely obliterates your car. You are gone.\r\n\r\nThis was a random chance.\r\nYou don't get to play again.\r\nCry about it.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.tbone;
                    Refresh();
                    Thread.Sleep(15000);
                    Application.Restart();
                    break;
                case 15:
                    outputLabel.Text = "You drive away into the distance, leaving your old life behind. It was time to start something new.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    pictureBox.BackgroundImage = Properties.Resources.car_driving_away;
                    break;
                case 16:
                    outputLabel.Text = "You drive off happy with what you learned. you go to sleep happy.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.car_driving_away;
                    break;
                case 17:
                    outputLabel.Text = "You decide to press on and investigate. Since you have not found anything you decide it might be a good idea to call out to the figure you saw.\r\nDo you take the chance?";
                    option1.Text = "Call out";
                    option2.Text = "Don't call out";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.investigate;
                    break;
                case 18:
                    outputLabel.Text = "As you back away from the house, your foot catches a rock. You fall backwards and hit your head off the ground. You experience severe head trauma and die. Play Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.unconscious;
                    break;
                case 19:
                    outputLabel.Text = "You back away, deciding maybe it's not such a good idea to go into the house. Do you investigate somewhere else or return home?";
                    option1.Text = "Return home";
                    option2.Text = "Investigate elsewhere";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.walkingaway;
                    break;
                case 20:
                    outputLabel.Text = "A dark figure appears from the shadows. You decide to start a conversation.";
                    option1.Text = "Hey, how's it going?";
                    option2.Text = "Stay where you are!";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.figure;
                    break;
                case 21:
                    outputLabel.Text = "Something jumps on you from behind. You grab the first object you can get your hands on and attack whatever it is. As you hurt it, it pushes you to the ground. Your head takes the brunt of the impact. As you lie there, vision fading, you find solace as your assailant falls to the ground.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.figure2;
                    break;
                case 22:
                    outputLabel.Text = "You realize it's probably a better idea to just stay at home and let it be.\r\nYou go on with your life.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.house;
                    break;
                case 23:
                    outputLabel.Text = "The figure tells you everything is going well. They ask you how you are doing.\r\nHow do you respond?";
                    option1.Text = "Not so good";
                    option2.Text = "Good";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.figure;
                    break;
                case 24:
                    outputLabel.Text = "You are grabbed from behind and stabbed multiple times. You fall to the ground, bleeding out, you never got to see your assailant.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.unconscious;
                    break;
                case 25:
                    outputLabel.Text = "You and the figure converse about the night's events. They tell you everything they know. You go home, satisfied.\r\nPlay again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.house;
                    break;
                case 26:
                    outputLabel.Text = "The figure jumps at you, knocking you to the ground. As you lie there stunned, the figure turns and runs. You call out for help.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.grab;
                    Refresh();
                    Thread.Sleep(20000);
                    if (friend == true)
                    {
                        page = 29;
                    }
                    else
                    {
                        page = 28;
                    }
                    break;
                case 27:
                    outputLabel.Text = "You and the figure have a nice conversation, talking about the night. The figure seems very friendly.";
                    option1.Text = "Return home";
                    option2.Text = "Investigate elsewhere";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.figure;
                    break;
                case 28:
                    outputLabel.Text = "You lie there, no one comes. You die... alone...\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.unconscious;
                    break;
                case 29:
                    outputLabel.Text = "Your friend from earlier rushes to your aid, rushing you to the hospital. You live, but they couldn't save your memory.";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.hospital;
                    Refresh();
                    Thread.Sleep(15000);
                    Application.Restart();
                    break;
                case 30:
                    outputLabel.Text = "You decide to return home, satisfied with how everything has gone. You no longer desire to know what woke you up.\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.house;
                    break;
                case 95:
                    outputLabel.Text = "You have died from multiple battle wounds. Play Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.dead;
                    break;
                case 96:
                    outputLabel.Text = "Your friend rushes to your aid, saving you. Scarred from the terrifying experience you return home.\r\nPlay Again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.house;
                    break;
                case 97:
                    outputLabel.Text = "Investigate elsewhere";
                    option1.Text = "Continue on (car required)";
                    option2.Text = "Abandoned house";
                    option3.Text = "Grocery store";
                    option3Button.Enabled = false;
                    if (car == true)
                    {
                        pictureBox.BackgroundImage = Properties.Resources.car_driving_away;
                    }
                    else if (walking == true)
                    {
                        pictureBox.BackgroundImage = Properties.Resources.walking;
                    }
                    break;
                case 98:
                    outputLabel.Text = "You were attacked";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.BackgroundImage = Properties.Resources.attacked;
                    Refresh();
                    Thread.Sleep(5000);
                    if (friend == true)
                    {
                        page = 96;
                    }
                    else
                    {
                        page = 95;
                    }
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing!";
                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";
                    option3Button.Enabled = false;
                    pictureBox.Visible = false;
                    Refresh();
                    Thread.Sleep(5000);
                    Application.Exit();
                    break;

            }
        }
    }
}
