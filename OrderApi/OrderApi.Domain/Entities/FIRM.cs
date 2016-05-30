using System.Collections.Generic;

namespace OrderApi.Domain.Entities
{
    public class FIRM
    {
        public int FIRMID { get; set; }
        public int FIRMTYPE { get; set; }
        public string FIRMNAME { get; set; }

        public IList<USER> USERS { get; set; }
    }
}