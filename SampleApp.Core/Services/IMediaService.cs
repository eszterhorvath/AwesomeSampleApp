using System.IO;
using System.Threading.Tasks;

namespace SampleApp.Core.Services
{
    public interface IMediaService
    {
        Task<Stream> TakePictureAsync();
        Task<Stream> PickPictureAsync();
    }
}
