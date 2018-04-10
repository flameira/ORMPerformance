namespace NPOCOvsEFCORE2vsADONETvsDAPPER
{
	using System;
	using BenchmarkDotNet.Running;

	class Program
    {
        static void Main(string[] args)
        {
	        var summary = BenchmarkRunner.Run(typeof(NpocOvsEFvsAdonetvsDapper));

			Console.WriteLine("Done");
	        Console.ReadLine();
         
        }
    }

	
}
