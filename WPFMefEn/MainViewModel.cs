using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using WPFMef.Interfaces;

namespace WPFMefEn
{
    public class MainViewModel
    {
        [ImportMany]
        public IEnumerable<IModule> Modules { get; set; }

        public MainViewModel()
        {
            var catalog = new AggregateCatalog(
                new AssemblyCatalog(Assembly.GetExecutingAssembly()),
                new DirectoryCatalog("."));
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }
    }

}
