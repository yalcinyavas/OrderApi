using System.ComponentModel.DataAnnotations;

namespace OrderApi.Domain.Entities
{
    public class USER
    {
        public int USERID { get; set; }
        
        
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public string NAME1 { get; set; }
        public string NAME2 { get; set; }

        public string FIRMID { get; set; }
        public FIRM FIRM { get; set; }
    }
}
