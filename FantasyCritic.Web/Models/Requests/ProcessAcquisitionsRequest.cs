using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCritic.Web.Models.Requests
{
    public class ProcessPickupsRequest
    {
        public int Year { get; set; }
        public Guid LeagueID { get; set; }
    }
}
