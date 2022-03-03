using System.Collections.Generic;
using System;

namespace KeepMovinAPI.DAOs
{
    public interface IDao<T>
    {
        void Add(T item);
        void Remove(Guid id);
        T Get(Guid id);
        IEnumerable<T> GetAll();
    }
}