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
        ItemDetailsResponse GetItemDetails(int sku);
        ItemReviewResponse GetReviewsSKU(int sku);
        ItemReviewResponse GetReviewsUID(int uid);
        int InsertUpdateSKULike(SKULike skuLike);
        UserResponse AuthenticateUser(string userName);
        int InsertUpdateReview(Review review);
        int DeleteReview(int sku, int reviewUserId);
        ItemListResponse GetItemFavsUID(int userId);
        CustomerResponse GetCustomerDetails(int CustomerID); 
    }
}
