
namespace Tema3._2
{
    partial class Form1
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
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEquals
            // 
            this.buttonEquals.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEquals.Location = new System.Drawing.Point(519, 318);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(80, 166);
            this.buttonEquals.TabIndex = 35;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Orange;
            this.buttonClear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(519, 232);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 80);
            this.buttonClear.TabIndex = 34;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.BackColor = System.Drawing.Color.Orange;
            this.buttonClearEntry.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClearEntry.Location = new System.Drawing.Point(519, 146);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(80, 80);
            this.buttonClearEntry.TabIndex = 33;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            this.buttonClearEntry.Click += new System.EventHandler(this.buttonClearEntry_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.BackColor = System.Drawing.Color.Silver;
            this.buttonAddition.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddition.Location = new System.Drawing.Point(433, 404);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(80, 80);
            this.buttonAddition.TabIndex = 32;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = false;
            this.buttonAddition.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.BackColor = System.Drawing.Color.Silver;
            this.buttonSubtraction.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSubtraction.Location = new System.Drawing.Point(433, 318);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(80, 80);
            this.buttonSubtraction.TabIndex = 31;
            this.buttonSubtraction.Text = "-";
            this.buttonSubtraction.UseVisualStyleBackColor = false;
            this.buttonSubtraction.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.Color.Silver;
            this.buttonMultiplication.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.buttonMultiplication.Location = new System.Drawing.Point(433, 232);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(80, 80);
            this.buttonMultiplication.TabIndex = 30;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.Silver;
            this.buttonDivision.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDivision.Location = new System.Drawing.Point(433, 146);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(80, 80);
            this.buttonDivision.TabIndex = 29;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDecimal.Location = new System.Drawing.Point(347, 404);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(80, 80);
            this.buttonDecimal.TabIndex = 28;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.button_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.button0.Location = new System.Drawing.Point(175, 404);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(166, 80);
            this.button0.TabIndex = 27;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(347, 146);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 80);
            this.button9.TabIndex = 26;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(261, 146);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 80);
            this.button8.TabIndex = 25;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(175, 146);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 80);
            this.button7.TabIndex = 24;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(347, 232);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 80);
            this.button6.TabIndex = 23;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(261, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 80);
            this.button5.TabIndex = 22;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(175, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 80);
            this.button4.TabIndex = 21;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(347, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 80);
            this.button3.TabIndex = 20;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(261, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 19;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(175, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 18;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxOutput);
            this.panel1.Location = new System.Drawing.Point(175, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 70);
            this.panel1.TabIndex = 36;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxOutput.Location = new System.Drawing.Point(3, 20);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(402, 36);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.Text = "0";
            this.textBoxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}

