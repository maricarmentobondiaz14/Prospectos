using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CrudPromotores.ModeloM;

namespace CrudPromotores.Modelo
{
    class ClsProspectos
    {
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader leerfilas;
        Prospecto obprospecto =new Prospecto();

        public DataTable ListarProspectos() {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Select * from prospectos ";
            leerfilas = Comando.ExecuteReader();
            Tabla.Load(leerfilas);
            leerfilas.Close();
            Conexion.CerrarConexion();
            return Tabla;

        
        }
        public void InsertaProspectos(
            string nombreP, 
            string apellidoP, 
            string apellidoM, 
            string calle, 
            string numeroCasa,
            string colonia,
            int codigoPostal, 
            string telefono, 
            string rfc, 
            int status,
            string observaciones,
            string[] url) {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "INSERT INTO PROSPECTOS VALUES('"+nombreP+"','"+apellidoP+"','"+apellidoM+"','"+calle+"','"
                +numeroCasa+"','"+colonia+"',"+codigoPostal+",'"+telefono+"','"+rfc+"',"+status+",'"+observaciones+"');";
            leerfilas = Comando.ExecuteReader();
            leerfilas.Close();
            Conexion.CerrarConexion();
            Comando.Connection = Conexion.AbrirConexion();
            int idProspecto=0;
            Comando.CommandText = "select id_prospecto from prospectos where nombreP='" + nombreP + "' and " +
                "apellidoP='"+apellidoP+"' and apellidoM='"+apellidoM+"' ;";
            leerfilas = Comando.ExecuteReader();
            while (leerfilas.Read())
            {
                idProspecto = Convert.ToInt32(leerfilas.GetDecimal(0));
                
                Console.WriteLine(idProspecto);
               
            }
            leerfilas.Close ();
            Conexion.CerrarConexion();
            Comando.Connection = Conexion.AbrirConexion();
            
            for (int i=0; i < url.Length; i++) {
                Comando.CommandText = "INSERT INTO DOCUMENTOS VALUES (" + idProspecto +",'"+url[i].ToString()+"') ;";
                leerfilas = Comando.ExecuteReader();

            }
            leerfilas.Close();
            Conexion.CerrarConexion();



        }
        public void ActualizarStatusProspectos(
            int idprospecto, 
            int status,
            string observaciones) {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "UPDATE PROSPECTOS SET STATUS = " + status +", OBSERVACIONES = '"+observaciones
                + "' WHERE ID_PROSPECTO = " + idprospecto +";";
            leerfilas = Comando.ExecuteReader();
            leerfilas.Close();
            Conexion.CerrarConexion();
        }
        public  Prospecto RevisarLista(int id_prospecto)
        {
            Prospecto pros = new Prospecto();

            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "SELECT *" +
                "FROM prospectos " +
                "WHERE id_prospecto = " +id_prospecto;
            leerfilas = Comando.ExecuteReader();
            while (leerfilas.Read())
            {
                pros.Identificador = Convert.ToInt32(leerfilas.GetDecimal(0));
                pros.NombreP = leerfilas.GetString(1);
                pros.ApellidoP = leerfilas.GetString(2);
                pros.ApellidoM = leerfilas.GetString(3);
                pros.Calle=leerfilas.GetString(4);
                pros.NumeroCasa = leerfilas.GetString(5);
                pros.Colonia=leerfilas.GetString(6);
                pros.CodigoPostal = Convert.ToInt32(leerfilas.GetDecimal(7));
                pros.Telefono = leerfilas.GetString(8);
                pros.RFC= leerfilas.GetString(9);
                pros.Estatus = Convert.ToInt32(leerfilas.GetDecimal(10));
                pros.Observaciones=leerfilas.GetString(11);
            }
            leerfilas.Close();

            Conexion.CerrarConexion();
            return pros;
        }
        public List<string> RevisarListaDocumentos(int id_prospecto)
        {
            List<string> urls = new List<string>();

            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "SELECT url " +
                "FROM documentos " +
                "WHERE id_prospecto = " + id_prospecto;
            leerfilas = Comando.ExecuteReader();
        
            while (leerfilas.Read())
            {
                urls.Add(leerfilas.GetString(0));
                Console.WriteLine(leerfilas.GetString(0));
                
            }
            leerfilas.Close();
            Conexion.CerrarConexion();

            return urls;
        }
    }
}
