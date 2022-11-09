namespace PPAI.Forms
{
    partial class PantallaRegistrarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistrarReserva));
            this.btn_cerrar_programa = new System.Windows.Forms.Button();
            this.dgTiposRT = new System.Windows.Forms.DataGridView();
            this.nombreTipoRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_mostrar_rt = new System.Windows.Forms.Button();
            this.dg_rt = new System.Windows.Forms.DataGridView();
            this.CentroInvestigacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeleccionadoRT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_seleccionar_rt = new System.Windows.Forms.Button();
            this.dg_turno = new System.Windows.Forms.DataGridView();
            this.fechaHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeleccionTurnos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.dg_fecha = new System.Windows.Forms.DataGridView();
            this.FechaTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaTurnoSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_seleccionar_fecha = new System.Windows.Forms.Button();
            this.btn_seleccionar_turno = new System.Windows.Forms.Button();
            this.chk_notificacionWhatsapp = new System.Windows.Forms.CheckBox();
            this.chk_notificacionEmail = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTiposRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_turno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_fecha)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_programa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_programa.BackgroundImage")));
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(1250, 12);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(41, 41);
            this.btn_cerrar_programa.TabIndex = 9;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // dgTiposRT
            // 
            this.dgTiposRT.AllowUserToAddRows = false;
            this.dgTiposRT.AllowUserToDeleteRows = false;
            this.dgTiposRT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTiposRT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreTipoRT,
            this.seleccionado});
            this.dgTiposRT.Location = new System.Drawing.Point(12, 12);
            this.dgTiposRT.Name = "dgTiposRT";
            this.dgTiposRT.Size = new System.Drawing.Size(403, 150);
            this.dgTiposRT.TabIndex = 10;
            // 
            // nombreTipoRT
            // 
            this.nombreTipoRT.HeaderText = "Nombre Tipo RT";
            this.nombreTipoRT.Name = "nombreTipoRT";
            this.nombreTipoRT.Width = 280;
            // 
            // seleccionado
            // 
            this.seleccionado.HeaderText = "Seleccionado";
            this.seleccionado.Name = "seleccionado";
            this.seleccionado.Width = 80;
            // 
            // btn_mostrar_rt
            // 
            this.btn_mostrar_rt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar_rt.Location = new System.Drawing.Point(421, 129);
            this.btn_mostrar_rt.Name = "btn_mostrar_rt";
            this.btn_mostrar_rt.Size = new System.Drawing.Size(184, 33);
            this.btn_mostrar_rt.TabIndex = 11;
            this.btn_mostrar_rt.Text = "Mostrar Recursos Tecnologicos";
            this.btn_mostrar_rt.UseVisualStyleBackColor = true;
            this.btn_mostrar_rt.Click += new System.EventHandler(this.btn_mostrar_rt_Click);
            // 
            // dg_rt
            // 
            this.dg_rt.AllowUserToAddRows = false;
            this.dg_rt.AllowUserToDeleteRows = false;
            this.dg_rt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CentroInvestigacion,
            this.nroInventario,
            this.marca,
            this.modelo,
            this.estado,
            this.SeleccionadoRT});
            this.dg_rt.Location = new System.Drawing.Point(12, 183);
            this.dg_rt.Name = "dg_rt";
            this.dg_rt.Size = new System.Drawing.Size(849, 161);
            this.dg_rt.TabIndex = 12;
            // 
            // CentroInvestigacion
            // 
            this.CentroInvestigacion.HeaderText = "Centro de investigación";
            this.CentroInvestigacion.Name = "CentroInvestigacion";
            this.CentroInvestigacion.ReadOnly = true;
            this.CentroInvestigacion.Width = 200;
            // 
            // nroInventario
            // 
            this.nroInventario.HeaderText = "Numero inventario";
            this.nroInventario.Name = "nroInventario";
            this.nroInventario.ReadOnly = true;
            this.nroInventario.Width = 75;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 210;
            // 
            // SeleccionadoRT
            // 
            this.SeleccionadoRT.HeaderText = "Seleccionado";
            this.SeleccionadoRT.Name = "SeleccionadoRT";
            // 
            // btn_seleccionar_rt
            // 
            this.btn_seleccionar_rt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar_rt.Location = new System.Drawing.Point(867, 309);
            this.btn_seleccionar_rt.Name = "btn_seleccionar_rt";
            this.btn_seleccionar_rt.Size = new System.Drawing.Size(311, 35);
            this.btn_seleccionar_rt.TabIndex = 11;
            this.btn_seleccionar_rt.Text = "Seleccionar Recurso Tecnológico";
            this.btn_seleccionar_rt.UseVisualStyleBackColor = true;
            this.btn_seleccionar_rt.Click += new System.EventHandler(this.btn_seleccionar_rt_Click);
            // 
            // dg_turno
            // 
            this.dg_turno.AllowUserToAddRows = false;
            this.dg_turno.AllowUserToDeleteRows = false;
            this.dg_turno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_turno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaHoraInicio,
            this.fechaHoraFin,
            this.estadoTurno,
            this.SeleccionTurnos});
            this.dg_turno.Location = new System.Drawing.Point(421, 372);
            this.dg_turno.Name = "dg_turno";
            this.dg_turno.Size = new System.Drawing.Size(567, 196);
            this.dg_turno.TabIndex = 13;
            // 
            // fechaHoraInicio
            // 
            this.fechaHoraInicio.HeaderText = "Hora de inicio";
            this.fechaHoraInicio.Name = "fechaHoraInicio";
            // 
            // fechaHoraFin
            // 
            this.fechaHoraFin.HeaderText = "Hora de fin";
            this.fechaHoraFin.Name = "fechaHoraFin";
            // 
            // estadoTurno
            // 
            this.estadoTurno.HeaderText = "Estado";
            this.estadoTurno.Name = "estadoTurno";
            this.estadoTurno.Width = 210;
            // 
            // SeleccionTurnos
            // 
            this.SeleccionTurnos.HeaderText = "Seleccionado";
            this.SeleccionTurnos.Name = "SeleccionTurnos";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Location = new System.Drawing.Point(1107, 695);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(184, 36);
            this.btn_confirmar.TabIndex = 11;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // dg_fecha
            // 
            this.dg_fecha.AllowUserToAddRows = false;
            this.dg_fecha.AllowUserToDeleteRows = false;
            this.dg_fecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_fecha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaTurno,
            this.FechaTurnoSeleccion});
            this.dg_fecha.Location = new System.Drawing.Point(12, 372);
            this.dg_fecha.Name = "dg_fecha";
            this.dg_fecha.Size = new System.Drawing.Size(363, 196);
            this.dg_fecha.TabIndex = 14;
            // 
            // FechaTurno
            // 
            this.FechaTurno.HeaderText = "Fecha";
            this.FechaTurno.Name = "FechaTurno";
            this.FechaTurno.Width = 200;
            // 
            // FechaTurnoSeleccion
            // 
            this.FechaTurnoSeleccion.HeaderText = "Seleccionada";
            this.FechaTurnoSeleccion.Name = "FechaTurnoSeleccion";
            // 
            // btn_seleccionar_fecha
            // 
            this.btn_seleccionar_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar_fecha.Location = new System.Drawing.Point(12, 586);
            this.btn_seleccionar_fecha.Name = "btn_seleccionar_fecha";
            this.btn_seleccionar_fecha.Size = new System.Drawing.Size(184, 35);
            this.btn_seleccionar_fecha.TabIndex = 15;
            this.btn_seleccionar_fecha.Text = "Seleccionar Fecha";
            this.btn_seleccionar_fecha.UseVisualStyleBackColor = true;
            this.btn_seleccionar_fecha.Click += new System.EventHandler(this.btn_seleccionar_fecha_Click);
            // 
            // btn_seleccionar_turno
            // 
            this.btn_seleccionar_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar_turno.Location = new System.Drawing.Point(421, 586);
            this.btn_seleccionar_turno.Name = "btn_seleccionar_turno";
            this.btn_seleccionar_turno.Size = new System.Drawing.Size(184, 35);
            this.btn_seleccionar_turno.TabIndex = 16;
            this.btn_seleccionar_turno.Text = "Seleccionar Turno";
            this.btn_seleccionar_turno.UseVisualStyleBackColor = true;
            this.btn_seleccionar_turno.Click += new System.EventHandler(this.btn_seleccionar_turno_Click);
            // 
            // chk_notificacionWhatsapp
            // 
            this.chk_notificacionWhatsapp.AutoSize = true;
            this.chk_notificacionWhatsapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_notificacionWhatsapp.ForeColor = System.Drawing.SystemColors.Control;
            this.chk_notificacionWhatsapp.Location = new System.Drawing.Point(318, 31);
            this.chk_notificacionWhatsapp.Name = "chk_notificacionWhatsapp";
            this.chk_notificacionWhatsapp.Size = new System.Drawing.Size(285, 29);
            this.chk_notificacionWhatsapp.TabIndex = 18;
            this.chk_notificacionWhatsapp.Text = "Notificacion por WhatsApp";
            this.chk_notificacionWhatsapp.UseVisualStyleBackColor = true;
            // 
            // chk_notificacionEmail
            // 
            this.chk_notificacionEmail.AutoSize = true;
            this.chk_notificacionEmail.Checked = true;
            this.chk_notificacionEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_notificacionEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_notificacionEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.chk_notificacionEmail.Location = new System.Drawing.Point(20, 31);
            this.chk_notificacionEmail.Name = "chk_notificacionEmail";
            this.chk_notificacionEmail.Size = new System.Drawing.Size(237, 29);
            this.chk_notificacionEmail.TabIndex = 17;
            this.chk_notificacionEmail.Text = "Notificacion por email";
            this.chk_notificacionEmail.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_notificacionEmail);
            this.groupBox1.Controls.Add(this.chk_notificacionWhatsapp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 652);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 79);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione método de notificación";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(916, 695);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(184, 36);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // PantallaRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1320, 789);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_seleccionar_turno);
            this.Controls.Add(this.btn_seleccionar_fecha);
            this.Controls.Add(this.dg_fecha);
            this.Controls.Add(this.dg_turno);
            this.Controls.Add(this.dg_rt);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_seleccionar_rt);
            this.Controls.Add(this.btn_mostrar_rt);
            this.Controls.Add(this.dgTiposRT);
            this.Controls.Add(this.btn_cerrar_programa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaRegistrarReserva";
            this.Text = "PantallaRegistrarReserva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaRegistrarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTiposRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_turno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_fecha)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar_programa;
        private System.Windows.Forms.DataGridView dgTiposRT;
        private System.Windows.Forms.Button btn_mostrar_rt;
        private System.Windows.Forms.DataGridView dg_rt;
        private System.Windows.Forms.Button btn_seleccionar_rt;
        private System.Windows.Forms.DataGridView dg_turno;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTipoRT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroInvestigacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionadoRT;
        private System.Windows.Forms.DataGridView dg_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaTurno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FechaTurnoSeleccion;
        private System.Windows.Forms.Button btn_seleccionar_fecha;
        private System.Windows.Forms.Button btn_seleccionar_turno;
        private System.Windows.Forms.CheckBox chk_notificacionWhatsapp;
        private System.Windows.Forms.CheckBox chk_notificacionEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoTurno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionTurnos;
        private System.Windows.Forms.Button btn_cancelar;
    }
}