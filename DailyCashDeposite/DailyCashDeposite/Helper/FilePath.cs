using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCashDeposite.Helper
{
    public static class FilePath
    {
        public static string NoPath { get; set; } = "No Path Selected";
        public static string SourcePath { get; set; } = NoPath;
        public static string ArchivePath { get; set; } = NoPath;
    }
}
