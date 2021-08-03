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
    }

}
