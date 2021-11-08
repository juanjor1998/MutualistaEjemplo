namespace Obligatorio1.Presentacion
{
    partial class Estadisticas
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
            unForm = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEspecialidadMax = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstConsultas = new System.Windows.Forms.ListBox();
            this.btnConsulta_Socio = new System.Windows.Forms.Button();
            this.lstSocios2 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSocios1 = new System.Windows.Forms.ListBox();
            this.btnSocio_Especialidad = new System.Windows.Forms.Button();
            this.lstEspecialidades = new System.Windows.Forms.ListBox();
            this.lstEspsMax = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecargar);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(12, 419);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(75, 23);
            this.btnRecargar.TabIndex = 3;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstEspsMax);
            this.groupBox4.Controls.Add(this.btnEspecialidadMax);
            this.groupBox4.Location = new System.Drawing.Point(12, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(613, 110);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Especialidad con Mas Consultas";
            // 
            // btnEspecialidadMax
            // 
            this.btnEspecialidadMax.Location = new System.Drawing.Point(7, 20);
            this.btnEspecialidadMax.Name = "btnEspecialidadMax";
            this.btnEspecialidadMax.Size = new System.Drawing.Size(75, 23);
            this.btnEspecialidadMax.TabIndex = 0;
            this.btnEspecialidadMax.Text = "Buscar";
            this.btnEspecialidadMax.UseVisualStyleBackColor = true;
            this.btnEspecialidadMax.Click += new System.EventHandler(this.btnEspecialidadMax_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lstConsultas);
            this.groupBox3.Controls.Add(this.btnConsulta_Socio);
            this.groupBox3.Controls.Add(this.lstSocios2);
            this.groupBox3.Location = new System.Drawing.Point(12, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 135);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mostrar Consultas de un Socio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Consultas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Socio";
            // 
            // lstConsultas
            // 
            this.lstConsultas.FormattingEnabled = true;
            this.lstConsultas.Location = new System.Drawing.Point(353, 46);
            this.lstConsultas.Name = "lstConsultas";
            this.lstConsultas.Size = new System.Drawing.Size(254, 82);
            this.lstConsultas.TabIndex = 2;
            // 
            // btnConsulta_Socio
            // 
            this.btnConsulta_Socio.Location = new System.Drawing.Point(272, 46);
            this.btnConsulta_Socio.Name = "btnConsulta_Socio";
            this.btnConsulta_Socio.Size = new System.Drawing.Size(75, 82);
            this.btnConsulta_Socio.TabIndex = 1;
            this.btnConsulta_Socio.Text = "Buscar";
            this.btnConsulta_Socio.UseVisualStyleBackColor = true;
            this.btnConsulta_Socio.Click += new System.EventHandler(this.btnConsulta_Socio_Click);
            // 
            // lstSocios2
            // 
            this.lstSocios2.FormattingEnabled = true;
            this.lstSocios2.Location = new System.Drawing.Point(7, 46);
            this.lstSocios2.Name = "lstSocios2";
            this.lstSocios2.Size = new System.Drawing.Size(259, 82);
            this.lstSocios2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lstSocios1);
            this.groupBox2.Controls.Add(this.btnSocio_Especialidad);
            this.groupBox2.Controls.Add(this.lstEspecialidades);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 136);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mostrar Socios que se consultaron por una Especialidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Socios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Especialidad";
            // 
            // lstSocios1
            // 
            this.lstSocios1.FormattingEnabled = true;
            this.lstSocios1.Location = new System.Drawing.Point(353, 46);
            this.lstSocios1.Name = "lstSocios1";
            this.lstSocios1.Size = new System.Drawing.Size(254, 82);
            this.lstSocios1.TabIndex = 2;
            // 
            // btnSocio_Especialidad
            // 
            this.btnSocio_Especialidad.Location = new System.Drawing.Point(272, 46);
            this.btnSocio_Especialidad.Name = "btnSocio_Especialidad";
            this.btnSocio_Especialidad.Size = new System.Drawing.Size(75, 82);
            this.btnSocio_Especialidad.TabIndex = 1;
            this.btnSocio_Especialidad.Text = "Buscar";
            this.btnSocio_Especialidad.UseVisualStyleBackColor = true;
            this.btnSocio_Especialidad.Click += new System.EventHandler(this.btnSocio_Especialidad_Click);
            // 
            // lstEspecialidades
            // 
            this.lstEspecialidades.FormattingEnabled = true;
            this.lstEspecialidades.Location = new System.Drawing.Point(7, 46);
            this.lstEspecialidades.Name = "lstEspecialidades";
            this.lstEspecialidades.Size = new System.Drawing.Size(259, 82);
            this.lstEspecialidades.TabIndex = 0;
            // 
            // lstEspsMax
            // 
            this.lstEspsMax.FormattingEnabled = true;
            this.lstEspsMax.Location = new System.Drawing.Point(100, 20);
            this.lstEspsMax.Name = "lstEspsMax";
            this.lstEspsMax.Size = new System.Drawing.Size(193, 82);
            this.lstEspsMax.TabIndex = 1;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 477);
            this.Controls.Add(this.groupBox1);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstEspecialidades;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEspecialidadMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstConsultas;
        private System.Windows.Forms.Button btnConsulta_Socio;
        private System.Windows.Forms.ListBox lstSocios2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSocios1;
        private System.Windows.Forms.Button btnSocio_Especialidad;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.ListBox lstEspsMax;
    }
}