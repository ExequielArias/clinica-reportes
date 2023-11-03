using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_reportes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'CLINICADataSet.Medicos' Puede moverla o quitarla según sea necesario.
            this.MedicosTableAdapter.Fill(this.CLINICADataSet.Medicos);

            this.reportViewer1.RefreshReport();
        }
    }
}
