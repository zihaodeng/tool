using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApiDebug.RequestHelper
{
    /**
     * 网络请求抽象基类
     */ 
    public abstract class AbstractRequestBase
    {
        //SpinLock spinLock = new SpinLock();
        //SpinWait spinWait = new SpinWait();

        public virtual string NetRequest(string requestType, string url, string postData)
        {
            //INetRequest Request = new NettyHelper();
            INetRequest Request = new PostHelper(requestType, url);
            return Request.PostRequest(postData);

            /**
            while (true)
            {
                ThreadStart tStart = () => {
                    
                    bool lockTaken = false;
                    try
                    {
                        spinLock.Enter(ref lockTaken);//获取锁资源
                        bool b = lockTaken;
                        Thread.Sleep(10000);
                    }
                    finally
                    {
                        if (lockTaken)//判断是否占有锁
                            spinLock.Exit();//释放锁
                    }
                     
                   
                };
                Thread thread = new Thread(tStart);
                thread.Start();

                Thread.Sleep(1000);
            }
            */

            /**
            Thread.SpinWait(10000);//旋转后等待 先自旋后再尝试获取资源，如果可用，则不进行上下文切换 如果不可用，则进行上下文切换
            
            while (true)
            {
                spinWait.SpinOnce();//执行单一自旋 在一定次数之后自动让出CPU 内部sleep和yield()
                //Thread.Sleep(10000);
                bool b = spinWait.NextSpinWillYield; //下一次SpinOnce是否进行上下文切换
                int it = spinWait.Count;
            }
             */

        }

    }
}