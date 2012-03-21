using MassTransit.NHibernateIntegration;
using FluentNHibernate.Mapping;
using MessagePOC.MessageBus.Contracts.Sagas;

namespace MessagePOC.MessageBus.Contracts.SagaMaps
{
    public class ApprovalSagaMap : ClassMap<ApprovalSaga>
    {
         public ApprovalSagaMap()
         {
             Not.LazyLoad();

             Id(x => x.CorrelationId);
             Map(x => x.Name).Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore);
             Map(x => x.Income).Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore);
             Map(x => x.Approved).Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore);
             Map(x => x.ChangedBy).Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore);
             Map(x => x.ChangedOn).Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore);

             Map(x => x.CurrentState)
                 .Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore)
                 .CustomType<StateMachineUserType>();
         }
    }
}