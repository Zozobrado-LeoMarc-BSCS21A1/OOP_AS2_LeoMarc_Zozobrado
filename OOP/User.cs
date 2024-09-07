using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace OOP
{
    public class User
    {
        private JsonDocument json;

        private List<Identity> Users { get; set; }

       
        public User()
        {
            Users = new List<Identity>();
        }

       
        public void LoadUsersFromJson(string filePath)
        {
            try
            {
                string jsonData = File.ReadAllText(filePath);
                Users = JsonSerializer.Deserialize<List<Identity>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading users: {ex.Message}");
            }
        }

  
        public bool IsValid(string username, string password)
        {
            foreach (var user in Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}


