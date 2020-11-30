﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW.Host.API.Model.ModelEntity
{
    public class HW_BackGroundImageInfo : Entity
    {
        // id Url
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BGId { get; set; }

        /// <summary>
        /// 背景图片URL
        /// </summary>
        public string BGUrl { get; set; }
    }
}