using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatMeUp.Model
{
    public class Custommer
    {
        private string username = String.Empty;
        private string password = String.Empty;
        private string firstName = String.Empty;
        private string lastName = String.Empty;
        private string gender = String.Empty;
        private string favouriteTypeFood = string.Empty;
        private byte[] image = Array.Empty<byte>();

        public Custommer(string username, string password, string firstName, string lastName, string gender, byte[] image, string favouriteTypeFood)
        {
            this.Username = username;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Image = image;
            this.FavouriteTypeFood = favouriteTypeFood;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public byte[] Image { get => image; set => image = value; }
        public string FavouriteTypeFood { get => favouriteTypeFood; set => favouriteTypeFood = value; }
    }
}

