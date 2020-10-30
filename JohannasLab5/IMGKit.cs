using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohannasLab5
{
    public class IMGKit
    {
        public readonly byte[] Content;
        public readonly string URL;

        public IMGKit(string url, byte[] content)
        {
            Content = content;
            URL = url;
        }
    }
}
