using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Hunter : Person
    {
        private string _camera;

        public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
        {
            _camera = camera;
        }

        public Hunter()
        {

        }

        public string Shoot()
        {
            var fullName = $"{base.FirstName} {base.LastName}";
            return $"{FullName} has taken a photo with a {_camera}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}"; 
        }
    }

    public class MonsterHunter : Hunter
    {
        // The following won't work if the Hunter is sealed.
        public override string ToString()
        {
            return "I'm a Monster Hunter";
        }
    }
}
