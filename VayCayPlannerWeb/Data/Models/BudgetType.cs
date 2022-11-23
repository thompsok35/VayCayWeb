﻿using System.ComponentModel.DataAnnotations;

namespace VayCayPlannerWeb.Data.Models
{
    public class BudgetType : BaseEntity
    {
        [MaxLength(512)]
        public string? Name { get; set; }

        [MaxLength(512)]
        public string? Description { get; set; }

    }
}
