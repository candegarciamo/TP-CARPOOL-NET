namespace Localidad_winForm
{
    partial class Localidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Localidades));
            toolStripLocalidad = new ToolStripContainer();
            tlLocalidad = new TableLayoutPanel();
            dgvLocalidad = new DataGridView();
            btnActualizar = new Button();
            btnSalir = new Button();
            tsLocalidades = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            toolStripLocalidad.ContentPanel.SuspendLayout();
            toolStripLocalidad.TopToolStripPanel.SuspendLayout();
            toolStripLocalidad.SuspendLayout();
            tlLocalidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalidad).BeginInit();
            tsLocalidades.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripLocalidad
            // 
            // 
            // toolStripLocalidad.ContentPanel
            // 
            toolStripLocalidad.ContentPanel.Controls.Add(tlLocalidad);
            toolStripLocalidad.ContentPanel.Size = new Size(800, 425);
            toolStripLocalidad.Dock = DockStyle.Fill;
            toolStripLocalidad.Location = new Point(0, 0);
            toolStripLocalidad.Name = "toolStripLocalidad";
            toolStripLocalidad.Size = new Size(800, 450);
            toolStripLocalidad.TabIndex = 0;
            toolStripLocalidad.Text = "toolStripContainer1";
            // 
            // toolStripLocalidad.TopToolStripPanel
            // 
            toolStripLocalidad.TopToolStripPanel.Controls.Add(tsLocalidades);
            // 
            // tlLocalidad
            // 
            tlLocalidad.ColumnCount = 2;
            tlLocalidad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlLocalidad.ColumnStyles.Add(new ColumnStyle());
            tlLocalidad.Controls.Add(dgvLocalidad, 0, 0);
            tlLocalidad.Controls.Add(btnActualizar, 0, 1);
            tlLocalidad.Controls.Add(btnSalir, 1, 1);
            tlLocalidad.Dock = DockStyle.Fill;
            tlLocalidad.Location = new Point(0, 0);
            tlLocalidad.Name = "tlLocalidad";
            tlLocalidad.RowCount = 2;
            tlLocalidad.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlLocalidad.RowStyles.Add(new RowStyle());
            tlLocalidad.Size = new Size(800, 425);
            tlLocalidad.TabIndex = 0;
            // 
            // dgvLocalidad
            // 
            dgvLocalidad.AllowUserToAddRows = false;
            dgvLocalidad.AllowUserToDeleteRows = false;
            dgvLocalidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlLocalidad.SetColumnSpan(dgvLocalidad, 2);
            dgvLocalidad.Dock = DockStyle.Fill;
            dgvLocalidad.Location = new Point(3, 3);
            dgvLocalidad.Name = "dgvLocalidad";
            dgvLocalidad.ReadOnly = true;
            dgvLocalidad.Size = new Size(794, 390);
            dgvLocalidad.TabIndex = 0;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Location = new Point(641, 399);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(722, 399);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tsLocalidades
            // 
            tsLocalidades.Dock = DockStyle.None;
            tsLocalidades.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditar, tsbEliminar });
            tsLocalidades.Location = new Point(3, 0);
            tsLocalidades.Name = "tsLocalidades";
            tsLocalidades.Size = new Size(81, 25);
            tsLocalidades.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(23, 22);
            tsbNuevo.Text = "toolStripButton1";
            tsbNuevo.ToolTipText = "Nuevo";
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(23, 22);
            tsbEditar.Text = "toolStripButton1";
            tsbEditar.ToolTipText = "Editar";
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(23, 22);
            tsbEliminar.Text = "toolStripButton2";
            tsbEliminar.ToolTipText = "Eliminar";
            // 
            // Localidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripLocalidad);
            Name = "Localidades";
            Text = "Localidades";
            Load += Localidades_Load;
            toolStripLocalidad.ContentPanel.ResumeLayout(false);
            toolStripLocalidad.TopToolStripPanel.ResumeLayout(false);
            toolStripLocalidad.TopToolStripPanel.PerformLayout();
            toolStripLocalidad.ResumeLayout(false);
            toolStripLocalidad.PerformLayout();
            tlLocalidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLocalidad).EndInit();
            tsLocalidades.ResumeLayout(false);
            tsLocalidades.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripLocalidad;
        private ToolStrip tsLocalidades;
        private TableLayoutPanel tlLocalidad;
        private DataGridView dgvLocalidad;
        private Button btnActualizar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn NombreLocalidad;
        private DataGridViewTextBoxColumn CodigoPostal;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbEliminar;
    }
}