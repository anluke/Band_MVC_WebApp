using Band.DataAccess.Data;
using Band.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Band.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set;}
        public IProductRepository Product { get; private set; }
        public ITourEventRepository TourEvent { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            TourEvent = new TourEventRepository(_db);
        }


        public void Save()
        {
            _db.SaveChanges();

        }
    }
}
