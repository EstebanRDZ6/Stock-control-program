﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Sistema.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;


        private Conexion()
        {
            this.Base = "SantiBD";
            this.Servidor = "PecuTostadora3k\\SQLEXPRESS";
            this.Usuario = "sa";
            this.Clave = "123456";
            this.Seguridad = true;
        }
        public SqlConnection CrearConexion()
        {
            /*Capturador de exceptiones*/
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + " Integrated Security = SSPI"; /*La seguridad intregrada de windows para base de datos SQL SERVER*/
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + ";User Id=" + this.Usuario + ";Password=" + this.Clave;
                }
            }
            catch(Exception ex)
            {               
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
