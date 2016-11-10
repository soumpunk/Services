using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangout.Models;
using System.Configuration;
using System.Data.Linq;

namespace Hangouts.DataAccess
{
    public class ItemDBManager : IItemDBManager
    {
        public HangoutsDBDataContext DBContext;

        public ItemDBManager()
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["DBCON"].ConnectionString;

            DBContext = new DataAccess.HangoutsDBDataContext(connection);
        }

        public IList<RetrieveAvailableWinesResult> GetLists(int plantFinal, int cardID, int customerID)
        {
            try
            {
                ISingleResult<RetrieveAvailableWinesResult> result =
                DBContext.RetrieveAvailableWines(plantFinal, cardID, customerID);
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
