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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiblioteca));
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCodEdito = new System.Windows.Forms.Label();
            this.lblCodAutor = new System.Windows.Forms.Label();
            this.lblCodDistr = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodigoDistribuidor = new System.Windows.Forms.Label();
            this.lblCodigoAutor = new System.Windows.Forms.Label();
            this.lblCodigoEditorial = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(177, 175);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(60, 23);
            this.cmdSalir.TabIndex = 0;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Location = new System.Drawing.Point(239, 175);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(60, 23);
            this.cmdAnterior.TabIndex = 1;
            this.cmdAnterior.Text = "Anterior";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Location = new System.Drawing.Point(300, 175);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(60, 23);
            this.cmdSiguiente.TabIndex = 2;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(12, 9);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 3;
            this.lblCod.Text = "Codigo";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 43);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(83, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nombre del libro";
            // 
            // lblCodEdito
            // 
            this.lblCodEdito.AutoSize = true;
            this.lblCodEdito.Location = new System.Drawing.Point(12, 77);
            this.lblCodEdito.Name = "lblCodEdito";
            this.lblCodEdito.Size = new System.Drawing.Size(79, 13);
            this.lblCodEdito.TabIndex = 5;
            this.lblCodEdito.Text = "Codigo editorial";
            // 
            // lblCodAutor
            // 
            this.lblCodAutor.AutoSize = true;
            this.lblCodAutor.Location = new System.Drawing.Point(12, 111);
            this.lblCodAutor.Name = "lblCodAutor";
            this.lblCodAutor.Size = new System.Drawing.Size(67, 13);
            this.lblCodAutor.TabIndex = 6;
            this.lblCodAutor.Text = "Codigo autor";
            // 
            // lblCodDistr
            // 
            this.lblCodDistr.AutoSize = true;
            this.lblCodDistr.Location = new System.Drawing.Point(12, 145);
            this.lblCodDistr.Name = "lblCodDistr";
            this.lblCodDistr.Size = new System.Drawing.Size(93, 13);
            this.lblCodDistr.TabIndex = 7;
            this.lblCodDistr.Text = "Codigo distribuidor";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo.Location = new System.Drawing.Point(58, 8);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(302, 19);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // lblCodigoDistribuidor
            // 
            this.lblCodigoDistribuidor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoDistribuidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoDistribuidor.Location = new System.Drawing.Point(111, 144);
            this.lblCodigoDistribuidor.Name = "lblCodigoDistribuidor";
            this.lblCodigoDistribuidor.Size = new System.Drawing.Size(249, 19);
            this.lblCodigoDistribuidor.TabIndex = 13;
            // 
            // lblCodigoAutor
            // 
            this.lblCodigoAutor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoAutor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoAutor.Location = new System.Drawing.Point(85, 110);
            this.lblCodigoAutor.Name = "lblCodigoAutor";
            this.lblCodigoAutor.Size = new System.Drawing.Size(275, 19);
            this.lblCodigoAutor.TabIndex = 14;
            // 
            // lblCodigoEditorial
            // 
            this.lblCodigoEditorial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoEditorial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoEditorial.Location = new System.Drawing.Point(97, 76);
            this.lblCodigoEditorial.Name = "lblCodigoEditorial";
            this.lblCodigoEditorial.Size = new System.Drawing.Size(263, 19);
            this.lblCodigoEditorial.TabIndex = 15;
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreLibro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreLibro.Location = new System.Drawing.Point(101, 37);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(259, 19);
            this.lblNombreLibro.TabIndex = 16;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 204);
            this.Controls.Add(this.lblNombreLibro);
            this.Controls.Add(this.lblCodigoEditorial);
            this.Controls.Add(this.lblCodigoAutor);
            this.Controls.Add(this.lblCodigoDistribuidor);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCodDistr);
            this.Controls.Add(this.lblCodAutor);
            this.Controls.Add(this.lblCodEdito);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.cmdAnterior);
            this.Controls.Add(this.cmdSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCodEdito;
        private System.Windows.Forms.Label lblCodAutor;
        private System.Windows.Forms.Label lblCodDistr;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodigoDistribuidor;
        private System.Windows.Forms.Label lblCodigoAutor;
        private System.Windows.Forms.Label lblCodigoEditorial;
        private System.Windows.Forms.Label lblNombreLibro;
    }
}

