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
    public partial class Personal_From_Kafedra : Form
    {
        public Personal_From_Kafedra()
        {
            InitializeComponent();
        }

        private void Personal_From_Kafedra_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kafedraDataSet.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.kafedraDataSet.Personal);

        }
    }
}
