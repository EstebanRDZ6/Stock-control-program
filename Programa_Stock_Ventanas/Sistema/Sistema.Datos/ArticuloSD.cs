using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;


namespace Sistema.Datos
{
    public class ArticuloSD
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_listar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable Buscar(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable BuscarVenta(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_buscar_venta", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable BuscarCodigo(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_buscar_codigo", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable BuscarCodigoVenta(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_buscar_codigo_venta", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_existe", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string Insertar(Articulo Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria",SqlDbType.Int).Value = Obj.IdCategoria;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@marca", SqlDbType.VarChar).Value = Obj.Marca;
                Comando.Parameters.Add("@grosor", SqlDbType.VarChar).Value = Obj.Grosor;
                Comando.Parameters.Add("@anchoXalto", SqlDbType.VarChar).Value = Obj.AnchoXalto;
                Comando.Parameters.Add("@color", SqlDbType.VarChar).Value = Obj.Color;
                Comando.Parameters.Add("@material", SqlDbType.VarChar).Value = Obj.Material;
                Comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = Obj.PrecioVenta;
                Comando.Parameters.Add("@stock", SqlDbType.Int).Value = Obj.Stock;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = Obj.Imagen;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string Actualizar(Articulo Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Obj.IdArticulo;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.IdCategoria;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = Obj.Codigo;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@marca", SqlDbType.VarChar).Value = Obj.Marca;
                Comando.Parameters.Add("@grosor", SqlDbType.VarChar).Value = Obj.Grosor;
                Comando.Parameters.Add("@anchoXalto", SqlDbType.VarChar).Value = Obj.AnchoXalto;
                Comando.Parameters.Add("@color", SqlDbType.VarChar).Value = Obj.Color;
                Comando.Parameters.Add("@material", SqlDbType.VarChar).Value = Obj.Material;
                Comando.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = Obj.PrecioVenta;
                Comando.Parameters.Add("@stock", SqlDbType.Int).Value = Obj.Stock;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                Comando.Parameters.Add("@imagen", SqlDbType.VarChar).Value = Obj.Imagen;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string Activar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_activar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string Desactivar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_desactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string AumentarPrecioPorCategoria(Articulo Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("AumentarPorCategoria", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = Obj.IdCategoria;
                Comando.Parameters.Add("@Aumento", SqlDbType.Decimal).Value = Obj.Aumento;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo aumentar el precio";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string DisminuirPrecioPorCategoria(Articulo Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("DisminuirPorCategoria", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = Obj.IdCategoria;
                Comando.Parameters.Add("@Disminucion", SqlDbType.Decimal).Value = Obj.Disminucion;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo disminuir el precio";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

    }
}
