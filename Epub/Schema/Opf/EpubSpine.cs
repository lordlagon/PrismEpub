using System.Collections.Generic;

namespace Epub.Epub.Schema
{
    public class EpubSpine : List<EpubSpineItemRef>
    {
        public string Toc { get; set; }
    }
}
