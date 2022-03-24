using System;
using System.IO;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using ReactiveUI;
using SampleApp.Core.Services;

namespace SampleApp.Core.ViewModels
{
    public class ImageLoadingTestViewModel : MvxViewModel
    {
        private readonly IMediaService _media;
        private readonly IFileStorage _fileStorage;
        private string _imagePath;
        private bool _hasImage;

        public ImageLoadingTestViewModel()
        {
            _media = new MediaService();
            _fileStorage = new SampleFileStorage();
        }

        public async void PickPictureAsync()
        {
            using var stream = await _media.PickPictureAsync();
            await StoreFileAsync(stream);
            ImagePath = await GetFilePathAsync();
        }

        public async void TakePictureAsync()
        {
            using var stream = await _media.TakePictureAsync();
            await StoreFileAsync(stream);
            ImagePath = await GetFilePathAsync();
        }

        public string ImagePath
        {
            get => _imagePath;
            set
            {
                if (_imagePath == value)
                    return;

                HasImage = true;
                this.RaiseAndSetIfChanged(ref _imagePath, value);
            }
        }

        public bool HasImage
        {
            get => _hasImage;
            set
            {
                if (_hasImage == value)
                    return;

                this.RaiseAndSetIfChanged(ref _hasImage, value);
            }
        }

        public Guid FileId { get; set; }

        private async Task StoreFileAsync(Stream stream)
        {
            try
            {
                if (stream == null || stream == Stream.Null)
                    return;

                // create new file
                FileId = Guid.NewGuid();
                await _fileStorage.InsertOrReplaceFileSetAsync(FileId, stream, MimeTypes.Jpeg);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private async Task<string> GetFilePathAsync()
        {
            if (!await _fileStorage.ExistsAsync(FileId))
                return null;

            return await _fileStorage.GetPathOfEditedImageOrImageAsync(FileId);
        }
    }
}
