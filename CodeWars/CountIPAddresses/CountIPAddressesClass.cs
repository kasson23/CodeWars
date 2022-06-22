using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//CODEWARS link: https://www.codewars.com/kata/526989a41034285187000de4/train/csharp
//INFO: https://docs.microsoft.com/en-us/troubleshoot/windows-client/networking/tcpip-addressing-and-subnetting
namespace CodeWars.CountIPAddresses
{
    public class CountIPAddressesClass
    {
        //each point goes to 255 so just check if end is great then add diffencer, otherwise subtract differnac
        public static long IpsBetween(string start, string end)
        {
            var startSplit = start.Split(".").ToList();
            var endSplit = end.Split(".").ToList();

            var lengthOfIp= 3;
            int totalDistance = 0;

            for (int i = 0; i <= lengthOfIp; i++)
            {
                var endValue = int.Parse(endSplit[i]);
                var startValue = int.Parse(startSplit[i]);
                if (i != lengthOfIp)
                {
                    if(endValue != startValue)
                    {
                        var distance = endValue - startValue;

                    }
                }
                else
                {
                    totalDistance += endValue - startValue;
                }

            }

            return totalDistance;
        }
    }
}
