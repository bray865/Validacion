namespace ValidarMatricula
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNivelEstudios = new System.Windows.Forms.TextBox();
            this.txtPeriodoIngreso = new System.Windows.Forms.TextBox();
            this.txtAñoIngreso = new System.Windows.Forms.TextBox();
            this.txtGeneracion = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtNumeroConsecutivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa tu matrícula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(192, 24);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(156, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(354, 22);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nivel de estudios:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Periodo de ingreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Año de ingreso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Generación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Carrera:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Número consecutivo:";
            // 
            // txtNivelEstudios
            // 
            this.txtNivelEstudios.Location = new System.Drawing.Point(192, 72);
            this.txtNivelEstudios.Name = "txtNivelEstudios";
            this.txtNivelEstudios.Size = new System.Drawing.Size(156, 20);
            this.txtNivelEstudios.TabIndex = 9;
            // 
            // txtPeriodoIngreso
            // 
            this.txtPeriodoIngreso.Location = new System.Drawing.Point(192, 124);
            this.txtPeriodoIngreso.Name = "txtPeriodoIngreso";
            this.txtPeriodoIngreso.Size = new System.Drawing.Size(156, 20);
            this.txtPeriodoIngreso.TabIndex = 10;
            // 
            // txtAñoIngreso
            // 
            this.txtAñoIngreso.Location = new System.Drawing.Point(192, 173);
            this.txtAñoIngreso.Name = "txtAñoIngreso";
            this.txtAñoIngreso.Size = new System.Drawing.Size(156, 20);
            this.txtAñoIngreso.TabIndex = 11;
            // 
            // txtGeneracion
            // 
            this.txtGeneracion.Location = new System.Drawing.Point(192, 228);
            this.txtGeneracion.Name = "txtGeneracion";
            this.txtGeneracion.Size = new System.Drawing.Size(156, 20);
            this.txtGeneracion.TabIndex = 12;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(192, 288);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(156, 20);
            this.txtCarrera.TabIndex = 13;
            // 
            // txtNumeroConsecutivo
            // 
            this.txtNumeroConsecutivo.Location = new System.Drawing.Point(192, 345);
            this.txtNumeroConsecutivo.Name = "txtNumeroConsecutivo";
            this.txtNumeroConsecutivo.Size = new System.Drawing.Size(156, 20);
            this.txtNumeroConsecutivo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.txtNumeroConsecutivo);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtGeneracion);
            this.Controls.Add(this.txtAñoIngreso);
            this.Controls.Add(this.txtPeriodoIngreso);
            this.Controls.Add(this.txtNivelEstudios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNivelEstudios;
        private System.Windows.Forms.TextBox txtPeriodoIngreso;
        private System.Windows.Forms.TextBox txtAñoIngreso;
        private System.Windows.Forms.TextBox txtGeneracion;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtNumeroConsecutivo;
    }
}

