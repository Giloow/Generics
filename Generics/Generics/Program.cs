using Generics;

DataFlow<string> process = new DataFlow<string>();
process.AddBlock(new UpperCaseBlock());
process.AddBlock(new ReverseBlock());
process.AddBlock(new ReplaceAWith6Block());
process.AddBlock(null);
Console.WriteLine(process.RunFlow(null));
