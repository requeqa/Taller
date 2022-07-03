using System;
using System.Collections.Generic;
using System.Text;

namespace Taller.Almacen
{
    public class Unidad
    {
        public Unidad()
        {

        }
        public Unidad(int codigo)
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
        void Cargar ()
        {
            switch (this.Codigo)
            {
                case 1:
                    Sigla = "PZ";
                    Descripcion="Pieza";
                    break;
                case 2:
                    Sigla = "CJ";
                    Descripcion = "Caja";
                    break;
                case 3:
                    Sigla = "BO";
                    Descripcion = "Botella";
                    break;
            }
        }

    }
}
