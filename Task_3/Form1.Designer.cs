namespace Task_3
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
            label1 = new Label();
            txtTemperatura = new NumericUpDown();
            btnConverter = new Button();
            lblResultF = new Label();
            lblResultK = new Label();
            ((System.ComponentModel.ISupportInitialize)txtTemperatura).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(390, 27);
            label1.TabIndex = 0;
            label1.Text = "Digite uma temperatura em Celcius";
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(416, 15);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(120, 23);
            txtTemperatura.TabIndex = 1;
            // 
            // btnConverter
            // 
            btnConverter.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConverter.Location = new Point(570, 9);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(298, 37);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "Converter Temperatura";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblResultF
            // 
            lblResultF.AutoSize = true;
            lblResultF.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultF.Location = new Point(14, 64);
            lblResultF.Name = "lblResultF";
            lblResultF.Size = new Size(0, 27);
            lblResultF.TabIndex = 3;
            // 
            // lblResultK
            // 
            lblResultK.AutoSize = true;
            lblResultK.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultK.Location = new Point(386, 64);
            lblResultK.Name = "lblResultK";
            lblResultK.Size = new Size(0, 27);
            lblResultK.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 107);
            Controls.Add(lblResultK);
            Controls.Add(lblResultF);
            Controls.Add(btnConverter);
            Controls.Add(txtTemperatura);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Task_3";
            ((System.ComponentModel.ISupportInitialize)txtTemperatura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown txtTemperatura;
        private Button btnConverter;
        private Label lblResultF;
        private Label lblResultK;
    }
}
