using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Детская_поликлиника5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void анализыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.анализыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.детская_поликлиника_1DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "детская_поликлиника_1DataSet.Анализы". При необходимости она может быть перемещена или удалена.
            this.анализыTableAdapter.Fill(this.детская_поликлиника_1DataSet.Анализы);

        }
        public Form2(Form1 f)
        {
            InitializeComponent();
        }
    }
}
