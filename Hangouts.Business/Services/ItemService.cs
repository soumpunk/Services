﻿using System;
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
        public ItemListResponse GetItemList(int plantFinal, int userid)
        {
            ItemListResponse itemListResponse = new ItemListResponse();
            List<Item> itemList = new List<Item>();

            IItemDBManager itemDBManager = new ItemDBManager();
            IList<RetrieveAvailableWinesResult> wineResults = itemDBManager.GetLists(plantFinal, userid).ToList();
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
                    Vintage = result.Vintage,
                    WineId = Convert.ToInt32(result.WineId),
                    DispenserCode = Convert.ToInt32(result.DispenserCode),
                    PositionTap = Convert.ToInt32(result.PositionTap)
                });
            }
            itemListResponse.ItemList = itemList;
            return itemListResponse;
        }

        public ItemDetailsResponse GetItemDetails(int WineId)
        {
            ItemDetailsResponse itemDetailsResponse = new ItemDetailsResponse();
            ItemDetails itemDetailsList = new ItemDetails();


            itemDetailsResponse.ItemDetails = itemDetailsList;

            #region DB Interaction

            IItemDBManager itemDBManager = new ItemDBManager();
            IList<RetrieveWineDetailsResult> wineDetailsResults = itemDBManager.GetDetails(WineId).ToList();

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
                        WineProperties = new Dictionary<string, string>(),
                        WineId = Convert.ToInt32(result.WineId)
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


        public ItemReviewResponse GetReviewsWineID(int WineId)
        {
            ItemReviewResponse itemReviewResponse = new ItemReviewResponse();
            IList<Review> raingList = new List<Review>();
            IItemDBManager itemDBManager = new ItemDBManager();
            IList<RetrieveReviewsByWineIdResult> reviewsSKUresult = itemDBManager.GetReviewsWineID(WineId).ToList();
            foreach (RetrieveReviewsByWineIdResult result in reviewsSKUresult)
            {
                raingList.Add(new Review
                {
                    SKU = Convert.ToInt32(result.SKU),
                    RatingStars = result.RatingStars,
                    Date = Convert.ToDateTime(result.Date),
                    Username = result.UserName.ToString(),
                    Name = result.Name,
                    Vintage = result.Vintage.ToString(),
                    Region = result.Region,
                    Country = result.Country,
                    RatingText = result.RatingText,
                    ReviewId = result.ReviewId,
                    WineId = result.WineId,
                    ReviewUserId = Convert.ToInt32(result.ReviewUserId)
                });
            }
            itemReviewResponse.Reviews = raingList;
            return itemReviewResponse;
        }

        public int InsertUpdateSKULike(SKULike skuLike)
        {
            IItemDBManager itemDBManager = new ItemDBManager();
            return (itemDBManager.InsertUpdateSKULike(skuLike));
        }

        public CustomerResponse AuthenticateUser(string userName)
        {
            CustomerResponse respObj = new CustomerResponse();
            Customer userObj = new Customer();
            IItemDBManager itemDBManager = new ItemDBManager();
            IList<AuthenticateUserResult> resultObj = itemDBManager.AuthenticateUser(userName).ToList();
            if (resultObj != null)
                foreach (AuthenticateUserResult result in resultObj)
                {
                    userObj = new Customer
                    {
                        CustomerID = Convert.ToInt32(result.CustomerID),
                        FirstName = result.FirstName
                    };
                }
            respObj.customer = userObj;
            return respObj;
        }

        public ItemReviewResponse GetReviewsUID(int uid)
        {
            ItemReviewResponse itemReviewResponse = new ItemReviewResponse();
            IList<Review> raingList = new List<Review>();
            IItemDBManager itemDBManager = new ItemDBManager();
            IList<RetrieveReviewsByUserIdResult> reviewsUserresult = itemDBManager.GetReviewsUID(uid).ToList();
            foreach (RetrieveReviewsByUserIdResult result in reviewsUserresult)
            {
                raingList.Add(new Review
                {
                    SKU = Convert.ToInt32(result.SKU),
                    RatingStars = result.RatingStars,
                    Date = Convert.ToDateTime(result.Date),
                    PlantFinal = result.PlantFinal,
                    RatingText = result.RatingText,
                    Username = result.UserName.ToString(),
                    Name = result.Name,
                    Vintage = result.Vintage.ToString(),
                    Region = result.Region,
                    Country = result.Country,
                    WineId = result.WineID
                });
            }
            itemReviewResponse.Reviews = raingList;
            return itemReviewResponse;
        }

        public int DeleteReview(int WineId, int reviewUserId)
        {
            try
            {
                IItemDBManager itemDBManager = new ItemDBManager();
                itemDBManager.DeleteReview(WineId, reviewUserId);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int InsertUpdateReview(Review review)
        {
            IItemDBManager itemDBManager = new ItemDBManager();
            itemDBManager.InsertUpdateReview(review);
            return 1;
        }

        public ItemListResponse GetItemFavsUID(int userId)
        {
            ItemListResponse respObj = new ItemListResponse();
            List<Item> itemObj = new List<Item>();

            respObj.ItemList = itemObj;

            IItemDBManager dbObj = new ItemDBManager();
            IList<RetrieveFavouriteWinesByUserIdResult> wineDetailsObj = dbObj.GetItemFavsUID(userId);
            if (wineDetailsObj.Any())
            {
                foreach (RetrieveFavouriteWinesByUserIdResult resultObj in wineDetailsObj)
                {
                    itemObj.Add(new Item
                    {
                        SKU = resultObj.SKU.ToString(),
                        Name = resultObj.Name,
                        Vintage = resultObj.Vintage,
                        SalePrice = Convert.ToDouble(resultObj.SalePrice),
                        RegPrice = Convert.ToDouble(resultObj.RegPrice),
                        IsLike = Convert.ToBoolean(resultObj.Liked),
                        WineId = Convert.ToInt32(resultObj.WineId),
                        AverageRating = Convert.ToInt32(resultObj.AverageRating)
                    });
                }
                respObj.ItemList = itemObj;
            }
            return respObj;
        }
        public CustomerResponse GetCustomerDetails(int CustomerID)
        {
            CustomerResponse respObj = new CustomerResponse();
            Customer CustObj = new Customer();
            respObj.customer = CustObj;
            IItemDBManager dbObj = new ItemDBManager();
            IList<RetrieveProfileDetailsResult> CustomerDetailsObj = dbObj.GetCustomerDetails(CustomerID);
            if (CustomerDetailsObj != null)
            {
                foreach (RetrieveProfileDetailsResult result in CustomerDetailsObj)
                {
                    CustObj = new Customer
                    {
                        CustomerID = Convert.ToInt32(result.CustomerID),
                        FirstName = result.FirstName,
                        LastName = result.LastName,
                        PhoneNumber = result.PhoneNumber,
                        Phone2 = result.Phone2,
                        Email = result.Email,
                        Address1 = result.Address1,
                        Address2 = result.Address2,
                        City = result.City,
                        State = result.State,
                        CustomerType = result.CustomerType,
                        CustsomerAdded = Convert.ToDateTime(result.CustomerAdded),
                        CardNumber = result.CardNumber,
                        Notes1 = result.Notes1
                    };
                }
            }
            respObj.customer = CustObj;
            return respObj;
        }

        public int UpdateCustomer(Customer CustomerObj)
        {
            IItemDBManager itemDBManager = new ItemDBManager();
            int ret = itemDBManager.UpdateCustomerDetails(CustomerObj);
            return ret;
        }

        public TastingListResponse GetMyTastingsList(int customerID)
        {
            TastingListResponse respObj = new TastingListResponse();
            List<Tastings> itemObj = new List<Tastings>();

            respObj.TastingList = itemObj;

            IItemDBManager dbObj = new ItemDBManager();
            IList<RetrieveMyTastingsResult> wineDetailsObj = dbObj.GetMyTastings(customerID);
            if (wineDetailsObj != null)
            {
                foreach (RetrieveMyTastingsResult resultObj in wineDetailsObj)
                {
                    itemObj.Add(new Tastings
                    {
                        SKU = resultObj.SKU.ToString(),
                        Name = resultObj.Name,
                        Vintage = Convert.ToInt32(resultObj.Vintage),
                        SalePrice = Convert.ToDouble(resultObj.SalePrice),
                        RegPrice = Convert.ToDouble(resultObj.RegPrice),
                        Description = resultObj.Description,
                        TastingDate = resultObj.TastingDate
                    });
                }
                respObj.TastingList = itemObj;
            }
            return respObj;
        }
        public int UpdateDeviceToken(int CustomerId, string DeviceToken)
        {
            IItemDBManager itemDBManager = new ItemDBManager();
            int ret = itemDBManager.UpdateDeviceToken(CustomerId,DeviceToken);
            return ret;
        }

        public int InsertActivationCode(string activationCode, string email)
        {
            int retObj = 0;
            IItemDBManager itemDBManager = new ItemDBManager();
            IList<InsertActivationCodeResult> resultObj = itemDBManager.InsertActivationCode(activationCode, email);
            foreach (InsertActivationCodeResult i in resultObj)
                retObj = i.RowCounts;
            return retObj;
        }

        public int UpdateVerfiedEmail(string activationCode)
        {
            IItemDBManager itemDBManager = new ItemDBManager();
            itemDBManager.UpdateVerfiedEmail(activationCode);
            return 1;
        }

        public CustomerResponse AuthenticateUser1(string Email)
        {
            CustomerResponse respObj = new CustomerResponse();
            Customer userObj = new Customer();
            IItemDBManager itemDBManager = new ItemDBManager();
            IList<AuthenticateUser1Result> resultObj = itemDBManager.AuthenticateUser1(Email).ToList();
            if (resultObj != null)
                foreach (AuthenticateUser1Result result in resultObj)
                {
                    userObj = new Customer
                    {
                        CustomerID = Convert.ToInt32(result.CustomerID),
                        FirstName = result.FirstName
                    };
                }
            respObj.customer = userObj;
            return respObj;
        }
    }
}
