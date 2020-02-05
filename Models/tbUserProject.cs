using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace codechallenge.Models
{
    public class tbUserProject
    {
        [Key]
        public int PK_UserProject { get; set; }
        public int FK_UserID { get; set; }
        public int FK_ProjectID { get; set; }
        public bool isActive { get; set; }

        public DateTime AssignedDate { get; set; }

        public List<tbUser> Users { get; set; }
        /*public virtual tbUser User { get; set; }
        public virtual tbProject Project { get; set; }*/


    }
}