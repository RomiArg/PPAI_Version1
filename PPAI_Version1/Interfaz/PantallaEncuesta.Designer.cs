namespace PPAI_Version1
{
    partial class PantallaEncuesta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblLlamadasEncuesta = new System.Windows.Forms.Label();
            this.dgwLlamadasEncuesta = new System.Windows.Forms.DataGridView();
            this.LlamadaNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncuestaBool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarPeriodo = new System.Windows.Forms.Button();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblBuscarPeriodo = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGenerarCSV = new System.Windows.Forms.Button();
            this.dgwLlamada = new System.Windows.Forms.DataGridView();
            this.LlamadaConEcuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEncuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RespuestasCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.Llamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLlamadasEncuesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLlamada)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscarPeriodo);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaFin);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaInicio);
            this.splitContainer1.Panel1.Controls.Add(this.lblBuscarPeriodo);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaFin);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaInicio);
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnImprimir);
            this.splitContainer1.Panel2.Controls.Add(this.btnGenerarCSV);
            this.splitContainer1.Panel2.Controls.Add(this.dgwLlamada);
            this.splitContainer1.Panel2.Controls.Add(this.splitter2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 546);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(390, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblLlamadasEncuesta);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgwLlamadasEncuesta);
            this.splitContainer2.Size = new System.Drawing.Size(410, 229);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 11;
            // 
            // lblLlamadasEncuesta
            // 
            this.lblLlamadasEncuesta.AutoSize = true;
            this.lblLlamadasEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamadasEncuesta.Location = new System.Drawing.Point(18, 3);
            this.lblLlamadasEncuesta.Name = "lblLlamadasEncuesta";
            this.lblLlamadasEncuesta.Size = new System.Drawing.Size(180, 20);
            this.lblLlamadasEncuesta.TabIndex = 0;
            this.lblLlamadasEncuesta.Text = "Llamadas con Encuesta";
            // 
            // dgwLlamadasEncuesta
            // 
            this.dgwLlamadasEncuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLlamadasEncuesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LlamadaNro,
            this.ClienteNombre,
            this.EncuestaBool});
            this.dgwLlamadasEncuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwLlamadasEncuesta.Location = new System.Drawing.Point(0, 0);
            this.dgwLlamadasEncuesta.Name = "dgwLlamadasEncuesta";
            this.dgwLlamadasEncuesta.Size = new System.Drawing.Size(410, 200);
            this.dgwLlamadasEncuesta.TabIndex = 0;
            this.dgwLlamadasEncuesta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwLlamadasEncuesta_CellContentClick);
            // 
            // LlamadaNro
            // 
            this.LlamadaNro.HeaderText = "Llamada";
            this.LlamadaNro.Name = "LlamadaNro";
            // 
            // ClienteNombre
            // 
            this.ClienteNombre.HeaderText = "Cliente";
            this.ClienteNombre.Name = "ClienteNombre";
            // 
            // EncuestaBool
            // 
            this.EncuestaBool.HeaderText = "Encuesta";
            this.EncuestaBool.Name = "EncuestaBool";
            // 
            // btnBuscarPeriodo
            // 
            this.btnBuscarPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPeriodo.Location = new System.Drawing.Point(274, 183);
            this.btnBuscarPeriodo.Name = "btnBuscarPeriodo";
            this.btnBuscarPeriodo.Size = new System.Drawing.Size(80, 25);
            this.btnBuscarPeriodo.TabIndex = 10;
            this.btnBuscarPeriodo.Text = "Buscar";
            this.btnBuscarPeriodo.UseVisualStyleBackColor = true;
            this.btnBuscarPeriodo.Click += new System.EventHandler(this.btnBuscarPeriodo_Click);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(40, 142);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(93, 18);
            this.lblFechaFin.TabIndex = 7;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(25, 88);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(107, 18);
            this.lblFechaInicio.TabIndex = 6;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // lblBuscarPeriodo
            // 
            this.lblBuscarPeriodo.AutoSize = true;
            this.lblBuscarPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPeriodo.Location = new System.Drawing.Point(118, 23);
            this.lblBuscarPeriodo.Name = "lblBuscarPeriodo";
            this.lblBuscarPeriodo.Size = new System.Drawing.Size(144, 20);
            this.lblBuscarPeriodo.TabIndex = 5;
            this.lblBuscarPeriodo.Text = "Buscar por Periodo";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(154, 142);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 4;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(154, 88);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(390, 229);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(715, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(715, 71);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 30);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Implimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGenerarCSV
            // 
            this.btnGenerarCSV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerarCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCSV.Location = new System.Drawing.Point(715, 138);
            this.btnGenerarCSV.Name = "btnGenerarCSV";
            this.btnGenerarCSV.Size = new System.Drawing.Size(80, 55);
            this.btnGenerarCSV.TabIndex = 3;
            this.btnGenerarCSV.Text = "Generar CSV";
            this.btnGenerarCSV.UseVisualStyleBackColor = true;
            this.btnGenerarCSV.Click += new System.EventHandler(this.btnGenerarCSV_Click);
            // 
            // dgwLlamada
            // 
            this.dgwLlamada.AllowUserToDeleteRows = false;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwLlamada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgwLlamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLlamada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LlamadaConEcuesta,
            this.Cliente,
            this.EstadoActual,
            this.Duracion,
            this.DescripcionEncuesta,
            this.Pregunta,
            this.RespuestasCliente});
            this.dgwLlamada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwLlamada.Location = new System.Drawing.Point(0, 0);
            this.dgwLlamada.Name = "dgwLlamada";
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwLlamada.RowHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.dgwLlamada.Size = new System.Drawing.Size(708, 313);
            this.dgwLlamada.TabIndex = 1;
            // 
            // LlamadaConEcuesta
            // 
            this.LlamadaConEcuesta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            this.LlamadaConEcuesta.DefaultCellStyle = dataGridViewCellStyle38;
            this.LlamadaConEcuesta.HeaderText = "Llamada";
            this.LlamadaConEcuesta.Name = "LlamadaConEcuesta";
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cliente.DefaultCellStyle = dataGridViewCellStyle39;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // EstadoActual
            // 
            this.EstadoActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EstadoActual.DefaultCellStyle = dataGridViewCellStyle40;
            this.EstadoActual.HeaderText = "Estado";
            this.EstadoActual.Name = "EstadoActual";
            // 
            // Duracion
            // 
            this.Duracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Duracion.DefaultCellStyle = dataGridViewCellStyle41;
            this.Duracion.HeaderText = "Duración ";
            this.Duracion.Name = "Duracion";
            // 
            // DescripcionEncuesta
            // 
            this.DescripcionEncuesta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DescripcionEncuesta.DefaultCellStyle = dataGridViewCellStyle42;
            this.DescripcionEncuesta.HeaderText = "Descripcion de la Encuesta";
            this.DescripcionEncuesta.Name = "DescripcionEncuesta";
            // 
            // Pregunta
            // 
            this.Pregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Pregunta.DefaultCellStyle = dataGridViewCellStyle43;
            this.Pregunta.HeaderText = "Preguntas";
            this.Pregunta.Name = "Pregunta";
            // 
            // RespuestasCliente
            // 
            this.RespuestasCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.White;
            this.RespuestasCliente.DefaultCellStyle = dataGridViewCellStyle44;
            this.RespuestasCliente.HeaderText = "Respuestas seleccionadas del Cliente";
            this.RespuestasCliente.Name = "RespuestasCliente";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(708, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(92, 313);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // Llamada
            // 
            this.Llamada.HeaderText = "Llamadas";
            this.Llamada.Name = "Llamada";
            // 
            // Cliente1
            // 
            this.Cliente1.HeaderText = "Cliente";
            this.Cliente1.Name = "Cliente1";
            // 
            // PantallaEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PantallaEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Encuestas";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLlamadasEncuesta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLlamada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblBuscarPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblLlamadasEncuesta;
        private System.Windows.Forms.DataGridView dgwLlamadasEncuesta;
        private System.Windows.Forms.Button btnBuscarPeriodo;
        private System.Windows.Forms.DataGridView dgwLlamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encuesta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlamadaConEcuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEncuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn RespuestasCliente;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerarCSV;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlamadaNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncuestaBool;
    }

}

