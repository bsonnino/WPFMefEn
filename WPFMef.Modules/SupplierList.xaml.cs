using System.Linq;
using System.Windows.Controls;

namespace WPFMef.Modules
{
    /// <summary>
    /// Interaction logic for SupplierList.xaml
    /// </summary>
    public partial class SupplierList
    {
        public SupplierList()
        {
            InitializeComponent();
            List.ItemsSource = Enumerable.Range(1, 100)
                .Select(n => "Supplier " + n);

        }
    }
}
