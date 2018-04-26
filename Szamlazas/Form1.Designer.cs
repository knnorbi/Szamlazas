namespace Szamlazas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.partnerTextBox = new System.Windows.Forms.TextBox();
            this.osszegNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.felvetenButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tartozasPartnerTextBox = new System.Windows.Forms.TextBox();
            this.tartozasKeresButton = new System.Windows.Forms.Button();
            this.mostWantedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.osszegNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Partner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Összeg:";
            // 
            // partnerTextBox
            // 
            this.partnerTextBox.Location = new System.Drawing.Point(65, 19);
            this.partnerTextBox.Name = "partnerTextBox";
            this.partnerTextBox.Size = new System.Drawing.Size(144, 20);
            this.partnerTextBox.TabIndex = 2;
            // 
            // osszegNumericUpDown
            // 
            this.osszegNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.osszegNumericUpDown.Location = new System.Drawing.Point(65, 46);
            this.osszegNumericUpDown.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.osszegNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.osszegNumericUpDown.Name = "osszegNumericUpDown";
            this.osszegNumericUpDown.Size = new System.Drawing.Size(144, 20);
            this.osszegNumericUpDown.TabIndex = 3;
            this.osszegNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // felvetenButton
            // 
            this.felvetenButton.Location = new System.Drawing.Point(16, 72);
            this.felvetenButton.Name = "felvetenButton";
            this.felvetenButton.Size = new System.Drawing.Size(75, 23);
            this.felvetenButton.TabIndex = 4;
            this.felvetenButton.Text = "Felvétel";
            this.felvetenButton.UseVisualStyleBackColor = true;
            this.felvetenButton.Click += new System.EventHandler(this.felvetenButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.osszegNumericUpDown);
            this.groupBox1.Controls.Add(this.felvetenButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.partnerTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Felvétel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tartozasKeresButton);
            this.groupBox2.Controls.Add(this.tartozasPartnerTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 76);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Partner tartozása";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Partner:";
            // 
            // tartozasPartnerTextBox
            // 
            this.tartozasPartnerTextBox.Location = new System.Drawing.Point(56, 20);
            this.tartozasPartnerTextBox.Name = "tartozasPartnerTextBox";
            this.tartozasPartnerTextBox.Size = new System.Drawing.Size(153, 20);
            this.tartozasPartnerTextBox.TabIndex = 1;
            // 
            // tartozasKeresButton
            // 
            this.tartozasKeresButton.Location = new System.Drawing.Point(9, 46);
            this.tartozasKeresButton.Name = "tartozasKeresButton";
            this.tartozasKeresButton.Size = new System.Drawing.Size(75, 23);
            this.tartozasKeresButton.TabIndex = 2;
            this.tartozasKeresButton.Text = "Keresés";
            this.tartozasKeresButton.UseVisualStyleBackColor = true;
            this.tartozasKeresButton.Click += new System.EventHandler(this.tartozasKeresButton_Click);
            // 
            // mostWantedButton
            // 
            this.mostWantedButton.Location = new System.Drawing.Point(12, 208);
            this.mostWantedButton.Name = "mostWantedButton";
            this.mostWantedButton.Size = new System.Drawing.Size(84, 23);
            this.mostWantedButton.TabIndex = 7;
            this.mostWantedButton.Text = "MostWanted";
            this.mostWantedButton.UseVisualStyleBackColor = true;
            this.mostWantedButton.Click += new System.EventHandler(this.mostWantedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.mostWantedButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.osszegNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partnerTextBox;
        private System.Windows.Forms.NumericUpDown osszegNumericUpDown;
        private System.Windows.Forms.Button felvetenButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button tartozasKeresButton;
        private System.Windows.Forms.TextBox tartozasPartnerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mostWantedButton;
    }
}

