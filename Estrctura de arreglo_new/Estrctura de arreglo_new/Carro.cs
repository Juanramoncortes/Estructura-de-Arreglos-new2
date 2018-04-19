using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrctura_de_arreglo_new
{
    class Carro
    {
        string _telefono;
        public string telefono { get { return _telefono; } set { _telefono = value; } }

        string _placa;
        public string placa { get { return _placa; } set{ _placa = value; } }
        string _modelo;
        public string modelo { get { return _modelo; } set { _modelo = value; } }
        string _fecha;
        public string fecha { get { return _fecha; } set { _fecha = value; } }
        public Carro()
        {
            _telefono = "";
            _placa = "";
            _modelo = "";
            _fecha = "";
        }
        public override string ToString()
        {
            return _telefono+"\t"+_fecha+ "\t" + _modelo+"\t"+_placa;
        }
    }
}
