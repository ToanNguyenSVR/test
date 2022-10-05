﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSoccers.Service.Models.Payload.ZoneType
{
    public class ZoneTypeCreatePayload
    {
        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        [Required]
        public byte DepositPercent { get; set; }
    }
}
