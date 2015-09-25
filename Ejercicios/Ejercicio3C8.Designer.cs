namespace Ejercicios
{
    partial class Ejercicio3C8
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
            this.FechaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FechaRichTextBox
            // 
            this.FechaRichTextBox.Location = new System.Drawing.Point(62, 71);
            this.FechaRichTextBox.Name = "FechaRichTextBox";
            this.FechaRichTextBox.ReadOnly = true;
            this.FechaRichTextBox.Size = new System.Drawing.Size(141, 59);
            this.FechaRichTextBox.TabIndex = 0;
            this.FechaRichTextBox.Text = "";
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(94, 136);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(75, 23);
            this.MostrarButton.TabIndex = 1;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha y hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // Ejercicio3C8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.FechaRichTextBox);
            this.Name = "Ejercicio3C8";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FechaRichTextBox;
        private System.Windows.Forms.Button MostrarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}