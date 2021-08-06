﻿using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

namespace Controlador
{
    /// <summary>
    /// Controlador para anotaciones
    /// </summary>
    public class controladorAnotacion
    {
        private ConexionODBC ODBC = new ConexionODBC();

        /// <summary>
        /// Controlador para anotaciones
        /// </summary>
        public modeloAnotacion agregarAnotacion(modeloAnotacion modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO anotacion (pkId, cantidad, fkIdJugador, fkIdPartido) " +
                "VALUES (NULL, ?cantidad?, ?fkIdJugador?, ?fkIdPartido?);";
                var ValorDeVariables = new
                {
                    cantidad = modelo.cantidad,
                    fkIdJugador = modelo.fkIdJugador,
                    fkIdPartido = modelo.fkIdPartido
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }

            return modelo;
        }

        public modeloAnotacion modificarAnotacion(modeloAnotacion modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE anotacion SET cantidad = ?cantidad? ," +
                "fkIdJugador = ?fkIdJugador?, fkIdPartido = ?fkIdPartido?, " +
                "WHERE pkId = ?pkId?;";
                var ValorDeVariables = new
                {
                    cantidad = modelo.cantidad,
                    fkIdJugador = modelo.fkIdJugador,
                    fkIdPartido = modelo.fkIdPartido,
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }

            return modelo;
        }

        public modeloAnotacion eliminarAnotacion(modeloAnotacion modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM antotacion WHERE pkId = ?pkId?;";

                var ValorDeVariables = new
                {
                    pkId = modelo.pkId
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }

            return modelo;
        }

        public List<modeloAnotacion> mostrarAnotacion()
        {
            List<modeloAnotacion> sqlresultado = new List<modeloAnotacion>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM anotacion;";
                sqlresultado = conexionODBC.Query<modeloAnotacion>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}