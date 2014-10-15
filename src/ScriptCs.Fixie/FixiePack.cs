using ScriptCs.Contracts;

namespace ScriptCs.Fixie
{
	public class FixiePack : IScriptPack
	{
		public void Initialize(IScriptPackSession session)
		{
			session.ImportNamespace("Fixie.Execution");
			session.ImportNamespace("Fixie.Reports");
			session.ImportNamespace("Fixie.Results");
			session.ImportNamespace("ScriptCs.Fixie");
			session.ImportNamespace("System.Reflection");
		}

		public IScriptPackContext GetContext()
		{
			return new FixieRunner();
		}

		public void Terminate()
		{
		}
	}
}