using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration
{
    internal class Model
    {
        private static List<Model> _models = new List<Model>();
        public string ID { get; set; }
        public string FirstName { get; set; }
       public string LastName { get; set; }
        public string Address { get; set; }
        public  string SchoolYear  { get; set; }
        public string Gender { get; set; }
        public static Model findOne(string id)
        {
            return _models.Find(p => p.ID == id);
        }
        public void save()
        {
            Console.WriteLine("You have registered successfully");
            _models.Add(this);
        }
        public static List<Model> GetAll()
        {
            return _models;   
        }
    }
}
