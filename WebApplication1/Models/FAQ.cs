using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FAQApp.Models
{
    public class FAQ
    {
        [Key]
        public int FAQID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        [Required]
        public string CategoryID { get; set; }
        public Category Category { get; set; }
        [Required]
        public string TopicID { get; set; }
        public Topic Topic { get; set; }
    }
}
