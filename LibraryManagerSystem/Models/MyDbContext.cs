namespace LibraryManagerSystem.Models
{
    public sealed class MyDbContext
    {
        // Singleton 
        private static nitlibraryEntities instance = new nitlibraryEntities();

        public static nitlibraryEntities Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new nitlibraryEntities();
                }
                return instance;
            }
        }

        private MyDbContext() { }
    }
}