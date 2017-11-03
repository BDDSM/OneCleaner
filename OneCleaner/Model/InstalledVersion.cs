﻿using System;

namespace OneCleaner
{
    public class InstalledVersion
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public long VersionInt { get; set; }
        public string UUID { get; set; }
        public string Location { get; set; }
        public DateTime InstallDate { get; set; }
        public long Size { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
