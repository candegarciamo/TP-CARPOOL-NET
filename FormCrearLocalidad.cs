//me borra la referencia de apiloc no se pq
using DTOsTp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Localidad_winForm
{
    public partial class FormCrearLocalidad : Form
    {
        public FormCrearLocalidad()
        {
            InitializeComponent();
            Mode = FormMode.Add;
        }

        public enum FormMode
        {
            Add,
            Update
        }

      
        private LocalidadDTO localidad;
        private FormMode mode;

        public LocalidadDTO Localidad
        {
            get { return localidad; }
            set
            {
                localidad = value;
                this.SetLocalidad();
            }
        }

        public FormMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                SetFormMode(value);
            }
        }

        private async void btnCrear_Click(object sender, EventArgs e)
    {
        if (this.ValidateLocalidad())
        {
            try
            {
                this.Localidad.Nombre = txtNombreLoc.Text;
                this.Localidad.CodPostal = txtCodPostal.Text;

                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                if (this.Mode == FormMode.Update)
                {
                    await LocalidadApiLoc.UpdateAsync(this.Localidad);
                }
                else
                {
                    await LocalidadApiLoc.AddAsync(this.Localidad);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }

        private void SetLocalidad()
        {
            this.txtCodPostal.Text = this.Localidad.CodPostal;
            this.txtNombreLoc.Text = this.Localidad.Nombre;
        }


        private void SetFormMode(FormMode value)
        {
            mode = value;

            if (Mode == FormMode.Add)
            {
                label2.Visible = false;
                label3.Visible = false;
            }

            if (Mode == FormMode.Update)
            {
                label2.Visible = true;
                label3.Visible = true;
            }
        }

        private bool ValidateLocalidad()
        {
            bool isValid = true;

            errorProvider.SetError(txtNombreLoc, string.Empty);
            errorProvider.SetError(txtCodPostal, string.Empty);


            if (this.txtNombreLoc.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(txtNombreLoc, "El Nombre de la localidad es Requerido");
            }
            if (this.txtCodPostal.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(txtCodPostal, "El Codigo Postal es Requerido");
            }


            return isValid;
        }

    }
}
