namespace Rutinero
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
            this.label5 = new System.Windows.Forms.Label();
            this.Imprimir = new System.Windows.Forms.Button();
            this.dgvRutina = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Quitar = new System.Windows.Forms.Button();
            this.Rutina = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.crearEjercicios = new System.Windows.Forms.Button();
            this.Ejercicios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ejercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Codigo";
            // 
            // Imprimir
            // 
            this.Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir.Location = new System.Drawing.Point(422, 665);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(98, 37);
            this.Imprimir.TabIndex = 22;
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.UseVisualStyleBackColor = true;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // dgvRutina
            // 
            this.dgvRutina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutina.Location = new System.Drawing.Point(12, 144);
            this.dgvRutina.Name = "dgvRutina";
            this.dgvRutina.Size = new System.Drawing.Size(508, 514);
            this.dgvRutina.TabIndex = 21;
            this.dgvRutina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutina_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nombre";
            // 
            // Quitar
            // 
            this.Quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitar.Location = new System.Drawing.Point(422, 90);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(98, 37);
            this.Quitar.TabIndex = 18;
            this.Quitar.Text = "Quitar";
            this.Quitar.UseVisualStyleBackColor = true;
            this.Quitar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // Rutina
            // 
            this.Rutina.AutoSize = true;
            this.Rutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rutina.Location = new System.Drawing.Point(12, 116);
            this.Rutina.Name = "Rutina";
            this.Rutina.Size = new System.Drawing.Size(74, 25);
            this.Rutina.TabIndex = 27;
            this.Rutina.Text = "Rutina";
            // 
            // Agregar
            // 
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.Location = new System.Drawing.Point(422, 47);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(98, 37);
            this.Agregar.TabIndex = 28;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // cmbNombre
            // 
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(12, 90);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(165, 21);
            this.cmbNombre.TabIndex = 29;
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbNombre_SelectedIndexChanged);
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(215, 90);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(163, 21);
            this.cmbCodigo.TabIndex = 30;
            this.cmbCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbCodigo_SelectedIndexChanged);
            // 
            // crearEjercicios
            // 
            this.crearEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearEjercicios.Location = new System.Drawing.Point(12, 12);
            this.crearEjercicios.Name = "crearEjercicios";
            this.crearEjercicios.Size = new System.Drawing.Size(173, 37);
            this.crearEjercicios.TabIndex = 31;
            this.crearEjercicios.Text = "Crear Ejercicios";
            this.crearEjercicios.UseVisualStyleBackColor = true;
            this.crearEjercicios.Click += new System.EventHandler(this.crearEjercicios_Click);
            // 
            // Ejercicios
            // 
            this.Ejercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ejercicios.Location = new System.Drawing.Point(560, 47);
            this.Ejercicios.Name = "Ejercicios";
            this.Ejercicios.Size = new System.Drawing.Size(430, 655);
            this.Ejercicios.TabIndex = 32;
            this.Ejercicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ejercicios_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ejercicios";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 714);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ejercicios);
            this.Controls.Add(this.crearEjercicios);
            this.Controls.Add(this.cmbCodigo);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Rutina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.dgvRutina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Quitar);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ejercicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.DataGridView dgvRutina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.Label Rutina;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Button crearEjercicios;
        private System.Windows.Forms.DataGridView Ejercicios;
        private System.Windows.Forms.Label label1;
    }
}