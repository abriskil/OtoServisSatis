using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entities
{
    //Id class'larda zorunlu olacak.Veritabanı nesnelerini IEntity olarak işaretliyoruz.
    public interface IEntity
    {
        public int Id { get; set; }
    }
}
