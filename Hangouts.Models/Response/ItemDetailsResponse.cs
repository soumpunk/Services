﻿using Hangout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangouts.Models
{
    public class ItemDetailsResponse: BaseServiceResponse
    {
        public IList<ItemDetailsResponse> ItemDetails { get; set; }
    }
}
