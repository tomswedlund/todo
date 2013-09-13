using System.Collections.ObjectModel;
using Framework;

namespace todo
{
    public class ListItemsViewModel : ViewModelBase
    {
        public ListItemsViewModel()
        {
            this.CurrentListItems = new ObservableCollection<ListItem>();
            this.CurrentListItems.Add(new ListItem("list item one"));
            this.CurrentListItems.Add(new ListItem("list item two"));
            this.CurrentListItems.Add(new ListItem("list item three"));
        }

        public ObservableCollection<ListItem> CurrentListItems { get; private set; }
    }
}
