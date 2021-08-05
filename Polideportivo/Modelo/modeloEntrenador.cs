﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polideportivo.Modelo
{
    public class modeloEntrenador
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public int fkIdEquipo { get; set; }
        public int fkIdDeporte { get; set; }

        public modeloEntrenador() { }

        public modeloEntrenador(int Id, string Nombre, int IdEquipo, int IdDeporte)
        {
            pkId = Id;
            nombre = Nombre;
            fkIdEquipo = IdEquipo;
            fkIdDeporte = IdDeporte;

            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }

    }
}