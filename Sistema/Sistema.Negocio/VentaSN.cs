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
    public class VentaSN
    {
        public static DataTable Listar() 
        { 
            VentaSD Datos = new VentaSD(); 
            return Datos.Listar();
        }
        public static DataTable Buscar(string valor)
        {
            VentaSD Datos = new VentaSD();
            return Datos.Buscar(valor);
        }
        public static DataTable ConsultaFechas(DateTime FechaInicio, DateTime FechaFin)
        {
            VentaSD Datos = new VentaSD();
            return Datos.ConsultaFechas(FechaInicio, FechaFin);
        }
        public static DataTable ListarDetalle(int id)
        {
            VentaSD Datos = new VentaSD();
            return Datos.ListarDetalle(id);
        }

        public static string Insertar(int IdCliente, int IdUsuario, string TipoComprobante, string SerieComprobante, string NumComprobante, decimal Impuesto, decimal Total, DataTable Detalles) 
        {
            VentaSD Datos = new VentaSD();
            Venta Obj = new Venta();
            Obj.IdCliente = IdCliente;
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
            VentaSD Datos = new VentaSD();
            return Datos.Anular(id);
        }

    }
}
