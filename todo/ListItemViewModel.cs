using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace todo
{
    public class ListItemViewModel : ViewModelBase
    {
        public ListItemViewModel(ListItem item)
        {
            this.IsChecked = item.Complete;
            this.ItemText = item.Name;
        }

        private bool _isChecked = false;
        public bool IsChecked
        {
            get { return this._isChecked; }
            set
            {
                this._isChecked = value;
                NotifyPropertyChanged(() => IsChecked);
            }
        }

        private string _itemText = string.Empty;
        public string ItemText
        {
            get { return this._itemText; }
            set
            {
                this._itemText = value;
                NotifyPropertyChanged(() => ItemText);
            }
        }
    }
}
