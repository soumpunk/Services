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
                    AverageRating = Convert.ToDouble(result.AverageRating),
                    IsLike = Convert.ToBoolean(result.Liked),
                    SmallImageUrl = result.SmallImageUrl
                });
            }
            itemListResponse.ItemList = itemList;
            return itemListResponse;
        }

        public ItemDetailsResponse GetItemDetails(int sku)
        {
            ItemDetailsResponse itemDetailsResponse = new ItemDetailsResponse();
            IList<ItemDetails> itemDetailsList = new List<ItemDetails>();
            List<Rating> ratings = new List<Rating>();

            itemDetailsList.Add(new ItemDetails
            {
                SKU = "1889",
                Name = "Ankur Wine",
                Region ="US",
                Country = "NY",
                SalePrice = 5.45,
                RegPrice = 3.56,
                AverageRating = 5,
                IsLike = true,
                LargeImageUrl = "",
                Sub_Region = "",
                GrapeVerietal = ""
                //AvgRating = "",
                //UsersRating = Convert.ToDouble(result.UsersRating),
                //Description = result.Description,
                //Type = result.Type,
                //BottleSize = result.BottleSize.ToString(),
                //Tasting_Notes = result.TastingNotes,
                //Ratings = ratings
                //Alcohol_Levels = result.Alcohol_Levels,
                //Food_Pairings = result.Food_Pairings,
                //ServingAt = result.ServingAt,
                //WineMakerNotes = result.WineMakerNotes,
                //TechnicalNotes = result.TechnicalNotes,
                //Notes = result.Notes,
                //OtherText = result.OtherText,
                //Producer = result.Producer
            });

            itemDetailsResponse.ItemDetails = itemDetailsList.ToList();

            #region DB Interaction

            //IItemDBManager itemDBManager = new ItemDBManager();
            //IList<RetrieveWineDetailsResult> wineDetailsResults = itemDBManager.GetDetails(wineId, cardID, customerID).ToList();
            //IList<RetrieveWineRatingsResult> wineRatings = itemDBManager.GetRatings(wineId, cardID, customerID).ToList();
            //if (wineRatings.Any())
            //{
            //    foreach (RetrieveWineRatingsResult rating in wineRatings)
            //    {
            //        ratings.Add(new Rating
            //        {
            //            SKU = rating.SKU.ToString(),
            //            RatingStars = rating.RatingStars.ToString(),
            //            //Date = rating.Date,
            //            //Username = rating.UserName,
            //            Name = rating.Name,
            //            Vintage = rating.Vintage.ToString(),
            //            Region = rating.Region,
            //            Country = rating.Country
            //        });
            //    }
            //}

            //if (wineDetailsResults.Any())
            //{
            //    foreach (RetrieveWineDetailsResult result in wineDetailsResults)
            //    {
            //        itemDetailsList.Add(new ItemDetails
            //        {
            //            SKU = result.SKU.ToString(),
            //            Name = result.Name,
            //            Region = result.Region,
            //            Country = result.Country,
            //            SalePrice = Convert.ToDouble(result.SalePrice),
            //            RegPrice = Convert.ToDouble(result.RegPrice),
            //            AverageRating = Convert.ToDouble(result.AverageRating),
            //            IsLike = Convert.ToBoolean(result.Liked),
            //            LargeImageUrl = result.LargeImageURL,
            //            Sub_Region = result.Sub_Region,
            //            GrapeVerietal = result.GrapeVerietal,
            //            AvgRating = Convert.ToDouble(result.AverageRating),
            //            UsersRating = Convert.ToDouble(result.UsersRating),
            //            Description = result.Description,
            //            Type = result.Type,
            //            BottleSize = result.BottleSize.ToString(),
            //            Tasting_Notes = result.TastingNotes,
            //            Ratings = ratings
            //            //Alcohol_Levels = result.Alcohol_Levels,
            //            //Food_Pairings = result.Food_Pairings,
            //            //ServingAt = result.ServingAt,
            //            //WineMakerNotes = result.WineMakerNotes,
            //            //TechnicalNotes = result.TechnicalNotes,
            //            //Notes = result.Notes,
            //            //OtherText = result.OtherText,
            //            //Producer = result.Producer
            //        });
            //    }
            //}
            #endregion 
            return itemDetailsResponse;
        }
              

        public ItemRatingResponse GetRatingsSKU(int sku)
        {
            ItemRatingResponse itemRatingResponse = new ItemRatingResponse();
            IList<Rating> raingList = new List<Rating>();
            raingList.Add(new Rating
            {
                SKU = "1889",
                RatingStars = "5",
                //Date = rating.Date,
                //Username = rating.UserName,
                Name = "Test",
                Vintage = "Vinatge1",
                Region = "US",
                Country = "NY"
            });
            itemRatingResponse.Ratings = raingList;
            return itemRatingResponse;
        }

        public ItemRatingResponse GetRatingsUID(int uid)
        {
            ItemRatingResponse itemRatingResponse = new ItemRatingResponse();
            IList<Rating> raingList = new List<Rating>();
            raingList.Add(new Rating
            {
                SKU = "1889",
                RatingStars = "5",
                //Date = rating.Date,
                //Username = rating.UserName,
                Name = "Test",
                Vintage = "Vinatge1",
                Region = "US",
                Country = "NY"
            });
            itemRatingResponse.Ratings = raingList;
            return itemRatingResponse;
        }
    }
}
