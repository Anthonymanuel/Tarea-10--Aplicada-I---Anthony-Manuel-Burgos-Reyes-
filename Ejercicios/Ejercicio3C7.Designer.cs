namespace Ejercicios
{
    partial class Ejercicio3C7
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
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.EntradaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SalidaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AbregarButton = new System.Windows.Forms.Button();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Location = new System.Drawing.Point(140, 46);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClienteTextBox.TabIndex = 1;
            // 
            // EntradaRichTextBox
            // 
            this.EntradaRichTextBox.Location = new System.Drawing.Point(97, 131);
            this.EntradaRichTextBox.Name = "EntradaRichTextBox";
            this.EntradaRichTextBox.ReadOnly = true;
            this.EntradaRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.EntradaRichTextBox.TabIndex = 2;
            this.EntradaRichTextBox.Text = "";
            // 
            // SalidaRichTextBox
            // 
            this.SalidaRichTextBox.Location = new System.Drawing.Point(255, 131);
            this.SalidaRichTextBox.Name = "SalidaRichTextBox";
            this.SalidaRichTextBox.ReadOnly = true;
            this.SalidaRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.SalidaRichTextBox.TabIndex = 3;
            this.SalidaRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orden de entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Atencion";
            // 
            // AbregarButton
            // 
            this.AbregarButton.Location = new System.Drawing.Point(153, 72);
            this.AbregarButton.Name = "AbregarButton";
            this.AbregarButton.Size = new System.Drawing.Size(75, 23);
            this.AbregarButton.TabIndex = 6;
            this.AbregarButton.Text = "agregar";
            this.AbregarButton.UseVisualStyleBackColor = true;
            this.AbregarButton.Click += new System.EventHandler(this.AbregarButton_Click);
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(266, 233);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(75, 23);
            this.MostrarButton.TabIndex = 7;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // Ejercicio3C7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 261);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.AbregarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalidaRichTextBox);
            this.Controls.Add(this.EntradaRichTextBox);
            this.Controls.Add(this.ClienteTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio3C7";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.RichTextBox EntradaRichTextBox;
        private System.Windows.Forms.RichTextBox SalidaRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AbregarButton;
        private System.Windows.Forms.Button MostrarButton;
    }
}