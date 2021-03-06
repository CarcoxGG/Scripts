using TestProject.Common.DTO.ExecutionResult;
using TestProject.Common.Enums;
using System;
using System.Reflection;
using TestProject.SDK;

namespace TestProject.Generated.Tests.Temperaturas
{
	/// <summary>
	/// This class was automatically generated by TestProject
	/// Provides an example how to run coded TestProject tests
	/// </summary>
	public class TemperaturasRunner
	{
		public static string DevToken = "sT-2XY2vTZ26MYXuybLcJ24b0obWl-GDQ-GYf5G2KPM";
		public static AutomatedBrowserType Browser = AutomatedBrowserType.Chrome;
		public static StepExecutionResult RunTestTemperaturaManual()
		{
			using (var runner = new RunnerBuilder(DevToken).AsWeb(Browser).Build())
				return runner.Run(new TestTemperaturaManual(), true);
		}

		public static void Main(string[] args)
		{
			try
			{
				RunTestTemperaturaManual();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
	}
}