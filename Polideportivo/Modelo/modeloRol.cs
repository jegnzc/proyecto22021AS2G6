﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polideportivo.Modelo
{
    class modeloRol
    {


        public int pkId { get; set; }
        public string nombre { get; set; }
        public int fkIdDeporte { get; set; }

        public modeloRol() { }

        public modeloRol(int Id, string Nombre, int FkIdDeporte)
        {
            pkId = Id;
            nombre = Nombre;
            fkIdDeporte = FkIdDeporte;
            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }


    }

}