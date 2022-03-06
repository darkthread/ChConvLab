using System;
using System.IO;
using OpenCCNET;

namespace ChConvUtil
{
    public class Converter
    {
        public Converter(string path = ".") {
            var jiebaResourceDirectory = Path.Combine(path, "JiebaResource");
            JiebaNet.Segmenter.ConfigManager.ConfigFileBaseDir = jiebaResourceDirectory;
            ZhConverter.Initialize();
            ZhDictionary.Initialize(
                Path.Combine(path, "Dictionary"));
        }
        public string TWtoCN(string src) => ZhConverter.TWToHans(src, true);
        public string CNtoTW(string src) => ZhConverter.HansToTW(src, true);
    }
}
