using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EncounterManager
{
    public class SortableBindingList<T> : BindingList<T>
    {
        public bool isSorted { get; set; }
        public PropertyDescriptor sortProperty { get; set; }
        public ListSortDirection sortDirection { get; set; }
        protected override bool SupportsSortingCore { get { return true; } }

        protected override void ApplySortCore( PropertyDescriptor property, ListSortDirection direction )
        {
            List<T> itemsList = (List<T>)this.Items;
            if (property.PropertyType.GetInterface("IComparable") != null)
            {
                itemsList.Sort(new Comparison<T>(delegate ( T x, T y )
                {
                    // Compare x to y if x is not null. If x is, but y isn't, we compare y
                    // to x and reverse the result. If both are null, they're equal.
                    if (property.GetValue(x) != null)
                        return ((IComparable)property.GetValue(x)).CompareTo(property.GetValue(y)) * (direction == ListSortDirection.Descending ? -1 : 1);
                    else if (property.GetValue(y) != null)
                        return ((IComparable)property.GetValue(y)).CompareTo(property.GetValue(x)) * (direction == ListSortDirection.Descending ? 1 : -1);
                    else
                        return 0;
                }));
            }

            isSorted = true;
            sortProperty = property;
            sortDirection = direction;
        }

        protected override bool IsSortedCore
        {
            get { return isSorted; }
        }

        protected override void RemoveSortCore()
        {
            isSorted = false;
        }
    }
}
