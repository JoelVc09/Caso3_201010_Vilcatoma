using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso3Biblio.Domain.Core.Interface;
using Caso3Biblio.Domain.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Caso3Biblio.Domain.Infrastructure.Repositories
{
    internal class Repositories: ICustomerRepository
    {
        private readonly Parcial202220101061Context _context;

        public Repositories(Parcial202220101061Context context)
        {
            _context = context;
        }
        //ObBTENER TODOS LOS DOCTORES 
        public async Task<IEnumerable<Doctor>> GetCustomers()
        {
            var Doctor = await _context.Doctor.ToListAsync();
            return Doctor;
        }
        //DEVOLVER DOCTOR POR ID
        public async Task<Doctor> GetCustomerById(int id)
        {
            var Doctor = await _context.Doctor.Where(x => x.Id == id).FirstOrDefaultAsync();
            //if (customer == null)
            //    throw new Exception("Customer not found");
            return Doctor;
        }
        //INSERTAR DOCTORES
        public async Task<bool> Insert(Doctor Doctor)
        {
            await _context.Doctor.AddAsync(Doctor);
            var countRows = await _context.SaveChangesAsync();
            return countRows > 0;
        }




    }
}
