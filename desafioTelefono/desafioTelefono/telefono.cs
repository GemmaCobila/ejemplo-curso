using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioTelefono
{
    class telefono
    {
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;
        private string contacto;
        public string model
        {
            get { return modelo; }
        }
        public int credit { get; set; }
        public string marc
        {
            get { return marca; }
        }
        public string numTel
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public string contact { get; set; }

        public int codOpe
        {
            set
            {
                if (value == 1 || value == 2 || value == 3)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
            get { return codigoOperador; }      
        }

        private int credito;
        public telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
            credito = 0;
        }
        public telefono() { }

        public int recargar(int recarga)
        {
            int monto = credito += recarga;
            return monto;
        }

        public string llamar(string nombre)
        {
            return "Realizando llamada a " + nombre + " ...";
        }

    }
}
