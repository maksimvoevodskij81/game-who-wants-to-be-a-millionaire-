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
using System.Threading;
using System.Media;


namespace game_1000000
{
   
    public partial class Form1 : Form
    {

        List<string> questions;
        List<string> rightAnswer;
        List<string> wrongAnswers;
        SoundPlayer soundPlayer ;
        static int countQuestions=0;
        int randQuestions = 0;
        Random random = new Random();
        public Form1()
        {

            InitializeComponent();
            questions = new List<string>();
            rightAnswer = new List<string>();
            wrongAnswers = new List<string>();
            soundPlayer = new SoundPlayer();
            buttonsVisibleFalse(buttonA, buttonB, buttonC, buttonD,buttonSTOP);
            buttonsEnabledFalse(button50, buttonCall, buttonHelp);
            labelVisibleFalse(labelQuestion,labelGiveup,labelExit);
            readSort();
          
        }
          void readSort()//read from file and sort line
          {
            try
            {   
              StreamReader sr = new StreamReader("question.txt", Encoding.Default);
                String line;
                for (int j = 0, i = 4, a = 1, b = 2, c = 3; (line = sr.ReadLine()) != null; j++, i++, a++, b++, c++)
                {
                    if (j % 5 == 0)
                    {
                        questions.Add(line);
                    }
                    if (i % 5 == 0)
                    {
                        rightAnswer.Add(line);
                    }
                    if (a % 5 == 0 || b % 5 == 0 || c % 5 == 0)
                    {
                        wrongAnswers.Add(line);
                    }
                }
                sr.Close();
                
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong !");
            }
          }
        void changeNextQuestions()
        {
            LablesQustionsChange();
           
            if(countQuestions==0)
            {
                buttonsEnabledTrue(buttonA, buttonB, buttonC, buttonD, button50, buttonCall, buttonHelp);
            }
            else
            {
                buttonsEnabledTrue(buttonA, buttonB, buttonC, buttonD);
                if (button50False.Enabled == false)
                {

                    button50.Enabled = true;
                }
                else
                {
                    button50.Enabled =false;
                }
                if (buttonCallEnd.Enabled == false)
                {

                    buttonCall.Enabled = true;
                }
                else
                {
                    buttonCall.Enabled = false;
                }
                if (buttonHelpFalse.Enabled == false)
                {

                    buttonHelp.Enabled = true;
                }
                else
                {
                    buttonHelp.Enabled = false;
                }
            }
            menuStrip1.Visible =false;
            labelVisibleTrue(labelQuestion, labelGiveup, labelExit);
            groupBoxProgresBar.Visible = false;
            lableGalkinSayTrue.Visible = false;
            pictureGalkin.Visible = false;
            FrendSay.Visible = false;
            pictureFrend.Visible = false;
            buttonA.BackColor = Color.Black;
            buttonB.BackColor = Color.Black;
            buttonC.BackColor = Color.Black;
            buttonD.BackColor = Color.Black;
            buttonsVisibleTrue(buttonA, buttonB, buttonC, buttonD);
            randQuestions = random.Next(0, questions.Count);
            labelQuestion.Text = questions[randQuestions];
            if (countQuestions<=14)
            {
                switch (random.Next(1, 5))
                {
                    case 1:
                        buttonA.Text = "A: " + wrongAnswers[randQuestions * 3];
                        buttonB.Text = "B: " + wrongAnswers[randQuestions * 3 + 1];
                        buttonC.Text = "C: " + wrongAnswers[randQuestions * 3 + 2];
                        buttonD.Text = "D: " + rightAnswer[randQuestions];
                        break;
                    case 2:
                        buttonA.Text = "A: " + rightAnswer[randQuestions];
                        buttonB.Text = "B: " + wrongAnswers[randQuestions * 3 + 1];
                        buttonC.Text = "C: " + wrongAnswers[randQuestions * 3 + 2];
                        buttonD.Text = "D: " + wrongAnswers[randQuestions * 3];
                        break;
                    case 3:
                        buttonA.Text = "A: " + wrongAnswers[randQuestions * 3 + 1];
                        buttonB.Text = "B: " + rightAnswer[randQuestions];
                        buttonC.Text = "C: " + wrongAnswers[randQuestions * 3 + 2];
                        buttonD.Text = "D: " + wrongAnswers[randQuestions * 3];
                        break;
                    case 4:
                        buttonA.Text = "A: " + wrongAnswers[randQuestions * 3 + 2];
                        buttonB.Text = "B: " + wrongAnswers[randQuestions * 3 + 1];
                        buttonC.Text = "C: " + rightAnswer[randQuestions];
                        buttonD.Text = "D: " + wrongAnswers[randQuestions * 3];
                        break;
                }
            }
            
            if (countQuestions == 15)
            {
                labelQuestion.Text = "You win 1000000 !!!";
                soundPlayer.SoundLocation = "sound/winner.wav";
                soundPlayer.Play();

                pictureBoxWonMoney.Visible = true;
                buttonsVisibleFalse(buttonA, buttonB, buttonC, buttonD);
            }
        }
        private void LablesQustionsChange() //перелючение label
        {
            List<Label> labels = new List<Label>();
            for (int i = 0; i < LableBox.Controls.Count; i++)
            {
                labels.Add((Label)LableBox.Controls[i]);
                labels[i].BackColor = Color.Black;
                if (countQuestions == i)
                {
                    labels[i].BackColor = Color.Gold;
                }
            }
        }
        void labelVisibleFalse(params object[] senders)
        {
            for (int i = 0; i < senders.Length; i++)
            {
                Label labels = new Label();
                labels = (Label)senders[i];
                labels.Visible = false;
            }
        }
        void labelVisibleTrue(params object[] senders)
        {
            for (int i = 0; i < senders.Length; i++)
            {
                Label labels = new Label();
                labels = (Label)senders[i];
                labels.Visible = true;
            }
        }

