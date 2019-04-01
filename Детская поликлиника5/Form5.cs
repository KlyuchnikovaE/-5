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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void процедурыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.процедурыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.детская_поликлиника_1DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "детская_поликлиника_1DataSet.Процедуры". При необходимости она может быть перемещена или удалена.
            this.процедурыTableAdapter.Fill(this.детская_поликлиника_1DataSet.Процедуры);

        }
        public Form5(Form1 f)
        {
            InitializeComponent();
        }
    }
}
