using Aerotec.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet3UpInterfaces.Factories
{
    public interface IUserFactory
    {
        /// <summary>
        /// Get's a list of all the <see cref="User"/> from the json file.
        /// </summary>
        /// <returns></returns>
        List<User> RefreshUsersFromHard();

        /// <summary>
        /// Returns all the <see cref="User"/> from currently enrolled.
        /// </summary>
        /// <returns></returns>
        List<User> GetUsers();

        /// <summary>
        /// Returns the names of all the <see cref="User"/> from the system.
        /// </summary>
        /// <returns></returns>
        List<string> GetUserNames();

        /// <summary>
        /// Creates a new empty <see cref="User"/>.
        /// </summary>
        /// <returns></returns>
        User Create();

        /// <summary>
        /// Creates a new <see cref="User"/>.
        /// </summary>
        /// <param name="name">The name that will be set to it.</param>
        /// <returns></returns>
        User Create(string name);
    }
}
