// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Aerotec.Data.Model;

namespace Jet3UpInterfaces.Factories
{
    public interface IUserFactory
    {
        /// <summary>
        /// Get's a list of all the <see cref="User"/> from the json file.
        /// </summary>
        /// <returns></returns>
        void RevertChanges();

        void SaveChanges();

        /// <summary>
        /// Returns all the <see cref="User"/> from currently enrolled.
        /// </summary>
        /// <returns></returns>
        IUserContainer GetUsers();

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
