using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangout.Models;
using System.Configuration;
using System.Data.Linq;

namespace Hangouts.DataAccess
{
    public class ItemDBManager : IItemDBManager
    {
        public HangoutsDBDataContext DBContext;

        public ItemDBManager()
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["DBCON"].ConnectionString;

            DBContext = new DataAccess.HangoutsDBDataContext(connection);
        }

        public IList<RetrieveWineDetailsResult> GetDetails(int WineId)
        {
            try
            {
                ISingleResult<RetrieveWineDetailsResult> result =
                DBContext.RetrieveWineDetails(WineId);
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<RetrieveAvailableWinesResult> GetLists(int plantFinal,int userid)
        {
            try
            {
                ISingleResult<RetrieveAvailableWinesResult> result =
                DBContext.RetrieveAvailableWines(plantFinal,userid);            
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<RetrieveReviewsByWineIdResult> GetReviewsWineID(int WineId)
        {
            try
            {
                ISingleResult<RetrieveReviewsByWineIdResult> result =
                DBContext.RetrieveReviewsByWineId(WineId);
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int InsertUpdateSKULike(SKULike skuLike)
        {
            try
            {
                int result = DBContext.InsertUpdateLike(skuLike.UserID, skuLike.SKU, skuLike.Liked,skuLike.WineId);
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public IList<AuthenticateUserResult> AuthenticateUser(string userName)
        {
            try
            {
                ISingleResult<AuthenticateUserResult> result = DBContext.AuthenticateUser(userName);
                if (result != null)
                {
                    return result.ToList();
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<RetrieveReviewsByUserIdResult> GetReviewsUID(int uid)
        {
            try
            {
                ISingleResult<RetrieveReviewsByUserIdResult> result =
                DBContext.RetrieveReviewsByUserId(uid);
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int InsertUpdateReview(Review review)
        {
            try
            {
                int result = DBContext.InsertUpdateReview(review.ReviewID,
                                                          review.PlantFinal,
                                                          review.ReviewDate,
                                                          review.CardID,
                                                          Convert.ToDecimal(review.Cost),
                                                          review.RatingStars,
                                                          review.SKU,
                                                          review.CommentsTitle,
                                                          review.RatingText,
                                                          review.ReviewUserId,
                                                          review.Name,
                                                          review.IsActive,
                                                          review.WineID);
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int DeleteReview(int sku, int reviewUserId)
        {
            try
            {
                int result = DBContext.DeleteReview(sku, reviewUserId);
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public IList<RetrieveFavouriteWinesByUserIdResult> GetItemFavsUID(int userId)
        {
            try {
                ISingleResult<RetrieveFavouriteWinesByUserIdResult> result =
                DBContext.RetrieveFavouriteWinesByUserId(userId);
                return result.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public IList<RetrieveProfileDetailsResult> GetCustomerDetails(int customerID)
        {
            try {
                ISingleResult<RetrieveProfileDetailsResult> result =
                DBContext.RetrieveProfileDetails(customerID);
                return result.ToList();
            }
            catch(Exception ex) {
                return null;
            }
        }

        public int UpdateCustomerDetails(Customer CustomerObj)
        {
            try
            {
                int result = DBContext.UpdateCustomers(CustomerObj.FirstName,
                                                        CustomerObj.LastName,
                                                        CustomerObj.PhoneNumber,
                                                        CustomerObj.Phone2,
                                                        CustomerObj.Email,
                                                        CustomerObj.Address1,
                                                        CustomerObj.Address2,
                                                        CustomerObj.City,
                                                        CustomerObj.State,
                                                        CustomerObj.CustomerType,
                                                        CustomerObj.CustomerID);
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public IList<RetrieveMyTastingsResult> GetMyTastings(int custID)
        {
            try
            {
                ISingleResult<RetrieveMyTastingsResult> result =
                DBContext.RetrieveMyTastings(custID);
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
