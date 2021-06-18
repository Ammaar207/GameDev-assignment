using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageGame
{
    public partial class Form1 : Form
    {
        //variables
        int correctAnswer;
        int questionNum = 1;
        int totalQuestions;

        public Form1()
        {
            AskQuestion(questionNum);
            totalQuestions = 10;
        }

        //Everytime the buttons (btn1 + btn2) are clicked this event will trigger
        private void CheckAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;      //identify the sender, now check its tags
            int buttonTag = Convert.ToInt32(senderObject.Tag);                         //tag is string, convert to number (will convert (senderObject.Tag) to int and save to buttonTag 
            if (buttonTag == correctAnswer)
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
                    pictureBox1.Image = Properties.Resources.bottle;           //this is from resources i.e the pictures
                    Qlabel.Text = "What is the correct spelling of the object or action below in Afrikaans?";   // This is the Question that will be asked in the label
                    button1.Text = "botle";      //the values of the buttons will change to these texts respectively
                    button2.Text = "bottel";
                    correctAnswer = 2;          //correct answer between the 2 options
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.car;
                    Qlabel.Text = "What is the correct spelling of the object or action below in Afrikaans?";
                    button1.Text = "kar";
                    button2.Text = "car";
                    correctAnswer = 1;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.dog;
                    Qlabel.Text = "What is the correct spelling of the object or action below in Afrikaans?";
                    button1.Text = "hont";
                    button2.Text = "hond";
                    correctAnswer = 2;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.door;
                    Qlabel.Text = "What is the correct spelling of the object or action below in Afrikaans?";
                    button1.Text = "deur";
                    button2.Text = "deer";
                    correctAnswer = 1;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.education;
                    Qlabel.Text = "What is the correct spelling of the object or action below in Afrikaans?";
                    button1.Text = "onderweis";
                    button2.Text = "onderwys";
                    correctAnswer = 2;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.house;
                    Qlabel.Text = "What is the correct spelling of the object or action below in Afrikaans?";
                    button1.Text = "huis";
                    button2.Text = "hys";
                    correctAnswer = 1;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.kick;
                    Qlabel.Text = "What is the correct spelling of the object or action below in Afrikaans?";
                    button1.Text = "scop";
                    button2.Text = "skop";
                    correctAnswer = 2;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.laptop;
                    Qlabel.Text = "What is the correct spelling of the object or action below in Afrikaans?";
                    button1.Text = "skootrekenaar";
                    button2.Text = "skootrekenar";
                    correctAnswer = 1;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.music;
                    Qlabel.Text = "What is the correct spelling of the object or action below in Afrikaans?";
                    button1.Text = "musik";
                    button2.Text = "musiek";
                    correctAnswer = 2;
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.water;
                    Qlabel.Text = "What is the correct spelling of the object or action below in Afrikaans?";
                    button1.Text = "water";
                    button2.Text = "watter";
                    correctAnswer = 1;
                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.water;
                    Qlabel.Text = "What is the correct spelling of the object or action below in Afrikaans?";

                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
