using System;
using System.IO;

namespace SuperBASIC
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Library lib = new Library();
#if MEMORY
				lib.AddFunction(new Functions.MemoryLoad(), 1, "MEMLOAD");
				lib.AddFunction(new Functions.MemoryStore(), 2, "MEMSTORE");
#endif
				lib.AddFunction(new Functions.Print(), 1, "PRINT");
				lib.AddFunction(new Functions.Multiply(), 2, "MULTIPLY");
				lib.AddFunction(new Functions.Add(), 2, "ADD");
				lib.AddFunction(new Functions.Compare(), 2, "COMPARE");
				lib.AddFunction(new Functions.JumpZero(), 2, "JZ");
				lib.AddFunction(new Functions.Goto(), 1, "GOTO");
				lib.AddFunction(new Functions.Pi(), 0, "PI");
				lib.AddFunction(new Functions.Euler(), 0, "EULER");
				lib.AddFunction(new Functions.Arcsin(), 1, "ARCSIN");
				lib.AddFunction(new Functions.Sin(), 1, "SIN");
				lib.AddFunction(new Functions.Cos(), 1, "COS");
				lib.AddFunction(new Functions.Acos(), 1, "ACOS");
				lib.AddFunction(new Functions.SolveLinear(), 3, "SOLVE_LINEAR");
				lib.AddFunction(new Functions.Rem(), 2, "REM");
				lib.AddFunction(new Functions.CylinderVol(), 2, "CYLINDER_VOL");
				lib.AddFunction(new Functions.SphereVol(), 2, "SPHERE_VOL");
				lib.AddFunction(new Functions.Gratio(), 0, "GRATIO");
				lib.AddFunction(new Functions.Tan(), 1, "TAN");
				lib.AddFunction(new Functions.Accumulate(), 2, "ACCUMULATE");
				lib.AddFunction(new Functions.Average(), 2, "AVERAGE");
				lib.AddFunction(new Functions.Partition(), 2, "PARTITION");
				lib.AddFunction(new Functions.QuickSelect(), 3, "QUICK_SELECT");
				lib.AddFunction(new Functions.Median(), 2, "MEDIAN");
				lib.AddFunction(new Functions.StalinSort(), 2, "STALIN_SORT");
				lib.AddFunction(new Functions.Sort(), 2, "SORT");
				lib.AddFunction(new Functions.M5(), 5, "M5");

				Runtime r = new Runtime(lib);
				if (args.Length <= 1)
				{
					r.OpenFile(Directory.GetCurrentDirectory() + "\\TestPartition.basic");
				} 
				else
				{
					r.OpenFile(args[1]);
				}
				r.Run();
			} catch (Parser.ParseException e)
			{
				Console.WriteLine($"Parsing failed:\n{e}");
			}
		}
	}
}
//MEMSTORE 1 0
//MEMSTORE 0 10
//WHILE MEMLOAD 0
//MEMLOAD 0
//ADD $ -1
//MEMSTORE 0 $
//MEMLOAD 1
//ADD $ 1
//MEMSTORE 1 $
//PRINT M1
//WEND

//Sin test
//MEMSTORE 0 1
//SIN M0
//PRINT $

//Accumulate test
//MEMSTORE 0 1,5
//MEMSTORE 1 2
//MEMSTORE 2 4
//MEMSTORE 3 0
//ACCUMULATE 0 3
//PRINT $