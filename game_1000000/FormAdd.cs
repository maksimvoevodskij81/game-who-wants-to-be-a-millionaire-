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
using System.Drawing;

namespace game_1000000
{
    public partial class FormAdd : Form
    {
        Question addQuestion;
        List<TextBox> listTexboxs ; 
        public FormAdd(Question obj)
        {
            InitializeComponent();
            listTexboxs = new List<TextBox>();
            addQuestion = obj;
            listTexboxs.Add(textBoxQuestion);
            listTexboxs.Add(textBoxTrueAnswer);
            listTexboxs.Add(textBoxAnswer1);
            listTexboxs.Add(textBoxAnswer2);
            listTexboxs.Add(textBoxAnswer3);
        }
       private bool Checking()
       {
          
                int i = 0;
                while (i<listTexboxs.Count)
                {
                     if(listTexboxs[i].Text.Trim().Length<2)
                     {
                             return false;
                     }
                  i++;
                   
                }
            buttonAddQuestion.Enabled = true;
            return true;
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            addQuestion.question = textBoxQuestion.Text;
            addQuestion.trueAnswer = textBoxTrueAnswer.Text;
            addQuestion.falseAnswer[0] = textBoxAnswer1.Text;
            addQuestion.falseAnswer[1] = textBoxAnswer2.Text;
            addQuestion.falseAnswer[2] = textBoxAnswer3.Text;
            this.Close();
        }

        private void textBoxQuestion_TextChanged(object sender, EventArgs e)
        {
            Checking();
        }
    }
}
