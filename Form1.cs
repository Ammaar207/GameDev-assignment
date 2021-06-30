using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalGame 
{
    public partial class Form1 : Form
    {
        //variables
        int correctAnswer;
        private int questionNum = 1;
        private int totalQuestions;

        public Form1()
        {
            InitializeComponent();
            AskQuestion(questionNum);
            totalQuestions = 10;
        }

        //splashscreen
        private void Form1_Load(object sender, EventArgs e)
        {
            Splashscreen splashForm = new Splashscreen();
            splashForm.ShowDialog();

        }

        //Everytime the buttons (btn1 + btn2) are clicked this event will trigger
        private void CheckAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;      //identify the sender, now check its tags
            int buttonTag = Convert.ToInt32(senderObject.Tag);                         //tag is string, convert to number (will convert (senderObject.Tag) to int and save to buttonTag 
            if(buttonTag == correctAnswer)
            {
                questionNum++;
                AskQuestion(questionNum);
            }
        }

        //function for "CheckAnswer"
        //Questions will be organized using a switch statement 
        //**(compare the question numbers with a conditition)
        private void AskQuestion(int QuestionNumber)
        {
            switch (QuestionNumber)
            {
                case 1:
                    Qlabel.Text = "What is the correct spelling of the object below in Afrikaans?";   // This is the Question that will be asked in the label
                    pictureBox1.Image = Properties.Resources.bottle;           //this is from resources i.e the pictures
                    button1.Text = "botle";      //the values of the buttons will change to these texts respectively
                    button2.Text = "bottel";
                    correctAnswer = 2;          //correct answer between the 2 options
                    break;

                case 2:
                    Qlabel.Text = "What is the correct spelling of the vehicle below in Afrikaans?";
                    pictureBox1.Image = Properties.Resources.car;             
                    button1.Text = "kar";      
                    button2.Text = "car";
                    correctAnswer = 1;          
                    break;

                case 3:
                    Qlabel.Text = "What is the correct spelling of the animal below in Afrikaans?";
                    pictureBox1.Image = Properties.Resources.dog;
                    button1.Text = "hont";
                    button2.Text = "hond";
                    correctAnswer = 2;
                    break;

                case 4:
                    Qlabel.Text = "What is the correct spelling of the object in Afrikaans?";
                    pictureBox1.Image = Properties.Resources.door;
                    button1.Text = "deur";
                    button2.Text = "deer";
                    correctAnswer = 1;
                    break;

                case 5:
                    Qlabel.Text = "What is the correct spelling of the practise below in Afrikaans?";
                    pictureBox1.Image = Properties.Resources.education;
                    button1.Text = "onderweis";
                    button2.Text = "onderwys";
                    correctAnswer = 2;
                    break;

                case 6:
                    Qlabel.Text = "What is the correct spelling of the building below in Afrikaans?";
                    pictureBox1.Image = Properties.Resources.house;
                    button1.Text = "huis";
                    button2.Text = "hys";
                    correctAnswer = 1;
                    break;

                case 7:
                    Qlabel.Text = "What is the correct spelling of the action below in Afrikaans?";
                    pictureBox1.Image = Properties.Resources.kick;
                    button1.Text = "scop";
                    button2.Text = "skop";
                    correctAnswer = 2;
                    break;

                case 8:
                    Qlabel.Text = "What is the correct spelling of the device below in Afrikaans?";
                    pictureBox1.Image = Properties.Resources.laptop;
                    button1.Text = "skootrekenaar";
                    button2.Text = "skootrekenar";
                    correctAnswer = 1;
                    break;

                case 9:
                    Qlabel.Text = "What is the correct spelling of the art form below in Afrikaans?";
                    pictureBox1.Image = Properties.Resources.music;
                    button1.Text = "musik";
                    button2.Text = "musiek";
                    correctAnswer = 2;
                    break;

                case 10:
                    Qlabel.Text = "What is the correct spelling of the liquid below in Afrikaans?";
                    pictureBox1.Image = Properties.Resources.water;
                    button1.Text = "water";
                    button2.Text = "watter";
                    correctAnswer = 1;
                    break;

                case 11:
                    Qlabel.Text = "Good Job!";
                    pictureBox1.Image = Properties.Resources.language;
                    button1.Text = "Game Over";
                    button2.Text = "Exit";
                    correctAnswer = 2;
                    break;

            }
        }

        
    }
}
