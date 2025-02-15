using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class GetResponse
    {
        public int Approved { get; set; }
        public long ID { get; set; }
        public long AdditionalID { get; set; }
        public long LoginID { get; set; }
        public long RoleID { get; set; }
        public string? DocType { get; set; }
        public string? Date { get; set; }
        public string? Param1 { get; set; }
        public string? Param2 { get; set; }
        public string? IPAddress { get; set; }

    }
}
