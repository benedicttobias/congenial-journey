using Core;
using StructureMap;

namespace IoCStructureMapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build registry
            var registry = new Registry();
            registry.IncludeRegistry<DefaultRegistry>();

            // build container
            var container = new Container(registry);

            // Get instance using IoC
            var writer = container.GetInstance<Writter>();

            // Write them
            writer.Write("My text is using StructureMap");
        }

        /// <summary>
        /// Example of registry
        /// </summary>
        public class DefaultRegistry : Registry
        {
            public DefaultRegistry()
            {
                For<IWritterDevice>().Use<Emailer>();
                For<IWritterDevice>().Use<Printer>(); // StructureMap using the last one registered

            }
        }
    }
}
