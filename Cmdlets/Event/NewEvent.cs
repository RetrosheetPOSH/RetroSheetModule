using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using RetroSheet.V2.Models;

namespace RetroSheetModule.Cmdlets.Event
{
    [Cmdlet(VerbsCommon.New, "Event", HelpUri = "https://github.com/RetroSheetPOSH/RetroSheetModule/blob/main/Docs/New-Event.md#new-event")]
    [OutputType("RetroSheet.V2.Models.Event")]
    [CmdletBinding(PositionalBinding = true)]
    public class NewEvent : PSCmdlet
    {
        [Parameter(Mandatory = false, Position = 0)]
        public string Id { get; set; } = string.Empty;
        protected override void ProcessRecord()
        {
            RetroSheet.V2.Models.Event NewEvent = new();
            if (Id != null)
            {
                NewEvent.Id = Id;
            }
            WriteObject(NewEvent);
        }
    }
}