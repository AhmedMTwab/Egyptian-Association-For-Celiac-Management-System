namespace Egyptian_association_of_cieliac_patients
{
   
        public class FirebaseConfig
        {
            public string ApiKey { get; set; }
            public string AuthDomain { get; set; }
            public string ProjectId { get; set; }
            public string StorageBucket { get; set; }
            public string SenderId { get; set; }
            public string AppId { get; set; }

            public FirebaseConfig()
            {
                // Replace with your actual Firebase project credentials
                ApiKey = "AIzaSyBQuuIwiT5zJu5ddUWhRdUBWSnkkgrPXvs";
                AuthDomain = "egyptian-assosiation-of-celiac.firebaseapp.com";
                ProjectId = "egyptian-assosiation-of-celiac";
                StorageBucket = "egyptian-assosiation-of-celiac.appspot.com";
                SenderId = "146254433938";
                AppId = "1:146254433938:web:1d9d28da29e63c1916a04b";
            }
        }
    
}
