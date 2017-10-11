namespace CalcularPerimetroYArea
{
    partial class formPrincipal
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
            this.cbFigura = new System.Windows.Forms.ComboBox();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbFigura
            // 
            this.cbFigura.FormattingEnabled = true;
            this.cbFigura.Items.AddRange(new object[] {
            "Rectángulo",
            "Triángulo",
            "Círculo"});
            this.cbFigura.Location = new System.Drawing.Point(303, 20);
            this.cbFigura.Name = "cbFigura";
            this.cbFigura.Size = new System.Drawing.Size(235, 21);
            this.cbFigura.TabIndex = 1;
            this.cbFigura.SelectedValueChanged += new System.EventHandler(this.formChanged);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(38, 23);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(131, 13);
            this.lblPrincipal.TabIndex = 3;
            this.lblPrincipal.Text = "Elige la figura que desees:";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 65);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.cbFigura);
            this.Name = "formPrincipal";
            this.Text = "Elige una figura.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFigura;
        private System.Windows.Forms.Label lblPrincipal;
    }
}