        void buttonsVisibleFalse(params object[]senders)
        {
            for(int i=0;i<senders.Length;i++)
            {
                Button buttons = new Button();
                buttons = (Button)senders[i];
                buttons.Visible = false;
            }
        }
        void buttonsVisibleTrue(params object[] senders)
        {
            for (int i = 0; i < senders.Length; i++)
            {
                Button buttons = new Button();
                buttons = (Button)senders[i];
                buttons.Visible = true;
            }
        }
        void buttonsEnabledFalse(params object[] senders)
        {
            for (int i = 0; i < senders.Length; i++)
            {
                Button buttons = new Button();
                buttons = (Button)senders[i];
                buttons.Enabled = false;
            }
        }
        void buttonsEnabledTrue( params object[] senders)
        {
            for (int i = 0; i < senders.Length; i++)
            {
                Button buttons = new Button();
                buttons = (Button)senders[i];
                buttons.Enabled = true;
            }
        }
        void rightResult(object sender)
        {
            if (sender != null)
            {
                Button button = new Button();
                button = (Button)sender;
                button.BackColor = Color.LightGreen;
                soundPlayer.SoundLocation = "sound/true.wav";
                soundPlayer.Play();
                lableGalkinSayTrue.Visible = true;
                pictureGalkin.Visible = true;
                if (sender == buttonA)
                {
                    buttonsEnabledFalse(buttonB, buttonC, buttonD, button50, buttonCall, buttonHelp);
                }
                if (sender == buttonB)
                {
                    buttonsEnabledFalse(buttonA, buttonC, buttonD, button50, buttonCall, buttonHelp);
                }
                if (sender == buttonC)
                {
                    buttonsEnabledFalse(buttonB, buttonA, buttonD, button50, buttonCall, buttonHelp);
                }
                if (sender == buttonD)
                {
                    buttonsEnabledFalse(buttonB, buttonC, buttonA, button50, buttonCall, buttonHelp);
                }
            }
        }
        void wrongResult(object sender)
        {
            if (sender != null)
            {
                Button button = new Button();
                button = (Button)sender;
                if(button!=null)
                {
                    button.BackColor = Color.Red;
                    soundPlayer.SoundLocation = "sound/false.wav";
                    soundPlayer.Play();
                    if (sender == buttonA)
                    {
                        buttonsEnabledFalse(buttonB, buttonC, buttonD, button50, buttonCall, buttonHelp);
                    }
                    if (sender == buttonB)
                    {
                        buttonsEnabledFalse(buttonA, buttonC, buttonD, button50, buttonCall, buttonHelp);
                    }
                    if (sender == buttonC)
                    {
                        buttonsEnabledFalse(buttonB, buttonA, buttonD, button50, buttonCall, buttonHelp);
                    }
                    if (sender == buttonD)
                    {
                        buttonsEnabledFalse(buttonB, buttonC, buttonA, button50, buttonCall, buttonHelp);
                    }
                }
               
            }

        }

