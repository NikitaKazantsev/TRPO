using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafedra
{
    public partial class Groups_From_Kafedra : Form
    {
        public Groups_From_Kafedra()
        {
            InitializeComponent();
        }

        private void Groups_From_Kafedra_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kafedraDataSet.Gruppa". При необходимости она может быть перемещена или удалена.
            this.gruppaTableAdapter.Fill(this.kafedraDataSet.Gruppa);

        }
    }
}
