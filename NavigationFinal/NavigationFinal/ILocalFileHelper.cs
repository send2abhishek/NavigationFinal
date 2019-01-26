using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationFinal
{
    //this interface for bringing your native file path of database to your xamerin forms
    public interface ILocalFileHelper
    {
        String getLocalFilePath(String fileName);
    }
}
