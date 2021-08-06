﻿using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class formPolideportivo : Form
    {
        public formPolideportivo()
        {
            InitializeComponent();
            panelLateralInterno.HorizontalScroll.Maximum = 0;
            panelLateralInterno.VerticalScroll.Maximum = 0;
            panelLateralInterno.AutoScroll = false;
            panelLateralInterno.VerticalScroll.Visible = false;
            panelLateralInterno.AutoScroll = true;
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            ResumeLayout();
            base.OnResizeEnd(e);
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLateral_Click(object sender, EventArgs e)
        {
            if (panelLateralInterno.Width == 250)
            {
                panelLateralInterno.Width = 77;
                panelLateralWrapper.Width = 105;
                separadorLogo.Width = 57;
            }
            else
            {
                panelLateralInterno.Width = 250;
                panelLateralWrapper.Width = 280;

                separadorLogo.Width = 220;
            }
        }

        private Form formActivo = null;
        private string formPrincipalAnterior = "";

        private void btnDeportes_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formDeporte(), "DEPORTES");
        }

        private void btnMenuJugador_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formJugador(), "JUGADORES");
        }

        private void btnMenuEquipo_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formEquipo(), "EQUIPO");
        }

        private void btnMenuCampeonato_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formCampeonato(), "CAMPEONATO");
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formRol(), "ROLES");
        }

        private void btnMenuEntrenador_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formEntrenador(), "ENTRENADOR");
        }

        private void btnMenuEmpleado_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formEmpleado(), "EMPLEADO");
        }

        private void btnMenuPartido_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new formPartido(), "PARTIDO");
        }

        private void gestorDeFormActivo(Form formHijo, string formHijoActual)
        {
            lblTituloPrincipal.Text = formHijoActual;
            if (formPrincipalAnterior == formHijoActual)
            {
                cerrarFormActivo();
                formPrincipalAnterior = "";
                lblTituloPrincipal.Text = "POLIDEPORTIVO";
            }
            else
            {
                formPrincipalAnterior = formHijoActual;
                cerrarFormActivo();
                abrirFormHijo(formHijo, panelPrincipal);
            }
        }

        private void gestorFormMenuActivo(Form formHijo, string formHijoActual)
        {
            lblTituloPrincipal.Text = formHijoActual;
            if (formPrincipalAnterior == formHijoActual)
            {
                cerrarFormActivo();
                formPrincipalAnterior = "";
                lblTituloPrincipal.Text = "POLIDEPORTIVO";
            }
            else
            {
                formPrincipalAnterior = formHijoActual;
                cerrarFormActivo();
                abrirFormHijo(formHijo, panelPrincipal);
            }
        }

        private void abrirFormHijo(Form formHijo, Panel panel)
        {
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel.Controls.Add(formHijo);
            panel.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void cerrarFormActivo()
        {
            if (formActivo != null)
            {
                formActivo.Close();
                formActivo = null;
            }
        }

        private void MenuSuperiorPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void lblMenuTitulo_Click(object sender, EventArgs e)
        {
        }
    }
}