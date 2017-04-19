using Hangout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangouts.DataAccess
{
    public interface IItemDBManager
    {
        IList<RetrieveAvailableWinesResult> GetLists(int plantFinal,int userid);
        IList<RetrieveWineDetailsResult> GetDetails(int WineId);
        IList<RetrieveReviewsByWineIdResult> GetReviewsWineID(int WineID);
        IList<RetrieveReviewsByUserIdResult> GetReviewsUID(int uid);
        int InsertUpdateSKULike(SKULike skuLike);
        IList<AuthenticateUserResult> AuthenticateUser(string userName);
        int InsertUpdateReview(Review review);
        int DeleteReview(int WineId, int reviewUserId);
        IList<RetrieveFavouriteWinesByUserIdResult> GetItemFavsUID(int userId);
        IList<RetrieveProfileDetailsResult> GetCustomerDetails(int customerid);
        int UpdateCustomerDetails(Customer customerObj);
        IList<RetrieveMyTastingsResult> GetMyTastings(int custID);
        int UpdateDeviceToken(int CustId, string Devicetoken);
    }
}
