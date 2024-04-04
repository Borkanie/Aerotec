using Aerotec.Data.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet3Up.Services
{
    public class UserContainer : IUserContainer
    {
        public User this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(User item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(User item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(User[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<User> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(User item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, User item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(User item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
