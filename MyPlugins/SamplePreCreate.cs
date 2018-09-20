using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlugins
{
    [CrmPluginRegistration(MessageNameEnum.Create, "new_sample", StageEnum.PreOperation, ExecutionModeEnum.Synchronous,
        "", "new_sample PreCreate", 1, IsolationModeEnum.Sandbox)]
    public class SamplePreCreate : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            // Do nothing
        }
    }
}
