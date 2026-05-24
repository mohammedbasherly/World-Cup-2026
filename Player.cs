using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using World_Cup___DataAccess;
using WorldCup_BusinessLogic;

namespace WorldCup_BusinessLogic
{
    public class clsPlayer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int KitNumber { get; set; }
        public int NationalTeamID { get; set; }
        public string Club {  get; set; }
        public string Position { get; set; }
        public short Age { get; set; }

        clsPlayer (int ID, string FirstName, string LastName, int KitNumber,
            int NationalNumberID, string Club, string Position, short Age)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.KitNumber = KitNumber;
            this.NationalTeamID = NationalNumberID;
            this.Club = Club;
            this.Position = Position;
            this.Age = Age;
        }

        static public clsPlayer FindByID(int ID)
        {
            int KitNumber = -1, NationalTeamID = -1;
            short Age = -1;
            string FirstName = "", LastName = "", Club = "", Position = "";

            if (clsPlayerData.GetPlayerByID(ID, ref FirstName, ref LastName, ref KitNumber,
                ref NationalTeamID, ref Club, ref Position, ref Age))
                return new clsPlayer(ID, FirstName, LastName, KitNumber, NationalTeamID, Club, Position, Age);
            else
                return null;
        }

        static public clsPlayer FindByFirstName(string FirstName)
        {
            int ID = -1, KitNumber = -1, NationalTeamID = -1;
            short Age = -1;
            string LastName = "", Club = "", Position = "";

            if (clsPlayerData.GetPlayerByFirstName(ref ID, FirstName, ref LastName, ref KitNumber,
                ref NationalTeamID, ref Club, ref Position, ref Age))
                return new clsPlayer(ID, FirstName, LastName, KitNumber, NationalTeamID, Club, Position, Age);
            else
                return null;
        }

        static public clsPlayer FindByLastName(string LastName)
        {
            int ID = -1, KitNumber = -1, NationalTeamID = -1;
            short Age = -1;
            string FirstName = "", Club = "", Position = "";

            if (clsPlayerData.GetPlayerByLastName(ref ID, ref FirstName, LastName, ref KitNumber,
                ref NationalTeamID, ref Club, ref Position, ref Age))
                return new clsPlayer(ID, FirstName, LastName, KitNumber, NationalTeamID, Club, Position, Age);
            else
                return null;
        }

        static public clsPlayer FindByNationalTeamID(int NationalTeamID)
        {
            int ID = -1, KitNumber = -1;
            short Age = -1;
            string FirstName = "", LastName = "", Club = "", Position = "";

            if (clsPlayerData.GetPlayerByNationalTeamID(ref ID, ref FirstName, ref LastName, ref KitNumber,
                NationalTeamID, ref Club, ref Position, ref Age))
                return new clsPlayer(ID, FirstName, LastName, KitNumber, NationalTeamID, Club, Position, Age);
            else
                return null;
        }

        static public clsPlayer FindByClub(string Club)
        {
            int ID = -1, KitNumber = -1, NationalTeamID = -1;
            short Age = -1;
            string FirstName = "", LastName = "", Position = "";

            if (clsPlayerData.GetPlayerByClub(ref ID, ref FirstName, ref LastName, ref KitNumber,
                ref NationalTeamID,  Club, ref Position, ref Age))
                return new clsPlayer(ID, FirstName, LastName, KitNumber, NationalTeamID, Club, Position, Age);
            else
                return null;
        }

        static public clsPlayer FindByPosition(string Position)
        {
            int ID = -1, KitNumber = -1, NationalTeamID = -1;
            short Age = -1;
            string FirstName = "", LastName = "", Club = "";

            if (clsPlayerData.GetPlayerByPosition(ref ID, ref FirstName, ref LastName, ref KitNumber,
                ref NationalTeamID, ref Club, Position, ref Age))
                return new clsPlayer(ID, FirstName, LastName, KitNumber, NationalTeamID, Club, Position, Age);
            else
                return null;
        }

        static public clsPlayer FindByAge(short Age)
        {
            int ID = -1, KitNumber = -1, NationalTeamID = -1;
            string FirstName = "", LastName = "", Club = "", Position = "";

            if (clsPlayerData.GetPlayerByAge(ref ID, ref FirstName, ref LastName, ref KitNumber,
                ref NationalTeamID, ref Club, ref Position, Age))
                return new clsPlayer(ID, FirstName, LastName, KitNumber, NationalTeamID, Club, Position, Age);
            else
                return null;
        }

        static public DataTable GetAllPlayers()
        {
            return clsPlayerData.GetAllPlayers();
        }

        static public DataTable GetAllPlayersWithNationalTeamID(int NationalTeamID)
        {
            return clsPlayerData.GetAllPlayersWhereNationalTeamID(NationalTeamID);
        }
        static public DataTable GetAllPlayersWithFirstName(string FirstName)
        {
            return clsPlayerData.GetAllPlayersWhereFirstName(FirstName);
        }
        static public DataTable GetAllPlayersWithLastName(string LastName)
        {
            return clsPlayerData.GetAllPlayersWhereLastName(LastName);
        }
        static public DataTable GetAllPlayersWithKitNumber(int kitNumber)
        {
            return clsPlayerData.GetAllPlayersWhereKitNumber(kitNumber);
        }
        static public DataTable GetAllPlayersWithClub(string Club)
        {
            return clsPlayerData.GetAllPlayersWhereClub(Club);
        }
        static public DataTable GetAllPlayersWithPosition(string Position)
        {
            return clsPlayerData.GetAllPlayersWherePosition(Position);
        }
        static public DataTable GetAllPlayersWithAge(short Age)
        {
            return clsPlayerData.GetAllPlayersWhereAge(Age);
        }
        static public string AddNewPlayer(string FirstName, string LastName, int KitNumber,
            int NationalNumberID, string Club, string Position, short Age)
        {
            return clsPlayerData.AddNewPlayer(FirstName, LastName, KitNumber, NationalNumberID, Club, Position, Age);
        }

    }


}
