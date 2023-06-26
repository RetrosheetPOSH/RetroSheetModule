using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using RetroSheet.V2.Models;

namespace RetroSheetModule.Cmdlets.Sub
{
    [Cmdlet(VerbsCommon.New, "Sub", HelpUri = "https://github.com/RetroSheetPOSH/RetroSheetModule/blob/main/Docs/New-Sub.md#new-sub")]
    [OutputType("RetroSheet.V2.Models.Sub")]
    [CmdletBinding(PositionalBinding = true)]
    public class NewSub : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            RetroSheet.V2.Models.Sub NewSub = new();
            WriteObject(NewSub);
        }
    }
}