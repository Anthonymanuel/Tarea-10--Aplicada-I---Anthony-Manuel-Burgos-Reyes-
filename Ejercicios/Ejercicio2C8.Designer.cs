namespace Ejercicios
{
    partial class Ejercicio2C8
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
            this.CadenaTextBox = new System.Windows.Forms.TextBox();
            this.DerechaRadioButton = new System.Windows.Forms.RadioButton();
            this.IzquierdaRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena";
            // 
            // CadenaTextBox
            // 
            this.CadenaTextBox.Location = new System.Drawing.Point(128, 70);
            this.CadenaTextBox.Name = "CadenaTextBox";
            this.CadenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.CadenaTextBox.TabIndex = 1;
            // 
            // DerechaRadioButton
            // 
            this.DerechaRadioButton.AutoSize = true;
            this.DerechaRadioButton.Location = new System.Drawing.Point(128, 137);
            this.DerechaRadioButton.Name = "DerechaRadioButton";
            this.DerechaRadioButton.Size = new System.Drawing.Size(66, 17);
            this.DerechaRadioButton.TabIndex = 2;
            this.DerechaRadioButton.TabStop = true;
            this.DerechaRadioButton.Text = "Derecha";
            this.DerechaRadioButton.UseVisualStyleBackColor = true;
            // 
            // IzquierdaRadioButton
            // 
            this.IzquierdaRadioButton.AutoSize = true;
            this.IzquierdaRadioButton.Location = new System.Drawing.Point(191, 137);
            this.IzquierdaRadioButton.Name = "IzquierdaRadioButton";
            this.IzquierdaRadioButton.Size = new System.Drawing.Size(68, 17);
            this.IzquierdaRadioButton.TabIndex = 3;
            this.IzquierdaRadioButton.TabStop = true;
            this.IzquierdaRadioButton.Text = "Izquierda";
            this.IzquierdaRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Justificacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. ";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(128, 106);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumeroTextBox.TabIndex = 6;
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(128, 183);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.ReadOnly = true;
            this.ResultadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultadoTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cadena justificada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Justificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio2C8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IzquierdaRadioButton);
            this.Controls.Add(this.DerechaRadioButton);
            this.Controls.Add(this.CadenaTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2C8";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CadenaTextBox;
        private System.Windows.Forms.RadioButton DerechaRadioButton;
        private System.Windows.Forms.RadioButton IzquierdaRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}