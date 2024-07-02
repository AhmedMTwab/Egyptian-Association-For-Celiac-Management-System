namespace Egyptian_association_of_cieliac_patients.Repositories
{
    public interface ISftpService
    {
        public  Task UploadFile(string folder,string fileName, Stream fileStream, CancellationToken cancellationToken = default);
        public Task<Stream> GetImageStream(string fileName, CancellationToken cancellationToken = default);
    }
}
