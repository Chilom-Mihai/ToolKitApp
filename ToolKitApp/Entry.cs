using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolKitApp
{
    internal class Entry
    {
        public string url;
        public string name;
        public string key;

        public Entry(string newUrl, string newName, string newKey)
        {
            url = newUrl;
            name = newName;
            key = newKey;
        }

    }
}
