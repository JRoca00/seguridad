
namespace Capa_vista
{
    partial class AsignacionAplicacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtIdAplicacion = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtImprimir = new System.Windows.Forms.TextBox();
            this.chBoxImprimir = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.chBoxBuscar = new System.Windows.Forms.CheckBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.chBoxEliminar = new System.Windows.Forms.CheckBox();
            this.txtModificar = new System.Windows.Forms.TextBox();
            this.chBoxModificar = new System.Windows.Forms.CheckBox();
            this.txtGuardar = new System.Windows.Forms.TextBox();
            this.chBoxGuardar = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignacion de Aplicaciones a Usuarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtIdAplicacion);
            this.groupBox1.Controls.Add(this.txtIdUsuario);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(59, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(819, 108);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(709, 14);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 36);
            this.btnNuevo.TabIndex = 41;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtIdAplicacion
            // 
            this.txtIdAplicacion.Location = new System.Drawing.Point(500, 55);
            this.txtIdAplicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdAplicacion.Name = "txtIdAplicacion";
            this.txtIdAplicacion.Size = new System.Drawing.Size(152, 22);
            this.txtIdAplicacion.TabIndex = 40;
            this.txtIdAplicacion.Tag = "fk_id_aplicacion";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(169, 55);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(152, 22);
            this.txtIdUsuario.TabIndex = 39;
            this.txtIdUsuario.Tag = "fk_id_usuario";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(331, 55);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(160, 24);
            this.comboBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aplicaciones";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(768, 15);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 43);
            this.button6.TabIndex = 32;
            this.button6.Text = "Ayuda";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(701, 39);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(87, 36);
            this.btnAll.TabIndex = 9;
            this.btnAll.Text = "Todos";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(808, 439);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 36);
            this.button4.TabIndex = 35;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 337);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(773, 138);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.Tag = "PermisosAplicacionesUsuario";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtImprimir);
            this.groupBox4.Controls.Add(this.chBoxImprimir);
            this.groupBox4.Controls.Add(this.txtBuscar);
            this.groupBox4.Controls.Add(this.chBoxBuscar);
            this.groupBox4.Controls.Add(this.txtEliminar);
            this.groupBox4.Controls.Add(this.chBoxEliminar);
            this.groupBox4.Controls.Add(this.txtModificar);
            this.groupBox4.Controls.Add(this.chBoxModificar);
            this.groupBox4.Controls.Add(this.txtGuardar);
            this.groupBox4.Controls.Add(this.chBoxGuardar);
            this.groupBox4.Controls.Add(this.btnAll);
            this.groupBox4.Location = new System.Drawing.Point(27, 209);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(836, 106);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estado";
            // 
            // txtImprimir
            // 
            this.txtImprimir.Location = new System.Drawing.Point(564, 50);
            this.txtImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImprimir.Name = "txtImprimir";
            this.txtImprimir.Size = new System.Drawing.Size(35, 22);
            this.txtImprimir.TabIndex = 42;
            this.txtImprimir.Tag = "imprimir_permiso";
            // 
            // chBoxImprimir
            // 
            this.chBoxImprimir.AutoSize = true;
            this.chBoxImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxImprimir.Location = new System.Drawing.Point(444, 46);
            this.chBoxImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBoxImprimir.Name = "chBoxImprimir";
            this.chBoxImprimir.Size = new System.Drawing.Size(123, 33);
            this.chBoxImprimir.TabIndex = 5;
            this.chBoxImprimir.Text = "Imprimir";
            this.chBoxImprimir.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(401, 73);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(33, 22);
            this.txtBuscar.TabIndex = 41;
            this.txtBuscar.Tag = "buscar_permiso";
            // 
            // chBoxBuscar
            // 
            this.chBoxBuscar.AutoSize = true;
            this.chBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxBuscar.Location = new System.Drawing.Point(277, 65);
            this.chBoxBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBoxBuscar.Name = "chBoxBuscar";
            this.chBoxBuscar.Size = new System.Drawing.Size(109, 33);
            this.chBoxBuscar.TabIndex = 4;
            this.chBoxBuscar.Text = "Buscar";
            this.chBoxBuscar.UseVisualStyleBackColor = true;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(401, 23);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(33, 22);
            this.txtEliminar.TabIndex = 40;
            this.txtEliminar.Tag = "eliminar_permiso";
            // 
            // chBoxEliminar
            // 
            this.chBoxEliminar.AutoSize = true;
            this.chBoxEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxEliminar.Location = new System.Drawing.Point(277, 23);
            this.chBoxEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBoxEliminar.Name = "chBoxEliminar";
            this.chBoxEliminar.Size = new System.Drawing.Size(123, 33);
            this.chBoxEliminar.TabIndex = 3;
            this.chBoxEliminar.Text = "Eliminar";
            this.chBoxEliminar.UseVisualStyleBackColor = true;
            // 
            // txtModificar
            // 
            this.txtModificar.Location = new System.Drawing.Point(213, 65);
            this.txtModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(37, 22);
            this.txtModificar.TabIndex = 39;
            this.txtModificar.Tag = "modificar_permiso";
            // 
            // chBoxModificar
            // 
            this.chBoxModificar.AutoSize = true;
            this.chBoxModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxModificar.Location = new System.Drawing.Point(76, 65);
            this.chBoxModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBoxModificar.Name = "chBoxModificar";
            this.chBoxModificar.Size = new System.Drawing.Size(134, 33);
            this.chBoxModificar.TabIndex = 2;
            this.chBoxModificar.Text = "Modificar";
            this.chBoxModificar.UseVisualStyleBackColor = true;
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(213, 23);
            this.txtGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(31, 22);
            this.txtGuardar.TabIndex = 38;
            this.txtGuardar.Tag = "guardar_permiso";
            // 
            // chBoxGuardar
            // 
            this.chBoxGuardar.AutoSize = true;
            this.chBoxGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxGuardar.Location = new System.Drawing.Point(76, 23);
            this.chBoxGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBoxGuardar.Name = "chBoxGuardar";
            this.chBoxGuardar.Size = new System.Drawing.Size(122, 33);
            this.chBoxGuardar.TabIndex = 1;
            this.chBoxGuardar.Text = "Guardar";
            this.chBoxGuardar.UseVisualStyleBackColor = true;
            // 
            // AsignacionAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 497);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AsignacionAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsignacionAplicacion";
            this.Load += new System.EventHandler(this.AsignacionAplicacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chBoxImprimir;
        private System.Windows.Forms.CheckBox chBoxBuscar;
        private System.Windows.Forms.CheckBox chBoxEliminar;
        private System.Windows.Forms.CheckBox chBoxModificar;
        private System.Windows.Forms.CheckBox chBoxGuardar;
        private System.Windows.Forms.TextBox txtGuardar;
        private System.Windows.Forms.TextBox txtIdAplicacion;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtModificar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtImprimir;
        private System.Windows.Forms.Button btnNuevo;
    }
}