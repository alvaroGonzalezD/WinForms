using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsContacts
{
    class BussinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        public BussinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }

        public Contacto SaveContacto(Contacto contacto)
        {
            _dataAccessLayer.InsertContacto(contacto);

            return contacto;
        }


        #region Ejercicio 04
        public List<Contacto> GetContactos(string searchString = null)
        {
            return _dataAccessLayer.GetContactos(searchString);
        }
        #endregion


        public void DeleteContacto(Contacto contacto)
        {
            _dataAccessLayer.DeleteContacto(contacto.Id);
        }
    }
}
