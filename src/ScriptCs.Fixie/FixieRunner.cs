using System.Reflection;
using Fixie.Execution;
using Fixie.Listeners;
using ScriptCs.Contracts;

namespace ScriptCs.Fixie
{
	public class FixieRunner : IScriptPackContext
	{
		public void RunAllTests()
		{
			var assemblyToTest = Assembly.GetCallingAssembly();
			var runner = new Runner(new ConsoleListener());
			runner.RunAssembly(assemblyToTest);
		}
	}
}