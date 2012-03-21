using System.Windows.Forms;
using MassTransit;
using Ohio.Counties.Franklin.MessageBus.Contracts;
using StructureMap;

namespace Ohio.Counties.Franklin.MessageBus.Client1
{
    public partial class SystemOneForm : Form
    {
        public SystemOneForm()
        {
            InitializeComponent();
        }

        private void SendCommand_Click(object sender, System.EventArgs e)
        {
            var userName = UserNameInput.Text;
            var oldName = OriginalNameInput.Text;
            var newName = NewNameInput.Text;
            var bus = ObjectFactory.GetInstance<IServiceBus>();
            if (!string.IsNullOrEmpty(newName.Trim()))
            {
                bus.Publish(new NameChanged(oldName, newName, userName));
            }

            decimal income;
            if (decimal.TryParse(IncomeInput.Text, out income))
            {
                bus.Publish(new IncomeChangeRequest(string.IsNullOrEmpty(oldName) ? newName : oldName, income, userName));
            }
        }
    }
}
