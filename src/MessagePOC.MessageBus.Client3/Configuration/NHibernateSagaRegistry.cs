using System.Data;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MassTransit.NHibernateIntegration.Saga;
using MassTransit.Saga;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using MessagePOC.MessageBus.Contracts.SagaMaps;
using StructureMap.Configuration.DSL;

namespace MessagePOC.MessageBus.Client3.Configuration
{
    public class NHibernateSagaRegistry : Registry
    {
         public NHibernateSagaRegistry()
         {
             Scan(x => x.AddAllTypesOf<ISaga>());
             For<ISessionFactory>().Use(() => Fluently.Configure()
                                                  .Database(
                                                      MsSqlConfiguration.MsSql2008
                                                          .ConnectionString("Server=(local);initial catalog=test;Trusted_Connection=yes")
                                                          .DefaultSchema("DBO")
                                                          .Raw(NHibernate.Cfg.Environment.Isolation, IsolationLevel.Serializable.ToString()))
                                                  .ProxyFactoryFactory("NHibernate.Bytecode.DefaultProxyFactoryFactory, NHibernate")
                                                  .Mappings(m =>
                                                                {
                                                                    m.FluentMappings.Add<ApprovalSagaMap>();
                                                                })
                                                  .ExposeConfiguration(c => new SchemaUpdate(c).Execute(false, true))
                                                  .BuildSessionFactory());
         }
    }
}