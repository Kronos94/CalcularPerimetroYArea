namespace CalcularPerimetroYArea
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
            this.lblRecAreaCalculated = new System.Windows.Forms.Label();
            this.lblRecPerCalculated = new System.Windows.Forms.Label();
            this.btnRec = new System.Windows.Forms.Button();
            this.tbRecAnchura = new System.Windows.Forms.TextBox();
            this.lblRecAnch = new System.Windows.Forms.Label();
            this.tbRecAltura = new System.Windows.Forms.TextBox();
            this.lblRecAltura = new System.Windows.Forms.Label();
            this.lblRectPerArea = new System.Windows.Forms.Label();
            this.btnBackRec = new System.Windows.Forms.Button();
            this.pbRect = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRect)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecAreaCalculated
            // 
            this.lblRecAreaCalculated.AutoSize = true;
            this.lblRecAreaCalculated.Location = new System.Drawing.Point(549, 341);
            this.lblRecAreaCalculated.Name = "lblRecAreaCalculated";
            this.lblRecAreaCalculated.Size = new System.Drawing.Size(0, 13);
            this.lblRecAreaCalculated.TabIndex = 54;
            // 
            // lblRecPerCalculated
            // 
            this.lblRecPerCalculated.AutoSize = true;
            this.lblRecPerCalculated.Location = new System.Drawing.Point(549, 292);
            this.lblRecPerCalculated.Name = "lblRecPerCalculated";
            this.lblRecPerCalculated.Size = new System.Drawing.Size(0, 13);
            this.lblRecPerCalculated.TabIndex = 53;
            // 
            // btnRec
            // 
            this.btnRec.Location = new System.Drawing.Point(413, 282);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(75, 23);
            this.btnRec.TabIndex = 52;
            this.btnRec.Text = "Calcular";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // tbRecAnchura
            // 
            this.tbRecAnchura.Location = new System.Drawing.Point(518, 202);
            this.tbRecAnchura.Name = "tbRecAnchura";
            this.tbRecAnchura.Size = new System.Drawing.Size(100, 20);
            this.tbRecAnchura.TabIndex = 51;
            // 
            // lblRecAnch
            // 
            this.lblRecAnch.AutoSize = true;
            this.lblRecAnch.Location = new System.Drawing.Point(425, 205);
            this.lblRecAnch.Name = "lblRecAnch";
            this.lblRecAnch.Size = new System.Drawing.Size(47, 13);
            this.lblRecAnch.TabIndex = 50;
            this.lblRecAnch.Text = "Anchura";
            // 
            // tbRecAltura
            // 
            this.tbRecAltura.Location = new System.Drawing.Point(518, 151);
            this.tbRecAltura.Name = "tbRecAltura";
            this.tbRecAltura.Size = new System.Drawing.Size(100, 20);
            this.tbRecAltura.TabIndex = 49;
            // 
            // lblRecAltura
            // 
            this.lblRecAltura.AutoSize = true;
            this.lblRecAltura.Location = new System.Drawing.Point(425, 154);
            this.lblRecAltura.Name = "lblRecAltura";
            this.lblRecAltura.Size = new System.Drawing.Size(34, 13);
            this.lblRecAltura.TabIndex = 48;
            this.lblRecAltura.Text = "Altura";
            // 
            // lblRectPerArea
            // 
            this.lblRectPerArea.AutoSize = true;
            this.lblRectPerArea.Location = new System.Drawing.Point(425, 108);
            this.lblRectPerArea.Name = "lblRectPerArea";
            this.lblRectPerArea.Size = new System.Drawing.Size(169, 13);
            this.lblRectPerArea.TabIndex = 47;
            this.lblRectPerArea.Text = "Perimetro y área de un réctangulo:";
            // 
            // btnBackRec
            // 
            this.btnBackRec.Location = new System.Drawing.Point(519, 12);
            this.btnBackRec.Name = "btnBackRec";
            this.btnBackRec.Size = new System.Drawing.Size(75, 23);
            this.btnBackRec.TabIndex = 55;
            this.btnBackRec.Text = "Atras";
            this.btnBackRec.UseVisualStyleBackColor = true;
            this.btnBackRec.Click += new System.EventHandler(this.btnBackRec_Click);
            // 
            // pbRect
            // 
            this.pbRect.Image = global::CalcularPerimetroYArea.Properties.Resources.Rectangulo;
            this.pbRect.Location = new System.Drawing.Point(12, 84);
            this.pbRect.Name = "pbRect";
            this.pbRect.Size = new System.Drawing.Size(342, 207);
            this.pbRect.TabIndex = 46;
            this.pbRect.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 396);
            this.Controls.Add(this.btnBackRec);
            this.Controls.Add(this.lblRecAreaCalculated);
            this.Controls.Add(this.lblRecPerCalculated);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.tbRecAnchura);
            this.Controls.Add(this.lblRecAnch);
            this.Controls.Add(this.tbRecAltura);
            this.Controls.Add(this.lblRecAltura);
            this.Controls.Add(this.lblRectPerArea);
            this.Controls.Add(this.pbRect);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbRect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecAreaCalculated;
        private System.Windows.Forms.Label lblRecPerCalculated;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.TextBox tbRecAnchura;
        private System.Windows.Forms.Label lblRecAnch;
        private System.Windows.Forms.TextBox tbRecAltura;
        private System.Windows.Forms.Label lblRecAltura;
        private System.Windows.Forms.Label lblRectPerArea;
        private System.Windows.Forms.PictureBox pbRect;
        private System.Windows.Forms.Button btnBackRec;
    }
}