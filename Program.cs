using System;
using System.Collections.Generic;

namespace LV3 {
	class Program {
		static void Main(string[] args) {
			//Dataset data = new Dataset("csv.txt");
			//IList<List<string>> fileData = data.GetData();
			//foreach (var row in fileData) {
			//	foreach (var element in row) {
			//		Console.Write(element + " ");
			//	}
			//	Console.WriteLine();
			//}
			//Console.WriteLine();

			//Dataset dataCopy = (Dataset)data.Clone();
			//dataCopy.ChangeFirstElement();
			//IList<List<string>> fileDataCopy = dataCopy.GetData();
			//foreach (var row in fileDataCopy) {
			//	foreach (var element in row) {
			//		Console.Write(element + " ");
			//	}
			//	Console.WriteLine();
			//}


			MatrixGenerator generator = MatrixGenerator.GetInstance();
			double[][] matrix = generator.CreateMatrix(6, 9);
			foreach (var row in matrix) {
				foreach (var element in row)
					Console.Write(element + " ");
				Console.WriteLine("");
			}

			FileLogger logger = FileLogger.GetInstance();
			logger.Log("XDDDDDDDDDD");
			logger.filePath = "log2.txt";
			logger.Log("XDDDDDDD");
		}
	}
}
