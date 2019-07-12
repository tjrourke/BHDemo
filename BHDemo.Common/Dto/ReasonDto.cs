using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.ComponentModel.DataAnnotations;

namespace BHDemo.Common.Dto
{
    public class ReasonDto
    {
        public int Id { get; set; } // ID (Primary key)

        [MaxLength(60)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Text { get; set; }

        public string Details { get; set; }

        public System.DateTime CreatedDate { get; set; }

        [MaxLength(50)]
        public string CreatedBy { get; set; }

        public System.DateTime EditedDate { get; set; }

        [MaxLength(50)]
        public string EditedBy { get; set; } 
    }
}
