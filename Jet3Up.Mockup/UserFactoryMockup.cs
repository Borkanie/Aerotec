using Aerotec.Data.Model;
using Jet3UpInterfaces.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet3Up.Services.Mockup
{
    public class UserFactoryMockup : IUserFactory
    {
        private List<User> users;

        /// <inheritdoc/>
        public User Create()
        {
            var user = new User();
            users.Add(user);
            return user;
        }

        /// <inheritdoc/>
        public User Create(string name)
        {
            var user = new User(name);
            users.Add(user);
            return user;
        }

        /// <inheritdoc/>
        public void Destroy(User user)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public List<string> GetuserNames()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public List<string> GetUserNames()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void RevertChanges()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        IUserContainer IUserFactory.GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
