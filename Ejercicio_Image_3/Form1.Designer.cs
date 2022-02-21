
namespace Ejercicio_Imagen_4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdEstudiant = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdMateri = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtIdEstudiantes = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomMateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDMateria = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAlumnosRegistrados = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rbAlumnosOrdenados = new System.Windows.Forms.RadioButton();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnNotas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 361);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNotas);
            this.tabPage1.Controls.Add(this.dgvNotas);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtIdEstudiant);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtIdMateri);
            this.tabPage1.Controls.Add(this.txtNota);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(552, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NOTAS";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(27, 151);
            this.dgvNotas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.RowHeadersWidth = 62;
            this.dgvNotas.RowTemplate.Height = 28;
            this.dgvNotas.Size = new System.Drawing.Size(490, 154);
            this.dgvNotas.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "ID Estudiante:";
            // 
            // txtIdEstudiant
            // 
            this.txtIdEstudiant.Location = new System.Drawing.Point(123, 32);
            this.txtIdEstudiant.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdEstudiant.Name = "txtIdEstudiant";
            this.txtIdEstudiant.Size = new System.Drawing.Size(145, 20);
            this.txtIdEstudiant.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "ID Materia:";
            // 
            // txtIdMateri
            // 
            this.txtIdMateri.Location = new System.Drawing.Point(123, 72);
            this.txtIdMateri.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdMateri.Name = "txtIdMateri";
            this.txtIdMateri.Size = new System.Drawing.Size(145, 20);
            this.txtIdMateri.TabIndex = 7;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(123, 112);
            this.txtNota.Margin = new System.Windows.Forms.Padding(2);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(145, 20);
            this.txtNota.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nota:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dgvEstudiante);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.txtTelefono);
            this.tabPage2.Controls.Add(this.txtApellido);
            this.tabPage2.Controls.Add(this.txtIdEstudiantes);
            this.tabPage2.Controls.Add(this.txtDireccion);
            this.tabPage2.Controls.Add(this.lblApellido);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(552, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ESTUDIANTE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Location = new System.Drawing.Point(4, 192);
            this.dgvEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.RowHeadersWidth = 62;
            this.dgvEstudiante.RowTemplate.Height = 28;
            this.dgvEstudiante.Size = new System.Drawing.Size(525, 123);
            this.dgvEstudiante.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 33);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(214, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(84, 134);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(101, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(84, 65);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(127, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtIdEstudiantes
            // 
            this.txtIdEstudiantes.Location = new System.Drawing.Point(84, 6);
            this.txtIdEstudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdEstudiantes.Name = "txtIdEstudiantes";
            this.txtIdEstudiantes.Size = new System.Drawing.Size(145, 20);
            this.txtIdEstudiantes.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(84, 97);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(120, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 68);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Estudiante:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.dgvMateria);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.txtNomMateria);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.txtIDMateria);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(552, 335);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "MATERIAS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvMateria
            // 
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Location = new System.Drawing.Point(68, 148);
            this.dgvMateria.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.RowHeadersWidth = 62;
            this.dgvMateria.RowTemplate.Height = 28;
            this.dgvMateria.Size = new System.Drawing.Size(345, 118);
            this.dgvMateria.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Materia:";
            // 
            // txtNomMateria
            // 
            this.txtNomMateria.Location = new System.Drawing.Point(140, 71);
            this.txtNomMateria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomMateria.Name = "txtNomMateria";
            this.txtNomMateria.Size = new System.Drawing.Size(211, 20);
            this.txtNomMateria.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Materia:";
            // 
            // txtIDMateria
            // 
            this.txtIDMateria.Location = new System.Drawing.Point(140, 42);
            this.txtIDMateria.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDMateria.Name = "txtIDMateria";
            this.txtIDMateria.Size = new System.Drawing.Size(98, 20);
            this.txtIDMateria.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.txtConsulta);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(552, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CONSULTA";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAlumnosRegistrados);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.rbAlumnosOrdenados);
            this.groupBox1.Location = new System.Drawing.Point(30, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(425, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONSULTAS";
            // 
            // rbAlumnosRegistrados
            // 
            this.rbAlumnosRegistrados.AutoSize = true;
            this.rbAlumnosRegistrados.Location = new System.Drawing.Point(22, 34);
            this.rbAlumnosRegistrados.Margin = new System.Windows.Forms.Padding(2);
            this.rbAlumnosRegistrados.Name = "rbAlumnosRegistrados";
            this.rbAlumnosRegistrados.Size = new System.Drawing.Size(124, 17);
            this.rbAlumnosRegistrados.TabIndex = 4;
            this.rbAlumnosRegistrados.TabStop = true;
            this.rbAlumnosRegistrados.Text = "Alumnos Registrados";
            this.rbAlumnosRegistrados.UseVisualStyleBackColor = true;
            this.rbAlumnosRegistrados.CheckedChanged += new System.EventHandler(this.rbAlumnosRegistrados_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(334, 34);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Materias";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbAlumnosOrdenados
            // 
            this.rbAlumnosOrdenados.AutoSize = true;
            this.rbAlumnosOrdenados.Location = new System.Drawing.Point(180, 34);
            this.rbAlumnosOrdenados.Margin = new System.Windows.Forms.Padding(2);
            this.rbAlumnosOrdenados.Name = "rbAlumnosOrdenados";
            this.rbAlumnosOrdenados.Size = new System.Drawing.Size(118, 17);
            this.rbAlumnosOrdenados.TabIndex = 1;
            this.rbAlumnosOrdenados.TabStop = true;
            this.rbAlumnosOrdenados.Text = "Alumnos ordenados";
            this.rbAlumnosOrdenados.UseVisualStyleBackColor = true;
            this.rbAlumnosOrdenados.CheckedChanged += new System.EventHandler(this.rbAlumnosOrdenados_CheckedChanged);
            // 
            // txtConsulta
            // 
            this.txtConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsulta.Location = new System.Drawing.Point(30, 148);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(447, 109);
            this.txtConsulta.TabIndex = 0;
            // 
            // btnNotas
            // 
            this.btnNotas.Location = new System.Drawing.Point(299, 107);
            this.btnNotas.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(115, 29);
            this.btnNotas.TabIndex = 14;
            this.btnNotas.Text = "INGRESAR";
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 129);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "INGRESAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 106);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "INGRESAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 400);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomMateria;
        private System.Windows.Forms.TextBox txtIDMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdEstudiantes;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAlumnosRegistrados;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rbAlumnosOrdenados;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdMateri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdEstudiant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

