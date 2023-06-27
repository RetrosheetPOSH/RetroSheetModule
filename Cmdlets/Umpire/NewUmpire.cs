using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using RetroSheet.V2.Models;

namespace RetroSheetModule.Cmdlets.Umpire
{
    [Cmdlet(VerbsCommon.New, "Umpire", HelpUri = "https://github.com/RetroSheetPOSH/RetroSheetModule/blob/main/Docs/New-RsUmpire.md#new-rsumpire")]
    [OutputType("RetroSheet.V2.Models.Umpire")]
    [CmdletBinding(PositionalBinding = true)]
    public class NewUmpire : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            RetroSheet.V2.Models.Umpire NewUmpire = new();
            WriteObject(NewUmpire);
        }
    }
}