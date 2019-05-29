namespace _4_5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTay = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbUp = new System.Windows.Forms.TextBox();
            this.tbDown = new System.Windows.Forms.TextBox();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btTest = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btfast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btStart.Location = new System.Drawing.Point(446, 599);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(95, 34);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btStop.Location = new System.Drawing.Point(570, 599);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(95, 34);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Стоп";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(68, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 550);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbA
            // 
            this.tbA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbA.Location = new System.Drawing.Point(810, 248);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 4;
            this.tbA.Text = "0,5";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(777, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Шаг по времени";
            // 
            // tbTay
            // 
            this.tbTay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbTay.Location = new System.Drawing.Point(810, 287);
            this.tbTay.Name = "tbTay";
            this.tbTay.Size = new System.Drawing.Size(100, 20);
            this.tbTay.TabIndex = 6;
            this.tbTay.Text = "0,01";
            // 
            // lbSize
            // 
            this.lbSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(758, 329);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(46, 13);
            this.lbSize.TabIndex = 9;
            this.lbSize.Text = "Размер";
            // 
            // tbSize
            // 
            this.tbSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbSize.Location = new System.Drawing.Point(810, 326);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(100, 20);
            this.tbSize.TabIndex = 8;
            this.tbSize.Text = "5";
            // 
            // tbUp
            // 
            this.tbUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbUp.Location = new System.Drawing.Point(298, 9);
            this.tbUp.MaximumSize = new System.Drawing.Size(50, 20);
            this.tbUp.MinimumSize = new System.Drawing.Size(50, 20);
            this.tbUp.Name = "tbUp";
            this.tbUp.Size = new System.Drawing.Size(50, 20);
            this.tbUp.TabIndex = 11;
            this.tbUp.Text = "75";
            // 
            // tbDown
            // 
            this.tbDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbDown.Location = new System.Drawing.Point(298, 594);
            this.tbDown.MaximumSize = new System.Drawing.Size(50, 20);
            this.tbDown.MinimumSize = new System.Drawing.Size(50, 20);
            this.tbDown.Name = "tbDown";
            this.tbDown.Size = new System.Drawing.Size(50, 20);
            this.tbDown.TabIndex = 13;
            this.tbDown.Text = "40";
            // 
            // tbRight
            // 
            this.tbRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbRight.Location = new System.Drawing.Point(624, 287);
            this.tbRight.MaximumSize = new System.Drawing.Size(50, 20);
            this.tbRight.MinimumSize = new System.Drawing.Size(50, 20);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(50, 20);
            this.tbRight.TabIndex = 15;
            this.tbRight.Text = "300";
            // 
            // tbLeft
            // 
            this.tbLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbLeft.Location = new System.Drawing.Point(12, 287);
            this.tbLeft.MaximumSize = new System.Drawing.Size(50, 20);
            this.tbLeft.MinimumSize = new System.Drawing.Size(50, 20);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(50, 20);
            this.tbLeft.TabIndex = 16;
            this.tbLeft.Text = "-150";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Кол-во разбиений";
            // 
            // nudN
            // 
            this.nudN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudN.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudN.Location = new System.Drawing.Point(813, 364);
            this.nudN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(97, 20);
            this.nudN.TabIndex = 19;
            this.nudN.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Время расчёта";
            // 
            // tbTime
            // 
            this.tbTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbTime.Location = new System.Drawing.Point(810, 208);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 20);
            this.tbTime.TabIndex = 20;
            this.tbTime.Text = "3";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(780, 574);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(113, 59);
            this.btTest.TabIndex = 24;
            this.btTest.Text = "TEST";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(690, 35);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(204, 147);
            this.rtb.TabIndex = 26;
            this.rtb.Text = "";
            // 
            // btfast
            // 
            this.btfast.Location = new System.Drawing.Point(690, 465);
            this.btfast.Name = "btfast";
            this.btfast.Size = new System.Drawing.Size(220, 40);
            this.btfast.TabIndex = 27;
            this.btfast.Text = "Быстрый расчёт без прорисовки";
            this.btfast.UseVisualStyleBackColor = true;
            this.btfast.Click += new System.EventHandler(this.btfast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.btfast);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLeft);
            this.Controls.Add(this.tbRight);
            this.Controls.Add(this.tbDown);
            this.Controls.Add(this.tbUp);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.MaximumSize = new System.Drawing.Size(950, 700);
            this.MinimumSize = new System.Drawing.Size(950, 700);
            this.Name = "Form1";
            this.Text = "Решение ДУ численными методами";
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTay;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbUp;
        private System.Windows.Forms.TextBox tbDown;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btfast;
    }
}

