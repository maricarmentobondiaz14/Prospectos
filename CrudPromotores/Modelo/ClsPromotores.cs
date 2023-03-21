using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CrudPromotores.Modelo
{
    class ClsPromotores
    {
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader leerfilas;
        public void InsertarPromotores(
            string usuario,
            string password,
            string nombre,
            string puesto,
            string rfc,
            string telefono,
            string correo) {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "INSERT INTO PROMOTORES VALUES('" + usuario + "','" + password + "','" + nombre + "','" + puesto + "','"
                    + rfc + "','" + telefono + "','" + correo +  "');";
                leerfilas = Comando.ExecuteReader();
                leerfilas.Close();
                Conexion.CerrarConexion();
               



            
        }
        public bool ExistePromotor(string usuario, string password) {
            Comando.Connection = Conexion.AbrirConexion();
            bool bandera = false;
            Comando.CommandText = "select  * from promotores where usuario='" + usuario + "' and " +
                "password='" + password +  "' ;";
            leerfilas = Comando.ExecuteReader();
            while (leerfilas.Read())
            {
                
                bandera = true;
            }
            leerfilas.Close();
            Conexion.CerrarConexion();
            return bandera;
        }
    }
}
