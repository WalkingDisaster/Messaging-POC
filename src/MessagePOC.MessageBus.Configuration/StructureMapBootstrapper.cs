using StructureMap;

namespace MessagePOC.MessageBus.Configuration
{
    public static class StructureMapBootstrapper
    {
         public static IContainer Bootstrap()
         {
             ObjectFactory.Initialize(x => x.Scan(s =>
                                                  {
                                                      s.AssembliesFromApplicationBaseDirectory(y => y.FullName.StartsWith("MessagePOC"));
                                                      s.WithDefaultConventions();
                                                      s.LookForRegistries();
                                                  }));

             ObjectFactory.Configure(x => x.For<IContainer>().Use(ObjectFactory.Container));

             return ObjectFactory.Container;
         }
    }
}