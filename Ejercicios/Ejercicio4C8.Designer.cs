namespace Ejercicios
{
    partial class Ejercicio4C8
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
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.SumarButton = new System.Windows.Forms.Button();
            this.ResultadoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(110, 33);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumeroTextBox.TabIndex = 2;
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(110, 76);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Numero2TextBox.TabIndex = 3;
            // 
            // SumarButton
            // 
            this.SumarButton.Location = new System.Drawing.Point(120, 102);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(75, 23);
            this.SumarButton.TabIndex = 4;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // ResultadoRichTextBox
            // 
            this.ResultadoRichTextBox.Location = new System.Drawing.Point(12, 153);
            this.ResultadoRichTextBox.Name = "ResultadoRichTextBox";
            this.ResultadoRichTextBox.ReadOnly = true;
            this.ResultadoRichTextBox.Size = new System.Drawing.Size(260, 96);
            this.ResultadoRichTextBox.TabIndex = 5;
            this.ResultadoRichTextBox.Text = "";
            // 
            // Ejercicio4C8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ResultadoRichTextBox);
            this.Controls.Add(this.SumarButton);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio4C8";
            this.Text = "Ejercicio 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.TextBox Numero2TextBox;
        private System.Windows.Forms.Button SumarButton;
        private System.Windows.Forms.RichTextBox ResultadoRichTextBox;
    }
}