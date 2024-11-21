using System.Globalization;

namespace ENT
{
    public class clsMision
    {
        #region Atributos
        private int id;
        private string nombre;
        private string descripcion;
        private int recompensa;
        #endregion

        #region Propiedades
        public int Id
        {
            get => id;
            set
            {
                if (value > 0)
                {
                    id = value;
                }
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
            }
        }

        public string Descripcion
        {
            get => descripcion;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    descripcion = value;
                }
            }
        }

        public int Recompensa
        {
            get => recompensa;
            set
            {
                if (value > 0)
                {
                    recompensa = value;
                }
            }
        }
        #endregion

        #region Constructores
        public clsMision() { }

        public clsMision(int id, string nombre, string descripcion, int recompensa)
        {
            if (id > 0)
            {
                this.id = id;
            }

            if (!string.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }

            if (!string.IsNullOrEmpty(descripcion))
            {
                this.descripcion = descripcion;
            }

            if (recompensa > 0)
            {
                this.recompensa = recompensa;
            }
        }


        #endregion
    }
}
