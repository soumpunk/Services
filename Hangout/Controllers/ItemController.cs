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
        public ItemListResponse GetItemList(int objectId,int userid)
        {
            ItemListResponse resp = new ItemListResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetItemList(objectId,userid);
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
        public ItemReviewResponse GetItemReviewsSKU(int objectId)
        {
            ItemReviewResponse resp = new ItemReviewResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetReviewsSKU(objectId);
            return resp;
        }

        [HttpGet]
        public ItemReviewResponse GetItemReviewsUID(int objectId)
        {
            ItemReviewResponse resp = new ItemReviewResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetReviewsUID(objectId);
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
        public CustomerResponse AuthenticateUser(string objectId)
        {
            CustomerResponse resp = new CustomerResponse();
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
        [HttpGet]
        public ItemListResponse GetItemFavsUID(int objectId)
        {
            ItemListResponse resp = new ItemListResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetItemFavsUID(objectId);
            return resp;
        }
        [HttpGet]
        public CustomerResponse GetCustomerDetails(int objectId)
        {
            CustomerResponse resp = new CustomerResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetCustomerDetails(objectId);
            return resp;
        }
        [HttpPost]
        public int UpdateCustomer(Customer CustomerObj)
        {
            IItemService itemService = new ItemService();
            return (itemService.UpdateCustomer(CustomerObj));
        }
        [HttpGet]
        public ItemListResponse GetMyTastingsList(int objectId)
        {
            ItemListResponse resp = new ItemListResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetMyTastingsList(objectId);
            return resp;
        }
    }
}
