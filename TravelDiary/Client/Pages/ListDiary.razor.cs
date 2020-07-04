using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TravelDiary.Shared;

namespace TravelDiary.Client.Pages
{
    public partial class ListDiary
    {
        [Inject]
        public HttpClient Http { get; set; }

        List<DiaryInfo> datas = new List<DiaryInfo>();

        private string queryText = "";

        List<DiaryInfo> queryDatas = new List<DiaryInfo>();

        protected override async Task OnInitializedAsync()
        {
            datas = await Http.GetFromJsonAsync<List<DiaryInfo>>("/Diary/GetAll");
            OnQuery("");
            await base.OnInitializedAsync();
        }

        private void OnQuery(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                queryDatas = datas;
            else
                queryDatas = datas.Where(x => x.Title.Contains(value) || x.Address.Contains(value)).ToList();

            StateHasChanged();
        }

    }
}
