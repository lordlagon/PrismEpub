﻿using System;

namespace Epub.Epub.Schema
{
    public class EpubSpineItemRef
    {
        public string IdRef { get; set; }
        public bool IsLinear { get; set; }

        public override string ToString()
        {
            return String.Concat("IdRef: ", IdRef);
        }
    }
}
