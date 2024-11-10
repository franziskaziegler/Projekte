namespace Projekt_Taschenrechner
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
            Zahl7 = new Button();
            Zahl8 = new Button();
            Zahl1 = new Button();
            Zahl4 = new Button();
            Zahl6 = new Button();
            Zahl9 = new Button();
            Zahl2 = new Button();
            Zahl5 = new Button();
            Zahl3 = new Button();
            Zahl0 = new Button();
            Multiplizieren = new Button();
            Minus = new Button();
            Plus = new Button();
            Input = new TextBox();
            IstGleich = new Button();
            komma = new Button();
            Clear = new Button();
            SuspendLayout();
            // 
            // Zahl7
            // 
            Zahl7.Location = new Point(12, 161);
            Zahl7.Name = "Zahl7";
            Zahl7.Size = new Size(62, 47);
            Zahl7.TabIndex = 0;
            Zahl7.Text = "7";
            Zahl7.UseVisualStyleBackColor = true;
            Zahl7.Click += Zahl7_Click;
            // 
            // Zahl8
            // 
            Zahl8.Location = new Point(80, 161);
            Zahl8.Name = "Zahl8";
            Zahl8.Size = new Size(62, 47);
            Zahl8.TabIndex = 1;
            Zahl8.Text = "8";
            Zahl8.UseVisualStyleBackColor = true;
            Zahl8.Click += Zahl8_Click;
            // 
            // Zahl1
            // 
            Zahl1.Location = new Point(12, 267);
            Zahl1.Name = "Zahl1";
            Zahl1.Size = new Size(62, 47);
            Zahl1.TabIndex = 2;
            Zahl1.Text = "1";
            Zahl1.UseVisualStyleBackColor = true;
            Zahl1.Click += Zahl1_Click;
            // 
            // Zahl4
            // 
            Zahl4.Location = new Point(12, 214);
            Zahl4.Name = "Zahl4";
            Zahl4.Size = new Size(62, 47);
            Zahl4.TabIndex = 3;
            Zahl4.Text = "4";
            Zahl4.UseVisualStyleBackColor = true;
            Zahl4.Click += Zahl4_Click;
            // 
            // Zahl6
            // 
            Zahl6.Location = new Point(148, 214);
            Zahl6.Name = "Zahl6";
            Zahl6.Size = new Size(62, 47);
            Zahl6.TabIndex = 4;
            Zahl6.Text = "6";
            Zahl6.UseVisualStyleBackColor = true;
            Zahl6.Click += Zahl6_Click;
            // 
            // Zahl9
            // 
            Zahl9.Location = new Point(148, 161);
            Zahl9.Name = "Zahl9";
            Zahl9.Size = new Size(62, 47);
            Zahl9.TabIndex = 5;
            Zahl9.Text = "9";
            Zahl9.UseVisualStyleBackColor = true;
            Zahl9.Click += Zahl9_Click;
            // 
            // Zahl2
            // 
            Zahl2.Location = new Point(80, 267);
            Zahl2.Name = "Zahl2";
            Zahl2.Size = new Size(62, 47);
            Zahl2.TabIndex = 6;
            Zahl2.Text = "2";
            Zahl2.UseVisualStyleBackColor = true;
            Zahl2.Click += Zahl2_Click;
            // 
            // Zahl5
            // 
            Zahl5.BackColor = SystemColors.ControlLight;
            Zahl5.ForeColor = SystemColors.ControlText;
            Zahl5.Location = new Point(80, 214);
            Zahl5.Name = "Zahl5";
            Zahl5.Size = new Size(62, 47);
            Zahl5.TabIndex = 7;
            Zahl5.Text = "5";
            Zahl5.UseVisualStyleBackColor = false;
            Zahl5.Click += Zahl5_Click;
            // 
            // Zahl3
            // 
            Zahl3.Location = new Point(148, 267);
            Zahl3.Name = "Zahl3";
            Zahl3.Size = new Size(62, 47);
            Zahl3.TabIndex = 8;
            Zahl3.Text = "3";
            Zahl3.UseVisualStyleBackColor = true;
            Zahl3.Click += Zahl3_Click;
            // 
            // Zahl0
            // 
            Zahl0.Location = new Point(80, 320);
            Zahl0.Name = "Zahl0";
            Zahl0.Size = new Size(62, 47);
            Zahl0.TabIndex = 9;
            Zahl0.Text = "0";
            Zahl0.UseVisualStyleBackColor = true;
            Zahl0.Click += Zahl0_Click;
            // 
            // Multiplizieren
            // 
            Multiplizieren.Location = new Point(216, 161);
            Multiplizieren.Name = "Multiplizieren";
            Multiplizieren.Size = new Size(62, 47);
            Multiplizieren.TabIndex = 10;
            Multiplizieren.Text = "*";
            Multiplizieren.UseVisualStyleBackColor = true;
            Multiplizieren.Click += Multiplizieren_Click;
            // 
            // Minus
            // 
            Minus.Location = new Point(216, 214);
            Minus.Name = "Minus";
            Minus.Size = new Size(62, 47);
            Minus.TabIndex = 11;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Minus_Click;
            // 
            // Plus
            // 
            Plus.Location = new Point(216, 267);
            Plus.Name = "Plus";
            Plus.Size = new Size(62, 47);
            Plus.TabIndex = 12;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Plus_Click;
            // 
            // Input
            // 
            Input.BackColor = SystemColors.ControlLightLight;
            Input.Location = new Point(10, 12);
            Input.Multiline = true;
            Input.Name = "Input";
            Input.ReadOnly = true;
            Input.Size = new Size(266, 143);
            Input.TabIndex = 13;
            // 
            // IstGleich
            // 
            IstGleich.BackColor = SystemColors.GradientActiveCaption;
            IstGleich.Location = new Point(214, 320);
            IstGleich.Name = "IstGleich";
            IstGleich.Size = new Size(62, 47);
            IstGleich.TabIndex = 14;
            IstGleich.Text = "=";
            IstGleich.UseVisualStyleBackColor = false;
            IstGleich.Click += IstGleich_Click;
            // 
            // komma
            // 
            komma.Location = new Point(148, 320);
            komma.Name = "komma";
            komma.Size = new Size(62, 47);
            komma.TabIndex = 15;
            komma.Text = ",";
            komma.UseVisualStyleBackColor = true;
            komma.Click += komma_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(12, 320);
            Clear.Name = "Clear";
            Clear.Size = new Size(62, 47);
            Clear.TabIndex = 16;
            Clear.Text = "DEL";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 388);
            Controls.Add(Clear);
            Controls.Add(komma);
            Controls.Add(IstGleich);
            Controls.Add(Input);
            Controls.Add(Plus);
            Controls.Add(Minus);
            Controls.Add(Multiplizieren);
            Controls.Add(Zahl0);
            Controls.Add(Zahl3);
            Controls.Add(Zahl5);
            Controls.Add(Zahl2);
            Controls.Add(Zahl9);
            Controls.Add(Zahl6);
            Controls.Add(Zahl4);
            Controls.Add(Zahl1);
            Controls.Add(Zahl8);
            Controls.Add(Zahl7);
            Name = "Form1";
            Text = "Taschenrechner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Zahl7;
        private Button Zahl8;
        private Button Zahl1;
        private Button Zahl4;
        private Button Zahl6;
        private Button Zahl9;
        private Button Zahl2;
        private Button Zahl5;
        private Button Zahl3;
        private Button Zahl0;
        private Button Multiplizieren;
        private Button Minus;
        private Button Plus;
        private TextBox Input;
        private Button IstGleich;
        private Button komma;
        private Button Clear;
    }
}
