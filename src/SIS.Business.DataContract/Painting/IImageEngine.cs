using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Painting
{
    public interface IImageEngine
    {
        string UploadImageAndGetUrl(PaintingCreateDTO image);
        string UpdateImageAndGetUrl(PaintingUpdateDTO image);
    }

    
}
