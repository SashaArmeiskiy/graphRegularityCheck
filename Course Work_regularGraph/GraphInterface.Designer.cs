
namespace Course_Work_RegularGraph
{
    partial class GraphInterface
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.control1 = new System.Windows.Forms.GroupBox();
            this.FI_Presentation1 = new System.Windows.Forms.Button();
            this.RegularCheck1 = new System.Windows.Forms.Button();
            this.clear1Button = new System.Windows.Forms.Button();
            this.keyboardEnter1 = new System.Windows.Forms.Button();
            this.randGenerateGraph1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.control2 = new System.Windows.Forms.GroupBox();
            this.RegularCheck2 = new System.Windows.Forms.Button();
            this.FI_Presentation2 = new System.Windows.Forms.Button();
            this.clear2Button = new System.Windows.Forms.Button();
            this.keyboardEnter2 = new System.Windows.Forms.Button();
            this.randGenerateGraph2 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.input1 = new System.Windows.Forms.PictureBox();
            this.input2 = new System.Windows.Forms.PictureBox();
            this.input1Matrix = new System.Windows.Forms.DataGridView();
            this.input2Matrix = new System.Windows.Forms.DataGridView();
            this.generalOutput = new System.Windows.Forms.TextBox();
            this.aboutProgram = new System.Windows.Forms.Button();
            this.control1.SuspendLayout();
            this.control2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input1Matrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // control1
            // 
            this.control1.Controls.Add(this.FI_Presentation1);
            this.control1.Controls.Add(this.RegularCheck1);
            this.control1.Controls.Add(this.clear1Button);
            this.control1.Controls.Add(this.keyboardEnter1);
            this.control1.Controls.Add(this.randGenerateGraph1);
            this.control1.Controls.Add(this.radioButton2);
            this.control1.Controls.Add(this.radioButton1);
            this.control1.Location = new System.Drawing.Point(11, 11);
            this.control1.Margin = new System.Windows.Forms.Padding(2);
            this.control1.Name = "control1";
            this.control1.Padding = new System.Windows.Forms.Padding(2);
            this.control1.Size = new System.Drawing.Size(102, 331);
            this.control1.TabIndex = 0;
            this.control1.TabStop = false;
            this.control1.Text = "Контроль вводу";
            // 
            // FI_Presentation1
            // 
            this.FI_Presentation1.Location = new System.Drawing.Point(4, 223);
            this.FI_Presentation1.Margin = new System.Windows.Forms.Padding(2);
            this.FI_Presentation1.Name = "FI_Presentation1";
            this.FI_Presentation1.Size = new System.Drawing.Size(94, 42);
            this.FI_Presentation1.TabIndex = 9;
            this.FI_Presentation1.Text = "FI подання";
            this.FI_Presentation1.UseVisualStyleBackColor = true;
            this.FI_Presentation1.Click += new System.EventHandler(this.FI_Presentation_Click);
            // 
            // RegularCheck1
            // 
            this.RegularCheck1.Location = new System.Drawing.Point(5, 274);
            this.RegularCheck1.Name = "RegularCheck1";
            this.RegularCheck1.Size = new System.Drawing.Size(92, 51);
            this.RegularCheck1.TabIndex = 18;
            this.RegularCheck1.Text = "Перевірити граф на регулярність";
            this.RegularCheck1.UseVisualStyleBackColor = true;
            this.RegularCheck1.Click += new System.EventHandler(this.RegularCheck_Click);
            // 
            // clear1Button
            // 
            this.clear1Button.Location = new System.Drawing.Point(4, 171);
            this.clear1Button.Margin = new System.Windows.Forms.Padding(2);
            this.clear1Button.Name = "clear1Button";
            this.clear1Button.Size = new System.Drawing.Size(94, 42);
            this.clear1Button.TabIndex = 8;
            this.clear1Button.Text = "Видалити введений граф";
            this.clear1Button.UseVisualStyleBackColor = true;
            this.clear1Button.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // keyboardEnter1
            // 
            this.keyboardEnter1.Location = new System.Drawing.Point(5, 66);
            this.keyboardEnter1.Margin = new System.Windows.Forms.Padding(2);
            this.keyboardEnter1.Name = "keyboardEnter1";
            this.keyboardEnter1.Size = new System.Drawing.Size(94, 50);
            this.keyboardEnter1.TabIndex = 7;
            this.keyboardEnter1.Text = "Ввести координати точки";
            this.keyboardEnter1.UseVisualStyleBackColor = true;
            this.keyboardEnter1.Click += new System.EventHandler(this.keyboardEnter_Click);
            // 
            // randGenerateGraph1
            // 
            this.randGenerateGraph1.Location = new System.Drawing.Point(4, 122);
            this.randGenerateGraph1.Margin = new System.Windows.Forms.Padding(2);
            this.randGenerateGraph1.Name = "randGenerateGraph1";
            this.randGenerateGraph1.Size = new System.Drawing.Size(94, 42);
            this.randGenerateGraph1.TabIndex = 6;
            this.randGenerateGraph1.Text = "Випадкова генерація";
            this.randGenerateGraph1.UseVisualStyleBackColor = true;
            this.randGenerateGraph1.Click += new System.EventHandler(this.randGenerateGraph_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 42);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Видалення";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 20);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Додавання";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // control2
            // 
            this.control2.Controls.Add(this.RegularCheck2);
            this.control2.Controls.Add(this.FI_Presentation2);
            this.control2.Controls.Add(this.clear2Button);
            this.control2.Controls.Add(this.keyboardEnter2);
            this.control2.Controls.Add(this.randGenerateGraph2);
            this.control2.Controls.Add(this.radioButton3);
            this.control2.Controls.Add(this.radioButton4);
            this.control2.Location = new System.Drawing.Point(11, 434);
            this.control2.Margin = new System.Windows.Forms.Padding(2);
            this.control2.Name = "control2";
            this.control2.Padding = new System.Windows.Forms.Padding(2);
            this.control2.Size = new System.Drawing.Size(102, 334);
            this.control2.TabIndex = 1;
            this.control2.TabStop = false;
            this.control2.Text = "Контроль вводу";
            // 
            // RegularCheck2
            // 
            this.RegularCheck2.Location = new System.Drawing.Point(5, 270);
            this.RegularCheck2.Name = "RegularCheck2";
            this.RegularCheck2.Size = new System.Drawing.Size(92, 54);
            this.RegularCheck2.TabIndex = 19;
            this.RegularCheck2.Text = "Перевірити граф на регулярність";
            this.RegularCheck2.UseVisualStyleBackColor = true;
            this.RegularCheck2.Click += new System.EventHandler(this.RegularCheck_Click);
            // 
            // FI_Presentation2
            // 
            this.FI_Presentation2.Location = new System.Drawing.Point(4, 223);
            this.FI_Presentation2.Margin = new System.Windows.Forms.Padding(2);
            this.FI_Presentation2.Name = "FI_Presentation2";
            this.FI_Presentation2.Size = new System.Drawing.Size(94, 42);
            this.FI_Presentation2.TabIndex = 15;
            this.FI_Presentation2.Text = "FI подання";
            this.FI_Presentation2.UseVisualStyleBackColor = true;
            this.FI_Presentation2.Click += new System.EventHandler(this.FI_Presentation_Click);
            // 
            // clear2Button
            // 
            this.clear2Button.Location = new System.Drawing.Point(4, 171);
            this.clear2Button.Margin = new System.Windows.Forms.Padding(2);
            this.clear2Button.Name = "clear2Button";
            this.clear2Button.Size = new System.Drawing.Size(94, 42);
            this.clear2Button.TabIndex = 14;
            this.clear2Button.Text = "Видалити введений граф";
            this.clear2Button.UseVisualStyleBackColor = true;
            this.clear2Button.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // keyboardEnter2
            // 
            this.keyboardEnter2.Location = new System.Drawing.Point(5, 65);
            this.keyboardEnter2.Margin = new System.Windows.Forms.Padding(2);
            this.keyboardEnter2.Name = "keyboardEnter2";
            this.keyboardEnter2.Size = new System.Drawing.Size(94, 50);
            this.keyboardEnter2.TabIndex = 13;
            this.keyboardEnter2.Text = "Ввести координати точки";
            this.keyboardEnter2.UseVisualStyleBackColor = true;
            this.keyboardEnter2.Click += new System.EventHandler(this.keyboardEnter_Click);
            // 
            // randGenerateGraph2
            // 
            this.randGenerateGraph2.Location = new System.Drawing.Point(4, 121);
            this.randGenerateGraph2.Margin = new System.Windows.Forms.Padding(2);
            this.randGenerateGraph2.Name = "randGenerateGraph2";
            this.randGenerateGraph2.Size = new System.Drawing.Size(94, 42);
            this.randGenerateGraph2.TabIndex = 11;
            this.randGenerateGraph2.Text = "Випадкова генерація";
            this.randGenerateGraph2.UseVisualStyleBackColor = true;
            this.randGenerateGraph2.Click += new System.EventHandler(this.randGenerateGraph_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(5, 40);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.Text = "Видалення";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(5, 18);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(82, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Додавання";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // input1
            // 
            this.input1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input1.Location = new System.Drawing.Point(124, 18);
            this.input1.Margin = new System.Windows.Forms.Padding(2);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(280, 314);
            this.input1.TabIndex = 0;
            this.input1.TabStop = false;
            this.input1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.input_MouseDown);
            // 
            // input2
            // 
            this.input2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input2.Location = new System.Drawing.Point(124, 439);
            this.input2.Margin = new System.Windows.Forms.Padding(2);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(280, 314);
            this.input2.TabIndex = 2;
            this.input2.TabStop = false;
            this.input2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.input_MouseDown);
            // 
            // input1Matrix
            // 
            this.input1Matrix.AllowUserToAddRows = false;
            this.input1Matrix.AllowUserToDeleteRows = false;
            this.input1Matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.input1Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input1Matrix.Location = new System.Drawing.Point(407, 18);
            this.input1Matrix.Margin = new System.Windows.Forms.Padding(2);
            this.input1Matrix.Name = "input1Matrix";
            this.input1Matrix.RowHeadersWidth = 51;
            this.input1Matrix.RowTemplate.Height = 24;
            this.input1Matrix.Size = new System.Drawing.Size(348, 314);
            this.input1Matrix.TabIndex = 5;
            this.input1Matrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputMatrix_CellContentClick);
            this.input1Matrix.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputMatrix_CellContentClick);
            // 
            // input2Matrix
            // 
            this.input2Matrix.AllowUserToAddRows = false;
            this.input2Matrix.AllowUserToDeleteRows = false;
            this.input2Matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.input2Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input2Matrix.Location = new System.Drawing.Point(407, 439);
            this.input2Matrix.Margin = new System.Windows.Forms.Padding(2);
            this.input2Matrix.Name = "input2Matrix";
            this.input2Matrix.RowHeadersWidth = 51;
            this.input2Matrix.RowTemplate.Height = 24;
            this.input2Matrix.Size = new System.Drawing.Size(348, 314);
            this.input2Matrix.TabIndex = 6;
            this.input2Matrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputMatrix_CellContentClick);
            this.input2Matrix.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inputMatrix_CellContentClick);
            // 
            // generalOutput
            // 
            this.generalOutput.BackColor = System.Drawing.SystemColors.Control;
            this.generalOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalOutput.Location = new System.Drawing.Point(124, 345);
            this.generalOutput.Margin = new System.Windows.Forms.Padding(2);
            this.generalOutput.Multiline = true;
            this.generalOutput.Name = "generalOutput";
            this.generalOutput.ReadOnly = true;
            this.generalOutput.Size = new System.Drawing.Size(631, 84);
            this.generalOutput.TabIndex = 17;
            this.generalOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aboutProgram
            // 
            this.aboutProgram.Location = new System.Drawing.Point(349, 771);
            this.aboutProgram.Margin = new System.Windows.Forms.Padding(2);
            this.aboutProgram.Name = "aboutProgram";
            this.aboutProgram.Size = new System.Drawing.Size(120, 24);
            this.aboutProgram.TabIndex = 17;
            this.aboutProgram.Text = "Про програму";
            this.aboutProgram.UseVisualStyleBackColor = true;
            this.aboutProgram.Click += new System.EventHandler(this.aboutProgram_Click);
            // 
            // GraphInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 811);
            this.Controls.Add(this.aboutProgram);
            this.Controls.Add(this.generalOutput);
            this.Controls.Add(this.input2Matrix);
            this.Controls.Add(this.input1Matrix);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.control2);
            this.Controls.Add(this.control1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GraphInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Перевірка графа на регулярність";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);
            this.control1.ResumeLayout(false);
            this.control1.PerformLayout();
            this.control2.ResumeLayout(false);
            this.control2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input1Matrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2Matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox control1;
        private System.Windows.Forms.GroupBox control2;
        private System.Windows.Forms.PictureBox input1;
        private System.Windows.Forms.PictureBox input2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView input1Matrix;
        private System.Windows.Forms.Button keyboardEnter1;
        private System.Windows.Forms.Button randGenerateGraph1;
        private System.Windows.Forms.Button clear1Button;
        private System.Windows.Forms.Button FI_Presentation1;
        private System.Windows.Forms.Button FI_Presentation2;
        private System.Windows.Forms.Button clear2Button;
        private System.Windows.Forms.Button keyboardEnter2;
        private System.Windows.Forms.Button randGenerateGraph2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.DataGridView input2Matrix;
        private System.Windows.Forms.TextBox generalOutput;
        private System.Windows.Forms.Button aboutProgram;
        private System.Windows.Forms.Button RegularCheck1;
        private System.Windows.Forms.Button RegularCheck2;
    }
}

