using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class Acceso_datos
    {
        SqlConnection conexion; // se define la variable para la conexión de tipo SqlConnection
        SqlCommand cmd; // se defie la variable para realizar comandos en la BD
        SqlDataReader LectorDatos = null;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        // Abrir BD
        public void AbrirBd() // método para abrir la base de datos
        {
            try // permite captura de un error en caso que se presente
            {
                // creamos un objeto de tipo conexión a la base de datos y se pasa como parámetro la cadena de 			conexión
                conexion = new SqlConnection("Data Source=DESKTOP-88MTFLQ\\SQLEXPRESS; Initial Catalog =[DBFACTURAS]; Integrated Security = True");

                conexion.Open(); // invocamos método para abrir la base de datos

                // MessageBox.Show("Se ha conectado correctamente a la Base de datos");
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                MessageBox.Show("falló conexión " + ex);
            }
        }

        // Cerrar BD

        public void CerrarBd() // método para cerrar la base de datos
        {
            try // permite captura de un error en caso que se presente
            {
                conexion.Close(); // invocamos método para cerrar la base de datos
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                MessageBox.Show("falló cerrar conexión " + ex);
            }
        }

        // Validar usuario
        public string ValidarUsuario(string StrUsuario, string StrClave)
        {
            try
            {
                string strEmpleado = "";

                string sentencia = $"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado where StrUsuario = '{StrUsuario}' and StrClave = '{StrClave}'";
       

                AbrirBd();
                cmd = new SqlCommand();

                // utilizamos las propiedades de SqlCommand esta es una forma extendidas con mas parámetros de control

                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text; // otros tipos son :CommandType.StoredProcedure CommandType.TableDirect
                cmd.CommandTimeout = 10;

                LectorDatos = cmd.ExecuteReader(); // ejecuta y retorna un conjunto de datos no actualizable 
                while (LectorDatos.Read()) // recorremos los datos consultados
                {
                    strEmpleado = Convert.ToString(LectorDatos.GetValue(0));
                }
                if (LectorDatos != null) // cerramos el lector de datos
                {
                    LectorDatos.Close();
                }
                return strEmpleado;
            }

            catch (Exception ex)
            {
                MessageBox.Show("FALLA LECTURA: " + ex.Message);
                return "";
            }
        }

        // Ejecutar comandos
        public string EjecutarComando(string sentencia)
        {
            string mensajeSalida = "Los datos se ACTUALIZARON correctamente";

            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery(); // update, insert, delete
                CerrarBd();

                if (retornado > 0)
                {
                    mensajeSalida = "Datos actualizados :)";
                }
                else
                {
                    mensajeSalida = "Lo sentimos, no se ejecutó la acción solicitada";
                }
            }
            catch (Exception ex)
            {
                mensajeSalida = "La acción falló " + ex;
            }

            return mensajeSalida;
        }

        // Cargar tabla
        public DataTable CargarTabla(string tabla, string strCondicion)
        {
            try
            {
                AbrirBd();
                string Sql = "select * from " + tabla + " " + strCondicion;
                da = new SqlDataAdapter(Sql, conexion);
                ds = new DataSet();
                da.Fill(ds, tabla);
                DataTable dt = new DataTable();
                dt = ds.Tables[tabla];
                CerrarBd();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! Se ha encontrado un error en la consulta " + ex.ToString());
                return null;
            }
        }

        // Ejecutar comandos para llenar dg
        public DataTable EjecutarComandoDatos(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                // MessageBox.Show("Otra vez se conecto");
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló la operación:  " + ex);
                return null;
            }
        }


    }

}
