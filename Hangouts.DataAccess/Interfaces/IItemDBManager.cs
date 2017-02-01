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
        IList<RetrieveWineDetailsResult> GetDetails(int sku);
        IList<RetrieveReviewsBySKUResult> GetReviewsSKU(int sku);
        IList<RetrieveReviewsByUserIdResult> GetReviewsUID(int uid);
        int InsertUpdateSKULike(SKULike skuLike);
        IList<AuthenticateUserResult> AuthenticateUser(string userName);
        int InsertUpdateReview(Review review);
        int DeleteReview(int sku, int reviewUserId);
        IList<RetrieveFavouriteWinesByUserIdResult> GetItemFavsUID(int userId);
        IList<RetrieveProfileDetailsResult> GetCustomerDetails(int customerid);
        int UpdateCustomerDetails(Customer customerObj);
        IList<RetrieveMyTastingsResult> GetMyTastings(int custID);
    }
}
