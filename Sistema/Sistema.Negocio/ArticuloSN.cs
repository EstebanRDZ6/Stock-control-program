using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Sistema.Negocio
{
    public class ArticuloSN
    {
        public static DataTable Listar()
        {
            ArticuloSD Datos = new ArticuloSD();
            return Datos.Listar();

        }
        public static DataTable Buscar(string Valor)
        {
            ArticuloSD Datos = new ArticuloSD();
            return Datos.Buscar(Valor);
        }
        public static DataTable BuscarVenta(string Valor)
        {
            ArticuloSD Datos = new ArticuloSD();
            return Datos.BuscarVenta(Valor);
        }
        public static DataTable BuscarCodigo(string Valor)
        {
            ArticuloSD Datos = new ArticuloSD();
            return Datos.BuscarCodigo(Valor);
        }
        public static DataTable BuscarCodigoVenta(string Valor)
        {
            ArticuloSD Datos = new ArticuloSD();
            return Datos.BuscarCodigoVenta(Valor);
        }
        public static string Insertar(int IdCategoria, string Serie, string Codigo, string Nombre, string Marca, string Tipo, string Grosor, string Ancho, string Color, string Material, decimal Peso, decimal Precio_venta_menor_kilo, decimal Precio_venta_mayor_rollo, decimal PrecioVenta, int Stock, string Descripcion, string Imagen)

        {
            ArticuloSD Datos = new ArticuloSD();

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "El artículo ya existe";
            }
            else
            {
                Articulo Obj = new Articulo();
                Obj.IdCategoria = IdCategoria;
                Obj.Serie = Serie;
                Obj.Codigo = Codigo;
                Obj.Nombre = Nombre;
                Obj.Marca = Marca;
                Obj.Tipo = Tipo;
                Obj.Grosor = Grosor;
                Obj.Ancho = Ancho;
                Obj.Color = Color;
                Obj.Material = Material;
                Obj.Peso = Peso;
                Obj.Precio_venta_menor_kilo = Precio_venta_menor_kilo;
                Obj.Precio_venta_mayor_rollo = Precio_venta_mayor_rollo;
                Obj.PrecioVenta = PrecioVenta;
                Obj.Stock = Stock;
                Obj.Descripcion = Descripcion;
                Obj.Imagen = Imagen;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int Id, int IdCategoria, string Serie, string Codigo, string NombreAnt, string Nombre, string Marca,string Tipo, string Grosor, string Ancho, string Color, string Material, decimal Peso, decimal Precio_venta_menor_kilo, decimal Precio_venta_mayor_rollo, decimal PrecioVenta, int Stock, string Descripcion, string Imagen)

        {
            ArticuloSD Datos = new ArticuloSD();
            Articulo Obj = new Articulo();

            if (NombreAnt.Equals(Nombre))
            {
                Obj.IdArticulo = Id;
                Obj.IdCategoria = IdCategoria;
                Obj.Serie = Serie;
                Obj.Codigo = Codigo;
                Obj.Nombre = Nombre;
                Obj.Marca = Marca;
                Obj.Tipo = Tipo;
                Obj.Grosor = Grosor;
                Obj.Ancho = Ancho;
                Obj.Color = Color;
                Obj.Material = Material;
                Obj.Peso = Peso;
                Obj.Precio_venta_menor_kilo = Precio_venta_menor_kilo;
                Obj.Precio_venta_mayor_rollo = Precio_venta_mayor_rollo;
                Obj.PrecioVenta = PrecioVenta;
                Obj.Stock = Stock;   
                Obj.Descripcion = Descripcion;
                Obj.Imagen = Imagen;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "El articulo ya existe";
                }
                else
                {
                    Obj.IdArticulo = Id;
                    Obj.IdCategoria = IdCategoria;
                    Obj.Codigo = Codigo;
                    Obj.Nombre = Nombre;
                    Obj.Marca = Marca;
                    Obj.PrecioVenta = PrecioVenta;
                    Obj.Stock = Stock;
                    Obj.Descripcion = Descripcion;
                    Obj.Imagen = Imagen;
                    return Datos.Actualizar(Obj);
                }
            }

        }
        public static string Eliminar(int Id)
        {
            ArticuloSD Datos = new ArticuloSD();
            return Datos.Eliminar(Id);
        }
        public static string Activar(int Id)
        {
            ArticuloSD Datos = new ArticuloSD();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            ArticuloSD Datos = new ArticuloSD();
            return Datos.Desactivar(Id);
        }
    }
}
