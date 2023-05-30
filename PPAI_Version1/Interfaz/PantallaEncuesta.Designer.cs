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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblLlamadasEncuesta = new System.Windows.Forms.Label();
            this.dgwLlamadasEncuesta = new System.Windows.Forms.DataGridView();
            this.btnBuscarPeriodo = new System.Windows.Forms.Button();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblBuscarPeriodo = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgwLlamada = new System.Windows.Forms.DataGridView();
            this.dgwPreguntas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGenerarCSV = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.Llamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LlamadaConEcuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEncuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preguntas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LlamadaNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncuestaBool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLlamadasEncuesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLlamada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnImprimir);
            this.splitContainer1.Panel2.Controls.Add(this.btnGenerarCSV);
            this.splitContainer1.Panel2.Controls.Add(this.splitter2);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 641);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.SplitterWidth = 1;
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
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.lblLlamadasEncuesta);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgwLlamadasEncuesta);
            this.splitContainer2.Size = new System.Drawing.Size(694, 224);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 11;
            // 
            // lblLlamadasEncuesta
            // 
            this.lblLlamadasEncuesta.AutoSize = true;
            this.lblLlamadasEncuesta.Font = new System.Drawing.Font("Romance Logic DEMO", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamadasEncuesta.Location = new System.Drawing.Point(265, 5);
            this.lblLlamadasEncuesta.Name = "lblLlamadasEncuesta";
            this.lblLlamadasEncuesta.Size = new System.Drawing.Size(203, 20);
            this.lblLlamadasEncuesta.TabIndex = 0;
            this.lblLlamadasEncuesta.Text = "Llamadas con Encuesta";
            // 
            // dgwLlamadasEncuesta
            // 
            this.dgwLlamadasEncuesta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwLlamadasEncuesta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwLlamadasEncuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLlamadasEncuesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LlamadaNro,
            this.ClienteNombre,
            this.EncuestaBool});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwLlamadasEncuesta.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgwLlamadasEncuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwLlamadasEncuesta.Location = new System.Drawing.Point(0, 0);
            this.dgwLlamadasEncuesta.Name = "dgwLlamadasEncuesta";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwLlamadasEncuesta.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwLlamadasEncuesta.Size = new System.Drawing.Size(694, 198);
            this.dgwLlamadasEncuesta.TabIndex = 4;
            this.dgwLlamadasEncuesta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwLlamadasEncuesta_CellContentClick);
            // 
            // btnBuscarPeriodo
            // 
            this.btnBuscarPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPeriodo.Location = new System.Drawing.Point(274, 183);
            this.btnBuscarPeriodo.Name = "btnBuscarPeriodo";
            this.btnBuscarPeriodo.Size = new System.Drawing.Size(80, 25);
            this.btnBuscarPeriodo.TabIndex = 3;
            this.btnBuscarPeriodo.Text = "Buscar";
            this.btnBuscarPeriodo.UseVisualStyleBackColor = true;
            this.btnBuscarPeriodo.Click += new System.EventHandler(this.btnBuscarPeriodo_Click);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(26, 142);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(93, 18);
            this.lblFechaFin.TabIndex = 7;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(12, 88);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(107, 18);
            this.lblFechaInicio.TabIndex = 6;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // lblBuscarPeriodo
            // 
            this.lblBuscarPeriodo.AutoSize = true;
            this.lblBuscarPeriodo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBuscarPeriodo.Font = new System.Drawing.Font("Romance Logic DEMO", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPeriodo.Location = new System.Drawing.Point(118, 23);
            this.lblBuscarPeriodo.Name = "lblBuscarPeriodo";
            this.lblBuscarPeriodo.Size = new System.Drawing.Size(174, 20);
            this.lblBuscarPeriodo.TabIndex = 5;
            this.lblBuscarPeriodo.Text = "Buscar por Periodo";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.AllowDrop = true;
            this.dtpFechaFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(125, 142);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(248, 22);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.AllowDrop = true;
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(125, 88);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(248, 22);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(390, 224);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgwLlamada);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgwPreguntas);
            this.splitContainer3.Size = new System.Drawing.Size(992, 416);
            this.splitContainer3.SplitterDistance = 69;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 6;
            // 
            // dgwLlamada
            // 
            this.dgwLlamada.AllowUserToAddRows = false;
            this.dgwLlamada.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwLlamada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwLlamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLlamada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LlamadaConEcuesta,
            this.Cliente,
            this.EstadoActual,
            this.Duracion,
            this.DescripcionEncuesta});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwLlamada.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgwLlamada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwLlamada.Location = new System.Drawing.Point(0, 0);
            this.dgwLlamada.Name = "dgwLlamada";
            this.dgwLlamada.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwLlamada.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgwLlamada.Size = new System.Drawing.Size(992, 69);
            this.dgwLlamada.TabIndex = 5;
            // 
            // dgwPreguntas
            // 
            this.dgwPreguntas.AllowUserToAddRows = false;
            this.dgwPreguntas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPreguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgwPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Preguntas,
            this.Respuesta});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwPreguntas.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgwPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPreguntas.Location = new System.Drawing.Point(0, 0);
            this.dgwPreguntas.Name = "dgwPreguntas";
            this.dgwPreguntas.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPreguntas.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgwPreguntas.Size = new System.Drawing.Size(992, 346);
            this.dgwPreguntas.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(999, 332);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(999, 72);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 30);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGenerarCSV
            // 
            this.btnGenerarCSV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerarCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCSV.Location = new System.Drawing.Point(999, 190);
            this.btnGenerarCSV.Name = "btnGenerarCSV";
            this.btnGenerarCSV.Size = new System.Drawing.Size(80, 55);
            this.btnGenerarCSV.TabIndex = 8;
            this.btnGenerarCSV.Text = "Generar CSV";
            this.btnGenerarCSV.UseVisualStyleBackColor = true;
            this.btnGenerarCSV.Click += new System.EventHandler(this.btnGenerarCSV_Click);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(992, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(92, 416);
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
            // LlamadaConEcuesta
            // 
            this.LlamadaConEcuesta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.LlamadaConEcuesta.DefaultCellStyle = dataGridViewCellStyle8;
            this.LlamadaConEcuesta.HeaderText = "Llamada";
            this.LlamadaConEcuesta.Name = "LlamadaConEcuesta";
            this.LlamadaConEcuesta.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Cliente.DefaultCellStyle = dataGridViewCellStyle9;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // EstadoActual
            // 
            this.EstadoActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.EstadoActual.DefaultCellStyle = dataGridViewCellStyle10;
            this.EstadoActual.HeaderText = "Estado";
            this.EstadoActual.Name = "EstadoActual";
            this.EstadoActual.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Duracion.DefaultCellStyle = dataGridViewCellStyle11;
            this.Duracion.HeaderText = "Duración (Minutos)";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // DescripcionEncuesta
            // 
            this.DescripcionEncuesta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DescripcionEncuesta.DefaultCellStyle = dataGridViewCellStyle12;
            this.DescripcionEncuesta.HeaderText = "Descripción de la Encuesta";
            this.DescripcionEncuesta.Name = "DescripcionEncuesta";
            this.DescripcionEncuesta.ReadOnly = true;
            // 
            // Preguntas
            // 
            this.Preguntas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Preguntas.HeaderText = "Preguntas";
            this.Preguntas.Name = "Preguntas";
            this.Preguntas.ReadOnly = true;
            // 
            // Respuesta
            // 
            this.Respuesta.HeaderText = "Respuestas Seleccionadas";
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.ReadOnly = true;
            this.Respuesta.Width = 280;
            // 
            // LlamadaNro
            // 
            this.LlamadaNro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.LlamadaNro.DefaultCellStyle = dataGridViewCellStyle2;
            this.LlamadaNro.HeaderText = "Llamada";
            this.LlamadaNro.Name = "LlamadaNro";
            // 
            // ClienteNombre
            // 
            this.ClienteNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ClienteNombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClienteNombre.HeaderText = "Cliente";
            this.ClienteNombre.Name = "ClienteNombre";
            // 
            // EncuestaBool
            // 
            this.EncuestaBool.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.EncuestaBool.DefaultCellStyle = dataGridViewCellStyle4;
            this.EncuestaBool.HeaderText = "Encuesta Enviada";
            this.EncuestaBool.Name = "EncuestaBool";
            // 
            // PantallaEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1084, 641);
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
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLlamada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPreguntas)).EndInit();
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
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerarCSV;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente1;
        private System.Windows.Forms.DataGridView dgwPreguntas;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlamadaConEcuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEncuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlamadaNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncuestaBool;
    }

}

