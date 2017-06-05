using GalaSoft.MvvmLight.Threading;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HandlerDemo
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   An application. </summary>
    ///
    /// <remarks>   Billly, 2017:06:03 23:03:56. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
    }
}
