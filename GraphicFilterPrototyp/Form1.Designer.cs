
namespace GraphicFilter
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputPictureBox = new System.Windows.Forms.PictureBox();
            this.outputPictureBox = new System.Windows.Forms.PictureBox();
            this.CppCounterLabel = new System.Windows.Forms.Label();
            this.AssemblerCounterLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnCPP = new System.Windows.Forms.RadioButton();
            this.radioBtnASM = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPictureBox
            // 
            this.inputPictureBox.BackColor = System.Drawing.Color.White;
            this.inputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPictureBox.Location = new System.Drawing.Point(13, 67);
            this.inputPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputPictureBox.Name = "inputPictureBox";
            this.inputPictureBox.Size = new System.Drawing.Size(558, 645);
            this.inputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputPictureBox.TabIndex = 2;
            this.inputPictureBox.TabStop = false;
            this.inputPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // outputPictureBox
            // 
            this.outputPictureBox.BackColor = System.Drawing.Color.White;
            this.outputPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPictureBox.Location = new System.Drawing.Point(795, 67);
            this.outputPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputPictureBox.Name = "outputPictureBox";
            this.outputPictureBox.Size = new System.Drawing.Size(558, 645);
            this.outputPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputPictureBox.TabIndex = 3;
            this.outputPictureBox.TabStop = false;
            // 
            // CppCounterLabel
            // 
            this.CppCounterLabel.AutoSize = true;
            this.CppCounterLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CppCounterLabel.Location = new System.Drawing.Point(92, 66);
            this.CppCounterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CppCounterLabel.Name = "CppCounterLabel";
            this.CppCounterLabel.Size = new System.Drawing.Size(15, 18);
            this.CppCounterLabel.TabIndex = 2;
            this.CppCounterLabel.Text = "-";
            // 
            // AssemblerCounterLabel
            // 
            this.AssemblerCounterLabel.AutoSize = true;
            this.AssemblerCounterLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AssemblerCounterLabel.Location = new System.Drawing.Point(92, 36);
            this.AssemblerCounterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AssemblerCounterLabel.Name = "AssemblerCounterLabel";
            this.AssemblerCounterLabel.Size = new System.Drawing.Size(15, 18);
            this.AssemblerCounterLabel.TabIndex = 3;
            this.AssemblerCounterLabel.Text = "-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 59);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(519, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cartoon Filter Image ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 720);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1366, 48);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(1153, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Authors: Bartosz Ryczek, Krystian Stasica";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(578, 566);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apply Cartoon Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.radioBtnCPP);
            this.panel1.Controls.Add(this.radioBtnASM);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.outputPictureBox);
            this.panel1.Controls.Add(this.inputPictureBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 0;
            // 
            // radioBtnCPP
            // 
            this.radioBtnCPP.AutoSize = true;
            this.radioBtnCPP.Checked = true;
            this.radioBtnCPP.Location = new System.Drawing.Point(730, 496);
            this.radioBtnCPP.Name = "radioBtnCPP";
            this.radioBtnCPP.Size = new System.Drawing.Size(54, 21);
            this.radioBtnCPP.TabIndex = 12;
            this.radioBtnCPP.TabStop = true;
            this.radioBtnCPP.Text = "C++";
            this.radioBtnCPP.UseVisualStyleBackColor = true;
            // 
            // radioBtnASM
            // 
            this.radioBtnASM.AutoSize = true;
            this.radioBtnASM.Location = new System.Drawing.Point(578, 496);
            this.radioBtnASM.Name = "radioBtnASM";
            this.radioBtnASM.Size = new System.Drawing.Size(58, 21);
            this.radioBtnASM.TabIndex = 11;
            this.radioBtnASM.Text = "ASM";
            this.radioBtnASM.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(800, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Preview:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(22, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Import:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.AssemblerCounterLabel);
            this.panel4.Controls.Add(this.CppCounterLabel);
            this.panel4.Location = new System.Drawing.Point(578, 612);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 100);
            this.panel4.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "ASM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "C++";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dencity of the filter(%):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(578, 540);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(208, 22);
            this.numericUpDown1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphicFilter";
            ((System.ComponentModel.ISupportInitialize)(this.inputPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox inputPictureBox;
        private System.Windows.Forms.PictureBox outputPictureBox;

        private System.Windows.Forms.Label CppCounterLabel;
        private System.Windows.Forms.Label AssemblerCounterLabel;


        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioBtnCPP;
        private System.Windows.Forms.RadioButton radioBtnASM;
    }
}

