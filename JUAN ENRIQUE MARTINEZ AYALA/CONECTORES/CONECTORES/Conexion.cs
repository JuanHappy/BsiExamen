using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CONECTORES
{
    public class Conexion
    {
        private string sqlconexion = ConfigurationManager.AppSettings["SQLExamen"];
        public SqlConnection cn;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;

        private void conectar()
        {
            cn = new SqlConnection(sqlconexion);
        }

        //constructor
        public Conexion()
        {
            //se hace llamado al metodo conectar
            conectar();
        }


        //consultar
        public DataTable spConsultar(string Id)
        {
            string tabla = "Resultado";
            da = new SqlDataAdapter("spConsultar", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }
        public DataTable spAgregar(string Id, string Nombre, string Descripcion)
        {
            string tabla = "Resultado";
            da = new SqlDataAdapter("spAgregar", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
            da.SelectCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Descripcion;
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }
        public DataTable spActualizar(string Id, string Nombre, string Descripcion)
        {
            string tabla = "Resultado";
            da = new SqlDataAdapter("spActualizar", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
            da.SelectCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Descripcion;
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }
        public DataTable spEliminar(string Id)
        {
            string tabla = "Resultado";
            da = new SqlDataAdapter("spEliminar", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }

        public DataTable Consultar(string sql, string tabla)
        {
            da = new SqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }
        //eliminar
        public bool Eliminar(string tabla, string condicion)
        {
            cn.Open();
            string sql = "delete from " + tabla + " where " + condicion;
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();

            //si se realizo o no el cambio
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //actualizar
        public bool Actualizar(string tabla, string campos, string condicion)
        {

            cn.Open();
            string sql = "update " + tabla + " set " + campos + " where " + condicion;
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Insertar(string sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void consulta(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}