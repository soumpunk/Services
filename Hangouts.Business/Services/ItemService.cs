using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangout.Models;
using Hangouts.DataAccess;

namespace Hangouts.Business
{
    public class ItemService : IItemService
    {
        public ItemListResponse GetItemList(int plantFinal, int cardID , int customerID)
        {
            ItemListResponse ItemListResponse = new ItemListResponse();
            List<Item> ItemList = new List<Item>();
            IItemDBManager itemDBManager = new ItemDBManager();
            IList<RetrieveAvailableWinesResult> wineResults = itemDBManager.GetLists(plantFinal, cardID, customerID).ToList();
            foreach (RetrieveAvailableWinesResult result in wineResults)
            {
                ItemList.Add(new Item
                {
                    SKU = result.SKU,
                    Name = result.Name,
                    Region = result.Region,
                    Country = result.Country,
                    SalePrice = Convert.ToDouble(result.SalePrice),
                    RegPrice = Convert.ToDouble(result.RegPrice),
                    AverageRating = Convert.ToDouble(result.AverageRating),
                    IsLike = Convert.ToBoolean(result.Liked),
                    SmallImageUrl = result.SmallImageUrl
                });
            }
            ItemListResponse.ItemList = ItemList;
            return ItemListResponse;
        }
    }
}
