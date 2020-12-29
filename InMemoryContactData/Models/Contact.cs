using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryContactData.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public int Hours { get; set; }
        public string Notes { get; set; }
        public string Jurisdicton { get; set; }
        public string Role { get; set; }
        
    }
}
