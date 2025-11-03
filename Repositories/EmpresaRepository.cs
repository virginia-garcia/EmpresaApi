using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpresaApi.Models;
using EmpresaApi.Data;

namespace EmpresaApi.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly EmpresaDbContext _context;

        public EmpresaRepository(EmpresaDbContext context)
        {
            _context = context;
        }



        public async Task<List<Employees>> GetAllEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<int> GetEmployeeCountAsync()
        {
            return await _context.Employees.CountAsync();
        }

        public async Task<Employees> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeID == id);
        }

        public async Task<Employees> GetEmployeeByNameAsync(string name)
        {
            // Busca por nombre completo (FirstName + LastName)
            return await _context.Employees
                                 .FirstOrDefaultAsync(e => (e.FirstName + " " + e.LastName).ToLower() == name.ToLower());
        }

        public async Task<Employees> GetEmployeeByTitleAsync(string title)
        {
            return await _context.Employees
                                 .FirstOrDefaultAsync(e => e.Title.ToLower() == title.ToLower());
        }

        public async Task<Employees> GetOneEmployeeByCountryAsync(string country)
        {
            return await _context.Employees
                                 .FirstOrDefaultAsync(e => e.Country.ToLower() == country.ToLower());
        }

        public async Task<List<Employees>> GetAllEmployeesByCountryAsync(string country)
        {
            return await _context.Employees
                                 .Where(e => e.Country.ToLower() == country.ToLower())
                                 .ToListAsync();
        }

        public async Task<Employees> GetOldestEmployeeAsync()
        {
            
            return await _context.Employees
                                 .OrderBy(e => e.BirthDate)
                                 .FirstOrDefaultAsync();
        }

        
        public async Task<List<TituloCantidadDTO>> GetEmployeeCountByTitleAsync()
        {
            return await _context.Employees
                                 .GroupBy(e => e.Title)
                                 .Select(g => new TituloCantidadDTO
                                 {
                                     Titulo = g.Key,
                                     Cantidad = g.Count()
                                 })
                                 .ToListAsync();
        }



        public async Task<List<ProductoConCategoriaDTO>> GetProductsWithCategoryAsync()
        {
            return await _context.Products
                                 .Include(p => p.Category)
                                 .Select(p => new ProductoConCategoriaDTO
                                 {
                                     ProductID = p.ProductID,
                                     ProductName = p.ProductName,
                                     CategoryName = p.Category.CategoryName
                                 })
                                 .ToListAsync();
        }

        public async Task<List<Products>> GetProductsContainingWordAsync(string word)
        {
            return await _context.Products
                                 .Where(p => p.ProductName.ToLower().Contains(word.ToLower()))
                                 .ToListAsync();
        }
    }
}
