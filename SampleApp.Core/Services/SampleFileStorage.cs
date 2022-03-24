using System;
using System.IO;
using System.Threading.Tasks;
using iCL.Plugins.FileRepository;

namespace SampleApp.Core.Services
{
    public class SampleFileStorage : IFileStorage
    {
        private static readonly Lazy<IFileRepository> _fileRepository = new(() =>
        {
            var dataDir = Xamarin.Essentials.FileSystem.AppDataDirectory;
            var rootPath = Path.Combine(dataDir, "pictures");
            return new FileRepository(new FileRepoConfig { RootPath = rootPath }, new FileEntryInMemoryStore());
        });
        private IFileRepository FileRepository => _fileRepository.Value;

        public Task InsertOrReplaceFileSetAsync(Guid fileSetId, Stream stream, string mimeType)
        {
            return FileRepository.InsertOrReplaceFileSetAsync(fileSetId, stream, mimeType: mimeType,
                fileEntryKind: FileEntryKind.Image);
        }

        public Task<bool> ExistsAsync(Guid fileSetId)
        {
            return FileRepository.ExistsAsync(fileSetId);
        }

        public async Task<string> GetPathOfEditedImageOrImageAsync(Guid fileSetId)
        {
            if (await FileRepository.ExistsInFileSetAsync(fileSetId, FileEntryKind.EditedImage).ConfigureAwait(false))
                return await FileRepository.GetPathFromFileSetAsync(fileSetId, FileEntryKind.EditedImage).ConfigureAwait(false);
            return await FileRepository.GetPathAsync(fileSetId).ConfigureAwait(false);
        }
    }
}
