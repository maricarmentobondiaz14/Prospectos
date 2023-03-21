using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrudPromotores.ModeloM
{
    class Prospecto
    {
        private int identificador;
        private string nombreP;
        private string apellidoP;
        private string apellidoM;
        private string calle;
        private string numeroCasa;
        private string colonia;
        private Int32 codigoPostal;
        private string telefono;
        private string rfc;
        private Int32 status;
        private string observaciones;
        public Prospecto() { 
        }
        public Prospecto(int identificador
            , string nombreP
            ,string apellidoP
            ,string apellidoM
            ,string calle
            ,string numeroCasa
            ,string colonia
            ,Int32 codigoPostal
            ,string telefono
            ,string rfc
            ,Int32 status
            ,string observaciones) {
         this.identificador = identificador;
            this.nombreP = nombreP;
            this.apellidoP = apellidoP;
            this.apellidoM=apellidoM;
            this.calle = calle;
            this.colonia = colonia;
            this.codigoPostal = codigoPostal;
            this.telefono = telefono;
            this.numeroCasa = numeroCasa;
            this.rfc = rfc;
            this.status = status;   
            this.observaciones = observaciones; 

        }
        public string NombreP
        {
            get { return nombreP; }
            set { nombreP = value; }
        }
        public string ApellidoP
        {
            get { return apellidoP; }
            set { apellidoP = value; }
        }
        public string ApellidoM
        {
            get { return apellidoM ; }
            set { apellidoM = value; }
        }
        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        public string Colonia
        {
            get { return colonia; }
            set { colonia = value; }
        }
        public int CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }
        public string NumeroCasa
        {
            get { return numeroCasa; }
            set { numeroCasa = value; }
        }
        public string RFC 
        {
            get { return rfc; }
            set { rfc = value; }
        }
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        public int Estatus
        {
            get { return status; }
            set { status = value; }
        }

    }
}
