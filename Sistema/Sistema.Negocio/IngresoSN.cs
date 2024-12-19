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
    public class IngresoSN
    {
        public static DataTable Listar() 
        { 
            IngresoSD Datos = new IngresoSD();
            return Datos.Listar();
        }
        public static DataTable Buscar(string valor)
        {
            IngresoSD Datos = new IngresoSD();
            return Datos.Buscar(valor);
        }
        public static DataTable ConsultaFechas(DateTime FechaInicio, DateTime FechaFin)
        {
            IngresoSD Datos = new IngresoSD();
            return Datos.ConsultaFechas(FechaInicio, FechaFin);
        }
        public static DataTable ListarDetalle(int id)
        {
            IngresoSD Datos = new IngresoSD();
            return Datos.ListarDetalle(id);
        }

        public static string Insertar(int IdProveedor, int IdUsuario, string TipoComprobante, string SerieComprobante, string NumComprobante, decimal Impuesto, decimal Total, DataTable Detalles) 
        {
            IngresoSD Datos = new IngresoSD();
            Ingreso Obj = new Ingreso();
            Obj.IdProveedor = IdProveedor;
            Obj.IdUsuario = IdUsuario;
            Obj.TipoComprobante = TipoComprobante;
            Obj.SerieComprobante = SerieComprobante;
            Obj.NumComprobante = NumComprobante;
            Obj.Impuesto = Impuesto;
            Obj.Total = Total;
            Obj.Detalles = Detalles;
            return Datos.Insertar(Obj);
        
        }
        public static string Anular(int id)
        {
            IngresoSD Datos = new IngresoSD();
            return Datos.Anular(id);
        }

    }
}
