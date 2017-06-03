namespace AdapterModel
{
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
