using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDebug.RequestHelper
{
    /**
     * 网络请求接口
     */ 
    interface INetRequest
    {
        string PostRequest(string postData);
    }
}