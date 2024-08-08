using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;

using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.UniverseRequests;

namespace EVEClient.NET.Logic
{
    internal class UniverseLogic : IUniverseLogic
    {
        private readonly IEsiHttpClient<IUniverseLogic> _esiClient;

        public UniverseLogic(IEsiHttpClient<IUniverseLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<Ancestry>>> Ancestries() =>
            _esiClient.GetRequestAsync<List<Ancestry>>();

        public Task<EsiResponse<AsteroidBelt>> AsteroidBeltInfo(int asteroidBeltId) =>
            _esiClient.GetRequestAsync<AsteroidBeltRequest, AsteroidBelt>(AsteroidBeltRequest.Create(asteroidBeltId));

        public Task<EsiResponse<List<Bloodline>>> Bloodlines() =>
            _esiClient.GetRequestAsync<List<Bloodline>>();

        public Task<EsiResponse<Constellation>> ConstellationInfo(int constellationId) =>
            _esiClient.GetRequestAsync<ConstellationRequest, Constellation>(ConstellationRequest.Create(constellationId));

        public Task<EsiResponse<List<int>>> Constellations() =>
            _esiClient.GetRequestAsync<List<int>>();

        public Task<EsiResponse<List<Faction>>> Factions() =>
            _esiClient.GetRequestAsync<List<Faction>>();

        public Task<EsiResponse<Graphic>> GraphicInfo(int graphicId) =>
            _esiClient.GetRequestAsync<GraphicRequest, Graphic>(GraphicRequest.Create(graphicId));

        public Task<EsiResponse<List<int>>> Graphics() =>
            _esiClient.GetRequestAsync<List<int>>();

        public Task<EsiResponse<IDsLookup>> IDs(string[] names) =>
            _esiClient.PostRequestAsync<IDsRequest, IDsLookup>(IDsRequest.Create(names));

        public Task<EsiResponse<List<int>>> ItemCategories() =>
            _esiClient.GetRequestAsync<List<int>>();

        public Task<EsiResponse<ItemCategory>> ItemCategoryInfo(int categoryId) =>
            _esiClient.GetRequestAsync<ItemCategoryInfoRequest, ItemCategory>(ItemCategoryInfoRequest.Create(categoryId));

        public Task<EsiResponse<ItemGroup>> ItemGroupInfo(int groupId) =>
            _esiClient.GetRequestAsync<ItemGroupInfoRequest, ItemGroup>(ItemGroupInfoRequest.Create(groupId));

        public Task<EsiResponsePagination<List<int>>> ItemGroups(int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedRouteRequest, List<int>>(PageBasedRouteRequest.Create(page));

        public Task<EsiResponse<Moon>> MoonInfo(int moonId) =>
            _esiClient.GetRequestAsync<MoonInfoRequest, Moon>(MoonInfoRequest.Create(moonId));

        public Task<EsiResponse<List<NamesLookup>>> Names(int[] ids) =>
            _esiClient.PostRequestAsync<NamesRequest, List<NamesLookup>>(NamesRequest.Create(ids));

        public Task<EsiResponse<Planet>> PlanetInfo(int planetId) =>
            _esiClient.GetRequestAsync<PlanetInfoRequest, Planet>(PlanetInfoRequest.Create(planetId));

        public Task<EsiResponse<List<Race>>> Races() =>
            _esiClient.GetRequestAsync<List<Race>>();

        public Task<EsiResponse<Region>> RegionInfo(int regionId) =>
            _esiClient.GetRequestAsync<RegionInfoRequest, Region>(RegionInfoRequest.Create(regionId));

        public Task<EsiResponse<List<int>>> Regions() =>
            _esiClient.GetRequestAsync<List<int>>();

        public Task<EsiResponse<SolarSystemInfo>> SolarSystemInfo(int systemId) =>
            _esiClient.GetRequestAsync<SolarSystemInfoRequest, SolarSystemInfo>(SolarSystemInfoRequest.Create(systemId));

        public Task<EsiResponse<List<int>>> SolarSystems() =>
            _esiClient.GetRequestAsync<List<int>>();

        public Task<EsiResponse<Stargate>> StargateInfo(int stargateId) =>
            _esiClient.GetRequestAsync<StargateInfoRequest, Stargate>(StargateInfoRequest.Create(stargateId));

        public Task<EsiResponse<Star>> StarInfo(int starId) =>
            _esiClient.GetRequestAsync<StarInfoRequest, Star>(StarInfoRequest.Create(starId));

        public Task<EsiResponse<Station>> StationInfo(int stationId) =>
            _esiClient.GetRequestAsync<StationInfoRequest, Station>(StationInfoRequest.Create(stationId));

        public Task<EsiResponse<StructureInfo>> StructureInfo(long structureId, string? token = null) =>
            _esiClient.GetRequestAsync<StructureInfoRequest, StructureInfo>(StructureInfoRequest.Create(structureId), token);

        public Task<EsiResponse<List<long>>> Structures(StructureType? type) =>
            _esiClient.GetRequestAsync<StructuresRequest, List<long>>(StructuresRequest.Create(type?.ToEsiString()));

        public Task<EsiResponse<List<JumpInfo>>> SystemJumps() =>
            _esiClient.GetRequestAsync<List<JumpInfo>>();

        public Task<EsiResponse<List<KillInfo>>> SystemKills() =>
            _esiClient.GetRequestAsync<List<KillInfo>>();

        public Task<EsiResponse<EveType>> TypeInfo(int typeId) =>
            _esiClient.GetRequestAsync<TypeInfoRequest, EveType>(TypeInfoRequest.Create(typeId));

        public Task<EsiResponse<List<int>>> Types() =>
            _esiClient.GetRequestAsync<List<int>>();
    }
}
