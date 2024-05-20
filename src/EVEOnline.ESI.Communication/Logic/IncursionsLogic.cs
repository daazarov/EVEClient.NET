﻿using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class IncursionsLogic : IIncursionsLogic
    {
        private readonly IEsiHttpClient<IIncursionsLogic> _esiClient;

        public IncursionsLogic(IEsiHttpClient<IIncursionsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<Incursion>>> IncursionList() => _esiClient.GetRequestAsync<List<Incursion>>();
    }
}
