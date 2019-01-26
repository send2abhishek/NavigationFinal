using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;
using NavigationFinal.Droid;

[assembly:Dependency(typeof(LocalFileHelper))]
namespace NavigationFinal.Droid
{
    public class LocalFileHelper : ILocalFileHelper
    {
        public string getLocalFilePath(string fileName)
        {
            String docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, fileName);
        }
    }
}