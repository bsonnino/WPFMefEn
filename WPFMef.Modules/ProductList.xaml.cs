using System.Linq;
using System.Windows.Controls;

namespace WPFMef.Modules
{
    /// <summary>
    /// Interaction logic for ProductList.xaml
    /// </summary>
    public partial class ProductList
    {
        public ProductList()
        {
            InitializeComponent();
            List.ItemsSource = Enumerable.Range(1, 100)
                .Select(n => "Product " + n);

        }
    }
}
