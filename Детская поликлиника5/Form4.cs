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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void пациентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пациентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.детская_поликлиника_1DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "детская_поликлиника_1DataSet.Пациенты". При необходимости она может быть перемещена или удалена.
            this.пациентыTableAdapter.Fill(this.детская_поликлиника_1DataSet.Пациенты);

        }
        public Form4(Form1 f)
        {
            InitializeComponent();
        }
    }
}
