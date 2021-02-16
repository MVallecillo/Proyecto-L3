using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ERP
{
    public class ProductosServiciosBL
    {
        public BindingList<ProductosServicios> ListaProductosServicios { get; set; }

        public ProductosServiciosBL()    // Inicio del constructor. 
                                         // método abreviado escribir "ctor" + doble tab
        {
            ListaProductosServicios = new BindingList<ProductosServicios>();

            var producto1 = new ProductosServicios();
            producto1.Codigo = 000001;
            producto1.Descripcion = "Kit Cámara 4CH 1080P.";
            producto1.Tipo = "Producto";
            producto1.Costo = 3200;
            producto1.Precio = 6000;
            producto1.Existencia = 7;
            producto1.Activo = true;

            ListaProductosServicios.Add(producto1);

            var producto2 = new ProductosServicios();
            producto2.Codigo = 000002;
            producto2.Descripcion = "Cámara WIFI IP66 1080P.";
            producto2.Tipo = "Producto";
            producto2.Costo = 1050;
            producto2.Precio = 2400;
            producto2.Existencia = 5;
            producto2.Activo = true;

            ListaProductosServicios.Add(producto2);

            var producto3 = new ProductosServicios();
            producto3.Codigo = 000003;
            producto3.Descripcion = "Instalación de Cámaras.";
            producto3.Tipo = "Producto";
            producto3.Costo = 1200;
            producto3.Precio = 3500;
            producto3.Existencia = 0;
            producto3.Activo = true;

            ListaProductosServicios.Add(producto3);

            var producto4 = new ProductosServicios();
            producto4.Codigo = 000004;
            producto4.Descripcion = "Kit Cámara 8CH 1080P";
            producto4.Tipo = "Producto";
            producto4.Costo = 4000;
            producto4.Precio = 8500;
            producto4.Existencia = 11;
            producto4.Activo = true;

            ListaProductosServicios.Add(producto4);

        }

        public BindingList<ProductosServicios> ObtenerProductosServicios()
        {
            return ListaProductosServicios;
        }

    public class ProductosServicios
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
      }
    }
}