using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterModel
{
    class Program
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Main entry-point for this application. </summary>
        ///
        /// <remarks>   Billly, 2017:06:03 23:16:47. </remarks>
        ///
        /// <param name="args"> An array of command-line argument strings. </param>
        ///-------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            Console.WriteLine("类适配器\n\r");
            IA7Lidar A7LIdar = new LidarAdapter();
            A7LIdar.Request();
            Console.WriteLine("对象适配器\n\r");
            A7TargetLidar LidarA7 = new EVLidarObjectAdapter();
            LidarA7.Request();
            Console.Read();
        }
    }
}
