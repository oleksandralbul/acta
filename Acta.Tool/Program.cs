using System.Reflection;

namespace Acta.Tool;

internal class Program
{
	static void Main(string[] args)
	{
		var version = Assembly
			.GetEntryAssembly()?
			.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
			.InformationalVersion;

		Console.WriteLine($"Acta v{version}");
	}
}
