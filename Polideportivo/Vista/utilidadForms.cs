﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polideportivo.Vista
{
    class utilidadForms 
    {
        public static void abrirForm(Form formEvento)
        {

            //formEvento.TopLevel = false;
            formEvento.FormBorderStyle = FormBorderStyle.None;
            //formEvento.Dock = DockStyle.Fill;
            formEvento.StartPosition = FormStartPosition.CenterScreen;
            formEvento.BringToFront();
            formEvento.Show();
        }
        public static void cerrarForm(Form formEvento)
        {
            formEvento.Close();
        }

        public static int stringAInt(string str)
        {
            int num;
            bool seConvirtioAInt = int.TryParse(str, out num);
            if (seConvirtioAInt)
            {
                return num;
            }
            else
            {
                return 0;
            }
            
        }

    }
}