using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class Avatar
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public int OrderBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
