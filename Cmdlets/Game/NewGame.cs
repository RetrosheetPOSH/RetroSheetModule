using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using RetroSheet.V2.Models;

namespace RetroSheetModule.Cmdlets.Game
{
    [Cmdlet(VerbsCommon.New, "Game", HelpUri = "https://github.com/RetroSheetPOSH/RetroSheetModule/blob/main/Docs/New-RsGame.md#new-rsgame")]
    [OutputType("RetroSheet.V2.Models.Game")]
    [CmdletBinding(PositionalBinding = true)]
    public class NewGame : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            RetroSheet.V2.Models.Game NewGame = new();
            WriteObject(NewGame);
        }
    }
}