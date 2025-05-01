using System.Threading;
using System.Threading.Tasks;

namespace EVEClient.NET
{
    public interface IUserInterfaceLogic
    {
        /// <summary>
        /// Set a solar system as autopilot waypoint
        /// </summary>
        /// <param name="destinationId">The destination to travel to, can be solar system, station or structure’s id</param>
        /// <param name="addToBeginning">Whether this solar system should be added to the beginning of all waypoints. Default value: false</param>
        /// <param name="clearOtherWaypoints">Whether clean other waypoints beforing adding this one. Default value: false</param>
        Task<EsiResponse> SetAutopilotWaypoint(long destinationId, bool addToBeginning = false, bool clearOtherWaypoints = false, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Open the contract window inside the client
        /// </summary>
        /// <param name="contractId">The contract to open</param>
        Task<EsiResponse> OpenContractWindow(int contractId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Open the information window for a character, corporation or alliance inside the client
        /// </summary>
        /// <param name="targetId">The target to open</param>
        Task<EsiResponse> OpenInformationWindow(int targetId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Open the market details window for a specific typeID inside the client
        /// </summary>
        /// <param name="typeId">The item type to open in market window</param>
        Task<EsiResponse> OpenMarketDetails(int typeId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Open the New Mail window, according to settings from the request if applicable
        /// </summary>
        /// <param name="subject">The subject of new email</param>
        /// <param name="body">The body of new email</param>
        /// <param name="recipients">Recipients list. Max 50</param>
        /// <param name="toCorpOrAllianceId">An EVE corporation or alliance ID</param>
        /// <param name="toMailingListId">Corporations, alliances and mailing lists are all types of mailing groups.
        /// You may only send to one mailing group, at a time, so you may fill out either this field or the to_corp_or_alliance_ids field</param>
        Task<EsiResponse> OpenNewMailWindow(string subject, string body, int[] recipients, int? toCorpOrAllianceId = null, int? toMailingListId = null, string? token = null, CancellationToken cancellationToken = default);
    }
}
