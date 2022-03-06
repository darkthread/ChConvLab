var s = "預設記憶體大小與硬碟容量";
var resPath =
    Path.GetDirectoryName(typeof(Program).Assembly.Location);
var c = new ChConvUtil.Converter(resPath);
var r = c.TWtoCN(s);
Console.WriteLine(r);
Console.WriteLine(c.CNtoTW(r));

