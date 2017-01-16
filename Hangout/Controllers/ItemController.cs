using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Hangout.Models;
using Hangouts.Business;

namespace Hangout.Controllers
{
    public class ItemController : ApiController
    {

        [HttpGet]
        public ItemListResponse GetItemList(int objectId)
        {
            ItemListResponse resp = new ItemListResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetItemList(objectId);
            return resp;
        }
        [HttpGet]
        public ItemDetailsResponse GetItemDetails(int objectId)
        {
            ItemDetailsResponse resp = new ItemDetailsResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetItemDetails(objectId);
            return resp;
        }
        [HttpGet]
        public ItemRatingResponse GetItemRatingsSKU(int objectId)
        {
            ItemRatingResponse resp = new ItemRatingResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetRatingsSKU(objectId);
            return resp;
        }

        [HttpGet]
        public ItemRatingResponse GetItemRatingsUID(int objectId)
        {
            ItemRatingResponse resp = new ItemRatingResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetRatingsUID(objectId);
            return resp;
        }

        [HttpGet]
        public string TestService(int objectId)
        {
            return "Ankur Dubey";
        }

        [HttpPost]
        public int InsertUpdateLike(SKULike skuLike )
        {
            IItemService itemService = new ItemService();
            return (itemService.InsertUpdateSKULike(skuLike));
        }

        [HttpGet]
        public UserResponse AuthenticateUser(string objectId)
        {
            UserResponse resp = new UserResponse();
            IItemService itemService = new ItemService();
            resp = itemService.AuthenticateUser(objectId);
            return resp;
        }

        [HttpPost]
        public int InsertUpdateReview(Review review)
        {
            IItemService itemService = new ItemService();
            return (itemService.InsertUpdateReview(review));
        }

        [HttpPost]
        public int DeleteReview(Review review)
        {
            IItemService itemService = new ItemService();
            return (itemService.DeleteReview(review.SKU, review.ReviewUserId));
        }
    }
}
