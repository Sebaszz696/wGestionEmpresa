using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wGestionPersonal
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //hace que el frmpersonal sea un hijo de frmMenuPrincipal
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // comprueba que no haya ningun formularo hijo abierto
            Form frmHijo = this.ActiveMdiChild;
            if (frmHijo != null)
            {

                frmHijo.Close();
            }

            frmPersonal frmPersonal = new frmPersonal();
            frmPersonal.MdiParent = this;
            frmPersonal.Show();
        }

        //Cierra
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
