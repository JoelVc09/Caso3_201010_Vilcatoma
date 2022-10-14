using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso3Biblio.Domain.Infraestructure.Data;

namespace Caso3Biblio.Domain.Core.Interface
{
    public interface ICustomerRepository
    {

        Task<IEnumerable<Doctor>> GetCustomers();

        Task<Doctor> GetCustomerById(int id);

        Task<bool> Insert(Doctor Doctor);

    }
}
