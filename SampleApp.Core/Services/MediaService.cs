using System.IO;
using System.Threading.Tasks;
using Plugin.Media.Abstractions;

namespace SampleApp.Core.Services
{
    public class MediaService : IMediaService
    {
        public async Task<Stream> TakePictureAsync()
        {
            var media = Plugin.Media.CrossMedia.Current;

            await media.Initialize();

            if (!media.IsCameraAvailable || !media.IsTakePhotoSupported)
                return null;

            var file = await media.TakePhotoAsync(new StoreCameraMediaOptions
            {
                Name = "picture.jpg",
                PhotoSize = PhotoSize.MaxWidthHeight,
                MaxWidthHeight = 500,
                CompressionQuality = 76,
                SaveToAlbum = true
            });

            return file?.GetStream();
        }

        public async Task<Stream> PickPictureAsync()
        {
            var media = Plugin.Media.CrossMedia.Current;

            await media.Initialize();

            if (!media.IsPickPhotoSupported)
                return null;

            var file = await media.PickPhotoAsync(new PickMediaOptions
            {
                PhotoSize = PhotoSize.MaxWidthHeight,
                MaxWidthHeight = 500,
                CompressionQuality = 76
            });

            return file?.GetStream();
        }
    }
}
