using Band.DataAccess.Data;
using Band.DataAccess.Repository.IRepository;
using Band.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Band.DataAccess.Repository
{
    public class TourEventRepository : Repository<TourEvent>, ITourEventRepository
    {
        private ApplicationDbContext _db;
        public TourEventRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(TourEvent obj)
        {
            _db.TourEvent.Update(obj);
        }
    }
}
