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

        public IList<RetrieveWineDetailsResult> GetDetails(int sku)
        {
            try
            {
                ISingleResult<RetrieveWineDetailsResult> result =
                DBContext.RetrieveWineDetails(sku);
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<RetrieveAvailableWinesResult> GetLists(int plantFinal)
        {
            try
            {
                ISingleResult<RetrieveAvailableWinesResult> result =
                DBContext.RetrieveAvailableWines(plantFinal);            
                return result.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }       

        public IList<RetrieveRatingsBySKUResult> GetRatingsSKU(int sku)
        {
            try
            {
                ISingleResult<RetrieveRatingsBySKUResult> result =
                DBContext.RetrieveRatingsBySKU(sku);
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
                int result = DBContext.InsertUpdateLike(skuLike.UserID, skuLike.SKU, skuLike.Liked);
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int AuthenticateUser(string userName)
        {
            try
            {
                ISingleResult<AuthenticateUserResult> result = DBContext.AuthenticateUser(userName);
                var res = result.ToList();
                if (res.Any())
                {
                    return res[0].Column1.Value;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public IList<RetrieveRatingsByUserIdResult> GetRatingsUID(int uid)
        {
            try
            {
                ISingleResult<RetrieveRatingsByUserIdResult> result =
                DBContext.RetrieveRatingsByUserId(uid);
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
                                                          review.IsActive);
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

    }
}
