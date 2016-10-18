using System.ComponentModel.Composition;
using System.Windows;
using WPFMef.Interfaces;

namespace WPFMef.Modules
{
    [Export(typeof(IModule))]
    public class Customer : IModule
    {
        public string Title
        {
            get { return "Customers"; }
        }

        public UIElement Content
        {
            get { return new CustomerList(); }
        }
    }

    [Export(typeof(IModule))]
    public class Product : IModule
    {
        public string Title
        {
            get { return "Products"; }
        }

        public UIElement Content
        {
            get { return new ProductList(); }
        }
    }

    [Export(typeof(IModule))]
    public class Supplier : IModule
    {
        public string Title
        {
            get { return "Suppliers"; }
        }

        public UIElement Content
        {
            get { return new SupplierList(); }
        }
    }
}
