namespace Calculator
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
            mainLine = new Label();
            secondLine = new Label();
            cButton = new Button();
            zeroButton = new Button();
            divButton = new Button();
            solveButton = new Button();
            sumButton = new Button();
            threeButton = new Button();
            twoButton = new Button();
            oneButton = new Button();
            subButton = new Button();
            sixButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            multButton = new Button();
            nineButton = new Button();
            eightButton = new Button();
            sevenButton = new Button();
            SuspendLayout();
            // 
            // mainLine
            // 
            mainLine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mainLine.AutoSize = true;
            mainLine.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainLine.ImageAlign = ContentAlignment.MiddleRight;
            mainLine.Location = new Point(289, 65);
            mainLine.Name = "mainLine";
            mainLine.Size = new Size(70, 81);
            mainLine.TabIndex = 0;
            mainLine.Text = "0";
            mainLine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // secondLine
            // 
            secondLine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            secondLine.AutoSize = true;
            secondLine.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            secondLine.Location = new Point(292, 59);
            secondLine.Name = "secondLine";
            secondLine.Size = new Size(46, 20);
            secondLine.TabIndex = 1;
            secondLine.Text = "3+4=";
            secondLine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cButton
            // 
            cButton.BackColor = SystemColors.ControlDarkDark;
            cButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cButton.ForeColor = SystemColors.ButtonHighlight;
            cButton.Location = new Point(13, 474);
            cButton.Name = "cButton";
            cButton.Size = new Size(80, 80);
            cButton.TabIndex = 2;
            cButton.Text = "C";
            cButton.UseVisualStyleBackColor = false;
            cButton.Click += cButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.BackColor = SystemColors.ControlDarkDark;
            zeroButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zeroButton.ForeColor = SystemColors.ButtonHighlight;
            zeroButton.Location = new Point(99, 474);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(80, 80);
            zeroButton.TabIndex = 3;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += zeroButton_Click;
            // 
            // divButton
            // 
            divButton.BackColor = Color.Maroon;
            divButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            divButton.ForeColor = SystemColors.ButtonHighlight;
            divButton.Location = new Point(185, 474);
            divButton.Name = "divButton";
            divButton.Size = new Size(80, 80);
            divButton.TabIndex = 4;
            divButton.Text = "÷";
            divButton.UseVisualStyleBackColor = false;
            divButton.Click += divButton_Click;
            // 
            // solveButton
            // 
            solveButton.BackColor = Color.Maroon;
            solveButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            solveButton.ForeColor = SystemColors.ButtonHighlight;
            solveButton.Location = new Point(271, 474);
            solveButton.Name = "solveButton";
            solveButton.Size = new Size(80, 80);
            solveButton.TabIndex = 5;
            solveButton.Text = "=";
            solveButton.UseVisualStyleBackColor = false;
            solveButton.Click += solveButton_Click;
            // 
            // sumButton
            // 
            sumButton.BackColor = Color.Maroon;
            sumButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sumButton.ForeColor = SystemColors.ButtonHighlight;
            sumButton.Location = new Point(271, 373);
            sumButton.Name = "sumButton";
            sumButton.Size = new Size(80, 80);
            sumButton.TabIndex = 9;
            sumButton.Text = "+";
            sumButton.UseVisualStyleBackColor = false;
            sumButton.Click += sumButton_Click;
            // 
            // threeButton
            // 
            threeButton.BackColor = SystemColors.ControlDarkDark;
            threeButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            threeButton.ForeColor = SystemColors.ButtonHighlight;
            threeButton.Location = new Point(185, 373);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(80, 80);
            threeButton.TabIndex = 8;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = false;
            threeButton.Click += threeButton_Click;
            // 
            // twoButton
            // 
            twoButton.BackColor = SystemColors.ControlDarkDark;
            twoButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            twoButton.ForeColor = SystemColors.ButtonHighlight;
            twoButton.Location = new Point(99, 373);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(80, 80);
            twoButton.TabIndex = 7;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = false;
            twoButton.Click += twoButton_Click;
            // 
            // oneButton
            // 
            oneButton.BackColor = SystemColors.ControlDarkDark;
            oneButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oneButton.ForeColor = SystemColors.ButtonHighlight;
            oneButton.Location = new Point(13, 373);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(80, 80);
            oneButton.TabIndex = 6;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = false;
            oneButton.Click += oneButton_Click;
            // 
            // subButton
            // 
            subButton.BackColor = Color.Maroon;
            subButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subButton.ForeColor = SystemColors.ButtonHighlight;
            subButton.Location = new Point(271, 272);
            subButton.Name = "subButton";
            subButton.Size = new Size(80, 80);
            subButton.TabIndex = 13;
            subButton.Text = "-";
            subButton.UseVisualStyleBackColor = false;
            subButton.Click += subButton_Click;
            // 
            // sixButton
            // 
            sixButton.BackColor = SystemColors.ControlDarkDark;
            sixButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sixButton.ForeColor = SystemColors.ButtonHighlight;
            sixButton.Location = new Point(185, 272);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(80, 80);
            sixButton.TabIndex = 12;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = false;
            sixButton.Click += sixButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.BackColor = SystemColors.ControlDarkDark;
            fiveButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fiveButton.ForeColor = SystemColors.ButtonHighlight;
            fiveButton.Location = new Point(99, 272);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(80, 80);
            fiveButton.TabIndex = 11;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = false;
            fiveButton.Click += fiveButton_Click;
            // 
            // fourButton
            // 
            fourButton.BackColor = SystemColors.ControlDarkDark;
            fourButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fourButton.ForeColor = SystemColors.ButtonHighlight;
            fourButton.Location = new Point(13, 272);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(80, 80);
            fourButton.TabIndex = 10;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = false;
            fourButton.Click += fourButton_Click;
            // 
            // multButton
            // 
            multButton.BackColor = Color.Maroon;
            multButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multButton.ForeColor = SystemColors.ButtonHighlight;
            multButton.Location = new Point(271, 175);
            multButton.Name = "multButton";
            multButton.Size = new Size(80, 80);
            multButton.TabIndex = 17;
            multButton.Text = "x";
            multButton.UseVisualStyleBackColor = false;
            multButton.Click += multButton_Click;
            // 
            // nineButton
            // 
            nineButton.BackColor = SystemColors.ControlDarkDark;
            nineButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nineButton.ForeColor = SystemColors.ButtonHighlight;
            nineButton.Location = new Point(185, 175);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(80, 80);
            nineButton.TabIndex = 16;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = false;
            nineButton.Click += nineButton_Click;
            // 
            // eightButton
            // 
            eightButton.BackColor = SystemColors.ControlDarkDark;
            eightButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eightButton.ForeColor = SystemColors.ButtonHighlight;
            eightButton.Location = new Point(99, 175);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(80, 80);
            eightButton.TabIndex = 15;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = false;
            eightButton.Click += eightButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.BackColor = SystemColors.ControlDarkDark;
            sevenButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sevenButton.ForeColor = SystemColors.ButtonHighlight;
            sevenButton.Location = new Point(13, 175);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(80, 80);
            sevenButton.TabIndex = 14;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = false;
            sevenButton.Click += sevenButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 585);
            Controls.Add(multButton);
            Controls.Add(nineButton);
            Controls.Add(eightButton);
            Controls.Add(sevenButton);
            Controls.Add(subButton);
            Controls.Add(sixButton);
            Controls.Add(fiveButton);
            Controls.Add(fourButton);
            Controls.Add(sumButton);
            Controls.Add(threeButton);
            Controls.Add(twoButton);
            Controls.Add(oneButton);
            Controls.Add(solveButton);
            Controls.Add(divButton);
            Controls.Add(zeroButton);
            Controls.Add(cButton);
            Controls.Add(secondLine);
            Controls.Add(mainLine);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainLine;
        private Label secondLine;
        private Button cButton;
        private Button zeroButton;
        private Button divButton;
        private Button solveButton;
        private Button sumButton;
        private Button threeButton;
        private Button twoButton;
        private Button oneButton;
        private Button subButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button multButton;
        private Button nineButton;
        private Button eightButton;
        private Button sevenButton;
    }
}
