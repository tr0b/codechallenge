using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codechallenge.Models
{
    public class tbProject
    {
        /**
         * 
         * Project Class Creation for its related Database Entity
         * Property -> (SQL) attribute
         * int PK_ProjectID -> (SQL) Primary key INT ProjectId
         * DateTime StartDate -> DATETIME StartDate
         * DateTime EndDate -> DATETIME EndDate
         * int Credits -> INT Credits
         * **/
        [Key]
        public int PK_ProjectID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Credits { get; set; }
    }
}