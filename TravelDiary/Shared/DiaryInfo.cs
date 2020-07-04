using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace TravelDiary.Shared
{
    public class DiaryInfo
    {
        [DisplayName("标题")]
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        [DisplayName("日期")]
        [Required]
        public DateTime Data { get; set; }

        [DisplayName("地点")]
        [Required]
        public string Address { get; set; }

        [DisplayName("内容")]
        public string Content { get; set; }

    }
}
