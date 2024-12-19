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
    public class UsuarioSN
    {
        public static DataTable Listar()
        {
            UsuarioSD Datos = new UsuarioSD();
            return Datos.Listar();

        }
        public static DataTable Buscar(string Valor)
        {
            UsuarioSD Datos = new UsuarioSD();
            return Datos.Buscar(Valor);
        }

        public static DataTable Login(string Email, string Clave)
        {
            UsuarioSD Datos = new UsuarioSD();
            return Datos.Login(Email,Clave);
        }
        public static string Insertar(int IdRol, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email, string Clave)
        {
            UsuarioSD Datos = new UsuarioSD();

            string Existe = Datos.Existe(Email);
            if (Existe.Equals("1"))
            {
                return "El usuario con ese email ya existe.";
            }
            else
            {
                Usuario Obj = new Usuario();
                Obj.IdRol = IdRol;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = TipoDocumento;
                Obj.NumDocumento = NumDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                Obj.Clave = Clave;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int Id, int IdRol, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono,string EmailAnt, string Email, string Clave)
        {
            UsuarioSD Datos = new UsuarioSD();
            Usuario Obj = new Usuario();

            if (EmailAnt.Equals(Email))
            {
                Obj.IdUsuario = Id;
                Obj.IdRol = IdRol;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = TipoDocumento;
                Obj.NumDocumento = TipoDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                Obj.Clave = Clave;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Email);
                if (Existe.Equals("1"))
                {
                    return "El usuario con ese email ya existe.";
                }
                else
                {
                    Obj.IdUsuario = Id;
                    Obj.IdRol = IdRol;
                    Obj.Nombre = Nombre;
                    Obj.TipoDocumento = TipoDocumento;
                    Obj.NumDocumento = TipoDocumento;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    Obj.Clave = Clave;
                    return Datos.Actualizar(Obj);
                }
            }

        }
        public static string Eliminar(int Id)
        {
            UsuarioSD Datos = new UsuarioSD();
            return Datos.Eliminar(Id);
        }
        public static string Activar(int Id)
        {
            UsuarioSD Datos = new UsuarioSD();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            UsuarioSD Datos = new UsuarioSD();
            return Datos.Desactivar(Id);
        }
    }
}
