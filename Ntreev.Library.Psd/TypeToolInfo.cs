﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ntreev.Library.Psd
{
    class TypeToolInfo : Properties
    {
        private int version;

        public TypeToolInfo(PsdReader reader)
        {
            this.version = (int)reader.ReadInt16();
            this.Add("Transforms", reader.ReadDoubles(6));
            this.Add("TextVersion", reader.ReadInt16());
            this.Add("Text", new DescriptorStructure(reader));
            this.Add("WarpVersion", reader.ReadInt16());
            this.Add("Warp", new DescriptorStructure(reader));
            this.Add("Bounds", reader.ReadDoubles(2));
        }
    }
}
