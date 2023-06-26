using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using RetroSheet.V2.Models;

namespace RetroSheetModule.Cmdlets.Info
{
    [Cmdlet(VerbsCommon.New, "Info", HelpUri = "https://github.com/RetroSheetPOSH/RetroSheetModule/blob/main/Docs/New-Info.md#new-info")]
    [OutputType("RetroSheet.V2.Models.Info")]
    [CmdletBinding(PositionalBinding = true)]
    public class NewInfo : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            RetroSheet.V2.Models.Info NewInfo = new();
            WriteObject(NewInfo);
        }
    }
}