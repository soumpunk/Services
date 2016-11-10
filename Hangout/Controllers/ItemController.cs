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
            int cardID = 0, customerID = 0;
            ItemListResponse resp = new ItemListResponse();
            IItemService itemService = new ItemService();
            resp = itemService.GetItemList(objectId, cardID, customerID);
            return resp;
        }

        public void GetItemDetails(int objectId)
        {
            
        }
        
    }
}
