namespace game_1000000
{
    partial class FormEdit
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
            this.textBoxAnswer3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAnswer2 = new System.Windows.Forms.TextBox();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.textBoxAnswer1 = new System.Windows.Forms.TextBox();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.textBoxTrueAnswer = new System.Windows.Forms.TextBox();
            this.labelTrueAnswer = new System.Windows.Forms.Label();
            this.buttonEditQuestion = new System.Windows.Forms.Button();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.labelAddQuestion = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAnswer3
            // 
            this.textBoxAnswer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer3.Location = new System.Drawing.Point(29, 313);
            this.textBoxAnswer3.Name = "textBoxAnswer3";
            this.textBoxAnswer3.Size = new System.Drawing.Size(312, 22);
            this.textBoxAnswer3.TabIndex = 21;
            this.textBoxAnswer3.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = " Answer 3 :";
            // 
            // textBoxAnswer2
            // 
            this.textBoxAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer2.Location = new System.Drawing.Point(29, 262);
            this.textBoxAnswer2.Name = "textBoxAnswer2";
            this.textBoxAnswer2.Size = new System.Drawing.Size(312, 22);
            this.textBoxAnswer2.TabIndex = 19;
            this.textBoxAnswer2.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer2.Location = new System.Drawing.Point(26, 236);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(130, 23);
            this.labelAnswer2.TabIndex = 18;
            this.labelAnswer2.Text = " Answer 2 :";
            // 
            // textBoxAnswer1
            // 
            this.textBoxAnswer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer1.Location = new System.Drawing.Point(29, 211);
            this.textBoxAnswer1.Name = "textBoxAnswer1";
            this.textBoxAnswer1.Size = new System.Drawing.Size(312, 22);
            this.textBoxAnswer1.TabIndex = 17;
            this.textBoxAnswer1.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer1.Location = new System.Drawing.Point(26, 185);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(130, 23);
            this.labelAnswer1.TabIndex = 16;
            this.labelAnswer1.Text = " Answer 1 :";
            // 
            // textBoxTrueAnswer
            // 
            this.textBoxTrueAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTrueAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTrueAnswer.Location = new System.Drawing.Point(29, 160);
            this.textBoxTrueAnswer.Name = "textBoxTrueAnswer";
            this.textBoxTrueAnswer.Size = new System.Drawing.Size(312, 22);
            this.textBoxTrueAnswer.TabIndex = 15;
            this.textBoxTrueAnswer.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // labelTrueAnswer
            // 
            this.labelTrueAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrueAnswer.Location = new System.Drawing.Point(26, 134);
            this.labelTrueAnswer.Name = "labelTrueAnswer";
            this.labelTrueAnswer.Size = new System.Drawing.Size(130, 23);
            this.labelTrueAnswer.TabIndex = 14;
            this.labelTrueAnswer.Text = "True Answer:";
            // 
            // buttonEditQuestion
            // 
            this.buttonEditQuestion.BackColor = System.Drawing.Color.Orange;
            this.buttonEditQuestion.Enabled = false;
            this.buttonEditQuestion.Location = new System.Drawing.Point(137, 370);
            this.buttonEditQuestion.Name = "buttonEditQuestion";
            this.buttonEditQuestion.Size = new System.Drawing.Size(95, 30);
            this.buttonEditQuestion.TabIndex = 13;
            this.buttonEditQuestion.Text = "Edit";
            this.buttonEditQuestion.UseVisualStyleBackColor = false;
            this.buttonEditQuestion.Click += new System.EventHandler(this.buttonEditQuestion_Click);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuestion.Location = new System.Drawing.Point(29, 100);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(312, 22);
            this.textBoxQuestion.TabIndex = 12;
            this.textBoxQuestion.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // labelAddQuestion
            // 
            this.labelAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddQuestion.Location = new System.Drawing.Point(26, 74);
            this.labelAddQuestion.Name = "labelAddQuestion";
            this.labelAddQuestion.Size = new System.Drawing.Size(130, 23);
            this.labelAddQuestion.TabIndex = 11;
            this.labelAddQuestion.Text = " Question :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(207, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Number of Question :";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(367, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxAnswer3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAnswer2);
            this.Controls.Add(this.labelAnswer2);
            this.Controls.Add(this.textBoxAnswer1);
            this.Controls.Add(this.labelAnswer1);
            this.Controls.Add(this.textBoxTrueAnswer);
            this.Controls.Add(this.labelTrueAnswer);
            this.Controls.Add(this.buttonEditQuestion);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelAddQuestion);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAnswer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAnswer2;
        private System.Windows.Forms.Label labelAnswer2;
        private System.Windows.Forms.TextBox textBoxAnswer1;
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.TextBox textBoxTrueAnswer;
        private System.Windows.Forms.Label labelTrueAnswer;
        private System.Windows.Forms.Button buttonEditQuestion;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label labelAddQuestion;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}