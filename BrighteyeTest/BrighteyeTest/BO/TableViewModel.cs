using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace BrighteyeTest
{
    internal class TableViewModel : DependencyObject
    {
        private static BrighteyeTestDBContext _context = new BrighteyeTestDBContext();

        private ICollectionView Numbers
        {
            get { return (ICollectionView)GetValue(NumbersProperty); }
            set { SetValue(NumbersProperty, value); }
        }

        private static readonly DependencyProperty NumbersProperty =
            DependencyProperty.Register("Numbers", typeof(ICollectionView), typeof(TableViewModel), new PropertyMetadata(null));

        internal TableViewModel()
        {
            Numbers = CollectionViewSource.GetDefaultView(_context.SortedNumbers.ToList());
        }
    }
}
