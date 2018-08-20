﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVCBLOG.ENTITY.Model_Entity
{
    [Table("Post")]
    public class Post : Base
    {
        #region Fields
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen Başlık kısmını doldurunuz."), StringLength(300)]
        public string Title { get; set; }
        
        public string Seolink { get; set; }
       
        [Required(ErrorMessage = "Lütfen İçerik kısmını doldurunuz.")]
        public string Content { get; set; }
        
        public int? ViewCount { get; set; }
        public int? LikeCount { get; set; }

        public int CategoryId { get; set; }
        public int UserId { get; set; }

        #endregion

        #region Relations
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual List<Tag> TagList { get; set; }
        public virtual List<Comment> CommentList { get; set; }
        public virtual List<Like> PostLikeList { get; set; }

        #endregion

    }
}
