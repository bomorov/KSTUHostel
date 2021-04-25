using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public int OrderBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int HostelId { get; set; }
        public Hostel Hostel { get; set; }
    }
}
