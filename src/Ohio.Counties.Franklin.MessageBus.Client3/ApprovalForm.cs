using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MassTransit;
using NHibernate;
using NHibernate.Linq;
using Ohio.Counties.Franklin.MessageBus.Configuration;
using Ohio.Counties.Franklin.MessageBus.Contracts;
using Ohio.Counties.Franklin.MessageBus.Contracts.Sagas;
using IContainer = StructureMap.IContainer;

namespace Ohio.Counties.Franklin.MessageBus.Client3
{
    public partial class ApprovalForm : Form
    {
        private static ApprovalForm instance;
        private IServiceBus bus;
        private IContainer container;

        public ApprovalForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void ApprovalForm_Load(object sender, EventArgs e)
        {
            container = StructureMapBootstrapper.Bootstrap();
            bus = container.GetInstance<IServiceBus>();
            ReloadValues();
            timer1.Start();
        }

        private void ReloadValues()
        {
            var session = container.GetInstance<ISessionFactory>().OpenSession();
            var items = session.Query<ApprovalSaga>().Where(s => s.Approved == null).ToList();
            RemoveAllItemsNotListed(items);
            foreach (var item in items)
            {
                AddItemIfMissing(item);
            }
            session.Close();            
        }

        private void RemoveAllItemsNotListed(ICollection<ApprovalSaga> items)
        {
            var toRemove = new Queue<ApprovalSaga>();
            foreach (var item in listBox1.Items.Cast<ApprovalSaga>())
            {
                if (!items.Any(x => x.CorrelationId == item.CorrelationId))
                    toRemove.Enqueue(item);
            }
            while (toRemove.Count > 0)
                listBox1.Items.Remove(toRemove.Dequeue());
        }

        private void AddItemIfMissing(ApprovalSaga item)
        {
            if (listBox1.Items.Cast<ApprovalSaga>().Any(x => x.CorrelationId == item.CorrelationId))
                return;
            listBox1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var items = listBox1.SelectedItems.Cast<ApprovalSaga>();
            foreach (var item in items)
            {
                bus.Publish(new IncomeChangeApproval(item.CorrelationId, UserNameInput.Text));
            }
            ReloadValues();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReloadValues();
        }
    }
}
