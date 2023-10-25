// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Aerotec.Data.Model;
using Newtonsoft.Json;

namespace Aerotec.Data.Factories
{
    /// <summary>
    /// A factory that reads the users from the json file.
    /// </summary>
    static public class UserFactory
    {
        /// <summary>
        /// Returns all the users in the json file.
        /// </summary>
        /// <returns></returns>
        public static List<User> GetUsers()
        {

            // Read the JSON data from a file
            string jsonFilePath = "Resources/Controllers.json"; // Update with your JSON file path
            string json;


            json = File.ReadAllText(jsonFilePath);


            // Deserialize the JSON data into a list of User objects
            var users = JsonConvert.DeserializeObject<List<User>>(json); 
            if(users == null)
            {
                throw new Exception($"Eroare de citire fisier la {jsonFilePath}. Nu exista angajati inregistrati in fisier.");
            }
            return users;
        }

        /// <summary>
        /// Returns all the names of the Users.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetUserNames()
        {
           
            var users = GetUsers();
            
            List<string> result = new();
            foreach (var user in users)
            {
                result.Add(user.Name);
            }
            return result;
        }
    }
}
