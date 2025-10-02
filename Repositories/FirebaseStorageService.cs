
//using Firebase.Storage;

//public class FirebaseStorageService
//{
//    private readonly string _storageBucket;
//    private readonly FirebaseStorage _firebaseStorage;

//    public FirebaseStorageService(string storageBucket, IFirebaseStorage firebaseStorage)
//    {
//        _storageBucket = storageBucket;
//        _firebaseStorage = firebaseStorage;
//    }

//    public async Task<string> UploadImageAsync(IFormFile file)
//    {
//        if (file == null || file.Length == 0)
//        {
//            throw new ArgumentNullException(nameof(file), "Uploaded file cannot be null or empty.");
//        }

//        // Generate a unique filename
//        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

//        try
//        {
//            // Upload the image using IFirebaseStorage
//            await _firebaseStorage.PutAsync(_storageBucket, fileName, file.OpenReadStream());

//            // Get the download URL (might require additional configuration)
//            var downloadUrl = await _firebaseStorage.GetDownloadUrlAsync(_storageBucket, fileName);

//            return downloadUrl;
//        }
//        catch (Exception ex)
//        {
//            throw new Exception($"Error uploading image: {ex.Message}"); // Rethrow a more informative exception
//        }
//    }
//}