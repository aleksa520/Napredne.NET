using Data.Repositories;
using DatabaseEFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class UnitOfWork : IDisposable
    {
        private DbContext _context;
        private DbContextOptions<V1Context> _options;

        public DbContext DataContext => _context ?? (_context = new V1Context());

        #region Repositories

        private EmployeeRepository _employeeRepository;
        public EmployeeRepository EmployeeRepository => _employeeRepository ?? (_employeeRepository = new EmployeeRepository(DataContext));

        private PaymentRepository _paymentRepository;
        public PaymentRepository PaymentRepository => _paymentRepository ?? (_paymentRepository = new PaymentRepository(DataContext));

        private DepartmentRepository _departmentRepository;
        public DepartmentRepository DepartmentRepository => _departmentRepository ?? (_departmentRepository = new DepartmentRepository(DataContext));
        #endregion

        public void Save()
        {
            _context.ChangeTracker.DetectChanges();
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _dissposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!_dissposed)
            {
                if (disposing)
                {
                    if(_context != null)
                    {
                        _context.Dispose();
                    }
                }
            }
            _dissposed = true;
        }
    }
}
