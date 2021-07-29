﻿using Polideportivo.AccesoDatos;
using Polideportivo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polideportivo.Vista
{
    public partial class formJugadorEventos : Form
    {

        

        public formJugadorEventos()
        {
            InitializeComponent();
        }
        formJugador formOriginal = new formJugador();
        public formJugadorEventos(modeloJugador modelo, formJugador form)
        {
            
            InitializeComponent();
            btnAgregarJugador.Visible = false;
            btnModificar.Visible = true;
            formOriginal = form;
            txtNombre.Text = modelo.pkId.ToString();
        }

        
        public formJugadorEventos(formJugador form)
        {
            
            InitializeComponent();
            btnAgregarJugador.Visible = true;
            btnModificar.Visible = false;
        }

        public void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            controladorJugador modeloAgregar = new controladorJugador();
            modeloJugador modelo = new modeloJugador();
            modelo.nombre = txtNombre.Text;
            modelo.anotaciones = utilidadForms.stringAInt(txtAnotaciones.Text);
            modelo.fkIdEquipo = utilidadForms.stringAInt(cboEquipo.SelectedValue.ToString());
            modelo.fkIdRol = utilidadForms.stringAInt(cboRol.SelectedValue.ToString());
            modeloAgregar.agregarJugador(modelo);
            formOriginal.actualizarTablaJugadores();
            utilidadForms.cerrarForm(this);
            
        }

        private void formJugadorEventos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cboRoles.rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.cboRoles.rol);
            // TODO: esta línea de código carga datos en la tabla 'cboEquipos.equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.cboEquipos.equipo);

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void parrotGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
