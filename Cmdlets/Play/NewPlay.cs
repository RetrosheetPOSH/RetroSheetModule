using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using RetroSheet.V2.Models;

namespace RetroSheetModule.Cmdlets.Play
{
    [Cmdlet(VerbsCommon.New, "Play", HelpUri = "https://github.com/RetroSheetPOSH/RetroSheetModule/blob/main/Docs/New-Play.md#new-play")]
    [OutputType("RetroSheet.V2.Models.Play")]
    [CmdletBinding(PositionalBinding = true)]
    public class NewPlay : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            RetroSheet.V2.Models.Play NewPlay = new();
            WriteObject(NewPlay);
        }
    }
}