using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoGameCollection.Models
{
    public class GameConsole
    {
        public static IEnumerable<SelectListItem> GetConsoleTypesList()
        {
            IList<SelectListItem> consoleTypes = new List<SelectListItem>
            {
                new SelectListItem() {Text="Playstation 4", Value="PS4"},
                new SelectListItem() { Text="Xbox One", Value="XB1"},
                new SelectListItem() { Text="Nintendo Switch", Value="SWITCH"},
            };
            return consoleTypes;
        }
    }
}