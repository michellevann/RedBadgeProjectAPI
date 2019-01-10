using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Painting
{
    public interface IPaintingRepository
    {
        Task<bool> CreatePainting(PaintingCreateRAO rao);
        Task<IEnumerable<PaintingGetListItemRAO>> GetPaintings();
        Task<PaintingGetListItemRAO> GetPaintingById(int id);
        Task<bool> DeletePainting(int id);
        Task<bool> UpdatePainting(PaintingUpdateRAO rao);
    }
}
