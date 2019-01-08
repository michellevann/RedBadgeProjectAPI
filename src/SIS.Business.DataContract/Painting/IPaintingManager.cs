using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Painting
{
    public interface IPaintingManager
    {
        Task<bool> CreatePainting(PaintingCreateDTO dto);
    }
}
