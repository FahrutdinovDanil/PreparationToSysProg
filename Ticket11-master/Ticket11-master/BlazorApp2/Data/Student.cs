using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace BlazorApp1.Data
{
    public class Team
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }

        static List<Team> team = new List<Team>();

        public Team(string name, string login, string email)
        {
            Name = name;
            Login = login;
            Email = email;
        }

        public static void AddToList(string name, string login, string email)
        {
            Team std = new Team(name, login, email);
            team.Add(std);
        }

        public static List<Team> GetTeam()
        {
            return team;
        }

        public static void Add (Team team)
        {
            MongoClient client = new MongoClient();
            var bs = client.GetDatabase("Name");
            var list = bs.GetCollection<Team>("Name");
            list.InsertOne(team);
        }
    }


}
