using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GotAzure.Models
{
    public class Chapter
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime DateChapter { get; set; }

        public Season SeasonChapter { get; set; }

        public Episode EpisodeChapter { get; set; }

        public string YearSeason { get; set; }

        public string Description { get; set; }

        public string URLImgChapter { get; set; }

        public string URLVideo { get; set; }
    }

    public enum Episode
    {
        E1, E2, E3, E4, E5, E6, E7, E8, E9, E10
    }

    public enum Season
    {
        S1,
        S2,
        S3,
        S4,
        S5,
        S6,
        S7
    }
}