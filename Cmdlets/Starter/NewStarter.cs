using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using RetroSheet.V2.Models;

namespace RetroSheetModule.Cmdlets.Starter
{
    [Cmdlet(VerbsCommon.New, "Starter", HelpUri = "https://github.com/RetroSheetPOSH/RetroSheetModule/blob/main/Docs/New-RsStarter.md#new-rsstarter")]
    [OutputType("RetroSheet.V2.Models.Starter")]
    [CmdletBinding(PositionalBinding = true)]
    public class NewStarter : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            RetroSheet.V2.Models.Starter NewStarter = new();
            WriteObject(NewStarter);
        }
    }
}