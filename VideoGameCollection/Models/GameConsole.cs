using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoGameCollection.Models
{
    public class GameConsole
    {
        /// <summary>
        /// This is just a list of Game consoles that I am using for a drop down list when creating a new game or editing an existing one
        /// </summary>

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