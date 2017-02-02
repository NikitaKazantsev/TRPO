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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Open_Kafedra_Button_Click(object sender, EventArgs e)
        {
            Kafedra_Form kafedra_form = new Kafedra_Form();
            kafedra_form.Show();
        }

        private void Open_Otdel_Kadrov_Button_Click(object sender, EventArgs e)
        {
            Otdel_Kadrov otdel_kadrov = new Otdel_Kadrov();
            otdel_kadrov.Show();
        }
    }
}
