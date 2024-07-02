using Renci.SshNet;
using Renci.SshNet.Common;

namespace Egyptian_association_of_cieliac_patients.Repositories
{
    public class SftpService:ISftpService
    {
        private readonly string _sftpServer;
        private readonly string _sftpUsername;
        private readonly string _sftpPassword;

        public SftpService(IConfiguration configuration)
        {
            _sftpServer = configuration["Sftp:Host"];
            _sftpUsername = configuration["Sftp:Username"];
            _sftpPassword = configuration["Sftp:Password"];
        }

        public async Task UploadFile(string folder,string fileName, Stream fileStream, CancellationToken cancellationToken = default)
        {
            using (SftpClient client = new SftpClient(_sftpServer, 22, _sftpUsername, _sftpPassword))
            {
                try
                {
                    // Combine base path with filename for SFTP path
                    var sftpPath = Path.Combine(folder, fileName); // Adjust base path as needed

                    await client.ConnectAsync(cancellationToken); // Use await for asynchronous connect

                    using (var sftpStream = client.Create(sftpPath))
                    {
                        await fileStream.CopyToAsync(sftpStream);
                    }
                }
                catch (OperationCanceledException)
                {
                    // Handle cancellation if needed
                }
            }
        }

        public async Task<Stream> GetImageStream(string fileName, CancellationToken cancellationToken = default)
        {
            using (SftpClient client = new SftpClient(_sftpServer, _sftpUsername, _sftpPassword))
            {
                try
                {
                    await client.ConnectAsync(cancellationToken); // Use asynchronous connect

                    var sftpPath = Path.Combine("user_images", fileName); // Adjust path as needed
                    using (var sftpStream = client.OpenRead(sftpPath))
                    {
                        // Return a new MemoryStream copy of the downloaded image data
                        var memoryStream = new MemoryStream();
                        await sftpStream.CopyToAsync(memoryStream);
                        memoryStream.Position = 0; // Reset position for reading
                        return memoryStream;
                    }
                }
                catch (OperationCanceledException)
                {
                    // Handle cancellation if needed
                    return null;
                }
                catch (SftpPathNotFoundException)
                {
                    // Handle case where file doesn't exist
                    return null;
                }
            }
        }
    }
}
