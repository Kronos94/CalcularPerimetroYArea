namespace CalcularPerimetroYArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnCir = new System.Windows.Forms.Button();
            this.lblCirPerCalculated = new System.Windows.Forms.Label();
            this.lblCirPerArea = new System.Windows.Forms.Label();
            this.tbRadioCir = new System.Windows.Forms.TextBox();
            this.lblCirRad = new System.Windows.Forms.Label();
            this.pbCircle = new System.Windows.Forms.PictureBox();
            this.lblCirAreaCalculated = new System.Windows.Forms.Label();
            this.btnBackRec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCir
            // 
            this.btnCir.Location = new System.Drawing.Point(328, 212);
            this.btnCir.Name = "btnCir";
            this.btnCir.Size = new System.Drawing.Size(75, 23);
            this.btnCir.TabIndex = 32;
            this.btnCir.Text = "Calcular";
            this.btnCir.UseVisualStyleBackColor = true;
            this.btnCir.Click += new System.EventHandler(this.btnCir_Click);
            // 
            // lblCirPerCalculated
            // 
            this.lblCirPerCalculated.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCirPerCalculated.AutoSize = true;
            this.lblCirPerCalculated.Location = new System.Drawing.Point(452, 217);
            this.lblCirPerCalculated.Name = "lblCirPerCalculated";
            this.lblCirPerCalculated.Size = new System.Drawing.Size(0, 13);
            this.lblCirPerCalculated.TabIndex = 31;
            // 
            // lblCirPerArea
            // 
            this.lblCirPerArea.AutoSize = true;
            this.lblCirPerArea.Location = new System.Drawing.Point(325, 107);
            this.lblCirPerArea.Name = "lblCirPerArea";
            this.lblCirPerArea.Size = new System.Drawing.Size(152, 13);
            this.lblCirPerArea.TabIndex = 30;
            this.lblCirPerArea.Text = "Perimetro y área de un círculo:";
            // 
            // tbRadioCir
            // 
            this.tbRadioCir.Location = new System.Drawing.Point(423, 150);
            this.tbRadioCir.Name = "tbRadioCir";
            this.tbRadioCir.Size = new System.Drawing.Size(100, 20);
            this.tbRadioCir.TabIndex = 29;
            // 
            // lblCirRad
            // 
            this.lblCirRad.AutoSize = true;
            this.lblCirRad.Location = new System.Drawing.Point(325, 153);
            this.lblCirRad.Name = "lblCirRad";
            this.lblCirRad.Size = new System.Drawing.Size(35, 13);
            this.lblCirRad.TabIndex = 28;
            this.lblCirRad.Text = "Radio";
            // 
            // pbCircle
            // 
            this.pbCircle.Image = ((System.Drawing.Image)(resources.GetObject("pbCircle.Image")));
            this.pbCircle.Location = new System.Drawing.Point(43, 59);
            this.pbCircle.Name = "pbCircle";
            this.pbCircle.Size = new System.Drawing.Size(200, 200);
            this.pbCircle.TabIndex = 27;
            this.pbCircle.TabStop = false;
            // 
            // lblCirAreaCalculated
            // 
            this.lblCirAreaCalculated.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCirAreaCalculated.AutoSize = true;
            this.lblCirAreaCalculated.Location = new System.Drawing.Point(452, 246);
            this.lblCirAreaCalculated.Name = "lblCirAreaCalculated";
            this.lblCirAreaCalculated.Size = new System.Drawing.Size(0, 13);
            this.lblCirAreaCalculated.TabIndex = 33;
            // 
            // btnBackRec
            // 
            this.btnBackRec.Location = new System.Drawing.Point(455, 24);
            this.btnBackRec.Name = "btnBackRec";
            this.btnBackRec.Size = new System.Drawing.Size(75, 23);
            this.btnBackRec.TabIndex = 56;
            this.btnBackRec.Text = "Atras";
            this.btnBackRec.UseVisualStyleBackColor = true;
            this.btnBackRec.Click += new System.EventHandler(this.btnBackRec_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 293);
            this.Controls.Add(this.btnBackRec);
            this.Controls.Add(this.lblCirAreaCalculated);
            this.Controls.Add(this.btnCir);
            this.Controls.Add(this.lblCirPerCalculated);
            this.Controls.Add(this.pbCircle);
            this.Controls.Add(this.lblCirPerArea);
            this.Controls.Add(this.tbRadioCir);
            this.Controls.Add(this.lblCirRad);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCir;
        private System.Windows.Forms.Label lblCirPerCalculated;
        private System.Windows.Forms.PictureBox pbCircle;
        private System.Windows.Forms.Label lblCirPerArea;
        private System.Windows.Forms.TextBox tbRadioCir;
        private System.Windows.Forms.Label lblCirRad;
        private System.Windows.Forms.Label lblCirAreaCalculated;
        private System.Windows.Forms.Button btnBackRec;
    }
}