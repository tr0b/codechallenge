using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codechallenge.Models
{
    public class tbUser
    {
        /*
        *
        *User class creation with its correspondent properties:
        * Property -> (SQL) attribute
        * int PK_UserID -> Primary key INT PK_UserID
        * string First_Name -> VARCHAR(50) First_Name
        * string Last_Name -> VARCHAR(50) Last_Name
        * 
        */
        [Key]
        public int PK_UserID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }



    }
}