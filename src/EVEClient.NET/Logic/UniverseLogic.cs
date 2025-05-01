using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class UniverseLogic : IUniverseLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public UniverseLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<Ancestry>>> Ancestries(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Universe.Ancestries, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Ancestry>>();
        }

        public async Task<EsiResponse<AsteroidBelt>> AsteroidBeltInfo(int asteroidBeltId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                   parameters.Route[ESI.Parameters.Route.AsteroidBeltId] = asteroidBeltId.ToString();
               });

            var response = await _client.Request(ESI.Endpoints.Universe.AsteroidBeltInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<AsteroidBelt>();
        }

        public async Task<EsiResponse<List<Bloodline>>> Bloodlines(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Universe.Bloodlines, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Bloodline>>();
        }

        public async Task<EsiResponse<Constellation>> ConstellationInfo(int constellationId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.ConstellationId] = constellationId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.ConstellationInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Constellation>();
        }

        public async Task<EsiResponse<List<int>>> Constellations(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Universe.Constellations, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<List<Faction>>> Factions(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Universe.Factions, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Faction>>();
        }

        public async Task<EsiResponse<Graphic>> GraphicInfo(int graphicId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.GraphicId] = graphicId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.GraphicInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Graphic>();
        }

        public async Task<EsiResponse<List<int>>> Graphics(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Universe.Graphics, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<IDsLookup>> IDs(string[] names, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Body = names;
                });

            var response = await _client.Request(ESI.Endpoints.Universe.IDs, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<IDsLookup>();
        }

        public async Task<EsiResponse<List<int>>> ItemCategories(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Universe.ItemCategories, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<ItemCategory>> ItemCategoryInfo(int categoryId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.ItemCategoryId] = categoryId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.ItemCategoryInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<ItemCategory>();
        }

        public async Task<EsiResponse<ItemGroup>> ItemGroupInfo(int groupId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.ItemGroupId] = groupId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.ItemGroupInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<ItemGroup>();
        }

        public async Task<EsiResponsePagination<List<int>>> ItemGroups(int page = 1, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.ItemGroups, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<Moon>> MoonInfo(int moonId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.MoonId] = moonId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.MoonInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Moon>();
        }

        public async Task<EsiResponse<List<NamesLookup>>> Names(int[] ids, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Body = ids;
                });

            var response = await _client.Request(ESI.Endpoints.Universe.Names, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<NamesLookup>>();
        }

        public async Task<EsiResponse<Planet>> PlanetInfo(int planetId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.PlanetId] = planetId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.PlanetInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Planet>();
        }

        public async Task<EsiResponse<List<Race>>> Races(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Universe.Races, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Race>>();
        }

        public async Task<EsiResponse<Region>> RegionInfo(int regionId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.RegionId] = regionId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.RegionInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Region>();
        }

        public async Task<EsiResponse<List<int>>> Regions(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Universe.Regions, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<SolarSystemInfo>> SolarSystemInfo(int systemId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.SystemId] = systemId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.SolarSystemInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<SolarSystemInfo>();
        }

        public async Task<EsiResponse<List<int>>> SolarSystems(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Universe.SolarSystems, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<Stargate>> StargateInfo(int stargateId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.StargateId] = stargateId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.StargateInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Stargate>();
        }

        public async Task<EsiResponse<Star>> StarInfo(int starId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.StarId] = starId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.StarInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Star>();
        }

        public async Task<EsiResponse<Station>> StationInfo(int stationId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.StationId] = stationId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.StationInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Station>();
        }

        public async Task<EsiResponse<StructureInfo>> StructureInfo(long structureId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.StructureId] = structureId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Universe.StructureInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<StructureInfo>();
        }

        public async Task<EsiResponse<List<long>>> Structures(StructureType? type, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Query[ESI.Parameters.Query.StructuresFilter] = type?.ToEsiString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.Structures, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<long>>();
        }

        public async Task<EsiResponse<List<JumpInfo>>> SystemJumps(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Universe.SystemJumps, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<JumpInfo>>();
        }

        public async Task<EsiResponse<List<KillInfo>>> SystemKills(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Universe.SystemKills, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<KillInfo>>();
        }

        public async Task<EsiResponse<EveType>> TypeInfo(int typeId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.TypeId] = typeId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Universe.TypeInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<EveType>();
        }

        public async Task<EsiResponse<List<int>>> Types(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Universe.Types, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }
    }
}
