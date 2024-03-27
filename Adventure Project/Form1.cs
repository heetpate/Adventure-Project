﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Text;

namespace Adventure_Project
{
    public partial class Form1 : Form
    {
        // Tracks the page of the story the user is on
        int page = 1;

        //Random number generator
        Random randGen = new Random();

        SoundPlayer themePlayer = new SoundPlayer(Properties.Resources.the_Quarry_Main_Theme);
        SoundPlayer timePassPlayer = new SoundPlayer(Properties.Resources.time_Pass_Theme);
        SoundPlayer zombieNoisePlayer = new SoundPlayer(Properties.Resources.Voicy_Zombies_sound_);
        SoundPlayer cinamaticIntroPlayer = new SoundPlayer(Properties.Resources.cinematic_Intro);
        SoundPlayer doorPlayer = new SoundPlayer(Properties.Resources.Voicy_Door_Opening);
        SoundPlayer phoneRingingPlayer = new SoundPlayer(Properties.Resources.Phone_Ringing_);
        SoundPlayer runningPlayer = new SoundPlayer(Properties.Resources.running_in_grass_);
        SoundPlayer screamingPlayer = new SoundPlayer(Properties.Resources.Voicy_Screaming_sound_);
        public Form1()
        {
            InitializeComponent();

            themePlayer.PlayLooping();

            optionButton1.Enabled = false;
            optionButton2.Enabled = false;
            optionButton3.Enabled = false;

            optionButton1.Hide();
            optionButton2.Hide();
            optionButton3.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 11;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                int randValue = randGen.Next(1, 41);

                if (randValue < 40)
                {
                    page = 6;
                }
                else
                {
                    page = 7;
                }
            }
            else if (page == 5)
            {
                int randValue = randGen.Next(1, 41);

                if (randValue < 40)
                {
                    page = 6;
                }
                else
                {
                    page = 7;
                }
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 10; //watch out for this one look at this option in the flowchart
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 11;
            }

            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 20)
            {
                page = 21;
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 23;
            }
            else if (page == 23)
            {
                page = 1;
            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 1;
            }

