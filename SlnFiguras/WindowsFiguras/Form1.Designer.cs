
namespace WindowsFiguras
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
            this.btnMostrarSuperficieTriangulo = new System.Windows.Forms.Button();
            this.lblBaseTriangulo = new System.Windows.Forms.Label();
            this.lblAlturaTriangulo = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.btnSuperficieRectangulo = new System.Windows.Forms.Button();
            this.lblBaseRectangulo = new System.Windows.Forms.Label();
            this.lblAlturaRectangulo = new System.Windows.Forms.Label();
            this.txtBaseRectangulo = new System.Windows.Forms.TextBox();
            this.txtAlturaRectangulo = new System.Windows.Forms.TextBox();
            this.txtRadioCirculo = new System.Windows.Forms.TextBox();
            this.btnSuperficieCirculo = new System.Windows.Forms.Button();
            this.lblRadioCirculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarSuperficieTriangulo
            // 
            this.btnMostrarSuperficieTriangulo.Location = new System.Drawing.Point(156, 76);
            this.btnMostrarSuperficieTriangulo.Name = "btnMostrarSuperficieTriangulo";
            this.btnMostrarSuperficieTriangulo.Size = new System.Drawing.Size(179, 23);
            this.btnMostrarSuperficieTriangulo.TabIndex = 0;
            this.btnMostrarSuperficieTriangulo.Text = "Superficie Triangulo";
            this.btnMostrarSuperficieTriangulo.UseVisualStyleBackColor = true;
            this.btnMostrarSuperficieTriangulo.Click += new System.EventHandler(this.btnMostrarSuperficieTriangulo_Click);
            // 
            // lblBaseTriangulo
            // 
            this.lblBaseTriangulo.AutoSize = true;
            this.lblBaseTriangulo.Location = new System.Drawing.Point(79, 31);
            this.lblBaseTriangulo.Name = "lblBaseTriangulo";
            this.lblBaseTriangulo.Size = new System.Drawing.Size(31, 13);
            this.lblBaseTriangulo.TabIndex = 1;
            this.lblBaseTriangulo.Text = "Base";
            // 
            // lblAlturaTriangulo
            // 
            this.lblAlturaTriangulo.AutoSize = true;
            this.lblAlturaTriangulo.Location = new System.Drawing.Point(79, 57);
            this.lblAlturaTriangulo.Name = "lblAlturaTriangulo";
            this.lblAlturaTriangulo.Size = new System.Drawing.Size(34, 13);
            this.lblAlturaTriangulo.TabIndex = 2;
            this.lblAlturaTriangulo.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(156, 50);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(179, 20);
            this.txtAltura.TabIndex = 4;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(156, 24);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(179, 20);
            this.txtBase.TabIndex = 5;
            // 
            // btnSuperficieRectangulo
            // 
            this.btnSuperficieRectangulo.Location = new System.Drawing.Point(156, 164);
            this.btnSuperficieRectangulo.Name = "btnSuperficieRectangulo";
            this.btnSuperficieRectangulo.Size = new System.Drawing.Size(179, 23);
            this.btnSuperficieRectangulo.TabIndex = 6;
            this.btnSuperficieRectangulo.Text = "Superficie Rectangulo";
            this.btnSuperficieRectangulo.UseVisualStyleBackColor = true;
            this.btnSuperficieRectangulo.Click += new System.EventHandler(this.btnSuperficieRectangulo_Click);
            // 
            // lblBaseRectangulo
            // 
            this.lblBaseRectangulo.AutoSize = true;
            this.lblBaseRectangulo.Location = new System.Drawing.Point(82, 119);
            this.lblBaseRectangulo.Name = "lblBaseRectangulo";
            this.lblBaseRectangulo.Size = new System.Drawing.Size(31, 13);
            this.lblBaseRectangulo.TabIndex = 7;
            this.lblBaseRectangulo.Text = "Base";
            // 
            // lblAlturaRectangulo
            // 
            this.lblAlturaRectangulo.AutoSize = true;
            this.lblAlturaRectangulo.Location = new System.Drawing.Point(82, 145);
            this.lblAlturaRectangulo.Name = "lblAlturaRectangulo";
            this.lblAlturaRectangulo.Size = new System.Drawing.Size(34, 13);
            this.lblAlturaRectangulo.TabIndex = 8;
            this.lblAlturaRectangulo.Text = "Altura";
            // 
            // txtBaseRectangulo
            // 
            this.txtBaseRectangulo.Location = new System.Drawing.Point(156, 112);
            this.txtBaseRectangulo.Name = "txtBaseRectangulo";
            this.txtBaseRectangulo.Size = new System.Drawing.Size(179, 20);
            this.txtBaseRectangulo.TabIndex = 9;
            // 
            // txtAlturaRectangulo
            // 
            this.txtAlturaRectangulo.Location = new System.Drawing.Point(156, 138);
            this.txtAlturaRectangulo.Name = "txtAlturaRectangulo";
            this.txtAlturaRectangulo.Size = new System.Drawing.Size(179, 20);
            this.txtAlturaRectangulo.TabIndex = 10;
            // 
            // txtRadioCirculo
            // 
            this.txtRadioCirculo.Location = new System.Drawing.Point(156, 205);
            this.txtRadioCirculo.Name = "txtRadioCirculo";
            this.txtRadioCirculo.Size = new System.Drawing.Size(179, 20);
            this.txtRadioCirculo.TabIndex = 11;
            // 
            // btnSuperficieCirculo
            // 
            this.btnSuperficieCirculo.Location = new System.Drawing.Point(156, 231);
            this.btnSuperficieCirculo.Name = "btnSuperficieCirculo";
            this.btnSuperficieCirculo.Size = new System.Drawing.Size(179, 23);
            this.btnSuperficieCirculo.TabIndex = 13;
            this.btnSuperficieCirculo.Text = "Superficie Circulo";
            this.btnSuperficieCirculo.UseVisualStyleBackColor = true;
            this.btnSuperficieCirculo.Click += new System.EventHandler(this.btnSuperficieCirculo_Click);
            // 
            // lblRadioCirculo
            // 
            this.lblRadioCirculo.AutoSize = true;
            this.lblRadioCirculo.Location = new System.Drawing.Point(82, 212);
            this.lblRadioCirculo.Name = "lblRadioCirculo";
            this.lblRadioCirculo.Size = new System.Drawing.Size(35, 13);
            this.lblRadioCirculo.TabIndex = 14;
            this.lblRadioCirculo.Text = "Radio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 279);
            this.Controls.Add(this.lblRadioCirculo);
            this.Controls.Add(this.btnSuperficieCirculo);
            this.Controls.Add(this.txtRadioCirculo);
            this.Controls.Add(this.txtAlturaRectangulo);
            this.Controls.Add(this.txtBaseRectangulo);
            this.Controls.Add(this.lblAlturaRectangulo);
            this.Controls.Add(this.lblBaseRectangulo);
            this.Controls.Add(this.btnSuperficieRectangulo);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAlturaTriangulo);
            this.Controls.Add(this.lblBaseTriangulo);
            this.Controls.Add(this.btnMostrarSuperficieTriangulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarSuperficieTriangulo;
        private System.Windows.Forms.Label lblBaseTriangulo;
        private System.Windows.Forms.Label lblAlturaTriangulo;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Button btnSuperficieRectangulo;
        private System.Windows.Forms.Label lblBaseRectangulo;
        private System.Windows.Forms.Label lblAlturaRectangulo;
        private System.Windows.Forms.TextBox txtBaseRectangulo;
        private System.Windows.Forms.TextBox txtAlturaRectangulo;
        private System.Windows.Forms.TextBox txtRadioCirculo;
        private System.Windows.Forms.Button btnSuperficieCirculo;
        private System.Windows.Forms.Label lblRadioCirculo;
    }
}

