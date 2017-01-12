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
        public ItemListResponse GetItemList(int plantFinal)
        {
            ItemListResponse itemListResponse = new ItemListResponse();
            List<Item> itemList = new List<Item>();
            IItemDBManager itemDBManager = new ItemDBManager();
            IList<RetrieveAvailableWinesResult> wineResults = itemDBManager.GetLists(plantFinal).ToList();
            foreach (RetrieveAvailableWinesResult result in wineResults)
            {
                itemList.Add(new Item
                {
                    SKU = result.SKU,
                    Name = result.Name,
                    Region = result.Region,
                    Country = result.Country,
                    SalePrice = Convert.ToDouble(result.SalePrice),
                    RegPrice = Convert.ToDouble(result.RegPrice),
                    AverageRating = Convert.ToDecimal(result.AverageRating),
                    IsLike = Convert.ToBoolean(result.Liked),
                    SmallImageUrl = result.SmallImageURL,
                    Vintage = result.Vintage
                });
            }
            itemListResponse.ItemList = itemList;
            return itemListResponse;
        }

        public ItemDetailsResponse GetItemDetails(int sku)
        {
            ItemDetailsResponse itemDetailsResponse = new ItemDetailsResponse();
            ItemDetails itemDetailsList = new ItemDetails();
            

            itemDetailsResponse.ItemDetails = itemDetailsList;

            #region DB Interaction

            IItemDBManager itemDBManager = new ItemDBManager();
            IList<RetrieveWineDetailsResult> wineDetailsResults = itemDBManager.GetDetails(sku).ToList();
        
            if (wineDetailsResults.Any())
            {
                foreach (RetrieveWineDetailsResult result in wineDetailsResults)
                {
                    itemDetailsList = new ItemDetails
                    {
                        SKU = result.SKU.ToString(),
                        Name = result.Name,
                        Region = result.Region,
                        Country = result.Country,
                        SalePrice = Convert.ToDouble(result.SalePrice),
                        RegPrice = Convert.ToDouble(result.RegPrice),
                        AverageRating = Convert.ToDecimal(result.AverageRating),
                        IsLike = Convert.ToBoolean(result.Liked),
                        LargeImageUrl = result.LargeImageUrl,
                        //Sub_Region = result.Sub_Region,
                        //GrapeVerietal = result.GrapeVerietal,
                        Vintage = Convert.ToInt32(result.Vintage),
                        UsersRating = Convert.ToDecimal(result.UsersRating),
                        Description = result.Description,
                        WineProperties = new Dictionary<string, string>()
                        //Type = result.Type,
                        //BottleSize = result.BottleSize.ToString(),
                        //Tasting_Notes = result.t,
                        //Alcohol_Levels = result.Alcohol_Levels,
                        //Food_Pairings = result.Food_Pairings,
                        //ServingAt = result.ServingAt,
                        //WineMakerNotes = result.WineMakerNotes,
                        //TechnicalNotes = result.TechnicalNotes,
                        //Notes = result.Notes,
                        //OtherText = result.OtherText,
                        //Producer = result.Producer
                    };
                }
                itemDetailsResponse.ItemDetails = itemDetailsList;
            }
            #endregion 
            return itemDetailsResponse;
        }


        public ItemRatingResponse GetRatingsSKU(int sku)
        {
            ItemRatingResponse itemRatingResponse = new ItemRatingResponse();
            IList<Rating> raingList = new List<Rating>();
            IItemDBManager itemDBManager = new ItemDBManager();
            IList<RetrieveRatingsBySKUResult> ratingsSKUresult = itemDBManager.GetRatingsSKU(sku).ToList();
            foreach (RetrieveRatingsBySKUResult result in ratingsSKUresult)
            {
                raingList.Add(new Rating
                {
                    SKU = result.SKU.ToString(),
                    RatingStars = result.RatingStars,
                    Date = result.Date,
                    Username = result.UserName.ToString(),
                    Name = result.Name,
                    Vintage = result.Vintage.ToString(),
                    Region = result.Region,
                    Country = result.Country,
                    RatingText = result.RatingText
                });
            }
            itemRatingResponse.Ratings = raingList;
            return itemRatingResponse;
        }

        public int InsertUpdateSKULike(SKULike skuLike)
        {
            IItemDBManager itemDBManager = new ItemDBManager();
            return (itemDBManager.InsertUpdateSKULike(skuLike));
        }

        public int AuthenticateUser(string userName)
        {
            IItemDBManager itemDBManager = new ItemDBManager();
            return (itemDBManager.AuthenticateUser(userName));
        }

        public ItemRatingResponse GetRatingsUID(int uid)
        {
            ItemRatingResponse itemRatingResponse = new ItemRatingResponse();
            IList<Rating> raingList = new List<Rating>();
            IItemDBManager itemDBManager = new ItemDBManager();
            IList<RetrieveRatingsByUserIdResult> ratingsUserresult = itemDBManager.GetRatingsUID(uid).ToList();
            foreach (RetrieveRatingsByUserIdResult result in ratingsUserresult)
            {
                raingList.Add(new Rating
                {
                    SKU = result.SKU.ToString(),
                    RatingStars = result.RatingStars,
                    Date = result.Date,
                    Username = result.UserName.ToString(),
                    Name = result.Name,
                    Vintage = result.Vintage.ToString(),
                    Region = result.Region,
                    Country = result.Country
                });
            }
            itemRatingResponse.Ratings = raingList;
            return itemRatingResponse;
        }
    }
}
