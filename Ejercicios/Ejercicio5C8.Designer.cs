namespace Ejercicios
{
    partial class Ejercicio5C8
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
            this.Cadena1TextBox = new System.Windows.Forms.TextBox();
            this.Cadena2TextBox = new System.Windows.Forms.TextBox();
            this.OrdenarButton = new System.Windows.Forms.Button();
            this.MostrarRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadena 2";
            // 
            // Cadena1TextBox
            // 
            this.Cadena1TextBox.Location = new System.Drawing.Point(109, 57);
            this.Cadena1TextBox.Name = "Cadena1TextBox";
            this.Cadena1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Cadena1TextBox.TabIndex = 2;
            // 
            // Cadena2TextBox
            // 
            this.Cadena2TextBox.Location = new System.Drawing.Point(109, 95);
            this.Cadena2TextBox.Name = "Cadena2TextBox";
            this.Cadena2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Cadena2TextBox.TabIndex = 2;
            // 
            // OrdenarButton
            // 
            this.OrdenarButton.Location = new System.Drawing.Point(119, 135);
            this.OrdenarButton.Name = "OrdenarButton";
            this.OrdenarButton.Size = new System.Drawing.Size(75, 23);
            this.OrdenarButton.TabIndex = 3;
            this.OrdenarButton.Text = "Ordenar";
            this.OrdenarButton.UseVisualStyleBackColor = true;
            this.OrdenarButton.Click += new System.EventHandler(this.OrdenarButton_Click);
            // 
            // MostrarRichTextBox
            // 
            this.MostrarRichTextBox.Location = new System.Drawing.Point(15, 169);
            this.MostrarRichTextBox.Name = "MostrarRichTextBox";
            this.MostrarRichTextBox.ReadOnly = true;
            this.MostrarRichTextBox.Size = new System.Drawing.Size(257, 80);
            this.MostrarRichTextBox.TabIndex = 4;
            this.MostrarRichTextBox.Text = "";
            // 
            // Ejercicio5C8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MostrarRichTextBox);
            this.Controls.Add(this.OrdenarButton);
            this.Controls.Add(this.Cadena2TextBox);
            this.Controls.Add(this.Cadena1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio5C8";
            this.Text = "Ejercicio 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cadena1TextBox;
        private System.Windows.Forms.TextBox Cadena2TextBox;
        private System.Windows.Forms.Button OrdenarButton;
        private System.Windows.Forms.RichTextBox MostrarRichTextBox;
    }
}