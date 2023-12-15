using TestSQLiteInMAUI.Services;

namespace TestSQLiteInMAUI
{
    public partial class App : Application
    {
        // TODO: Add a public static PersonRepository property
        public static PersonRepository PersonRepo;
        public App(PersonRepository repo)
        {
            InitializeComponent();

            MainPage = new AppShell();

            // TODO: Initialize the PersonRepository property with the PersonRespository singleton object
            PersonRepo = repo;
        }
    }
}
