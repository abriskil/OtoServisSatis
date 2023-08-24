using OtoServisSatis.Data;
using OtoServisSatis.Data.Abstract;
using OtoServisSatis.Data.Concrete;
using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Service.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        // !! constructor neden dbcontext istiyor bul. --Data.Concrete repository içinde constructor böyle parametre olarak geçildiği içinmiş.
        public Service(DatabaseContext context) : base(context)
        {
        }
    }
}
