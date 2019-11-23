﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FlubuCore.Tasks.Versioning
{
    public class BuildVersion
    {
        public Version Version { get; set; }

        public string VersionQuality { get; set; }

        public string BuildVersionWithQuality(int versionFieldCount)
        {
            return $"{Version.ToString(versionFieldCount)}{VersionQuality}";
        }
    }
}