namespace Proiect1;
using Proiect1;
using Proiect1.Database;
using Proiect1.Views;
using System;
using System.IO;
public partial class App : Application
{
    static LoginDatabase database;

    // Create the database connection as a singleton.
    public static LoginDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new LoginDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SQLLiteSample.db"));
            }
            return database;
        }
    }

    public App()
    {
        InitializeComponent();

        MainPage = new AppShell(); //LoginPage()
    }
    
}
