namespace AstridDiaz
{
    partial class Form3
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
            this.GenerarButton = new System.Windows.Forms.Button();
            this.NumerosListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GenerarButton
            // 
            this.GenerarButton.Location = new System.Drawing.Point(43, 58);
            this.GenerarButton.Name = "GenerarButton";
            this.GenerarButton.Size = new System.Drawing.Size(75, 23);
            this.GenerarButton.TabIndex = 0;
            this.GenerarButton.Text = "Generar";
            this.GenerarButton.UseVisualStyleBackColor = true;
            this.GenerarButton.Click += new System.EventHandler(this.GenerarButton_Click);
            // 
            // NumerosListBox
            // 
            this.NumerosListBox.FormattingEnabled = true;
            this.NumerosListBox.ItemHeight = 16;
            this.NumerosListBox.Location = new System.Drawing.Point(168, 58);
            this.NumerosListBox.Name = "NumerosListBox";
            this.NumerosListBox.Size = new System.Drawing.Size(120, 468);
            this.NumerosListBox.TabIndex = 1;
            this.NumerosListBox.SelectedIndexChanged += new System.EventHandler(this.NumerosListBox_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.NumerosListBox);
            this.Controls.Add(this.GenerarButton);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerarButton;
        private System.Windows.Forms.ListBox NumerosListBox;
    }
}