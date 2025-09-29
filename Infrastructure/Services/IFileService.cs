using Infrastructure.Models;

namespace Infrastructure.Services;

public interface IFileService
{
    FileResult SaveContentToFile(string path, string content);
    FileResult GetContentFromFile(string path);

}
// Sökväg til filen: Infrastructure/Interfaces/IFileService.cs