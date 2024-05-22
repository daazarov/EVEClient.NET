using EVEOnline.ESI.Communication.Pipline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication.Handlers
{
    public class ExceptionHandler : IHandler
    {
        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            ExceptionDispatchInfo edi = null;

            try
            {
                await next(context);
            }
            catch (Exception exception)
            {
                // Get the Exception, but don't continue processing in the catch block as its bad for stack usage.
                edi = ExceptionDispatchInfo.Capture(exception);
            }

            if (edi != null)
            {
                await HandleException(context, edi);
            }
        }

        private async Task HandleException(EsiContext context, ExceptionDispatchInfo edi)
        { 
        }
    }
}
