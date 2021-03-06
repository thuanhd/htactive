﻿using HTActive.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HTActive.Entities
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public int? Priority { get; set; }
        public ServiceTypeEnums? ServiceType { get; set; }
        public List<ServiceLanguage> ServiceLanguages { get; set; }
    }

    public class ServiceLanguage
    {
        [Key]
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public Service Service { get; set; }
        public SiteLanguageTypeEnums Language { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }
        [StringLength(512)]
        public string ImageSrc { get; set; }
        [StringLength(512)]
        public string ImageAlt { get; set; }
        [StringLength(512)]
        public string TitleText { get; set; }
        [StringLength(512)]
        public string TitleTagForSEO { get; set; }

    }
}
