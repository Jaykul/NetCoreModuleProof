using System.Management.Automation;

namespace NetCoreModuleProof
{
    [Cmdlet(VerbsCommon.Get, "Greeting")]
    public class GreetingGetCommand : Cmdlet
    {

        protected override void EndProcessing()
        {
            base.EndProcessing();

            WriteObject("Hello World");
        }
    }
}
