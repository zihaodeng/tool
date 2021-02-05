using ApiDebug.RequestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDebug
{
    /**
     * 业务方API网络请求类
     */
    class ApiRequest : AbstractRequestBase
    {
        public override string NetRequest(string requestType, string url, string postData)
        {
            return base.NetRequest(requestType, url, postData);
        }
    }
}