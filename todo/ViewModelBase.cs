using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace todo
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged<T>(Expression<Func<T>> property)
        {
            if (this.PropertyChanged != null)
            {
                MemberExpression expression = property.Body as MemberExpression;
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(expression.Member.Name);
                this.PropertyChanged(this, args);
            }
        }
    }
}
