using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace Taller_en_clase_22._05._2024
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
