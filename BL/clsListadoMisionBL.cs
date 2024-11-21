using DAL;
using ENT;

namespace BL
{
    public class clsListadoMisionBL
    {
        /// <summary>
        /// Función que obtiene una lista de misiones
        /// <br></br>
        /// Pre: Ninguna
        /// <br></br>
        /// Post: Ninguna
        /// </summary>
        /// <returns>Listado de misiones</returns>
        public static List<clsMision> obtenerMisiones()
        {
            if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 24)
            {
                return clsListadoMisionDAL.obtenerMisiones();
            }

            throw new HourException("Debes descansar Mando");
        }

        /// <summary>
        /// Función que busca una misión por su id
        /// <br></br>
        /// Pre: El id debe ser mayor a 0
        /// <br></br>
        /// Post: Puede devolver null si no encuentra una misión con ese id
        /// </summary>
        /// <param name="id">Id de la misión a buscar</param>
        /// <returns>Mision</returns>
        public static clsMision buscarMisionPorId(int id)
        {
            return clsListadoMisionDAL.buscarMisionPorId(id);
        }

        /// <summary>
        /// Función que inserta una misión en la lista de misiones
        /// <br></br>
        /// Pre: Misión rellena
        /// <br></br>
        /// Post: Ninguna
        /// </summary>
        /// <param name="mision">Mision a insertar</param>
        /// <returns>Booleano que indica si se ha insertado o no</returns>
        public static Boolean insertarMision(clsMision mision)
        {
            return clsListadoMisionDAL.insertarMision(mision);
        }

        /// <summary>
        /// Función que actualiza una misión
        /// <br></br>
        /// Pre: Misión rellena
        /// <br></br>
        /// Post: Ninguna
        /// </summary>
        /// <param name="mision">Mision con los nuevos datos</param>
        /// <returns>Booleano que indica si se ha editado o no</returns>
        public static Boolean editarMision(clsMision mision)
        {
            return clsListadoMisionDAL.editarMision(mision);
        }

        /// <summary>
        /// Función que eliminar una misión de la lista
        /// <br></br>
        /// Pre: El id debe ser mayor que 0
        /// <br></br>
        /// Post: Ninguna
        /// </summary>
        /// <param name="id">Id por el que se buscará la misión</param>
        /// <returns>Booleano que indica si se ha eliminado o n</returns>
        public static Boolean eliminarMision(int id)
        {
            return clsListadoMisionDAL.eliminarMision(id);
        }
    }
}
