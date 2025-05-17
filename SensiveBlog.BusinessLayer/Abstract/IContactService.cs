using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.BusinessLayer.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        // Custom methods for Contact can be added here
        // For example:
        // List<Contact> GetContactsByStatus(string status);
    }

}
