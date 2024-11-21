using ENT;

namespace DAL
{
    public class clsListadoMisionDAL
    {
        private static List<clsMision> misiones = new List<clsMision>
            {
                new clsMision(1, "Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.", 5000),
                new clsMision(2, "Recuperar armadura Beskar", "Tu armadura de Beskar ha sido robada. Debes encontrarla.", 2000),
                new clsMision(3, "Planeta Sorgon", "Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.", 500),
                new clsMision(4, "Renacuajos", "Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", 500)
            };

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
            return misiones;
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
        public static clsMision? buscarMisionPorId(int id)
        {
            clsMision mision = null;

            mision = misiones.Find(mision => mision.Id == id);

            return mision;
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
            Boolean insertado = false;

            // Le colocamos el siguiente id al último de la lista
            mision.Id = siguienteId();

            misiones.Add(mision);

            insertado = misiones.Contains(mision);

            return insertado;
        }

        /// <summary>
        /// Función que obtiene el siguiente id a generar
        /// <br></br>
        /// Pre: Ninguna
        /// <br></br>
        /// Post: Ninguna
        /// </summary>
        /// <returns>Devuelve el siguiente id a generar</returns>
        private static int siguienteId()
        {
            int id = 1;

            // Comprobamos que la lista no esté vacía
            if (misiones.Count > 0)
            {
                // Le sumamos 1 al id más grande encontrado
                id = misiones.Max(mision => mision.Id) + 1;
            }

            return id;
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
            Boolean editado = false;

            // Buscamos la misión con el Id especificado
            clsMision misionExistente = misiones.First(m => m.Id == mision.Id);

            // Si la misión se encuentra, actualizamos sus valores
            if (misionExistente != null)
            {
                misionExistente.Nombre = mision.Nombre;
                misionExistente.Descripcion = mision.Descripcion;
                misionExistente.Recompensa = mision.Recompensa;
                editado = true;
            }

            return editado;
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
            Boolean eliminado = false;
            clsMision mision;

            // Buscamos el índice de la misión en la lista
            int index = misiones.FindIndex(misionL => misionL.Id == id);
           
            // Si lo encuentra, eliminamos la misión de la lista
            if (index != -1)
            {
                eliminado = misiones.Remove(misiones[index]);
            }

            return eliminado;
        }
    }
}
