using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IInsuranceLogic
    {
        /// <summary>
        /// Return available insurance levels for all ship types
        /// </summary>
        Task<EsiResponse<List<Insurance>>> InsuranceLevels(CancellationToken cancellationToken = default);
    }
}
