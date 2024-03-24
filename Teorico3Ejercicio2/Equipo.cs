using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teorico3Ejercicio2.Interface;

namespace Teorico3Ejercicio2
{
    internal class Equipo : IValidar
    {
        private static int _idEquipo = 0;
        private int _id;
        private string _nombre;
        private string _departamento;

        public Equipo(string nombre, string departamento)
        {
            _id = Equipo._idEquipo++;
            _nombre = nombre;
            _departamento = departamento;
        }

        public void Validar()
        {
            ValidarNombre();
            ValidarDepartamento();
        }

        internal void ValidarNombre()
        {
            if (string.IsNullOrEmpty(_nombre)) throw new Exception("Nombre del Equipo Obligatorio");
        }

        internal void ValidarDepartamento()
        {
            if (string.IsNullOrEmpty(_departamento)) throw new Exception("Departamento del Equipo Obligatorio");
        }

        internal string Departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

        internal string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public override string ToString()
        {
            return $"ID: {this._id}" +
                $"Nombre: {this._nombre}" +
                $"Departamento: {this._departamento}";
        }
    }
}
