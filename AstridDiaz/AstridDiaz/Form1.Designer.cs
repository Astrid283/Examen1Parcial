namespace AstridDiaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.InteresesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InteresesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InteresesListBox
            // 
            this.InteresesListBox.FormattingEnabled = true;
            this.InteresesListBox.ItemHeight = 16;
            this.InteresesListBox.Location = new System.Drawing.Point(171, 38);
            this.InteresesListBox.Name = "InteresesListBox";
            this.InteresesListBox.Size = new System.Drawing.Size(245, 372);
            this.InteresesListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Institucion Financiera";
            // 
            // InteresesButton
            // 
            this.InteresesButton.Location = new System.Drawing.Point(41, 70);
            this.InteresesButton.Name = "InteresesButton";
            this.InteresesButton.Size = new System.Drawing.Size(105, 23);
            this.InteresesButton.TabIndex = 3;
            this.InteresesButton.Text = "Intereses";
            this.InteresesButton.UseVisualStyleBackColor = true;
            this.InteresesButton.Click += new System.EventHandler(this.InteresesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InteresesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InteresesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InteresesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InteresesButton;
    }
}

