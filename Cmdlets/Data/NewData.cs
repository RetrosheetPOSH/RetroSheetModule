using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using RetroSheet.V2.Models;

namespace RetroSheetModule.Cmdlets.Data
{
    [Cmdlet(VerbsCommon.New, "Data", HelpUri = "https://github.com/RetroSheetPOSH/RetroSheetModule/blob/main/Docs/New-RsData.md#new-rsdata")]
    [OutputType("RetroSheet.V2.Models.Datum")]
    [CmdletBinding(PositionalBinding = true)]
    public class NewData : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            RetroSheet.V2.Models.Datum NewData = new();
            WriteObject(NewData);
        }
    }
}