using System;
using System.Data;
using World_Cup___DataAccess;

namespace WorldCup_BusinessLogic
{
    public class clsTeam
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public int WorldCupTrophies { get; set; }

        clsTeam (int ID, string Name, string Continent, int WorldCupTrophies)
        {
            this.ID = ID;
            this.Name = Name;
            this.Continent = Continent;
            this.WorldCupTrophies = WorldCupTrophies;
        }

        static public clsTeam Find(string Name)
        {
            int ID = -1, WorldCupTrophies = -1;
            string Continent = "";
            if (clsTeamData.GetTeamByID(ref ID, Name, ref Continent, ref WorldCupTrophies))
                return new clsTeam(ID, Name, Continent, WorldCupTrophies);
            else
                return null;
        }

        static public DataTable GetAllTeams()
        {
            return clsTeamData.GetAllTeams(); 
        }

        static public DataTable GetAllTeamsNames()
        {
            return clsTeamData.GetAllTeamsNames();
        }

        static public int GetIDOfNationalTeam(string Name)
        {
            return clsTeamData.GetIDOfTeam(Name);
        }

        static public string GetTeamNameByID(int ID)
        {
            return clsTeamData.GetTeamNameWhereID(ID);
        }

    }
}
