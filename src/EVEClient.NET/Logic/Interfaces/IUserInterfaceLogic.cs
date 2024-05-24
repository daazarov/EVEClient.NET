using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        [ProtectedEndpoint(RequiredScope = "esi-ui.write_waypoint.v1")]
        [Route("/latest/ui/autopilot/waypoint/", Version = EndpointVersion.Latest)]
        [Route("/legacy/ui/autopilot/waypoint/", Version = EndpointVersion.Legacy)]
        [Route("/v2/ui/autopilot/waypoint/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/ui/autopilot/waypoint/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> SetAutopilotWaypoint(long destinationId, bool addToBeginning = false, bool clearOtherWaypoints = false);

        /// <summary>
        /// Open the contract window inside the client
        /// </summary>
        /// <param name="contractId">The contract to open</param>
        [ProtectedEndpoint(RequiredScope = "esi-ui.open_window.v1")]
        [Route("/latest/ui/openwindow/contract/", Version = EndpointVersion.Latest)]
        [Route("/legacy/ui/openwindow/contract/", Version = EndpointVersion.Legacy)]
        [Route("/v1/ui/openwindow/contract/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/ui/openwindow/contract/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> OpenContractWindow(int contractId);

        /// <summary>
        /// Open the information window for a character, corporation or alliance inside the client
        /// </summary>
        /// <param name="targetId">The target to open</param>
        [ProtectedEndpoint(RequiredScope = "esi-ui.open_window.v1")]
        [Route("/latest/ui/openwindow/information/", Version = EndpointVersion.Latest)]
        [Route("/legacy/ui/openwindow/information/", Version = EndpointVersion.Legacy)]
        [Route("/v1/ui/openwindow/information/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/ui/openwindow/information/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> OpenInformationWindow(int targetId);

        /// <summary>
        /// Open the market details window for a specific typeID inside the client
        /// </summary>
        /// <param name="typeId">The item type to open in market window</param>
        [ProtectedEndpoint(RequiredScope = "esi-ui.open_window.v1")]
        [Route("/latest/ui/openwindow/marketdetails/", Version = EndpointVersion.Latest)]
        [Route("/legacy/ui/openwindow/marketdetails/", Version = EndpointVersion.Legacy)]
        [Route("/v1/ui/openwindow/marketdetails/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/ui/openwindow/marketdetails/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> OpenMarketDetails(int typeId);

        /// <summary>
        /// Open the New Mail window, according to settings from the request if applicable
        /// </summary>
        /// <param name="subject">The subject of new email</param>
        /// <param name="body">The body of new email</param>
        /// <param name="recipients">Recipients list. Max 50</param>
        /// <param name="toCorpOrAllianceId">An EVE corporation or alliance ID</param>
        /// <param name="toMailingListId">Corporations, alliances and mailing lists are all types of mailing groups.
        /// You may only send to one mailing group, at a time, so you may fill out either this field or the to_corp_or_alliance_ids field</param>
        [ProtectedEndpoint(RequiredScope = "esi-ui.open_window.v1")]
        [Route("/latest/ui/openwindow/newmail/", Version = EndpointVersion.Latest)]
        [Route("/legacy/ui/openwindow/newmail/", Version = EndpointVersion.Legacy)]
        [Route("/v1/ui/openwindow/newmail/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/ui/openwindow/newmail/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> OpenNewMailWindow(string subject, string body, int[] recipients, int? toCorpOrAllianceId = null, int? toMailingListId = null);
    }
}
