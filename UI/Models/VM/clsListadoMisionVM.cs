using BL;
using DAL;
using ENT;

namespace UI.Models.VM
{
    public class clsListadoMisionVM : clsMision
    {
        #region Atributos
        private List<clsMision> misiones;
        #endregion

        #region Propiedades
        public List<clsMision> Misiones { get { return misiones; } }
        #endregion

        #region Constructores
        public clsListadoMisionVM()
        {
            misiones = clsListadoMisionBL.obtenerMisiones();
        }

        public clsListadoMisionVM(clsMision mision) : this()
        {
            this.Id = mision.Id;
            this.Nombre = mision.Nombre;
            this.Descripcion = mision.Descripcion;
            this.Recompensa = mision.Recompensa;
        }
        #endregion
    }
}
