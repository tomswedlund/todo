using System.Collections.ObjectModel;
using Framework;

namespace todo
{
    public class ListItemsViewModel : ViewModelBase
    {
        public ListItemsViewModel()
        {
            this.CurrentListItems = new ObservableCollection<ListItemViewModel>();
            this.CurrentListItems.Add(new ListItemViewModel(new ListItem("list item one")));
            this.CurrentListItems.Add(new ListItemViewModel(new ListItem("list item two")));
            this.CurrentListItems.Add(new ListItemViewModel(new ListItem("list item three")));
        }

        public ObservableCollection<ListItemViewModel> CurrentListItems { get; private set; }
    }
}
