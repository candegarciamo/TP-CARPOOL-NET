
namespace Localidad_winForm
{
    partial class FormCrearLocalidad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombreLoc = new TextBox();
            txtCodPostal = new TextBox();
            btnCrear = new Button();
            lnkVerLocalidades = new LinkLabel();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 59);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Agregar Nueva Localidad";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 130);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre localidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 201);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Codigo Postal:";
            // 
            // txtNombreLoc
            // 
            txtNombreLoc.Location = new Point(278, 127);
            txtNombreLoc.Name = "txtNombreLoc";
            txtNombreLoc.Size = new Size(100, 23);
            txtNombreLoc.TabIndex = 3;
            // 
            // txtCodPostal
            // 
            txtCodPostal.Location = new Point(278, 193);
            txtCodPostal.Name = "txtCodPostal";
            txtCodPostal.Size = new Size(100, 23);
            txtCodPostal.TabIndex = 4;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(265, 260);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // lnkVerLocalidades
            // 
            lnkVerLocalidades.AutoSize = true;
            lnkVerLocalidades.Location = new Point(138, 314);
            lnkVerLocalidades.Name = "lnkVerLocalidades";
            lnkVerLocalidades.Size = new Size(85, 15);
            lnkVerLocalidades.TabIndex = 6;
            lnkVerLocalidades.TabStop = true;
            lnkVerLocalidades.Text = "Ver localidades";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormCrearLocalidad
            // 
            AcceptButton = btnCrear;
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(557, 378);
            Controls.Add(lnkVerLocalidades);
            Controls.Add(btnCrear);
            Controls.Add(txtCodPostal);
            Controls.Add(txtNombreLoc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCrearLocalidad";
            StartPosition = FormStartPosition.CenterParent;
            Text = "agregarLocalidad";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombreLoc;
        private TextBox txtCodPostal;
        private Button btnCrear;
        private LinkLabel lnkVerLocalidades;
        private ErrorProvider errorProvider;
    }
}
