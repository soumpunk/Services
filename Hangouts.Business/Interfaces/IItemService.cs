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
        ItemListResponse GetItemList(int plantFinal);
        ItemDetailsResponse GetItemDetails(int sku);
        ItemRatingResponse GetRatingsSKU(int sku);
        ItemRatingResponse GetRatingsUID(int uid);
        int InsertUpdateSKULike(SKULike skuLike);
        int AuthenticateUser(string userName);
        int InsertUpdateReview(Review review);
        int DeleteReview(int sku, int reviewUserId);

    }
}
