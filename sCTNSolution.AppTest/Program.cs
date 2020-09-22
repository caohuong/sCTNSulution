
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using sCTNSolution.AppTest.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace sCTNSolution.AppTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] 
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // var _httpClient = new HttpClient();
            //_httpClient.BaseAddress = new Uri("https://localhost:44325/");
            // serverapi.ConfigarutionAsync(_httpClient);
            serverapi.ConfigarutionAsync();
            Application.Run(new Login());
        }
    }
}
