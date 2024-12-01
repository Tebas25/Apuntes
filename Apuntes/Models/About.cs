using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Apuntes.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Messsage => "Esta aplicación esta escrita en XAML y C# con .NET MAUI.";
    }
}
