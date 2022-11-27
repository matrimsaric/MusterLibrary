using Microsoft.Data.SqlClient;
using MusterLibrary.CrewData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MusterLibrary.DataAccess.MSSQL
{
    public class MsSqlDataAccess : DataAccessParent
    {
        private SqlDataAccess sqlClient = new SqlDataAccess();

        public override Task<bool> DeleteCrew(Crew current, bool ifTestClear)
        {
            var cmd = new SqlCommand("DeleteCrewMember");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = current.CrewId;

            try
            {
                sqlClient.ExecuteCommand(cmd);


            }
            catch (Exception exc)
            {
                throw new Exception("DeleteCrew failed", exc);
            }

            return Task.FromResult(true);
        }

        public override Task<bool> DeleteCrew(Guid id)
        {
            var cmd = new SqlCommand("DeleteCrewMember");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = id;

            try
            {
                sqlClient.ExecuteCommand(cmd);


            }
            catch (Exception exc)
            {
                throw new Exception("DeleteCrew failed", exc);
            }

            return Task.FromResult(true);
        }

        public override Task<Crew> LoadCrew(Guid idToLoad)
        {
            string sql = $"SELECT * FROM MasterInfo WHERE PersonGuid =  '{idToLoad}'";

            DataTable response = sqlClient.GetData(sql);
            Crew thisCrew = new Crew();

            if (response.Rows.Count > 0)
            {
                // get first row and populate fields
                DataRow initial = response.Rows[0];

                thisCrew.CrewId = idToLoad;
                thisCrew.Age = (int)initial["Age"];
                thisCrew.CrewName = (string)initial["Name"];
                thisCrew.SheetRef = (string)initial["SheetRef"];
                thisCrew.CrewId = idToLoad;
                thisCrew.MusterNumber = (int)initial["MusterId"];
                thisCrew.BirthPlace = (string)initial["BirthPlace"];
              

                return Task.FromResult(thisCrew);

            }
            throw new Exception("Player Not Found");
        }

        public override Task<bool> SaveCrew(Crew current, bool infoOnly)
        {
            var cmd = new SqlCommand("SaveCrewMaster");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = current.CrewId;
            cmd.Parameters.Add("@Name", SqlDbType.NChar, 50).Value = current.CrewName;
            cmd.Parameters.Add("@SheetRef", SqlDbType.NVarChar, 20).Value = current.SheetRef;
            cmd.Parameters.Add("@BirthPlace", SqlDbType.NVarChar, 50).Value = current.BirthPlace;
            cmd.Parameters.Add("@Age", SqlDbType.Int).Value = current.Age;
            cmd.Parameters.Add("@MusterId", SqlDbType.Int).Value = current.MusterNumber;
;

            string response = String.Empty;

            try
            {
                sqlClient.ExecuteCommand(cmd);

                // process if important, the subset info needs saving but that is done individually as added
                // keeping this method focused on a very specific task
            }
            catch (Exception exc)
            {
                throw new Exception("SaveCrew failed", exc);
            }

            return Task.FromResult(true);
        }

        public override Task<bool> SaveCrewEntry(Entry current)
        {
            var cmd = new SqlCommand("SaveCrewEntry");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = current.CrewId;
            cmd.Parameters.Add("@EntryDate", SqlDbType.DateTime).Value = current.EntryDate;
            cmd.Parameters.Add("@Appearance", SqlDbType.DateTime).Value = current.AppearanceDate;
            cmd.Parameters.Add("@Pressed", SqlDbType.NVarChar, 30).Value = current.PressedOrNot;
            cmd.Parameters.Add("@Tickets", SqlDbType.NVarChar, 20).Value = current.NumberAndAmountOfTickets;
            cmd.Parameters.Add("@SheetRef", SqlDbType.NVarChar, 20).Value = current.SheetRef;
            

            string response = String.Empty;

            try
            {
                sqlClient.ExecuteCommand(cmd);
            }
            catch (Exception exc)
            {
                throw new Exception("SaveCrewEntry failed", exc);
            }

            return Task.FromResult(true);
        }
    }
}
