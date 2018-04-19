using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrctura_de_arreglo_new
{
    class Inventario
    {
        int _cantidad;
        int _posicion;
        string Datos="";
        public int posicion { get { return _posicion; } set { _posicion = value; } }

        Carro[] lisCarro= new Carro[15];
        public int cantidad { get { return _cantidad; } }
        public Inventario()
        {
            _cantidad = 0;
            _posicion = 0;
            //lisCarro = null;
        }
        public void Agregar(Carro Carr)
        {

            if (_cantidad < 14)
            {
                lisCarro[_cantidad] = Carr;
                _cantidad++;
                //MessageBox.Show("Agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //MessageBox.Show("Insuficiente", "Espacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lisCarro[_cantidad] = Carr;
            }
           
        }
        public void Insertar(Carro Carr)
        {            
            Mover();
            lisCarro[_posicion]= Carr;
            //MessageBox.Show("Insertado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (_cantidad < 14)
            {
                _cantidad++;                
            }
        }
        private void Mover()
        {
            for (int a = _cantidad; a > _posicion; a--)
            {
                lisCarro[a] = lisCarro[a - 1];
            }
        }
        public void Eliminar()
        {
            if (lisCarro[_posicion] != null)
            {
                lisCarro[_posicion] = null;
                MoverBorrar();
                _cantidad--;
              //  MessageBox.Show("Borrado con exito", "Exito", MessageBoxButtons.OK);

            }
            else
            {
                ///MessageBox.Show("Carro no encontrado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
        private void MoverBorrar()
        {
            
            for (int a = _posicion; a < _cantidad; a++)
            {

                lisCarro[a] = lisCarro[a + 1];
            }
        }
        public void Lista()
        {
            Datos = "";
            for (int a =0; a <= (_cantidad-1); a++)
            {
                Datos +=(a+1)+"._\t"+ lisCarro[a].ToString()+Environment.NewLine;
            }
        }
        public void Buscar(string placa)
        {
            bool existe=false;
            Datos ="";
            int a = 0;
            while (existe==false&& a<=_cantidad)
            {
                if (lisCarro[a].placa == placa)
                {
                    Datos =(a+1)+"._\t"+ lisCarro[a].ToString();
                   
                    MessageBox.Show("Carro encontrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    a = _cantidad;
                    existe = true;
                }
                
                a++;
            }

        }

        public override string ToString()
        {
            return Datos;
        }
    }

}

