using System;
using System.Windows.Forms;

namespace WinFormsContacts
{
    public partial class Detalles : Form
    {
        private BussinessLogicLayer _bussinessLogicLayer;
        private Contacto _contacto;
        public Detalles()
        {
            InitializeComponent();
            _bussinessLogicLayer = new BussinessLogicLayer();
        }

        private void buttonCancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            SaveContacto();
            this.Close();
            ((Main)this.Owner).PopulateContactos();
        }

        private void SaveContacto()
        {
            Contacto contacto = new Contacto();
            contacto.Nombre = textNombre.Text;
            contacto.Apellidos = textApellidos.Text;
            contacto.Telefono = textTelefono.Text;
            contacto.Direccion = textDireccion.Text;

            contacto.Id = _contacto != null ? _contacto.Id : 0;

            _bussinessLogicLayer.SaveContacto(contacto);
        }

        public void LoadContacto(Contacto contacto)
        {
            _contacto = contacto;
            if (contacto != null)
            {
                ClearForm();

                textNombre.Text = _contacto.Nombre;
                textApellidos.Text = _contacto.Apellidos;
                textDireccion.Text = _contacto.Direccion;
                textTelefono.Text = _contacto.Telefono;
            }
        }

        private void ClearForm()
        {
            textNombre.Text = string.Empty;
            textApellidos.Text = string.Empty;
            textDireccion.Text = string.Empty;
            textTelefono.Text = string.Empty;
        }
    }
}

