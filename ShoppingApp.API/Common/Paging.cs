﻿namespace ShoppingApp.API.Common
{
    public class Paging<T>
    {
        public T[] Items { get; set; }
        public int Total { get; set; }
        public int Current { get; set; }

        public Paging(T[] items, int total, int current = 0)
        {
            Items = items;
            Total = total;
            Current = current;
        }
    }
}
