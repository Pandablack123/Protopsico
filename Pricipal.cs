using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protopsico
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            ocultarpanel();
        }

        private void ocultarpanel()
        {
            panelsubmenuCita.Visible = false;
            panelsubmenuConsulta.Visible = false;
            panelsubmenuEXPE.Visible = false;
            panelsubmenuinfor.Visible = false;
        }

        private void ocultarsubmenu()
        {
            if (panelsubmenuCita.Visible == true)
            {
                panelsubmenuCita.Visible = false;
            }
            if (panelsubmenuConsulta.Visible == true)
            {
                panelsubmenuConsulta.Visible = false;
            }
            if (panelsubmenuEXPE.Visible == true)
            {
                panelsubmenuEXPE.Visible = false;
            }
            if (panelsubmenuinfor.Visible == true)
            {
                panelsubmenuinfor.Visible = false;
            }
        }
        private void mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarsubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void buttonExpediente_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenuEXPE);
        }

        

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenuConsulta);
        }

        private void buttonCita_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenuCita);
        }

        private void buttonInformes_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenuinfor);
        }

        private void buttonVerExpe_Click(object sender, EventArgs e)
        {
            abrirForm(new Verexpediente());
            ocultarsubmenu();
            
        }

        private void buttonCrearExp_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void buttonBajaExpe_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void buttonNuevaConsulta_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void buttonVerConsulta_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void buttonIniciarConsulta_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void buttonAgendarCita_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void buttonPosponerCita_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void buttonVerCitas_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void buttonVerInformes_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void buttonGenerarInformes_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private Form fomractive = null;
        private void abrirForm(Form formhijo)
        {
            if (fomractive != null)
            {
                fomractive.Close();  
            }
            fomractive = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panelFormhijo.Controls.Add(formhijo);
            panelFormhijo.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();
        }

    }

}
