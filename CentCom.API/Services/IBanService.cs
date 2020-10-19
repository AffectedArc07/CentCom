﻿using CentCom.API.Models;
using CentCom.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CentCom.API.Services
{
    public interface IBanService
    {
        public Task<IEnumerable<BanData>> GetBansForSourceAsync(int source, bool onlyActive = false);
        public Task<IEnumerable<BanData>> GetBansForKeyAsync(string key, int? source, bool onlyActive = false);
        public Task<BanData> GetBanAsync(int ban);
        public Task<IEnumerable<KeySummary>> SearchSummariesForKeyAsync(string key);
    }
}
