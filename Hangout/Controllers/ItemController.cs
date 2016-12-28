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
        public ItemListResponse GetItemList(int objectId)
        {
            ItemListResponse resp = new ItemListResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetItemList(objectId);
            return resp;
        }

        public ItemDetailsResponse GetItemDetails(int objectId)
        {
            ItemDetailsResponse resp = new ItemDetailsResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetItemDetails(objectId);
            return resp;
        }

        public ItemRatingResponse GetItemRatingsSKU(int objectId)
        {
            ItemRatingResponse resp = new ItemRatingResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetRatingsSKU(objectId);
            return resp;
        }

        public ItemRatingResponse GetItemRatingsUID(int objectId)
        {
            ItemRatingResponse resp = new ItemRatingResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetRatingsUID(objectId);
            return resp;
        }

        ////[HttpGet]
        ////public string TestService(int objectId)
        ////{
        ////    return "Ankur Dubey";
        ////}

    }
}
