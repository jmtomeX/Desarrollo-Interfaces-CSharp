
namespace CalculoDietas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTotalSalarioDia = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkCena = new System.Windows.Forms.CheckBox();
            this.checkDesayuno = new System.Windows.Forms.CheckBox();
            this.checkComida = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHoras = new System.Windows.Forms.Label();
            this.txtHorasViaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorasTrabajo = new System.Windows.Forms.TextBox();
            this.txtTotalDietas = new System.Windows.Forms.TextBox();
            this.txtTotalViajes = new System.Windows.Forms.TextBox();
            this.txtTotalHorasTrabajo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotalSalarioDia
            // 
            this.txtTotalSalarioDia.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalSalarioDia.Location = new System.Drawing.Point(756, 362);
            this.txtTotalSalarioDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalSalarioDia.Name = "txtTotalSalarioDia";
            this.txtTotalSalarioDia.ReadOnly = true;
            this.txtTotalSalarioDia.Size = new System.Drawing.Size(184, 29);
            this.txtTotalSalarioDia.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(56, 362);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 38);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkCena);
            this.groupBox1.Controls.Add(this.checkDesayuno);
            this.groupBox1.Controls.Add(this.checkComida);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(53, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(185, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dietas";
            // 
            // checkCena
            // 
            this.checkCena.AutoSize = true;
            this.checkCena.Location = new System.Drawing.Point(25, 122);
            this.checkCena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkCena.Name = "checkCena";
            this.checkCena.Size = new System.Drawing.Size(64, 25);
            this.checkCena.TabIndex = 14;
            this.checkCena.Text = "Cena";
            this.checkCena.UseVisualStyleBackColor = true;
            this.checkCena.CheckStateChanged += new System.EventHandler(this.checkCena_CheckStateChanged);
            // 
            // checkDesayuno
            // 
            this.checkDesayuno.AutoSize = true;
            this.checkDesayuno.Location = new System.Drawing.Point(25, 44);
            this.checkDesayuno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkDesayuno.Name = "checkDesayuno";
            this.checkDesayuno.Size = new System.Drawing.Size(97, 25);
            this.checkDesayuno.TabIndex = 12;
            this.checkDesayuno.Text = "Desayuno";
            this.checkDesayuno.UseVisualStyleBackColor = true;
            this.checkDesayuno.CheckStateChanged += new System.EventHandler(this.checkDesayuno_CheckStateChanged);
            // 
            // checkComida
            // 
            this.checkComida.AutoSize = true;
            this.checkComida.Location = new System.Drawing.Point(25, 82);
            this.checkComida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkComida.Name = "checkComida";
            this.checkComida.Size = new System.Drawing.Size(82, 25);
            this.checkComida.TabIndex = 13;
            this.checkComida.Text = "Comida";
            this.checkComida.UseVisualStyleBackColor = true;
            this.checkComida.CheckStateChanged += new System.EventHandler(this.checkComida_CheckStateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHoras);
            this.groupBox2.Controls.Add(this.txtHorasViaje);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtKm);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(295, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(309, 169);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Viajes";
            // 
            // txtHoras
            // 
            this.txtHoras.AutoSize = true;
            this.txtHoras.Location = new System.Drawing.Point(23, 115);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(50, 21);
            this.txtHoras.TabIndex = 4;
            this.txtHoras.Text = "Horas";
            // 
            // txtHorasViaje
            // 
            this.txtHorasViaje.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHorasViaje.Location = new System.Drawing.Point(96, 110);
            this.txtHorasViaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHorasViaje.Name = "txtHorasViaje";
            this.txtHorasViaje.Size = new System.Drawing.Size(184, 29);
            this.txtHorasViaje.TabIndex = 3;
            this.txtHorasViaje.Enter += new System.EventHandler(this.txtHorasViaje_Enter);
            this.txtHorasViaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasViaje_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "KM";
            // 
            // txtKm
            // 
            this.txtKm.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKm.Location = new System.Drawing.Point(96, 44);
            this.txtKm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(184, 29);
            this.txtKm.TabIndex = 1;
            this.txtKm.Enter += new System.EventHandler(this.txtKm_Enter);
            this.txtKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtHorasTrabajo);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(658, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(309, 169);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trabajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Horas";
            // 
            // txtHorasTrabajo
            // 
            this.txtHorasTrabajo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHorasTrabajo.Location = new System.Drawing.Point(98, 46);
            this.txtHorasTrabajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHorasTrabajo.Name = "txtHorasTrabajo";
            this.txtHorasTrabajo.Size = new System.Drawing.Size(184, 29);
            this.txtHorasTrabajo.TabIndex = 5;
            this.txtHorasTrabajo.Enter += new System.EventHandler(this.txtHorasTrabajo_Enter);
            this.txtHorasTrabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasTrabajo_KeyPress);
            // 
            // txtTotalDietas
            // 
            this.txtTotalDietas.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalDietas.Location = new System.Drawing.Point(54, 278);
            this.txtTotalDietas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalDietas.Name = "txtTotalDietas";
            this.txtTotalDietas.ReadOnly = true;
            this.txtTotalDietas.Size = new System.Drawing.Size(184, 29);
            this.txtTotalDietas.TabIndex = 6;
            // 
            // txtTotalViajes
            // 
            this.txtTotalViajes.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalViajes.Location = new System.Drawing.Point(391, 278);
            this.txtTotalViajes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalViajes.Name = "txtTotalViajes";
            this.txtTotalViajes.ReadOnly = true;
            this.txtTotalViajes.Size = new System.Drawing.Size(184, 29);
            this.txtTotalViajes.TabIndex = 7;
            // 
            // txtTotalHorasTrabajo
            // 
            this.txtTotalHorasTrabajo.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalHorasTrabajo.Location = new System.Drawing.Point(756, 278);
            this.txtTotalHorasTrabajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalHorasTrabajo.Name = "txtTotalHorasTrabajo";
            this.txtTotalHorasTrabajo.ReadOnly = true;
            this.txtTotalHorasTrabajo.Size = new System.Drawing.Size(184, 29);
            this.txtTotalHorasTrabajo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(620, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "TOTAL";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(245, 362);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 38);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 452);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalHorasTrabajo);
            this.Controls.Add(this.txtTotalViajes);
            this.Controls.Add(this.txtTotalDietas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtTotalSalarioDia);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Cálculo de dietas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtHoras;
        private System.Windows.Forms.TextBox txtHorasViaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorasTrabajo;
        private System.Windows.Forms.TextBox txtTotalDietas;
        private System.Windows.Forms.TextBox txtTotalViajes;
        private System.Windows.Forms.TextBox txtTotalTrabajo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox checkDesayuno;
        private System.Windows.Forms.CheckBox checkComida;
        private System.Windows.Forms.CheckBox checkCena;
        private System.Windows.Forms.TextBox totalSalarioDia;
        private System.Windows.Forms.TextBox txtTotalSalarioDia;
        private System.Windows.Forms.TextBox txtTotalHorasTrabajo;
    }
}

