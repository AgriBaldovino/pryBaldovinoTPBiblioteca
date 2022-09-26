namespace pryBaldovinoTPBiblioteca
{
    partial class frmBiblioteca
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
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodigoDistribuidor = new System.Windows.Forms.Label();
            this.lblCodigoAutor = new System.Windows.Forms.Label();
            this.lblCodigoEditorial = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(13, 175);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(56, 23);
            this.cmdSalir.TabIndex = 0;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Location = new System.Drawing.Point(75, 175);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(55, 23);
            this.cmdAnterior.TabIndex = 1;
            this.cmdAnterior.Text = "Anterior";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Location = new System.Drawing.Point(136, 175);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(60, 23);
            this.cmdSiguiente.TabIndex = 2;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo editorial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Codigo distribuidor";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo.Location = new System.Drawing.Point(58, 8);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(138, 19);
            this.lblCodigo.TabIndex = 12;
            // 
            // lblCodigoDistribuidor
            // 
            this.lblCodigoDistribuidor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoDistribuidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoDistribuidor.Location = new System.Drawing.Point(111, 144);
            this.lblCodigoDistribuidor.Name = "lblCodigoDistribuidor";
            this.lblCodigoDistribuidor.Size = new System.Drawing.Size(85, 19);
            this.lblCodigoDistribuidor.TabIndex = 13;
            // 
            // lblCodigoAutor
            // 
            this.lblCodigoAutor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoAutor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoAutor.Location = new System.Drawing.Point(85, 110);
            this.lblCodigoAutor.Name = "lblCodigoAutor";
            this.lblCodigoAutor.Size = new System.Drawing.Size(111, 19);
            this.lblCodigoAutor.TabIndex = 14;
            // 
            // lblCodigoEditorial
            // 
            this.lblCodigoEditorial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoEditorial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoEditorial.Location = new System.Drawing.Point(97, 76);
            this.lblCodigoEditorial.Name = "lblCodigoEditorial";
            this.lblCodigoEditorial.Size = new System.Drawing.Size(99, 19);
            this.lblCodigoEditorial.TabIndex = 15;
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreLibro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreLibro.Location = new System.Drawing.Point(101, 37);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(95, 19);
            this.lblNombreLibro.TabIndex = 16;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 205);
            this.Controls.Add(this.lblNombreLibro);
            this.Controls.Add(this.lblCodigoEditorial);
            this.Controls.Add(this.lblCodigoAutor);
            this.Controls.Add(this.lblCodigoDistribuidor);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.cmdAnterior);
            this.Controls.Add(this.cmdSalir);
            this.Name = "frmBiblioteca";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmBiblioteca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdAnterior;
        private System.Windows.Forms.Button cmdSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodigoDistribuidor;
        private System.Windows.Forms.Label lblCodigoAutor;
        private System.Windows.Forms.Label lblCodigoEditorial;
        private System.Windows.Forms.Label lblNombreLibro;
    }
}

