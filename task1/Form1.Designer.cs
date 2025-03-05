namespace task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label8 = new Label();
            textBoxReport = new TextBox();
            button4 = new Button();
            InputNumGenMatrix2 = new NumericUpDown();
            InputNumGenMatrix1 = new NumericUpDown();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            TextBoxResultatMatrixA = new TextBox();
            TextBoxResultatMatrix = new TextBox();
            button3 = new Button();
            LabelMatrixRange = new Label();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            InputMatrixB = new TextBox();
            label1 = new Label();
            InputMatrixA = new TextBox();
            tabPage2 = new TabPage();
            button5 = new Button();
            textBox5 = new TextBox();
            label13 = new Label();
            textBox4 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            CountVal = new NumericUpDown();
            ReportTextBox = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox3 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox2 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputNumGenMatrix2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputNumGenMatrix1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CountVal).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(5, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1360, 678);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(textBoxReport);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(InputNumGenMatrix2);
            tabPage1.Controls.Add(InputNumGenMatrix1);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(TextBoxResultatMatrixA);
            tabPage1.Controls.Add(TextBoxResultatMatrix);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(LabelMatrixRange);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(InputMatrixB);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(InputMatrixA);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1352, 645);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(821, 4);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 41;
            label8.Text = "Звіт";
            // 
            // textBoxReport
            // 
            textBoxReport.Location = new Point(821, 33);
            textBoxReport.Multiline = true;
            textBoxReport.Name = "textBoxReport";
            textBoxReport.ScrollBars = ScrollBars.Both;
            textBoxReport.Size = new Size(529, 583);
            textBoxReport.TabIndex = 40;
            textBoxReport.WordWrap = false;
            // 
            // button4
            // 
            button4.Location = new Point(442, 101);
            button4.Name = "button4";
            button4.Size = new Size(173, 47);
            button4.TabIndex = 39;
            button4.Text = "Згенерувати матрицю";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // InputNumGenMatrix2
            // 
            InputNumGenMatrix2.Location = new Point(530, 59);
            InputNumGenMatrix2.Name = "InputNumGenMatrix2";
            InputNumGenMatrix2.Size = new Size(61, 27);
            InputNumGenMatrix2.TabIndex = 38;
            InputNumGenMatrix2.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // InputNumGenMatrix1
            // 
            InputNumGenMatrix1.Location = new Point(442, 59);
            InputNumGenMatrix1.Name = "InputNumGenMatrix1";
            InputNumGenMatrix1.Size = new Size(61, 27);
            InputNumGenMatrix1.TabIndex = 37;
            InputNumGenMatrix1.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(530, 36);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 36;
            label7.Text = "Стовпці";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 36);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 35;
            label3.Text = "Рядки";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(530, 410);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 34;
            label6.Text = "Обернена матриця";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 410);
            label5.Name = "label5";
            label5.Size = new Size(193, 20);
            label5.TabIndex = 33;
            label5.Text = "Результат обрахунку СЛАУ";
            // 
            // TextBoxResultatMatrixA
            // 
            TextBoxResultatMatrixA.Location = new Point(530, 433);
            TextBoxResultatMatrixA.Multiline = true;
            TextBoxResultatMatrixA.Name = "TextBoxResultatMatrixA";
            TextBoxResultatMatrixA.ScrollBars = ScrollBars.Both;
            TextBoxResultatMatrixA.Size = new Size(271, 183);
            TextBoxResultatMatrixA.TabIndex = 32;
            TextBoxResultatMatrixA.WordWrap = false;
            // 
            // TextBoxResultatMatrix
            // 
            TextBoxResultatMatrix.Location = new Point(271, 433);
            TextBoxResultatMatrix.Multiline = true;
            TextBoxResultatMatrix.Name = "TextBoxResultatMatrix";
            TextBoxResultatMatrix.ScrollBars = ScrollBars.Both;
            TextBoxResultatMatrix.Size = new Size(241, 183);
            TextBoxResultatMatrix.TabIndex = 31;
            TextBoxResultatMatrix.WordWrap = false;
            // 
            // button3
            // 
            button3.Location = new Point(9, 443);
            button3.Name = "button3";
            button3.Size = new Size(172, 47);
            button3.TabIndex = 30;
            button3.Text = "Обчислити СЛАУ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // LabelMatrixRange
            // 
            LabelMatrixRange.AutoSize = true;
            LabelMatrixRange.Location = new Point(115, 400);
            LabelMatrixRange.Name = "LabelMatrixRange";
            LabelMatrixRange.Size = new Size(17, 20);
            LabelMatrixRange.TabIndex = 29;
            LabelMatrixRange.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 400);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 28;
            label4.Text = "Ранг матриці";
            // 
            // button2
            // 
            button2.Location = new Point(9, 336);
            button2.Name = "button2";
            button2.Size = new Size(219, 47);
            button2.TabIndex = 27;
            button2.Text = "Пошук ранга матриці";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(234, 336);
            button1.Name = "button1";
            button1.Size = new Size(219, 47);
            button1.TabIndex = 26;
            button1.Text = "Знайти обернену матрицю";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 4);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 25;
            label2.Text = "Матриця В";
            // 
            // InputMatrixB
            // 
            InputMatrixB.Location = new Point(281, 36);
            InputMatrixB.Multiline = true;
            InputMatrixB.Name = "InputMatrixB";
            InputMatrixB.ScrollBars = ScrollBars.Both;
            InputMatrixB.Size = new Size(132, 241);
            InputMatrixB.TabIndex = 24;
            InputMatrixB.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 4);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 23;
            label1.Text = "Матриця А";
            // 
            // InputMatrixA
            // 
            InputMatrixA.Location = new Point(9, 36);
            InputMatrixA.Multiline = true;
            InputMatrixA.Name = "InputMatrixA";
            InputMatrixA.ScrollBars = ScrollBars.Both;
            InputMatrixA.Size = new Size(254, 241);
            InputMatrixA.TabIndex = 22;
            InputMatrixA.WordWrap = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(CountVal);
            tabPage2.Controls.Add(ReportTextBox);
            tabPage2.Controls.Add(radioButton2);
            tabPage2.Controls.Add(radioButton1);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1352, 645);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(413, 185);
            button5.Name = "button5";
            button5.Size = new Size(156, 56);
            button5.TabIndex = 44;
            button5.Text = "Знайти розв'язок";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(413, 306);
            textBox5.Name = "textBox5";
            textBox5.ScrollBars = ScrollBars.Both;
            textBox5.ShortcutsEnabled = false;
            textBox5.Size = new Size(325, 27);
            textBox5.TabIndex = 43;
            textBox5.WordWrap = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(375, 309);
            label13.Name = "label13";
            label13.Size = new Size(32, 20);
            label13.TabIndex = 42;
            label13.Text = "X =";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(413, 262);
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Both;
            textBox4.ShortcutsEnabled = false;
            textBox4.Size = new Size(325, 27);
            textBox4.TabIndex = 41;
            textBox4.WordWrap = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(375, 265);
            label12.Name = "label12";
            label12.Size = new Size(32, 20);
            label12.TabIndex = 40;
            label12.Text = "Z =";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(377, 86);
            label11.Name = "label11";
            label11.Size = new Size(130, 20);
            label11.TabIndex = 39;
            label11.Text = "Кількість змінних";
            // 
            // CountVal
            // 
            CountVal.Location = new Point(513, 86);
            CountVal.Name = "CountVal";
            CountVal.Size = new Size(61, 27);
            CountVal.TabIndex = 38;
            CountVal.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // ReportTextBox
            // 
            ReportTextBox.Location = new Point(744, 15);
            ReportTextBox.Multiline = true;
            ReportTextBox.Name = "ReportTextBox";
            ReportTextBox.ScrollBars = ScrollBars.Both;
            ReportTextBox.Size = new Size(587, 540);
            ReportTextBox.TabIndex = 15;
            ReportTextBox.WordWrap = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(463, 15);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 24);
            radioButton2.TabIndex = 14;
            radioButton2.Text = "min";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(399, 15);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "max";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(9, 83);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Both;
            textBox3.Size = new Size(325, 250);
            textBox3.TabIndex = 12;
            textBox3.Text = "x1+x2-x3-2x4<=6\r\nx1+x2+x3-x4>=5\r\n2x1-x2+3x3+4x4<=10";
            textBox3.WordWrap = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 50);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 11;
            label9.Text = "Обмеження";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 13);
            label10.Name = "label10";
            label10.Size = new Size(32, 20);
            label10.TabIndex = 10;
            label10.Text = "Z =";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(47, 12);
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(325, 27);
            textBox2.TabIndex = 9;
            textBox2.Text = "x1+2x2-x3-x4";
            textBox2.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 719);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputNumGenMatrix2).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputNumGenMatrix1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CountVal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label8;
        private TextBox textBoxReport;
        private Button button4;
        private NumericUpDown InputNumGenMatrix2;
        private NumericUpDown InputNumGenMatrix1;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox TextBoxResultatMatrixA;
        private TextBox TextBoxResultatMatrix;
        private Button button3;
        private Label LabelMatrixRange;
        private Label label4;
        private Button button2;
        private Button button1;
        private Label label2;
        private TextBox InputMatrixB;
        private Label label1;
        private TextBox InputMatrixA;
        private TabPage tabPage2;
        private TextBox ReportTextBox;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox3;
        private Label label9;
        private Label label10;
        private TextBox textBox2;
        private Label label11;
        private NumericUpDown CountVal;
        private TextBox textBox5;
        private Label label13;
        private TextBox textBox4;
        private Label label12;
        private Button button5;
    }
}
