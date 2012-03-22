using System;
using Magnum;
using Magnum.StateMachine;
using MassTransit;
using MassTransit.Saga;

namespace MessagePOC.MessageBus.Contracts.Sagas
{
    public class ApprovalSaga : SagaStateMachine<ApprovalSaga>, ISaga
    {
        static ApprovalSaga()
        {
            Define(() =>
                       {
                           Correlate(ChangeRequested).By((saga, message) => saga.CorrelationId == message.CorrelationId);
                           Correlate(ChangeApproved).By((saga, message) => saga.CorrelationId == message.CorrelationId);
                           Correlate(ChangeRejected).By((saga, message) => saga.CorrelationId == message.CorrelationId);

                           Initially(
                               When(ChangeRequested)
                               .Then((saga, message) => saga.Begin(message))
                               .TransitionTo(ApprovalPending));

                           During(ApprovalPending, When(ChangeApproved)
                               .Then((saga, message) => saga.Approve(message))
                               .TransitionTo(Completed));

                           During(ApprovalPending, When(ChangeRejected)
                               .Then((saga, message) => saga.Reject(message))
                               .TransitionTo(Completed));
                       });
        }

        // states
        public static State Initial { get; set; }
        public static State ApprovalPending { get; set; }
        public static State Completed { get; set; }

        // bus, injected from ???
        public IServiceBus Bus { get; set; }

        private Guid _correlationId;
        private string _name;
        private decimal _income;
        private bool? _approved;
        private string _changedBy;
        private DateTime _changedOn;
        private string _reviewedBy;
        private DateTime? _reviewedOn;

        // persisted properties (not lazy loaded, so doesn't have to be virtual)
        public Guid CorrelationId { get { return _correlationId; }}
        public string Name { get { return _name; } }
        public decimal Income { get { return _income; } }
        public bool? Approved { get { return _approved; } }
        public string ChangedBy { get { return _changedBy; } }
        public DateTime ChangedOn { get { return _changedOn; } }
        public string ReviewedBy { get { return _reviewedBy; } }
        public DateTime? ReviewedOn { get { return _reviewedOn; } }

        // EVENTS //
        public static Event<IncomeChangeRequest> ChangeRequested { get; set; }
        public static Event<IncomeChangeApproval> ChangeApproved { get; set; }
        public static Event<IncomeChangeRejection> ChangeRejected { get; set; }

        // CONSTRUCTORS //
        public ApprovalSaga()
        {
            _correlationId = CombGuid.Generate();
        }

        public ApprovalSaga(Guid correlationId)
        {
            _correlationId = correlationId;
        }

        // BEHAVIORS //
        public void Begin(IncomeChangeRequest message)
        {
            _correlationId = message.CorrelationId;
            _name = message.Name;
            _income = message.NewIncome;
            _changedBy = message.ChangedBy;
            _changedOn = message.ChangedOn;
        }

       public void Approve(IncomeChangeApproval approval)
        {
            _approved = true;
            _reviewedBy = approval.ChangedBy;
            _reviewedOn = approval.ChangedOn;
            Bus.Publish(new IncomeChange(CorrelationId, Name, Income, approval.ChangedBy));
        }

        public void Reject(IncomeChangeRejection rejection)
        {
            _approved = false;
            _reviewedBy = rejection.ChangedBy;
            _reviewedOn = rejection.ChangedOn;
        }

        public override string ToString()
        {
            return string.Format("{0}: Income change requested by {1} for {2} to {3:c}", ChangedOn, ChangedBy, Name, Income);
        }
    }
}