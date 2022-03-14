using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePagos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Propiedad> propiedades = new List<Propiedad>();
        List<Propietario> propietarios = new List<Propietario>();
        List<ControlCuotas> controlCuotas = new List<ControlCuotas>();

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            leer("propiedades.txt");
            leer("propietarios.txt");
            propietarioPropiedad();
            mostrar();
        }

        private void mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = controlCuotas;
            dataGridView1.Refresh();
        }

        private void leer(string fileNombre)
        {
            FileStream stream = new FileStream(fileNombre, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while(reader.Peek() > -1)
            {
                Propiedad propiedadTemp = new Propiedad();
                Propietario propietarioTemp = new Propietario();
                if (fileNombre == "propiedades.txt")
                {
                    propiedadTemp.noCasa = reader.ReadLine();
                    propiedadTemp.dpi = reader.ReadLine();
                    propiedadTemp.cuota = Convert.ToInt16(reader.ReadLine());
                    propiedades.Add(propiedadTemp);
                }
                if (fileNombre == "propietarios.txt")
                {
                    propietarioTemp.dpi = reader.ReadLine();
                    propietarioTemp.nombre = reader.ReadLine();
                    propietarioTemp.apellido = reader.ReadLine();
                    propietarios.Add(propietarioTemp);
                }
            }
            reader.Close();
        }

        private void propietarioPropiedad()
        {
            foreach (var i in propietarios)
            {
                ControlCuotas controlTemp = new ControlCuotas();
                foreach (var j in propiedades)
                {
                    if (i.dpi == j.dpi )
                    {
                        controlTemp.nombre = i.nombre;
                        controlTemp.apellido = i.apellido;
                        controlTemp.noCasa = j.noCasa;
                        controlTemp.cuota = j.cuota;
                        controlCuotas.Add(controlTemp);
                    }
                }
            }
        }
    }
}
