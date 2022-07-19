using static System.Console;

WriteLine("--------------------------------------------------------------------------");
WriteLine("Type     Byte(s) of memory               Min                           Max");
WriteLine("--------------------------------------------------------------------------");
WriteLine($"sbyte {sizeof(sbyte),4} {sbyte.MinValue,33} {sbyte.MaxValue,29}");
WriteLine($"byte {sizeof(byte),5} {byte.MinValue,33} {byte.MaxValue,29}");
WriteLine($"short {sizeof(short),4} {short.MinValue,33} {short.MaxValue,29}");
WriteLine($"ushort {sizeof(ushort),3} {ushort.MinValue,33} {ushort.MaxValue,29}");
WriteLine($"int {sizeof(int),6} {int.MinValue,33} {int.MaxValue,29}");
WriteLine($"uint {sizeof(uint),5} {uint.MinValue,33} {uint.MaxValue,29}");
WriteLine($"long {sizeof(long),5} {long.MinValue,33} {long.MaxValue,29}");
WriteLine($"ulong {sizeof(ulong),4} {ulong.MinValue,33} {ulong.MaxValue,29}");
WriteLine($"float {sizeof(float),4} {float.MinValue,33} {float.MaxValue,29}");
WriteLine($"double {sizeof(double),3} {double.MinValue,33} {double.MaxValue,29}");
WriteLine($"decimal {sizeof(decimal),3} {decimal.MinValue,32} {decimal.MaxValue,29}");
WriteLine("--------------------------------------------------------------------------");


