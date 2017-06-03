using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterModel
{
    
    public class A7TargetLidar
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   用的Virtual可以在这里实现基本的操作 没有用Abstract. </summary>
        ///
        /// <remarks>   Billly, 2017:06:03 23:20:58. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public virtual  void Request() { }
    }
}
