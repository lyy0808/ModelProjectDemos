///=================================================================================================
// file:	RoleAbstract.cs
//
// summary:	Implements the role abstract class
///-------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerDemo
{
    ///=================================================================================================
    /// <summary>   A role abstract. </summary>
    ///
    /// <remarks>   lyy, 2017:6:5_9:58:0. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public abstract class RoleAbstract
    {
        ///=================================================================================================
        /// <summary>   Gets or sets the next role. </summary>
        ///
        /// <value> The next role. </value>
        ///-------------------------------------------------------------------------------------------------

        public RoleAbstract NextRole { get; set; }

        ///=================================================================================================
        /// <summary>   Gets or sets the name. </summary>
        ///
        /// <value> The name. </value>
        ///-------------------------------------------------------------------------------------------------

        public string name { get; set; }

        ///=================================================================================================
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   lyy, 2017:6:5_9:58:0. </remarks>
        ///
        /// <param name="strName">  The name. </param>
        ///-------------------------------------------------------------------------------------------------

        public RoleAbstract(string strName)
        {
            name = strName;
        }

        ///=================================================================================================
        /// <summary>   Behaviours the given request. </summary>
        ///
        /// <remarks>   lyy, 2017:6:5_9:58:0. </remarks>
        ///
        /// <param name="request">  The request. </param>
        ///-------------------------------------------------------------------------------------------------

        public abstract void Behaviour(BehaviourRequest request);
    }

   ///=================================================================================================
   /// <summary>    A manager role. </summary>
   ///
   /// <remarks>    lyy, 2017:6:5_9:57:59. </remarks>
   ///-------------------------------------------------------------------------------------------------

   public class ManagerRole : RoleAbstract
    {
        ///=================================================================================================
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   lyy, 2017:6:5_9:57:59. </remarks>
        ///
        /// <param name="strName">  The name. </param>
        ///-------------------------------------------------------------------------------------------------

        public ManagerRole(string strName) : base(strName)
        {
        }

        ///=================================================================================================
        /// <summary>   Behaviours the given request. </summary>
        ///
        /// <remarks>   lyy, 2017:6:5_9:57:59. </remarks>
        ///
        /// <param name="request">  The request. </param>
        ///-------------------------------------------------------------------------------------------------

        public override void Behaviour(BehaviourRequest request)
        {
            if (request.TxTNumber<5)
            {
                request.StrResult = "ManagerRole:OK";

            }
            else if (NextRole!=null)
            {
                NextRole.Behaviour(request);
            }
        }
    }

    ///=================================================================================================
    /// <summary>   A president role. </summary>
    ///
    /// <remarks>   lyy, 2017:6:5_9:57:59. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public class PresidentRole : RoleAbstract
    {
        ///=================================================================================================
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   lyy, 2017:6:5_9:57:59. </remarks>
        ///
        /// <param name="strName">  The name. </param>
        ///-------------------------------------------------------------------------------------------------

        public PresidentRole(string strName) : base(strName)
        {
        }

        ///=================================================================================================
        /// <summary>   Behaviours the given request. </summary>
        ///
        /// <remarks>   lyy, 2017:6:5_9:57:59. </remarks>
        ///
        /// <param name="request">  The request. </param>
        ///-------------------------------------------------------------------------------------------------

        public override void Behaviour(BehaviourRequest request)
        {
            if (request.TxTNumber >5&& request.TxTNumber<15)
            {
                request.StrResult = "PresidentRole:OK";

            }
            else if (NextRole != null)
            {
                NextRole.Behaviour(request);
            }

        }
    }

    ///=================================================================================================
    /// <summary>   A presigengt role. </summary>
    ///
    /// <remarks>   lyy, 2017:6:5_9:57:59. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public class PresigengtRole : RoleAbstract
    {
        ///=================================================================================================
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   lyy, 2017:6:5_9:57:59. </remarks>
        ///
        /// <param name="strName">  The name. </param>
        ///-------------------------------------------------------------------------------------------------

        public PresigengtRole(string strName) : base(strName)
        {
        }

        ///=================================================================================================
        /// <summary>   Behaviours the given request. </summary>
        ///
        /// <remarks>   lyy, 2017:6:5_9:57:59. </remarks>
        ///
        /// <param name="request">  The request. </param>
        ///-------------------------------------------------------------------------------------------------

        public override void Behaviour(BehaviourRequest request)
        {
            if (request.TxTNumber > 15&& request.TxTNumber <30)
            {
                request.StrResult = "PresigengtRole:OK";

            }
            else
            {
                request.StrResult = "No person can deal it ";
            }
        }
    }

}
