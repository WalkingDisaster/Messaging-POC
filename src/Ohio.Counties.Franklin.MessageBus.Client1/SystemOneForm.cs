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

        private void button1_Click(object sender, System.EventArgs e)
        {
            var message = textBox1.Text;
            var bus = ObjectFactory.GetInstance<IServiceBus>();
            bus.Publish(new TextChanged(message));
        }
    }
}
