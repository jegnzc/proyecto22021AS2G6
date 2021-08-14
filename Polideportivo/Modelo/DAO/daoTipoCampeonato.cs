﻿using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Modelo.DAO
{
    public class daoTipoCampeonato
    {
        private ConexionODBC ODBC = new ConexionODBC();
        /// <summary>
        /// Metodo que sirve para mostrar los tipos de campeonatos
        /// </summary>
        /// <returns>Retorna la consulta a la base de datos que son los tipos de campeonato de la tablaTiposDeCampeonato</returns>
        public List<dtoTipoCampeonato> mostrarTipoDeCampeonatos()
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            List<dtoTipoCampeonato> sqlresultado = new List<dtoTipoCampeonato>();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM tipocampeonato;";
                sqlresultado = conexionODBC.Query<dtoTipoCampeonato>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}