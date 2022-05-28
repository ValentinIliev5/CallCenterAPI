using Data.Context;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    // anti-pattern
    public class UnitOfWork : IDisposable
    {
        private CCDBContext context = new CCDBContext();
        private GenericRepository<Call> callsRepository;
        private GenericRepository<Client> clientsRepository;
        private GenericRepository<Employee> employeesRepository;
        public GenericRepository<Call> CallsRepository
        {
            get
            {

                if (this.callsRepository == null)
                {
                    this.callsRepository = new GenericRepository<Call>(context);
                }
                return callsRepository;
            }
        }

        public GenericRepository<Client> ClientsRepository
        {
            get
            {
                if (this.clientsRepository == null)
                {
                    this.clientsRepository = new GenericRepository<Client>(context);
                }
                return clientsRepository;
            }
        }

        public GenericRepository<Employee> EmployeesRepository
        {
            get
            {
                if (this.employeesRepository == null)
                {
                    this.employeesRepository = new GenericRepository<Employee>(context);
                }
                return employeesRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
