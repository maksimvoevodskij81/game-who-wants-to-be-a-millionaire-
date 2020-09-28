namespace game_1000000
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAddQuestion = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.labelTrueAnswer = new System.Windows.Forms.Label();
            this.textBoxTrueAnswer = new System.Windows.Forms.TextBox();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.textBoxAnswer1 = new System.Windows.Forms.TextBox();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.textBoxAnswer2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAnswer3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAddQuestion
            // 
            this.labelAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddQuestion.Location = new System.Drawing.Point(44, 26);
            this.labelAddQuestion.Name = "labelAddQuestion";
            this.labelAddQuestion.Size = new System.Drawing.Size(130, 23);
            this.labelAddQuestion.TabIndex = 0;
            this.labelAddQuestion.Text = "Enter Question :";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuestion.Location = new System.Drawing.Point(47, 50);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(312, 22);
            this.textBoxQuestion.TabIndex = 1;
            this.textBoxQuestion.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonAddQuestion.Enabled = false;
            this.buttonAddQuestion.Location = new System.Drawing.Point(151, 337);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(95, 30);
            this.buttonAddQuestion.TabIndex = 2;
            this.buttonAddQuestion.Text = "Add";
            this.buttonAddQuestion.UseVisualStyleBackColor = false;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // labelTrueAnswer
            // 
            this.labelTrueAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrueAnswer.Location = new System.Drawing.Point(44, 75);
            this.labelTrueAnswer.Name = "labelTrueAnswer";
            this.labelTrueAnswer.Size = new System.Drawing.Size(130, 23);
            this.labelTrueAnswer.TabIndex = 3;
            this.labelTrueAnswer.Text = "True Answer:";
            // 
            // textBoxTrueAnswer
            // 
            this.textBoxTrueAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTrueAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTrueAnswer.Location = new System.Drawing.Point(47, 101);
            this.textBoxTrueAnswer.Name = "textBoxTrueAnswer";
            this.textBoxTrueAnswer.Size = new System.Drawing.Size(312, 22);
            this.textBoxTrueAnswer.TabIndex = 4;
            this.textBoxTrueAnswer.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer1.Location = new System.Drawing.Point(44, 136);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(130, 23);
            this.labelAnswer1.TabIndex = 5;
            this.labelAnswer1.Text = " Answer 1 :";
            // 
            // textBoxAnswer1
            // 
            this.textBoxAnswer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer1.Location = new System.Drawing.Point(47, 162);
            this.textBoxAnswer1.Name = "textBoxAnswer1";
            this.textBoxAnswer1.Size = new System.Drawing.Size(312, 22);
            this.textBoxAnswer1.TabIndex = 6;
            this.textBoxAnswer1.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer2.Location = new System.Drawing.Point(44, 199);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(130, 23);
            this.labelAnswer2.TabIndex = 7;
            this.labelAnswer2.Text = " Answer 2 :";
            // 
            // textBoxAnswer2
            // 
            this.textBoxAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer2.Location = new System.Drawing.Point(47, 225);
            this.textBoxAnswer2.Name = "textBoxAnswer2";
            this.textBoxAnswer2.Size = new System.Drawing.Size(312, 22);
            this.textBoxAnswer2.TabIndex = 8;
            this.textBoxAnswer2.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = " Answer 3 :";
            // 
            // textBoxAnswer3
            // 
            this.textBoxAnswer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer3.Location = new System.Drawing.Point(47, 291);
            this.textBoxAnswer3.Name = "textBoxAnswer3";
            this.textBoxAnswer3.Size = new System.Drawing.Size(312, 22);
            this.textBoxAnswer3.TabIndex = 10;
            this.textBoxAnswer3.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(397, 379);
            this.Controls.Add(this.textBoxAnswer3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAnswer2);
            this.Controls.Add(this.labelAnswer2);
            this.Controls.Add(this.textBoxAnswer1);
            this.Controls.Add(this.labelAnswer1);
            this.Controls.Add(this.textBoxTrueAnswer);
            this.Controls.Add(this.labelTrueAnswer);
            this.Controls.Add(this.buttonAddQuestion);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelAddQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdd";
            this.Text = "Add  Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddQuestion;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Label labelTrueAnswer;
        private System.Windows.Forms.TextBox textBoxTrueAnswer;
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.TextBox textBoxAnswer1;
        private System.Windows.Forms.Label labelAnswer2;
        private System.Windows.Forms.TextBox textBoxAnswer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAnswer3;
    }
}