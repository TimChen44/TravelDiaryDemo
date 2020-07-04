using TravelDiary.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json.Serialization;
using System.IO;

namespace TravelDiary.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DiaryController : ControllerBase
    {
        /// <summary>
        /// 添加日记
        /// </summary>
        /// <param name="diaryInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public void Add(DiaryInfo diaryInfo)
        {
            System.IO.File.WriteAllText($"AppData\\{Guid.NewGuid()}.json", System.Text.Json.JsonSerializer.Serialize(diaryInfo));
        }

        /// <summary>
        /// 获得日志
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<DiaryInfo> GetAll()
        {
            var diaries = new List<DiaryInfo>();
            foreach (var item in Directory.GetFiles($"AppData\\", "*.json"))
            {
                diaries.Add(System.Text.Json.JsonSerializer.Deserialize<DiaryInfo>(System.IO.File.ReadAllText(item)));

            }
            return diaries;
        }
    }

}