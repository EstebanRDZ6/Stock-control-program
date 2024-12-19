using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class PersonaSN
    {
        public static DataTable Listar()
        {
            PersonaSD Datos = new PersonaSD();
            return Datos.Listar();

        }
        public static DataTable ListarProveedores()
        {
            PersonaSD Datos = new PersonaSD();
            return Datos.ListarProveedores();

        }
        public static DataTable ListarClientes()
        {
            PersonaSD Datos = new PersonaSD();
            return Datos.ListarClientes();

        }
        public static DataTable Buscar(string Valor)
        {
            PersonaSD Datos = new PersonaSD();
            return Datos.Buscar(Valor);
        }
        public static DataTable BuscarProveedores(string Valor)
        {
            PersonaSD Datos = new PersonaSD();
            return Datos.BuscarProveedores(Valor);
        }
        public static DataTable BuscarClientes(string Valor)
        {
            PersonaSD Datos = new PersonaSD();
            return Datos.BuscarClientes(Valor);
        }
        public static string Insertar(string TipoPersona, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email)
        {
            PersonaSD Datos = new PersonaSD();

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La persona ya existe.";
            }
            else
            {
                Persona Obj = new Persona();
                Obj.TipoPersona = TipoPersona;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = TipoDocumento;
                Obj.NumDocumento = NumDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;                
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int Id, string TipoPersona, string NombreAnt, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email)
        {
            PersonaSD Datos = new PersonaSD();
            Persona Obj = new Persona();

            if (NombreAnt.Equals(Nombre))
            {
                Obj.IdPersona = Id;
                Obj.TipoPersona = TipoPersona; 
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = TipoDocumento;
                Obj.NumDocumento = NumDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;               
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "Una persona con ese nombre ya existe.";
                }
                else
                {
                    Obj.IdPersona = Id;
                    Obj.TipoPersona = TipoPersona;
                    Obj.Nombre = Nombre;
                    Obj.TipoDocumento = TipoDocumento;
                    Obj.NumDocumento = NumDocumento;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    return Datos.Actualizar(Obj);
                }
            }

        }
        public static string Eliminar(int Id)
        {
            PersonaSD Datos = new PersonaSD();
            return Datos.Eliminar(Id);
        }
    }
}
