﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Data.Enums;


namespace backend.Data.Models
{
    [Table("Reports")]

    public class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("EventTypeId")]
        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }

        [ForeignKey("SeverityLevelTypeId")]
        public int SeverityLevelTypeId { get; set; }
        public SeverityLevel SeverityLevelType { get; set; }

        [ForeignKey("LocationId")]
        public int LocationId { get; set; }
        public Location Location { get; set; }

        public DateTime Date { get; set; }
        public string CarNumber { get; set; }
        /// <summary>
        /// represent the current connected user
        /// </summary>
        public string Name { get; set; } // reporter's name
        
        [MaxLength(200)]
        public string Note { get; set; }
        public int Casualties { get; set; } // num of casualties
        public List<Image> Images { get; set; }
    }
}
