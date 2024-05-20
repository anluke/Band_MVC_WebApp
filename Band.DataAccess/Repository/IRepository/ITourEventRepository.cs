using Band.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Band.DataAccess.Repository.IRepository
{
    public interface ITourEventRepository : IRepository<TourEvent>
    {
        void Update(TourEvent obj);

    }
}
