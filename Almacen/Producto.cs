using System;
using System.Collections.Generic;
using System.Text;

namespace Taller.Almacen
{
    public class Producto
    {
        public Producto() { CargarUnidades(); CargarMarcas(); }
        public Producto(int codigo)
        {
            this.Codigo = codigo;
            CargarProducto(codigo);
        }
        #region Parametros
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int CodigoUnidad { 
            //get { return codigoUnidad; }
            set { codigoUnidad = value;descUnidad = new Unidad(codigoUnidad).Descripcion;}
        }
        public int CodigoMarca
        {
            //get { return codigoMarca; }
            set{codigoMarca = value; descMarca = new Marca(codigoMarca).Descripcion;}
        }
        public string descUnidad { get; set; }
        public string descMarca { get; set; }
        //  public string Lugar { get; set; } // No se usara lugar por que generara un movimiento de Kardex innecesario

        public int Cantidad { get; set; } 
        public decimal Costo { get { return costo; } set { costo = value; } }
        public decimal Valor { get { return Cantidad * Costo; } }
        // Cantidad costo valor



        public int cantidad;
        public decimal costo;
        public int codigoUnidad;
        public int codigoMarca;
        public List<Unidad> Unidades = new List<Unidad>();
        public List<Marca> Marcas = new List<Marca>();

        #endregion

        #region Funciones
        void CargarUnidades() { for (int i = 1; i <= 3; i++) Unidades.Add(new Unidad(i)); }
        void CargarMarcas() { for (int i = 1; i <= 3; i++) Marcas.Add(new Marca(i)); }
        //void Cargar
        void CargarProducto(int id)
        {
            CodigoUnidad = id;
            CodigoMarca = id;
            switch (id)
            {
                case 1: Descripcion = "Bateria"; Cantidad = 2; Costo = (decimal)200.00; break;
                case 2: Descripcion = "Tornillos"; Cantidad = 3; costo = (decimal)6.35; break;
                case 3: Descripcion = "Liquido de frenos"; Cantidad = 2; costo = (decimal)20.0; break;
            }
        }
        void Agregar() { }
        void Editar() { }
        void Eliminar () { }
        #endregion
    }
}
