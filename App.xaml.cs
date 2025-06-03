using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DotNetEnv;


namespace ugyfel
{
    
    public partial class App : Application
    {
        public static string ConnString { get; private set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // .env betöltése
            DotNetEnv.Env.Load();
            ConnString = $"server={Env.GetString("DB_HOST")};user={Env.GetString("DB_USER")};password={Env.GetString("DB_PASS")};database={Env.GetString("DB_NAME")}";
            //ablak
            Regisztracio ablak = new Regisztracio();
            MainWindow = ablak;
            ablak.Show();
        }
    }
}
