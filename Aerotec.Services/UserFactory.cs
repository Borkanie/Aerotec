// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Aerotec.Data.Model;
using Jet3UpInterfaces.Factories;
using Newtonsoft.Json;

namespace Jet3Up.Services
{
    /// <inheritdoc/>
    public class UserFactory : IUserFactory
    {
        private List<User> defaultUsers = new();
        private List<User> users =  new();
        
        public UserFactory()
        {
            RevertChanges();
        }

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
            try
            {
                users.Remove(user);
                string jsonFilePath = "users.json";
                string json = File.ReadAllText(jsonFilePath);
                defaultUsers = JsonConvert.DeserializeObject<List<User>>(json);

                if (defaultUsers.Contains(user))
                {
                    defaultUsers.Remove(user);
                    string serializedJson = JsonConvert.SerializeObject(defaultUsers, Formatting.Indented);
                    File.WriteAllText(jsonFilePath, serializedJson);
                    users.Remove(user);
                }
            }
            catch (IOException ex)
            {

            }
        }

        /// <inheritdoc/>
        public List<string> GetUserNames()
        {
            var names = new List<string>();
            foreach (var user in users)
            {
                names.Add(user.Name);
            }
            return names;
        }

        /// <inheritdoc/>
        public List<User> GetUsers()
        {
            return users;
        }

        /// <inheritdoc/>
        public void RevertChanges()
        {

            try
            {
                string jsonFilePath = "users.json";
                string json = File.ReadAllText(jsonFilePath);

                defaultUsers = JsonConvert.DeserializeObject<List<User>>(json);
                foreach (var user in defaultUsers)
                {
                    var dummy = new User()
                    {
                        Name = user.Name,
                        Id = user.Id,
                    };
                    users.Add(dummy);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <inheritdoc/>
        public void SaveChanges()
        {
            try
            {
                string jsonFilePath = "users.json";
                
                if (!File.Exists(jsonFilePath))
                {
                   File.Create(jsonFilePath);
                }

                defaultUsers.Clear();
                foreach (var user in users)
                {
                    var dummy = new User()
                    {
                        Name = user.Name,
                        Id = user.Id,
                    };
                    defaultUsers.Add(dummy);
                }
                string serializedJson = JsonConvert.SerializeObject(defaultUsers, Formatting.Indented);
                File.WriteAllText(jsonFilePath, serializedJson);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
