﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teorico3Ejercicio2.Interface;

namespace Teorico3Ejercicio2
{
    internal class Partido : IValidar
    {
        /*
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public DateTime Fecha { get; set; }
        public int GolesVisitante { get; set; }
        public int GolesLocal { get; set; }
        */

        private Equipo _equipoLocal;
        private Equipo _equipoVisitante;
        private DateTime _fecha;
        private int _golesLocal;
        private int _golesVisitante;

        public Partido(Equipo equipoLocal, Equipo equipoVisitante, DateTime fecha, int golesLocal, int golesVisitante)
        {
            _equipoLocal = equipoLocal;
            _equipoVisitante = equipoVisitante;
            _fecha = fecha;
            _golesLocal = golesLocal;
            _golesVisitante = golesVisitante;
        }

        public void Validar()
        {
            ValidarEquipoLocal();
            ValidarEquipoVisitante();
            ValidarGolesLocal();
            ValidarGolesVisitante();
        }

        internal void MostrarResultado()
        {

            Console.WriteLine($"Equipo local: {_equipoLocal.Nombre} - Goles: {_golesLocal}");
            Console.WriteLine($"Equipo visitante: {_equipoVisitante.Nombre} - Goles: {_golesVisitante}");

            if (_golesLocal > _golesVisitante)
            {
                Console.WriteLine($"El equipo ganador es: {_equipoLocal.Nombre}");
            }
            else if (_golesVisitante > _golesLocal)
            {
                Console.WriteLine($"El equipo ganador es: {_equipoVisitante.Nombre}");
            }
            else
            {
                Console.WriteLine("El resultado es un empate.");
            }
        }

        internal void ValidarGolesVisitante()
        {
            if (int.IsNegative(_golesVisitante)) throw new Exception("Goles Equipo Visitante Obligatorio");
        }

        internal void ValidarGolesLocal()
        {
            if (int.IsNegative(_golesLocal)) throw new Exception("Goles Equipo Local Obligatorio");
        }

        internal void ValidarEquipoVisitante()
        {
            if (_equipoVisitante == null) throw new Exception("Equipo Visitante Obligatorio");
        }

        internal void ValidarEquipoLocal()
        {
            if (_equipoLocal == null) throw new Exception("Equipo Local Obligatorio");
        }
    }
}

