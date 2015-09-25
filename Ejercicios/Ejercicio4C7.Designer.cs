namespace Ejercicios
{
    partial class Ejercicio4C7
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
            this.GastosTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.GastosRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gastos";
            // 
            // GastosTextBox
            // 
            this.GastosTextBox.Location = new System.Drawing.Point(112, 45);
            this.GastosTextBox.Name = "GastosTextBox";
            this.GastosTextBox.Size = new System.Drawing.Size(100, 20);
            this.GastosTextBox.TabIndex = 1;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(124, 108);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 2;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // GastosRichTextBox
            // 
            this.GastosRichTextBox.Location = new System.Drawing.Point(12, 153);
            this.GastosRichTextBox.Name = "GastosRichTextBox";
            this.GastosRichTextBox.ReadOnly = true;
            this.GastosRichTextBox.Size = new System.Drawing.Size(302, 75);
            this.GastosRichTextBox.TabIndex = 3;
            this.GastosRichTextBox.Text = "";
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(124, 234);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(75, 23);
            this.MostrarButton.TabIndex = 4;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gastos mensual en orden cronologico decendente";
            // 
            // Ejercicio4C7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.GastosRichTextBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.GastosTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio4C7";
            this.Text = "Ejercicio 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GastosTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.RichTextBox GastosRichTextBox;
        private System.Windows.Forms.Button MostrarButton;
        private System.Windows.Forms.Label label2;
    }
}