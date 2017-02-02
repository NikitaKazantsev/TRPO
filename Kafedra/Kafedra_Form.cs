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
    public partial class Kafedra_Form : Form
    {
        public Kafedra_Form()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Kafedra_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kafedraDataSet.Gruppa_Запрос". При необходимости она может быть перемещена или удалена.
            this.gruppa_ЗапросTableAdapter.Fill(this.kafedraDataSet.Gruppa_Запрос);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Groups_From_Kafedra groups_from_kafedra=new Groups_From_Kafedra();
            groups_from_kafedra.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.gruppa_ЗапросTableAdapter.Update(this.kafedraDataSet.Gruppa_Запрос);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.gruppa_ЗапросTableAdapter.Fill(this.kafedraDataSet.Gruppa_Запрос);
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Personal_From_Kafedra personal_from_kafedra = new Personal_From_Kafedra();
            personal_from_kafedra.Show();
        }
    }
}
