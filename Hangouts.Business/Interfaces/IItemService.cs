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
    }
}
