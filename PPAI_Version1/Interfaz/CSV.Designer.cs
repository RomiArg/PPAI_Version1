namespace PPAI_Version1
{
    partial class CSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgwLlamada = new System.Windows.Forms.DataGridView();
            this.dgwPreguntas = new System.Windows.Forms.DataGridView();
            this.Llamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionLlamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEncuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preguntas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RespuestaSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLlamada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPreguntas)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dgwLlamada);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgwPreguntas);
            this.splitContainer1.Size = new System.Drawing.Size(794, 441);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgwLlamada
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwLlamada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwLlamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLlamada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Llamada,
            this.NombreCliente,
            this.EstadoActual,
            this.DuracionLlamada,
            this.DescripcionEncuesta});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwLlamada.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwLlamada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwLlamada.Location = new System.Drawing.Point(0, 0);
            this.dgwLlamada.Name = "dgwLlamada";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwLlamada.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwLlamada.Size = new System.Drawing.Size(794, 115);
            this.dgwLlamada.TabIndex = 1;
            // 
            // dgwPreguntas
            // 
            this.dgwPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Preguntas,
            this.RespuestaSeleccionada});
            this.dgwPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPreguntas.Location = new System.Drawing.Point(0, 0);
            this.dgwPreguntas.Name = "dgwPreguntas";
            this.dgwPreguntas.Size = new System.Drawing.Size(794, 322);
            this.dgwPreguntas.TabIndex = 0;
            // 
            // Llamada
            // 
            this.Llamada.HeaderText = "Llamada";
            this.Llamada.Name = "Llamada";
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre del Cliente";
            this.NombreCliente.Name = "NombreCliente";
            // 
            // EstadoActual
            // 
            this.EstadoActual.HeaderText = "Estado Actual de la Llamada";
            this.EstadoActual.Name = "EstadoActual";
            // 
            // DuracionLlamada
            // 
            this.DuracionLlamada.HeaderText = "Duración de la Llamada";
            this.DuracionLlamada.Name = "DuracionLlamada";
            // 
            // DescripcionEncuesta
            // 
            this.DescripcionEncuesta.HeaderText = "Descripcion Encuesta";
            this.DescripcionEncuesta.Name = "DescripcionEncuesta";
            // 
            // Preguntas
            // 
            this.Preguntas.HeaderText = "Preguntas";
            this.Preguntas.Name = "Preguntas";
            this.Preguntas.Width = 380;
            // 
            // RespuestaSeleccionada
            // 
            this.RespuestaSeleccionada.HeaderText = "Respuesta Seleccionada";
            this.RespuestaSeleccionada.Name = "RespuestaSeleccionada";
            this.RespuestaSeleccionada.Width = 260;
            // 
            // CSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 441);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encuesta.csv";
            this.Load += new System.EventHandler(this.CSV_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLlamada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPreguntas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgwLlamada;
        private System.Windows.Forms.DataGridView dgwPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionLlamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEncuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn RespuestaSeleccionada;
    }
}