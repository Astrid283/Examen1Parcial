namespace AstridDiaz
{
    partial class Form2
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
            this.NombreLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.NombreListBox = new System.Windows.Forms.ListBox();
            this.PrecioListBox = new System.Windows.Forms.ListBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.TotalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(25, 41);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(56, 16);
            this.NombreLabel.TabIndex = 0;
            this.NombreLabel.Text = "Nombre";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Location = new System.Drawing.Point(396, 41);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(46, 16);
            this.PrecioLabel.TabIndex = 1;
            this.PrecioLabel.Text = "Precio";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(111, 41);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.NombreTextBox.TabIndex = 2;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(487, 35);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(100, 22);
            this.PrecioTextBox.TabIndex = 3;
            // 
            // NombreListBox
            // 
            this.NombreListBox.FormattingEnabled = true;
            this.NombreListBox.ItemHeight = 16;
            this.NombreListBox.Location = new System.Drawing.Point(111, 85);
            this.NombreListBox.Name = "NombreListBox";
            this.NombreListBox.Size = new System.Drawing.Size(120, 276);
            this.NombreListBox.TabIndex = 4;
            // 
            // PrecioListBox
            // 
            this.PrecioListBox.FormattingEnabled = true;
            this.PrecioListBox.ItemHeight = 16;
            this.PrecioListBox.Location = new System.Drawing.Point(487, 85);
            this.PrecioListBox.Name = "PrecioListBox";
            this.PrecioListBox.Size = new System.Drawing.Size(120, 276);
            this.PrecioListBox.TabIndex = 5;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(156, 391);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // TotalButton
            // 
            this.TotalButton.Location = new System.Drawing.Point(487, 391);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(75, 23);
            this.TotalButton.TabIndex = 7;
            this.TotalButton.Text = "Total";
            this.TotalButton.UseVisualStyleBackColor = true;
            this.TotalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.PrecioListBox);
            this.Controls.Add(this.NombreListBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.NombreLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.ListBox NombreListBox;
        private System.Windows.Forms.ListBox PrecioListBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button TotalButton;
    }
}