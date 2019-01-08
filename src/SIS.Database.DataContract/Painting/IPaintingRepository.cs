using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Painting
{
    public interface IPaintingRepository
    {
        Task<bool> CreatePainting(PaintingCreateRAO rao);
    }
}
