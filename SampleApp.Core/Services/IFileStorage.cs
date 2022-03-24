using System;
using System.IO;
using System.Threading.Tasks;

namespace SampleApp.Core.Services
{
    public class MimeTypes
    {
        public const string Jpeg = "image/jpeg";
        public const string Svg = "image/svg+xml";
        public const string Png = "image/png";
    }

    public interface IFileStorage
    {
        Task<bool> ExistsAsync(Guid fileSetId);
        Task<string> GetPathOfEditedImageOrImageAsync(Guid fileSetId);
        Task InsertOrReplaceFileSetAsync(Guid fileSetId, Stream stream, string mimeType);
    }
}