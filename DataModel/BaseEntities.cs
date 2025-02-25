﻿using System.ComponentModel.DataAnnotations;

namespace AplikasiBarbershop.DataModel
{
    public class BaseEntities
    {
        [Required, MaxLength(50)]
        public string? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }

        [MaxLength(50)]
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        [MaxLength(50)]
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}
