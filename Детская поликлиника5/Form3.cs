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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void врачиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.врачиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.детская_поликлиника_1DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "детская_поликлиника_1DataSet.Врачи". При необходимости она может быть перемещена или удалена.
            this.врачиTableAdapter.Fill(this.детская_поликлиника_1DataSet.Врачи);

        }
        public Form3(Form1 f)
        {
            InitializeComponent();
        }
    }
}
