namespace Ejercicios
{
    partial class Ejercicio1C7
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
            this.CalificacionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimoTextBox = new System.Windows.Forms.TextBox();
            this.PromedioTextBox = new System.Windows.Forms.TextBox();
            this.MaximoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.CaluclarButton = new System.Windows.Forms.Button();
            this.MostrarRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CalificacionTextBox
            // 
            this.CalificacionTextBox.Location = new System.Drawing.Point(79, 12);
            this.CalificacionTextBox.Name = "CalificacionTextBox";
            this.CalificacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.CalificacionTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calificacion";
            // 
            // MinimoTextBox
            // 
            this.MinimoTextBox.Location = new System.Drawing.Point(423, 214);
            this.MinimoTextBox.Name = "MinimoTextBox";
            this.MinimoTextBox.ReadOnly = true;
            this.MinimoTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinimoTextBox.TabIndex = 2;
            // 
            // PromedioTextBox
            // 
            this.PromedioTextBox.Location = new System.Drawing.Point(79, 214);
            this.PromedioTextBox.Name = "PromedioTextBox";
            this.PromedioTextBox.ReadOnly = true;
            this.PromedioTextBox.Size = new System.Drawing.Size(100, 20);
            this.PromedioTextBox.TabIndex = 2;
            // 
            // MaximoTextBox
            // 
            this.MaximoTextBox.Location = new System.Drawing.Point(253, 214);
            this.MaximoTextBox.Name = "MaximoTextBox";
            this.MaximoTextBox.ReadOnly = true;
            this.MaximoTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaximoTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Minimo";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(79, 69);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 6;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // CaluclarButton
            // 
            this.CaluclarButton.Location = new System.Drawing.Point(160, 69);
            this.CaluclarButton.Name = "CaluclarButton";
            this.CaluclarButton.Size = new System.Drawing.Size(75, 23);
            this.CaluclarButton.TabIndex = 7;
            this.CaluclarButton.Text = "Calcular";
            this.CaluclarButton.UseVisualStyleBackColor = true;
            this.CaluclarButton.Click += new System.EventHandler(this.CaluclarButton_Click);
            // 
            // MostrarRichTextBox
            // 
            this.MostrarRichTextBox.Location = new System.Drawing.Point(15, 140);
            this.MostrarRichTextBox.Name = "MostrarRichTextBox";
            this.MostrarRichTextBox.ReadOnly = true;
            this.MostrarRichTextBox.Size = new System.Drawing.Size(528, 68);
            this.MostrarRichTextBox.TabIndex = 8;
            this.MostrarRichTextBox.Text = "";
            // 
            // Ejercicio1C7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.MostrarRichTextBox);
            this.Controls.Add(this.CaluclarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaximoTextBox);
            this.Controls.Add(this.PromedioTextBox);
            this.Controls.Add(this.MinimoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalificacionTextBox);
            this.Name = "Ejercicio1C7";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalificacionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MinimoTextBox;
        private System.Windows.Forms.TextBox PromedioTextBox;
        private System.Windows.Forms.TextBox MaximoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button CaluclarButton;
        private System.Windows.Forms.RichTextBox MostrarRichTextBox;
    }
}