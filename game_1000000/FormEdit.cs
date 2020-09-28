using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_1000000

{
    public partial class FormEdit : Form
    {
        
        List<string> questions;
        List<string> rightAnswer;
        List<string> wrongAnswers;
        List<TextBox> textBoxes;
        public bool flag = false;
        public FormEdit(Choice choice, List<string> _questions, List<string> _rightAnswer, List<string> _wrongAnswers)
        {
             InitializeComponent();
            switch (choice)
            {
                case Choice.edit:
                    this.Text = "EDIT";
                    break;
                case Choice.delete:
                    this.Text = "DELETE";
                    buttonEditQuestion.Text = "delete";
                    buttonEditQuestion.BackColor = Color.Red;
                    flag = true;
                    break;
               
            }
            questions=_questions;
             rightAnswer = _rightAnswer; 
             wrongAnswers = _wrongAnswers;
             textBoxes =new List<TextBox>();
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = questions.Count;
            numericUpDown1.Value = 1;
            textBoxQuestion.Text = questions[(int)numericUpDown1.Value-1];
            textBoxTrueAnswer.Text = rightAnswer[(int)numericUpDown1.Value-1];
            textBoxAnswer1.Text = wrongAnswers[((int)numericUpDown1.Value-1) * 3 ];
            textBoxAnswer2.Text = wrongAnswers[((int)numericUpDown1.Value-1) * 3+1];
            textBoxAnswer3.Text = wrongAnswers[((int)numericUpDown1.Value-1) * 3+2];
            textBoxes.Add(textBoxQuestion);
            textBoxes.Add(textBoxTrueAnswer);
            textBoxes.Add(textBoxAnswer1);
            textBoxes.Add(textBoxAnswer2);
            textBoxes.Add(textBoxAnswer3);

        }

        private void buttonEditQuestion_Click( object sender, EventArgs e)
        {
            questions[(int)numericUpDown1.Value - 1] = textBoxQuestion.Text;
            rightAnswer[(int)numericUpDown1.Value - 1] = textBoxTrueAnswer.Text;
            wrongAnswers[((int)numericUpDown1.Value - 1) * 3] = textBoxAnswer1.Text;
            wrongAnswers[((int)numericUpDown1.Value - 1) * 3 + 1] = textBoxAnswer2.Text;
            wrongAnswers[((int)numericUpDown1.Value - 1) * 3 + 2] = textBoxAnswer3.Text;
            if (flag)
            {
                questions.RemoveAt((int)numericUpDown1.Value - 1); 
                rightAnswer.RemoveAt((int)numericUpDown1.Value - 1);
                wrongAnswers.RemoveAt(((int)numericUpDown1.Value - 1) * 3);
                wrongAnswers.RemoveAt(((int)numericUpDown1.Value - 1) * 3+1);
                wrongAnswers.RemoveAt(((int)numericUpDown1.Value - 1) * 3+2);
            }
           
           
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBoxQuestion.Text = questions[(int)numericUpDown1.Value - 1];
            textBoxTrueAnswer.Text = rightAnswer[(int)numericUpDown1.Value - 1];
            textBoxAnswer1.Text = wrongAnswers[((int)numericUpDown1.Value - 1) * 3];
            textBoxAnswer2.Text = wrongAnswers[((int)numericUpDown1.Value - 1) * 3 + 1];
            textBoxAnswer3.Text = wrongAnswers[((int)numericUpDown1.Value - 1) * 3 + 2];
        }

        private void textBoxQuestion_TextChanged(object sender, EventArgs e)
        {
            Checking();
        }
        private bool Checking()
        {

            int i = 0;
            while (i < textBoxes.Count)
            {
                if (textBoxes[i].Text.Trim().Length < 2)
                {
                    return false;
                }
                i++;

            }
            buttonEditQuestion.Enabled = true;
            return true;
        }
        
    }
    public enum Choice { edit, delete };
}