            DisplayPage();
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 12;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 8;
            }
            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 10; //correct this statement
            }
            else if (page == 10)
            {
                page = 12;
            }

            else if (page == 11)
            {
                page = 99;
            }

            else if (page == 12)
            {
                page = 14;
            }
            else if (page == 13)
            {
                page = 16; //correct this statement
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 20;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 22;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 24;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 99;
            }

            DisplayPage();
        }

        private void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    pictureBox2.BackgroundImage = (Properties.Resources.Campus);

                    timePassPlayer.PlayLooping();

                    outputLabel.Text = "You are in a campus with you school friends they are planning to go outside at night for camp fire. Go outside or stay?";
                    optionButton1.Text = "Outside";
                    optionButton2.Text = "Stay"; 
                    break;
                case 2:
                    pictureBox2.BackgroundImage = (Properties.Resources.Camping_With_Friends);

                    timePassPlayer.PlayLooping();
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;

                    outputLabel.Text = "You light up the fire and having fun.";
                    Refresh();
                    Thread.Sleep(3000);

                    optionButton1.Visible = true;
                    optionButton2.Visible = true;

                    outputLabel.Text = "Your friend ran to you and tells you everything that happened";
                    optionButton1.Text = "Run right away ";
                    optionButton2.Text = "Find a safe place and make a plan";
                    break;
                case 3:
                    zombieNoisePlayer.PlayLooping();

                    outputLabel.Text = "You stayed with your friend and suddenly you hear strange sounds from the basement and your teacher is out with the other friends, What would you do?";
                    optionButton1.Text = "No";
                    optionButton2.Text = "Explore";
                    break;
                case 4:
                    cinamaticIntroPlayer.PlayLooping();

                    optionButton1.Visible = false;
                    optionButton2.Visible = false;

                    outputLabel.Text = "You and your friend started a movie but the noise is to irritating so you decide to go, check anyways";
                    Refresh();
                    Thread.Sleep(3500);

                    optionButton1.Visible = true;
                    optionButton2.Visible = true;

                    zombieNoisePlayer.PlayLooping();
                    doorPlayer.PlayLooping();

                    outputLabel.Text = "You open the basement, it's pitch black and suddenly a strange looking creature jumped on your friend";
                    optionButton1.Text = "Save";
                    optionButton2.Text = "Get out of there";
                    break;
                case 5:
                    doorPlayer.PlayLooping();

                    outputLabel.Text = "You open the basement, it's pitch black and suddenly a strange looking creature jumped on you friend";
                   
                    zombieNoisePlayer.PlayLooping();

                    optionButton1.Text = "Save";
                    optionButton2.Text = "Get out of there";
                    break;
                case 6:
                    themePlayer.PlayLooping();

                    outputLabel.Text = "You die saving your friend\r\nYour a TRUE FRIEND! \r\n Play Again";
                    optionButton1.Text = "Yes ";
                    optionButton2.Text = "No";
                    break;
                case 7:
                    doorPlayer.PlayLooping();

                    outputLabel.Text = "You lived...\r\nYou locked the basement.";

                    optionButton1.Text = "Call";
                    optionButton2.Text = "Run";
                    break;
                case 8:
                    doorPlayer.PlayLooping();

                    outputLabel.Text = "You locked the basement";

                    doorPlayer.Stop();

                    optionButton1.Visible = false;
                    optionButton2.Visible = false;

                    Refresh();
                    Thread.Sleep(1500);

                    optionButton1.Visible = true;
                    optionButton2.Visible = true;

                    outputLabel.Text = "Are you going to call your friends or run to your friends?";
                    optionButton1.Text = "Run";
                    optionButton2.Text = "Call";
                    break;
                case 9:
                    phoneRingingPlayer.PlayLooping();

                    optionButton1.Visible = false;
                    optionButton2.Visible = false;

                    outputLabel.Text = "The electricity ran out the last option is to run to them";
                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "You ran to your friends and told them everything";
                    
                    runningPlayer.PlayLooping();
                    break;
                case 10:
                    outputLabel.Text = "You ran to your friends and told them everything";
                   
                    runningPlayer.PlayLooping();

                    optionButton1.Text = "Run right away";
                    optionButton2.Text = "Find a safe place and make a plan";
                    break;
                case 11:
                    runningPlayer.PlayLooping();
                    zombieNoisePlayer.PlayLooping();

                    outputLabel.Text = "You and your friends got chased and killed by a scary looking creature. \r\n Play Again?";
                   
                    timePassPlayer.PlayLooping();
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 12:
                    themePlayer.PlayLooping();
                    timePassPlayer.PlayLooping();

                    outputLabel.Text = "You find a house where no one lives there but to keep yourself alive you decide to break into it";
                    optionButton1.Text = "Explore";
                    optionButton2.Text = "No";
                    break;
                case 13:
                    themePlayer.PlayLooping();
                    timePassPlayer.PlayLooping();

                    optionButton1.Visible = false;
                    optionButton2.Visible = false;

                    outputLabel.Text = "You're safe! \r\nYou also find a gun, some food and water for temporary, the map to escape.";
                    Refresh();
                    Thread.Sleep(2000);

                    optionButton1.Visible = true;
                    optionButton2.Visible = true;

                    outputLabel.Text = "Your plan is to wait for the electricity to call or go outside and escape yourself";
                   
                    themePlayer.PlayLooping();
                    timePassPlayer.PlayLooping();

                    optionButton1.Text = "Wait";
                    optionButton2.Text = "Try escaping";
                    break;
                case 14:
                    zombieNoisePlayer.PlayLooping();
                    screamingPlayer.PlayLooping();

                    outputLabel.Text = "The next day you were killed by the creature\r\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 15:
                    zombieNoisePlayer.PlayLooping();

                    outputLabel.Text = "You have waited to long, your resources ran out and the electricity hasn't came you died\r\nPlay Again?";
                    optionButton1.Text = "No";
                    optionButton2.Text = "Yes";
                    break;
                case 16:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;

                    themePlayer.PlayLooping();
                    timePassPlayer.PlayLooping();

                    outputLabel.Text = "According to the map you are on the way to escape. In the morning you realize there is no creature roaming around";
                    Refresh();
                    Thread.Sleep(3000);

                    optionButton1.Visible = true;
                    optionButton2.Visible = true;
                    
                    outputLabel.Text = "They are planning to reach a small hotel and according to the map it will take them 10 hours walk and 6 hours car";
                    optionButton1.Text = "Walk";
                    optionButton2.Text = "Find a Car nearby";
                    break;
                case 17:
                    zombieNoisePlayer.PlayLooping();
                    screamingPlayer.PlayLooping();

                    outputLabel.Text = "You ran out of resources and wasn't able to reach the hotel before evening you got hunted\r\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 18:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;

                    themePlayer.PlayLooping();
                    timePassPlayer.PlayLooping();

                    outputLabel.Text = "You found a car after 3 and half hours of walking you have to go 2 more";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "You reached the hotel successfully and safely but as you were going to it you saw blood and dead bodies of people.";
                    Refresh();
                    Thread.Sleep(3000);

                    optionButton1.Visible = true;
                    optionButton2.Visible = true;

                    zombieNoisePlayer.PlayLooping();
                    screamingPlayer.PlayLooping();

                    outputLabel.Text = "You saw a creature trying to chase you  but lucky you ended up saving yourself in a room. The next morning you saw no creature outside so that made you wonder why the creature are not seen but they can in the night. There is a gas station nearby";
                    optionButton1.Text = "It's fine, keep going";
                    optionButton2.Text = "Fuel";
                    break;
                case 19:
                    themePlayer.PlayLooping();
                    timePassPlayer.PlayLooping();

                    outputLabel.Text = "The car stopped mid way and no shelter was there you died\r\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 20:
                    themePlayer.PlayLooping();
                    timePassPlayer.PlayLooping();

                    outputLabel.Text = "You were close to escaping but suddenly your car got in engine problem ";
                    optionButton1.Text = "Fix it";
                    optionButton2.Text = "Walk 2 hours and escape";
                    break;
                case 21:
                    themePlayer.PlayLooping();
                    zombieNoisePlayer.PlayLooping();
                    timePassPlayer.PlayLooping();

                    outputLabel.Text = "You tried but too late\nPlay Again?";
                   
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 22:
                    themePlayer.PlayLooping();
                    timePassPlayer.PlayLooping();
                    zombieNoisePlayer.PlayLooping();

                    optionButton3.Visible = true;
                    outputLabel.Text = "You chose walk for 2 hours but it turn evening and creature are getting outside";
                    optionButton1.Text = "Run Separate";
                    optionButton2.Text = "Pull out a gun and stay together";
                    optionButton3.Text = "Hide";
                    break;
                case 23:
                    optionButton3.Visible = false;

                    screamingPlayer.PlayLooping();
                    zombieNoisePlayer.PlayLooping();

                    outputLabel.Text = "You and your friend were hunted by different creature\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 24:
                    zombieNoisePlayer.PlayLooping();
                    screamingPlayer.PlayLooping();

                    outputLabel.Text = "You were run out of bullets you died\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 25:
                    optionButton1.Visible = false;
                    optionButton2.Visible = false;

                    themePlayer.PlayLooping();
                    timePassPlayer.PlayLooping();

                    outputLabel.Text = "You survived the night and was successful escaping ";
                    Refresh();
                    Thread.Sleep(2000);

                    optionButton1.Visible = true;
                    optionButton2.Visible = true;

                    outputLabel.Text = "Game over \r\nPart 2 coming soon!\r\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 99:
                    themePlayer.PlayLooping();
                    timePassPlayer.PlayLooping();

                    outputLabel.Text = "Thanks for playing!";
                    optionButton1.Text = "";
                    optionButton2.Text = "";

                    optionButton1.Visible = false;
                    optionButton2.Visible = false;

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
            }
        }

        private void optionButton3_Click(object sender, EventArgs e)
        {
            if (page == 22)
            {
                page = 25;
            }
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            themePlayer.Stop();

            optionButton1.Hide();
            optionButton2.Hide();
            optionButton3.Hide();
            titleLabel2.Hide();

            startButton.Hide();
            pictureBox1.Hide();
            

            optionButton1.Enabled = true;
            optionButton2.Enabled = true;
            optionButton3.Enabled = false;

            page = 1;

            DisplayPage();
        }
    }
}



