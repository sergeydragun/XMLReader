using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XMLReader.Models
{
    public static class ObservableCollectionDelete
    {
        public static void DeleteAllObjects<T>(this ObservableCollection<T> collection)
        {
            for(int i = collection.Count - 1; i >= 0; i--)
            {
                collection.RemoveAt(i);
            }
        }
    }
}
