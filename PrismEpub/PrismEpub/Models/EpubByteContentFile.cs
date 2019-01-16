using System;
using System.Collections.Generic;
using System.Text;

namespace PrismEpub.Models
{
   public  class EpubByteContentFile: EpubContentFile
    {
        public byte[] Content { get; set; }

    }
}
