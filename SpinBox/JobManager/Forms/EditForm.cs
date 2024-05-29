using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobManager
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            userControls1.dataSavedEvent += UserControls1_dataSavedEvent;
        }

        private void UserControls1_dataSavedEvent(bool isJob, Interfacedatas datas)
        {
            dataSavedEvent1?.Invoke(isJob, datas);
        }

        public DataSavedEventHandler dataSavedEvent1;
        UserControls uc = new UserControls();
        UserControl uc1 = new UserControl();

        public void Editting(bool isJob, Interfacedatas details)
        {
            userControls1.UpdateValues(isJob, details);
        }

        private void DataSavedEvent(bool isJob, Interfacedatas datas)
        {
            dataSavedEvent1?.Invoke(isJob, datas);
        }
    }
}
