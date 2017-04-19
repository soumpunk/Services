using Hangout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangouts.Business
{
    public interface IItemService
    {
        ItemListResponse GetItemList(int plantFinal, int userid);
        ItemDetailsResponse GetItemDetails(int WineID);
        ItemReviewResponse GetReviewsWineID(int WineId);
        ItemReviewResponse GetReviewsUID(int uid);
        int InsertUpdateSKULike(SKULike skuLike);
        CustomerResponse AuthenticateUser(string userName);
        int InsertUpdateReview(Review review);
        int DeleteReview(int WineId, int reviewUserId);
        ItemListResponse GetItemFavsUID(int userId);
        CustomerResponse GetCustomerDetails(int CustomerID);
        int UpdateCustomer(Customer CustomerObj);
        TastingListResponse GetMyTastingsList(int customerID);
        int UpdateDeviceToken(int CustomerId, string DeviceToken);
    }
}
