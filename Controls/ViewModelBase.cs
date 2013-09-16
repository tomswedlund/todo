using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Controls
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged<T>(Expression<Func<T>> expression)
        {
            if (this.PropertyChanged != null)
            {
                string propertyName = (expression as MemberExpression).Member.Name;
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