        void exitOrNot()
        {
            
            labelQuestion.Text = " You lose :-( !";
            DialogResult = MessageBox.Show("Do you want try again ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
            {
                Environment.Exit(0);
            }
            else
            {
                countQuestions = 0;
                changeNextQuestions();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerRight.Stop();
            countQuestions++;
            LablesQustionsChange();
            changeNextQuestions();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timerWrong.Stop();
            exitOrNot();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {

            timerExit.Start();
            labelQuestion.Text = " GOOD BAY !!!";
            labelQuestion.BackColor = Color.Green;
            buttonsVisibleFalse(buttonA,buttonB,buttonC,buttonD);
        }

        private void timerExit_Tick(object sender, EventArgs e)
        {
            timerExit.Stop();
            Environment.Exit(0);
        }
       
        private void button50_MouseClick(object sender, MouseEventArgs e)//fifty/fifty
        {
            if (buttonA.Text == "A: "+rightAnswer[randQuestions])
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        buttonsVisibleFalse(buttonC, buttonD);
                        break;
                    case 2:
                        buttonsVisibleFalse(buttonC, buttonB);
                        break;
                    case 3:
                        buttonsVisibleFalse(buttonD, buttonB);
                        break;
                }
            }
            if (buttonB.Text == "B: "+ rightAnswer[randQuestions])
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        buttonsVisibleFalse(buttonC, buttonD);
                        break;
                    case 2:
                        buttonsVisibleFalse(buttonC, buttonA);
                        break;
                    case 3:
                        buttonsVisibleFalse(buttonD, buttonA);
                        break;
                }
            }
            if (buttonC.Text == "C: "+ rightAnswer[randQuestions])
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        buttonsVisibleFalse(buttonA, buttonD);
                        break;
                    case 2:
                        buttonsVisibleFalse(buttonA, buttonB);
                        break;
                    case 3:
                        buttonsVisibleFalse(buttonD, buttonB);
                        break;
                }
            }
            if (buttonD.Text == "D: "+ rightAnswer[randQuestions])
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        buttonsVisibleFalse(buttonC, buttonA);
                        break;
                    case 2:
                        buttonsVisibleFalse(buttonC, buttonB);
                        break;
                    case 3:
                        buttonsVisibleFalse(buttonA, buttonB);
                        break;
                }
            }
            button50.Visible = false;
            button50False.Enabled = true;
        
        }

        private void buttonCall_MouseClick(object sender, MouseEventArgs e)//callfrend
        {
            pictureFrend.Visible = true;
            FrendSay.Visible = true;
            FrendSay.Text = "I think it " + rightAnswer[randQuestions];
            soundPlayer.SoundLocation = "sound/zvonok.wav";
            soundPlayer.Play();
            buttonCall.Visible = false;
            buttonCallEnd.Enabled = true;
        }

        private void buttonHelp_MouseClick(object sender, MouseEventArgs e)
        {
            groupBoxProgresBar.Visible = true;
            soundPlayer.SoundLocation = "sound/zal.wav";
            soundPlayer.Play();
            int A = 0, B = 0, C = 0, D = 0;

            if (buttonA.Text == "A: " + rightAnswer[randQuestions])
            {
                do
                {
                    A = random.Next(55, 87);
                    B = random.Next(0, 13);
                    C = random.Next(0, 13);
                    D = random.Next(0, 13);
                } while ((A + B + C + D) != 100);
            }
            if (buttonB.Text == "B: " + rightAnswer[randQuestions])
            {
                do
                {
                    B = random.Next(55, 87);
                    A = random.Next(0, 13);
                    C = random.Next(0, 13);
                    D = random.Next(0, 13);
                } while ((A + B + C + D) != 100);
            }
            if (buttonC.Text == "C: " + rightAnswer[randQuestions])
            {
                do
                {
                    C = random.Next(55, 87);
                    B = random.Next(0, 13);
                    A = random.Next(0, 13);
                    D = random.Next(0, 13);
                } while ((A + B + C + D) != 100);
            }
            if (buttonD.Text == "D: " + rightAnswer[randQuestions])
            {
                do
                {
                    D = random.Next(55, 87);
                    B = random.Next(0, 13);
                    C = random.Next(0, 13);
                    A = random.Next(0, 13);
                } while ((A + B + C + D) != 100);
            }
            labelAPros.Text += A + "%";
            labelBPros.Text += B + "%"; 
            labelCPros.Text += C + "%"; 
            labelDPros.Text += D + "%"; 

            progressBarA.Value = A;
            progressBarB.Value = B;
            progressBarC.Value = C;
            progressBarD.Value = D;

            buttonHelp.Visible = false;
            buttonHelpFalse.Enabled = true;
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(button !=null)
            {
                
                if(button==buttonA)
                {
                    if (buttonA.Text == "A: " + rightAnswer[randQuestions])
                    {
                        rightResult(sender);
                        timerRight.Start();
                    }
                    else
                    {
                        wrongResult(sender);
                        timerWrong.Start();
                    }
                }
               

                else if (button == buttonB )
                {
                    if(buttonB.Text == "B: " + rightAnswer[randQuestions])
                    {
                        rightResult(sender);
                        timerRight.Start();
                    }
                else
                {
                        wrongResult(sender);
                        timerWrong.Start();
                    }
                }
               
               else if (button == buttonC )
               {
                    if (buttonC.Text == "C: " + rightAnswer[randQuestions])
                    {
                        rightResult(sender);
                        timerRight.Start();
                    }
                    else
                    {
                        wrongResult(sender);
                        timerWrong.Start();
                    }
               }
                 
               else if (button == buttonD )
                {
                    if (buttonD.Text == "D: " + rightAnswer[randQuestions])
                    {
                        rightResult(sender);
                        timerRight.Start();
                    }
                    else
                    {
                        wrongResult(sender);
                        timerWrong.Start();
                    }
                }
                  
            }

        }

        private void labelGiveupAndStartAgain_Click(object sender, EventArgs e)
        {
            timerStart.Start();
            labelQuestion.Visible = true;
            labelQuestion.Text = " Hello !!! We are glad to welcome you ! ";
            soundPlayer.SoundLocation = "sound/begin.wav";
            soundPlayer.Play();
           
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            timerStart.Stop();
            changeNextQuestions();
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            Question obj = new Question();
            FormAdd formAdd = new FormAdd(obj);
            formAdd.ShowDialog();
            StreamWriter streamWriter = new StreamWriter("question.txt",true,Encoding.Default);
                streamWriter.WriteLine(obj.question);
                streamWriter.WriteLine(obj.trueAnswer);
                streamWriter.WriteLine(obj.falseAnswer[0]);
                streamWriter.WriteLine(obj.falseAnswer[1]);
                streamWriter.WriteLine(obj.falseAnswer[2]);
                questions.Add (obj.question);
                rightAnswer.Add(obj.trueAnswer);
                wrongAnswers.Add(obj.falseAnswer[0]);//Add to Lists
                wrongAnswers.Add(obj.falseAnswer[1]);
                wrongAnswers.Add(obj.falseAnswer[2]);
                streamWriter.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            FormEdit formEdit = new FormEdit(Choice.edit, questions, rightAnswer, wrongAnswers);
            formEdit.ShowDialog();
            StreamWriter streamWriter = new StreamWriter("question.txt", false, Encoding.Default);
            for (int i = 0; i < questions.Count; i++)
            {
                streamWriter.WriteLine(questions[i]);
                streamWriter.WriteLine(rightAnswer[i]);
                streamWriter.WriteLine(wrongAnswers[i * 3]);
                streamWriter.WriteLine(wrongAnswers[i * 3 + 1]);
                streamWriter.WriteLine(wrongAnswers[i * 3 + 2]);
            }
            streamWriter.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit(Choice.delete, questions, rightAnswer, wrongAnswers);
            formEdit.ShowDialog();
            StreamWriter streamWriter = new StreamWriter("question.txt", false, Encoding.Default);
            for (int i = 0; i < questions.Count; i++)
            {
                streamWriter.WriteLine(questions[i]);
                streamWriter.WriteLine(rightAnswer[i]);
                streamWriter.WriteLine(wrongAnswers[i * 3]);
                streamWriter.WriteLine(wrongAnswers[i * 3 + 1]);
                streamWriter.WriteLine(wrongAnswers[i * 3 + 2]);
            }
            streamWriter.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            aboutUS aboutUS = new aboutUS();
            aboutUS.ShowDialog();
        }
    }
    public class Question
    {
        public string question { get; set; }
        public string trueAnswer { get; set; }
        public string[] falseAnswer { get; set; } = new string[3];
      
    }
         
}
