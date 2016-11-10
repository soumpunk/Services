using Hangout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangouts.DataAccess
{
    public interface IItemDBManager
    {
        IList<RetrieveAvailableWinesResult> GetLists(int plantFinal,int cardID,int customerID);
    }
}
