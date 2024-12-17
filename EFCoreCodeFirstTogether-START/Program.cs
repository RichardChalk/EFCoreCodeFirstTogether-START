using EFCoreCodeFirstTogether_START.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCoreCodeFirstTogether_START
{
    // Updated to .net8.0
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8: Vill vill lämna 'Main' static class och jobbar i vår egen class som heter 'Application'
            var app = new Application();
            app.Run();

        }
    }
}
