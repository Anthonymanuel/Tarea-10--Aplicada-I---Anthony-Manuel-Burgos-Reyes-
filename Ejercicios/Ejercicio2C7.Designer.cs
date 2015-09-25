namespace Ejercicios
{
    partial class Ejercicio2C7
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.PalabraTextBox = new System.Windows.Forms.TextBox();
            this.DiccionarioRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palabra";
            // 
            // PalabraTextBox
            // 
            this.PalabraTextBox.Location = new System.Drawing.Point(133, 36);
            this.PalabraTextBox.Name = "PalabraTextBox";
            this.PalabraTextBox.Size = new System.Drawing.Size(100, 20);
            this.PalabraTextBox.TabIndex = 1;
            this.PalabraTextBox.TextChanged += new System.EventHandler(this.PalabraTextBox_TextChanged);
            // 
            // DiccionarioRichTextBox
            // 
            this.DiccionarioRichTextBox.Location = new System.Drawing.Point(12, 127);
            this.DiccionarioRichTextBox.Name = "DiccionarioRichTextBox";
            this.DiccionarioRichTextBox.ReadOnly = true;
            this.DiccionarioRichTextBox.Size = new System.Drawing.Size(296, 96);
            this.DiccionarioRichTextBox.TabIndex = 2;
            this.DiccionarioRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Significado";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(144, 62);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 4;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // MostrarButton
            // 
            this.MostrarButton.Location = new System.Drawing.Point(144, 226);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(75, 23);
            this.MostrarButton.TabIndex = 5;
            this.MostrarButton.Text = "Mostrar ";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ejercicio2C7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 261);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiccionarioRichTextBox);
            this.Controls.Add(this.PalabraTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2C7";
            this.Text = "Ejercicio 2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PalabraTextBox;
        private System.Windows.Forms.RichTextBox DiccionarioRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button MostrarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}