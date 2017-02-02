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
    public partial class Otdel_Kadrov : Form
    {
        public Otdel_Kadrov()
        {
            InitializeComponent();
        }

        private void Otdel_Kadrov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kafedraDataSet.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.kafedraDataSet.Personal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.personalTableAdapter.Update(this.kafedraDataSet.Personal);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.personalTableAdapter.Fill(this.kafedraDataSet.Personal);
        }
    }
}
