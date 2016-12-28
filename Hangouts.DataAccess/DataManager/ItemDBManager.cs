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

        public IList<RetrieveWineDetailsResult> GetDetails(int sku)
        {
            try
            {
                ISingleResult<RetrieveWineDetailsResult> result =
                DBContext.RetrieveWineDetails(sku);
                return result.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<RetrieveAvailableWinesResult> GetLists(int plantFinal)
        {
            try
            {
                ISingleResult<RetrieveAvailableWinesResult> result =
                DBContext.RetrieveAvailableWines(plantFinal);            
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }       

        public IList<RetrieveRatingsBySKUResult> GetRatingsSKU(int sku)
        {
            try
            {
                ISingleResult<RetrieveRatingsBySKUResult> result =
                DBContext.RetrieveRatingsBySKU(sku);
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<RetrieveRatingsByUserIdResult> GetRatingsUID(int uid)
        {
            try
            {
                ISingleResult<RetrieveRatingsByUserIdResult> result =
                DBContext.RetrieveRatingsByUserId(uid);
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }        
    }
}
