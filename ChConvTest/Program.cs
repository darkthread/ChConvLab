var s = "預設記憶體大小與硬碟容量";
var resPath = 
    Path.GetDirectoryName(typeof(Program).Assembly.Location);
var c = new ChConvUtil.Converter(resPath);
Console.WriteLine(c.TWtoCN(s));
Console.WriteLine(c.CNtoTW(s));

