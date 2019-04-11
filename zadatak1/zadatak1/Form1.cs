using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak1
{
    public partial class Form1 : Form
    {

        List<Knjiga> listaKnjiga = new List<Knjiga>();
        List<Knjiga> listaIznajmljeno = new List<Knjiga>();
         
        
        
        public Form1()
        {
            InitializeComponent();
            Knjiga knjiga = new Knjiga("Harry Potter");
            listaKnjiga.Add(knjiga);
            knjiga = new Knjiga("Gospodar prstenova");
            listaKnjiga.Add(knjiga);
            knjiga = new Knjiga("Druzba Pere Kvrzice");
            listaKnjiga.Add(knjiga);

            lbIznajmljene.DataSource = listaIznajmljeno;
            lbPopisKnjiga.DataSource = listaKnjiga;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Knjiga knjiga = (Knjiga)lbPopisKnjiga.SelectedItem;

            listaKnjiga.Remove(knjiga);
            listaIznajmljeno.Add(knjiga);

            lbIznajmljene.DataSource = null;
            lbPopisKnjiga.DataSource = null;

            lbIznajmljene.DataSource = listaIznajmljeno;
            lbPopisKnjiga.DataSource = listaKnjiga;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Knjiga knjiga = (Knjiga)lbIznajmljene.SelectedItem;

            listaIznajmljeno.Remove(knjiga);
            listaKnjiga.Add(knjiga);

            lbIznajmljene.DataSource = null;
            lbPopisKnjiga.DataSource = null;

            lbIznajmljene.DataSource = listaIznajmljeno;
            lbPopisKnjiga.DataSource = listaKnjiga;
        }
    }
}
