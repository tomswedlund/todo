using System;

namespace Framework
{
    public class ListItem
    {
        public bool Complete { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; private set; }

        public ListItem(string name)
        {
            this.Created = DateTime.UtcNow;
            this.Name = name;
        }
    }
}
