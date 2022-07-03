using System;
using System.Collections.Generic;
using System.Text;

namespace Taller.Almacen
{
    public class Marca
    {
        public Marca()
        {

        }
        public Marca(int codigo)
        {
            this.Codigo = codigo;
            Cargar();
        }

        public int Codigo;
        public string Sigla;
        public string Descripcion;

        public void Agregar()
        {

        }
        public void Editar()
        {

        }
        public void Eliminar()
        {

        }
        void Cargar()
        {
            switch (this.Codigo)
            {
                case 1:
                    Sigla = "BS";
                    Descripcion = "BOSCH";
                    break;
                case 2:
                    Sigla = "CAT";
                    Descripcion = "CATERPILLAR";
                    break;
                case 3:
                    Sigla = "ZX";
                    Descripcion = "ZEXEL";
                    break;
            }
        }
    }
}
