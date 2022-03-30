// See https://aka.ms/new-console-template for more information
using Lzma;

Console.WriteLine("Hello, World!");
//SevenZip.Compression.LZMA.Decoder coder = new SevenZip.Compression.LZMA.Decoder();
LzmaHandler.CompressFileLZMA("Testdata/MR.dcm", "Testdata/MR.7z");



