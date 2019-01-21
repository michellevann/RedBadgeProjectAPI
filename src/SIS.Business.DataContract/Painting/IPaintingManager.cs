using RedStarter.API.DataContract.Painting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Painting
{
    public interface IPaintingManager
    {
        Task<bool> CreatePainting(PaintingCreateDTO dto);
        Task<IEnumerable<PaintingGetListItemDTO>> GetPaintings();
        Task<PaintingGetListItemDTO> GetPaintingById(int id);
        Task<bool> DeletePainting(int id);
        Task<bool> UpdatePainting(PaintingUpdateDTO dto);
    }
}
