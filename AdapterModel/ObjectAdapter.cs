using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterModel
{
    class ObjectAdapter
    {
    }
    public class A7TargetLidar
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   用的Virtual可以在这里实现基本的操作 没有用Abstract. </summary>
        ///
        /// <remarks>   Billly, 2017:06:03 23:20:58. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public virtual  void Request() { }
    }

    ///-------------------------------------------------------------------------------------------------
    /// <summary>  要适配的类. </summary>
    ///
    /// <remarks>   Billly, 2017:06:03 23:25:27. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public  class LidarEV
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是EV雷达");
        }
    }

    ///-------------------------------------------------------------------------------------------------
    /// <summary>   对象适配器. </summary>
    ///
    /// <remarks>   Billly, 2017:06:03 23:25:49. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public class EVLidarObjectAdapter: A7TargetLidar
    {
        public LidarEV D3EvLidar = new LidarEV();

        public override void Request()
        {
            D3EvLidar.SpecificRequest();
        }


    }
}
