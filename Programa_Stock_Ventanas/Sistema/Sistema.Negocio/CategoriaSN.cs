using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using Sistema.Entidades;



namespace Sistema.Negocio
{
    public class CategoriaSN
    {
        public static DataTable Listar()
        {
            CategoriaSD Datos = new CategoriaSD();
            return Datos.Listar();

        }
        public static DataTable Buscar(string Valor)
        {
            CategoriaSD Datos = new CategoriaSD();
            return Datos.Buscar(Valor);
        }

        public static DataTable Seleccionar()
        {
            CategoriaSD Datos = new CategoriaSD();
            return Datos.Seleccionar();

        }
        public static string Insertar(string Nombre, string Descripcion)
        {
            CategoriaSD Datos = new CategoriaSD();

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoria ya existe";
            }
            else
            {
                Categoria Obj = new Categoria();
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj);
            }   
        }
        public static string Actualizar(int Id, string NombreAnt, string Nombre, string Descripcion)
        {
            CategoriaSD Datos = new CategoriaSD();
            Categoria Obj = new Categoria();

            if (NombreAnt.Equals(Nombre))
            {
                Obj.IdCategoria = Id;
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "La categoria ya existe";
                }
                else
                {
                    Obj.IdCategoria = Id;
                    Obj.Nombre = Nombre;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }
            
        }
        public static string Eliminar(int Id)
        {
            CategoriaSD Datos = new CategoriaSD();
            return Datos.Eliminar(Id);
        }
        public static string Activar(int Id)
        {
            CategoriaSD Datos = new CategoriaSD();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            CategoriaSD Datos = new CategoriaSD();
            return Datos.Desactivar(Id);
        }
    }
}
