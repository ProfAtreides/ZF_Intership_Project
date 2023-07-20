using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    class DatabaseEventHandler
    {
        public event EventHandler ItemAdded;
        public event EventHandler ItemRemoved;
        public event EventHandler DatabaseChanged;

        protected virtual void OnItemAdded(EventArgs e)
        {
            ItemAdded?.Invoke(this, e);
        }

        protected virtual void OnItemRemoved(EventArgs e)
        {
            ItemRemoved?.Invoke(this, e);
        }

        protected virtual void OnDataBaseChanged(EventArgs e)
        {
            DatabaseChanged?.Invoke(this, e);
        }

    }
}
