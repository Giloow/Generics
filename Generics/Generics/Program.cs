using Generics;

DataFlow<string> process = new DataFlow<string>();
process.AddBlock(new UpperCaseBlock());
process.AddBlock(new ReverseBlock());
process.AddBlock(new ReplaceAWith6Block());
Console.WriteLine(process.RunFlow("abcAbCD"));
