using InMemoryContactData.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryContactData.Services
{
    public interface IContactData
    {
        IEnumerable<Contact> GetAll();
    }

}
