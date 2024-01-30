using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.MyWpfApp
{
    public class SumService: ITransientDependency
    {

        public ILogger<SumService> Logger { get; set; }

        public SumService()
        {
            Logger = NullLogger<SumService>.Instance;
        }
        public int Sum(int num1,int num2)
        {
            int sum = num1 + num2; 
            Logger.LogInformation(sum.ToString());
            return sum;
        }

    }
}
