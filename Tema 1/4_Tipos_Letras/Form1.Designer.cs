
namespace Tipos_Letras
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
            this.txtPrueba = new System.Windows.Forms.Label();
            this.btnComicSans = new System.Windows.Forms.Button();
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnTachado = new System.Windows.Forms.Button();
            this.btnMasGrande = new System.Windows.Forms.Button();
            this.btnMenosGrande = new System.Windows.Forms.Button();
            this.btnSubrayado = new System.Windows.Forms.Button();
            this.btnCursiva = new System.Windows.Forms.Button();
            this.btnCourier = new System.Windows.Forms.Button();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPrueba
            // 
            this.txtPrueba.AutoSize = true;
            this.txtPrueba.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrueba.Location = new System.Drawing.Point(318, 38);
            this.txtPrueba.Name = "txtPrueba";
            this.txtPrueba.Size = new System.Drawing.Size(174, 23);
            this.txtPrueba.TabIndex = 0;
            this.txtPrueba.Text = "Texto de prueba";
            // 
            // btnComicSans
            // 
            this.btnComicSans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComicSans.Location = new System.Drawing.Point(62, 92);
            this.btnComicSans.Name = "btnComicSans";
            this.btnComicSans.Size = new System.Drawing.Size(128, 39);
            this.btnComicSans.TabIndex = 1;
            this.btnComicSans.Text = "Comic Sans";
            this.btnComicSans.UseVisualStyleBackColor = true;
            this.btnComicSans.Click += new System.EventHandler(this.btnComicSans_Click);
            // 
            // btnNegrita
            // 
            this.btnNegrita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegrita.Location = new System.Drawing.Point(247, 92);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(128, 39);
            this.btnNegrita.TabIndex = 2;
            this.btnNegrita.Text = "Negrita";
            this.btnNegrita.UseVisualStyleBackColor = true;
            this.btnNegrita.Click += new System.EventHandler(this.btnNegrita_Click);
            // 
            // btnTachado
            // 
            this.btnTachado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTachado.Location = new System.Drawing.Point(422, 92);
            this.btnTachado.Name = "btnTachado";
            this.btnTachado.Size = new System.Drawing.Size(128, 39);
            this.btnTachado.TabIndex = 3;
            this.btnTachado.Text = "Tachado";
            this.btnTachado.UseVisualStyleBackColor = true;
            this.btnTachado.Click += new System.EventHandler(this.btnTachado_Click);
            // 
            // btnMasGrande
            // 
            this.btnMasGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasGrande.Location = new System.Drawing.Point(596, 92);
            this.btnMasGrande.Name = "btnMasGrande";
            this.btnMasGrande.Size = new System.Drawing.Size(128, 39);
            this.btnMasGrande.TabIndex = 4;
            this.btnMasGrande.Text = "+ Tamaño";
            this.btnMasGrande.UseVisualStyleBackColor = true;
            this.btnMasGrande.Click += new System.EventHandler(this.btnMasGrande_Click);
            // 
            // btnMenosGrande
            // 
            this.btnMenosGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenosGrande.Location = new System.Drawing.Point(596, 187);
            this.btnMenosGrande.Name = "btnMenosGrande";
            this.btnMenosGrande.Size = new System.Drawing.Size(128, 39);
            this.btnMenosGrande.TabIndex = 8;
            this.btnMenosGrande.Text = "- Tamaño";
            this.btnMenosGrande.UseVisualStyleBackColor = true;
            this.btnMenosGrande.Click += new System.EventHandler(this.btnMenosGrande_Click);
            // 
            // btnSubrayado
            // 
            this.btnSubrayado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubrayado.Location = new System.Drawing.Point(422, 187);
            this.btnSubrayado.Name = "btnSubrayado";
            this.btnSubrayado.Size = new System.Drawing.Size(128, 39);
            this.btnSubrayado.TabIndex = 7;
            this.btnSubrayado.Text = "Subrayado";
            this.btnSubrayado.UseVisualStyleBackColor = true;
            this.btnSubrayado.Click += new System.EventHandler(this.btnSubrayado_Click);
            // 
            // btnCursiva
            // 
            this.btnCursiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursiva.Location = new System.Drawing.Point(247, 187);
            this.btnCursiva.Name = "btnCursiva";
            this.btnCursiva.Size = new System.Drawing.Size(128, 39);
            this.btnCursiva.TabIndex = 6;
            this.btnCursiva.Text = "Cursiva";
            this.btnCursiva.UseVisualStyleBackColor = true;
            this.btnCursiva.Click += new System.EventHandler(this.btnCursiva_Click);
            // 
            // btnCourier
            // 
            this.btnCourier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourier.Location = new System.Drawing.Point(62, 187);
            this.btnCourier.Name = "btnCourier";
            this.btnCourier.Size = new System.Drawing.Size(128, 39);
            this.btnCourier.TabIndex = 5;
            this.btnCourier.Text = "Courier";
            this.btnCourier.UseVisualStyleBackColor = true;
            this.btnCourier.Click += new System.EventHandler(this.btnCourier_Click);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.Location = new System.Drawing.Point(80, 480);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(17, 23);
            this.lblSeleccion.TabIndex = 9;
            this.lblSeleccion.Text = "-";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(596, 281);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(128, 42);
            this.btnSeleccionar.TabIndex = 10;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(596, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 42);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(62, 281);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(488, 143);
            this.textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.btnMenosGrande);
            this.Controls.Add(this.btnSubrayado);
            this.Controls.Add(this.btnCursiva);
            this.Controls.Add(this.btnCourier);
            this.Controls.Add(this.btnMasGrande);
            this.Controls.Add(this.btnTachado);
            this.Controls.Add(this.btnNegrita);
            this.Controls.Add(this.btnComicSans);
            this.Controls.Add(this.txtPrueba);
            this.Name = "Form1";
            this.Text = "Estilos y tipos de letras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPrueba;
        private System.Windows.Forms.Button btnComicSans;
        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.Button btnTachado;
        private System.Windows.Forms.Button btnMasGrande;
        private System.Windows.Forms.Button btnMenosGrande;
        private System.Windows.Forms.Button btnSubrayado;
        private System.Windows.Forms.Button btnCursiva;
        private System.Windows.Forms.Button btnCourier;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBox1;
    }
}

