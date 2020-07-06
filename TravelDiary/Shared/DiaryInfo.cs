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
        [Required(ErrorMessage ="标题必须填写")]
        [MaxLength(20, ErrorMessage = "标题长度不能超过20个字符")]
        [MinLength(5, ErrorMessage = "标题长度不能短于5个字符")]
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
