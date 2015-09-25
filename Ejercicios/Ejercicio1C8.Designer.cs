namespace Ejercicios
{
    partial class Ejercicio1C8
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
            this.CadenaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PalabraButton = new System.Windows.Forms.Button();
            this.ResultadoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena";
            // 
            // CadenaRichTextBox
            // 
            this.CadenaRichTextBox.Location = new System.Drawing.Point(109, 62);
            this.CadenaRichTextBox.Name = "CadenaRichTextBox";
            this.CadenaRichTextBox.Size = new System.Drawing.Size(115, 39);
            this.CadenaRichTextBox.TabIndex = 1;
            this.CadenaRichTextBox.Text = "";
            // 
            // PalabraButton
            // 
            this.PalabraButton.Location = new System.Drawing.Point(126, 107);
            this.PalabraButton.Name = "PalabraButton";
            this.PalabraButton.Size = new System.Drawing.Size(75, 23);
            this.PalabraButton.TabIndex = 2;
            this.PalabraButton.Text = "Palabra";
            this.PalabraButton.UseVisualStyleBackColor = true;
            this.PalabraButton.Click += new System.EventHandler(this.PalabraButton_Click);
            // 
            // ResultadoRichTextBox
            // 
            this.ResultadoRichTextBox.Location = new System.Drawing.Point(101, 162);
            this.ResultadoRichTextBox.Name = "ResultadoRichTextBox";
            this.ResultadoRichTextBox.ReadOnly = true;
            this.ResultadoRichTextBox.Size = new System.Drawing.Size(111, 87);
            this.ResultadoRichTextBox.TabIndex = 3;
            this.ResultadoRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Palabras que hay en la cadena";
            // 
            // Ejercicio1C8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultadoRichTextBox);
            this.Controls.Add(this.PalabraButton);
            this.Controls.Add(this.CadenaRichTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio1C8";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox CadenaRichTextBox;
        private System.Windows.Forms.Button PalabraButton;
        private System.Windows.Forms.RichTextBox ResultadoRichTextBox;
        private System.Windows.Forms.Label label2;
    }
}