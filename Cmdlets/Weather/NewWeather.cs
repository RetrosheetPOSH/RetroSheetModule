using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using RetroSheet.V2.Models;

namespace RetroSheetModule.Cmdlets.Weather
{
    [Cmdlet(VerbsCommon.New, "Weather", HelpUri = "https://github.com/RetroSheetPOSH/RetroSheetModule/blob/main/Docs/New-RsWeather.md#new-rsweather")]
    [OutputType("RetroSheet.V2.Models.Umpire")]
    [CmdletBinding(PositionalBinding = true)]
    public class NewWeather : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            RetroSheet.V2.Models.Weather NewWeather = new();
            WriteObject(NewWeather);
        }
    }
}