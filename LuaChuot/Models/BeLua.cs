using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LuaChuot.Models
{
    [Table("BeLuas")]
    public class BeLua
    {
        [Key]
        public string HoBe  { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
    }
}