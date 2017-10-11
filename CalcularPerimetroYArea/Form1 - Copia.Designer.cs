namespace CalcularPerimetroYArea
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
            this.btnTriArea = new System.Windows.Forms.Button();
            this.lblPerTri = new System.Windows.Forms.Label();
            this.btnTriPer = new System.Windows.Forms.Button();
            this.lblLadoATri = new System.Windows.Forms.Label();
            this.lblLadoBTri = new System.Windows.Forms.Label();
            this.lblLadoCTri = new System.Windows.Forms.Label();
            this.lblAlturaTri = new System.Windows.Forms.Label();
            this.lblBaseTri = new System.Windows.Forms.Label();
            this.lblTriCalculatedArea = new System.Windows.Forms.Label();
            this.lblTriCalculatedPer = new System.Windows.Forms.Label();
            this.tbLadoCTri = new System.Windows.Forms.TextBox();
            this.tbLadoBTri = new System.Windows.Forms.TextBox();
            this.tbLadoATri = new System.Windows.Forms.TextBox();
            this.tbAlturaTri = new System.Windows.Forms.TextBox();
            this.tbBaseTri = new System.Windows.Forms.TextBox();
            this.lblAreaTri = new System.Windows.Forms.Label();
            this.btnBackRec = new System.Windows.Forms.Button();
            this.pbTri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTriArea
            // 
            this.btnTriArea.Location = new System.Drawing.Point(40, 393);
            this.btnTriArea.Name = "btnTriArea";
            this.btnTriArea.Size = new System.Drawing.Size(75, 23);
            this.btnTriArea.TabIndex = 1;
            this.btnTriArea.Text = "Calcular";
            this.btnTriArea.UseVisualStyleBackColor = true;
            this.btnTriArea.Click += new System.EventHandler(this.btnTriArea_Click);
            // 
            // lblPerTri
            // 
            this.lblPerTri.AutoSize = true;
            this.lblPerTri.Location = new System.Drawing.Point(417, 92);
            this.lblPerTri.Name = "lblPerTri";
            this.lblPerTri.Size = new System.Drawing.Size(127, 13);
            this.lblPerTri.TabIndex = 4;
            this.lblPerTri.Text = "Perimetro de un triangulo:";
            // 
            // btnTriPer
            // 
            this.btnTriPer.Location = new System.Drawing.Point(341, 279);
            this.btnTriPer.Name = "btnTriPer";
            this.btnTriPer.Size = new System.Drawing.Size(75, 23);
            this.btnTriPer.TabIndex = 5;
            this.btnTriPer.Text = "Calcular";
            this.btnTriPer.UseVisualStyleBackColor = true;
            this.btnTriPer.Click += new System.EventHandler(this.btnTriPer_Click);
            // 
            // lblLadoATri
            // 
            this.lblLadoATri.AutoSize = true;
            this.lblLadoATri.Location = new System.Drawing.Point(417, 132);
            this.lblLadoATri.Name = "lblLadoATri";
            this.lblLadoATri.Size = new System.Drawing.Size(40, 13);
            this.lblLadoATri.TabIndex = 6;
            this.lblLadoATri.Text = "Lado a";
            // 
            // lblLadoBTri
            // 
            this.lblLadoBTri.AutoSize = true;
            this.lblLadoBTri.Location = new System.Drawing.Point(417, 173);
            this.lblLadoBTri.Name = "lblLadoBTri";
            this.lblLadoBTri.Size = new System.Drawing.Size(40, 13);
            this.lblLadoBTri.TabIndex = 7;
            this.lblLadoBTri.Text = "Lado b";
            // 
            // lblLadoCTri
            // 
            this.lblLadoCTri.AutoSize = true;
            this.lblLadoCTri.Location = new System.Drawing.Point(417, 214);
            this.lblLadoCTri.Name = "lblLadoCTri";
            this.lblLadoCTri.Size = new System.Drawing.Size(40, 13);
            this.lblLadoCTri.TabIndex = 8;
            this.lblLadoCTri.Text = "Lado c";
            // 
            // lblAlturaTri
            // 
            this.lblAlturaTri.AutoSize = true;
            this.lblAlturaTri.Location = new System.Drawing.Point(37, 289);
            this.lblAlturaTri.Name = "lblAlturaTri";
            this.lblAlturaTri.Size = new System.Drawing.Size(34, 13);
            this.lblAlturaTri.TabIndex = 9;
            this.lblAlturaTri.Text = "Altura";
            // 
            // lblBaseTri
            // 
            this.lblBaseTri.AutoSize = true;
            this.lblBaseTri.Location = new System.Drawing.Point(37, 336);
            this.lblBaseTri.Name = "lblBaseTri";
            this.lblBaseTri.Size = new System.Drawing.Size(73, 13);
            this.lblBaseTri.TabIndex = 10;
            this.lblBaseTri.Text = "Base (Lado b)";
            // 
            // lblTriCalculatedArea
            // 
            this.lblTriCalculatedArea.AutoSize = true;
            this.lblTriCalculatedArea.Location = new System.Drawing.Point(174, 398);
            this.lblTriCalculatedArea.Name = "lblTriCalculatedArea";
            this.lblTriCalculatedArea.Size = new System.Drawing.Size(0, 13);
            this.lblTriCalculatedArea.TabIndex = 11;
            // 
            // lblTriCalculatedPer
            // 
            this.lblTriCalculatedPer.AutoSize = true;
            this.lblTriCalculatedPer.Location = new System.Drawing.Point(509, 284);
            this.lblTriCalculatedPer.Name = "lblTriCalculatedPer";
            this.lblTriCalculatedPer.Size = new System.Drawing.Size(0, 13);
            this.lblTriCalculatedPer.TabIndex = 12;
            // 
            // tbLadoCTri
            // 
            this.tbLadoCTri.Location = new System.Drawing.Point(500, 211);
            this.tbLadoCTri.Name = "tbLadoCTri";
            this.tbLadoCTri.Size = new System.Drawing.Size(100, 20);
            this.tbLadoCTri.TabIndex = 13;
            // 
            // tbLadoBTri
            // 
            this.tbLadoBTri.Location = new System.Drawing.Point(500, 170);
            this.tbLadoBTri.Name = "tbLadoBTri";
            this.tbLadoBTri.Size = new System.Drawing.Size(100, 20);
            this.tbLadoBTri.TabIndex = 15;
            // 
            // tbLadoATri
            // 
            this.tbLadoATri.Location = new System.Drawing.Point(500, 129);
            this.tbLadoATri.Name = "tbLadoATri";
            this.tbLadoATri.Size = new System.Drawing.Size(100, 20);
            this.tbLadoATri.TabIndex = 16;
            // 
            // tbAlturaTri
            // 
            this.tbAlturaTri.Location = new System.Drawing.Point(155, 286);
            this.tbAlturaTri.Name = "tbAlturaTri";
            this.tbAlturaTri.Size = new System.Drawing.Size(100, 20);
            this.tbAlturaTri.TabIndex = 18;
            this.tbAlturaTri.Tag = "";
            // 
            // tbBaseTri
            // 
            this.tbBaseTri.Location = new System.Drawing.Point(155, 333);
            this.tbBaseTri.Name = "tbBaseTri";
            this.tbBaseTri.Size = new System.Drawing.Size(100, 20);
            this.tbBaseTri.TabIndex = 19;
            // 
            // lblAreaTri
            // 
            this.lblAreaTri.AutoSize = true;
            this.lblAreaTri.Location = new System.Drawing.Point(40, 250);
            this.lblAreaTri.Name = "lblAreaTri";
            this.lblAreaTri.Size = new System.Drawing.Size(105, 13);
            this.lblAreaTri.TabIndex = 20;
            this.lblAreaTri.Text = "Área de un triángulo:";
            // 
            // btnBackRec
            // 
            this.btnBackRec.Location = new System.Drawing.Point(568, 23);
            this.btnBackRec.Name = "btnBackRec";
            this.btnBackRec.Size = new System.Drawing.Size(75, 23);
            this.btnBackRec.TabIndex = 57;
            this.btnBackRec.Text = "Atras";
            this.btnBackRec.UseVisualStyleBackColor = true;
            this.btnBackRec.Click += new System.EventHandler(this.btnBackRec_Click);
            // 
            // pbTri
            // 
            this.pbTri.Image = global::CalcularPerimetroYArea.Properties.Resources.Triangulo;
            this.pbTri.InitialImage = null;
            this.pbTri.Location = new System.Drawing.Point(40, 68);
            this.pbTri.Name = "pbTri";
            this.pbTri.Size = new System.Drawing.Size(314, 159);
            this.pbTri.TabIndex = 14;
            this.pbTri.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 441);
            this.Controls.Add(this.btnBackRec);
            this.Controls.Add(this.lblLadoCTri);
            this.Controls.Add(this.lblAreaTri);
            this.Controls.Add(this.tbBaseTri);
            this.Controls.Add(this.tbAlturaTri);
            this.Controls.Add(this.tbLadoATri);
            this.Controls.Add(this.tbLadoBTri);
            this.Controls.Add(this.tbLadoCTri);
            this.Controls.Add(this.lblTriCalculatedPer);
            this.Controls.Add(this.lblTriCalculatedArea);
            this.Controls.Add(this.lblBaseTri);
            this.Controls.Add(this.lblAlturaTri);
            this.Controls.Add(this.lblLadoBTri);
            this.Controls.Add(this.lblLadoATri);
            this.Controls.Add(this.btnTriPer);
            this.Controls.Add(this.lblPerTri);
            this.Controls.Add(this.btnTriArea);
            this.Controls.Add(this.pbTri);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Área y Périmetro de figuras.";
            ((System.ComponentModel.ISupportInitialize)(this.pbTri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTriArea;
        private System.Windows.Forms.Label lblPerTri;
        private System.Windows.Forms.Button btnTriPer;
        private System.Windows.Forms.Label lblLadoATri;
        private System.Windows.Forms.Label lblLadoBTri;
        private System.Windows.Forms.Label lblLadoCTri;
        private System.Windows.Forms.Label lblAlturaTri;
        private System.Windows.Forms.Label lblBaseTri;
        private System.Windows.Forms.Label lblTriCalculatedArea;
        private System.Windows.Forms.Label lblTriCalculatedPer;
        private System.Windows.Forms.TextBox tbLadoCTri;
        private System.Windows.Forms.PictureBox pbTri;
        private System.Windows.Forms.TextBox tbLadoBTri;
        private System.Windows.Forms.TextBox tbLadoATri;
        private System.Windows.Forms.TextBox tbAlturaTri;
        private System.Windows.Forms.TextBox tbBaseTri;
        private System.Windows.Forms.Label lblAreaTri;
        private System.Windows.Forms.Button btnBackRec;
    }
}

