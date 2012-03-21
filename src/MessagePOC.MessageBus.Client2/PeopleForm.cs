using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MassTransit;
using MessagePOC.MessageBus.Configuration;
using MessagePOC.MessageBus.Contracts;

namespace MessagePOC.MessageBus.Client2
{
    public partial class PeopleForm : Form
    {
        private static PeopleForm instance;

        private ICollection<Person> people;

        public PeopleForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            people = new BindingList<Person>
                         {
                             new Person
                                 {
                                     Name = "Sally",
                                     Income = 100000m,
                                     LastChanged = new DateTime(2012, 1, 1)
                                 },
                             new Person
                                 {
                                     Name = "Bill",
                                     Income = 50000m,
                                     LastChanged = new DateTime(2012, 1, 1)
                                 },
                             new Person
                                 {
                                     Name = "Fredrick",
                                     Income = 60000m,
                                     LastChanged = new DateTime(2012, 1, 1)
                                 },
                             new Person
                                 {
                                     Name = "Mitch",
                                     Income = 1000000m,
                                     LastChanged = new DateTime(2012, 1, 1)
                                 },
                         };
            Data.DataSource = people;
        }

        public static void ChangeName(NameChanged message)
        {
            instance.Invoke(new Action(() =>
            {
                if (instance.people.Any(p => p.Name == message.OldName))
                {
                    instance.people.Single(p => p.Name == message.OldName).Name = message.NewName;
                }
                else
                {
                    instance.people.Add(new Person
                    {
                        Name = message.NewName,
                        Income = 0m,
                        LastChanged = message.ChangedOn
                    });
                }
                instance.Data.Refresh();
            }));
        }

        public static void ChangeIncome(IncomeChange message)
        {
            instance.Invoke(new Action(() =>
            {
                if (instance.people.Any(p => p.Name == message.Name))
                {
                    instance.people.Single(p => p.Name == message.Name).Income = message.Income;
                }
                instance.Data.Refresh();
            }));
        }
    }
}
