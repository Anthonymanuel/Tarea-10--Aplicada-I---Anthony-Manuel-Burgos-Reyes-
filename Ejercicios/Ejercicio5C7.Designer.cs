namespace Ejercicios
{
    partial class Ejercicio5C7
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
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.guardarButton = new System.Windows.Forms.Button();
            this.AgendaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.mostrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(149, 30);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. Telefonico";
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(149, 56);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.TelefonoTextBox.TabIndex = 2;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(149, 92);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 23);
            this.guardarButton.TabIndex = 2;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // AgendaRichTextBox
            // 
            this.AgendaRichTextBox.Location = new System.Drawing.Point(12, 132);
            this.AgendaRichTextBox.Name = "AgendaRichTextBox";
            this.AgendaRichTextBox.ReadOnly = true;
            this.AgendaRichTextBox.Size = new System.Drawing.Size(329, 86);
            this.AgendaRichTextBox.TabIndex = 3;
            this.AgendaRichTextBox.Text = "";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 116);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Contacto";
            // 
            // mostrarButton
            // 
            this.mostrarButton.Location = new System.Drawing.Point(149, 226);
            this.mostrarButton.Name = "mostrarButton";
            this.mostrarButton.Size = new System.Drawing.Size(75, 23);
            this.mostrarButton.TabIndex = 5;
            this.mostrarButton.Text = "Mostrar";
            this.mostrarButton.UseVisualStyleBackColor = true;
            this.mostrarButton.Click += new System.EventHandler(this.mostrarButton_Click);
            // 
            // Ejercicio5C7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.Controls.Add(this.mostrarButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.AgendaRichTextBox);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio5C7";
            this.Text = "2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.RichTextBox AgendaRichTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button mostrarButton;
    }
}