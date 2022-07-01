using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp2;
using BlazorApp2.Data;

namespace BlazorApp1.Data
{
    public class InfoTeamEx
    {
        public static string FirstColum = "Nickname";
        public static string SecondColum = "Group";

        public static List<Team> AddTable { get => Team.GetTeam(); }
    }
}
