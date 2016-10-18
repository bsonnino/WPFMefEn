using System.Linq;
using System.Windows.Controls;

namespace WPFMef.Modules
{
    /// <summary>
    /// Interaction logic for CustomerList.xaml
    /// </summary>
    public partial class CustomerList
    {
        public CustomerList()
        {
            InitializeComponent();
            List.ItemsSource = Enumerable.Range(1, 100)
                .Select(n => "Customer " + n);
        }
    }
}
