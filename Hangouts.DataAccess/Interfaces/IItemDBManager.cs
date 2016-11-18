﻿using Hangout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangouts.DataAccess
{
    public interface IItemDBManager
    {
        IList<RetrieveAvailableWinesResult> GetLists(int plantFinal);
        IList<RetrieveWineDetailsResult> GetDetails(int sku);
        IList<RetrieveRatingsBySKUResult> GetRatingsSKU(int sku);
        IList<RetrieveRatingsByUserIdResult> GetRatingsUID(int uid);
    }
}
