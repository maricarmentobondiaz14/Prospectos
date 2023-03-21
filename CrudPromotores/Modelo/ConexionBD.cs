using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CrudPromotores.Modelo
{
    class ConexionBD
    {
        static private string CadenaConexion = "Server=DESKTOP-EHTEBU6\\MSSQLSERVER01; DataBase=crudProspectos; Integrated Security=true";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion() {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;

        }
        public SqlConnection CerrarConexion() {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;

        }
    }
}
