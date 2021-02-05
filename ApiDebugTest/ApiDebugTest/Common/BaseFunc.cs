using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDebugTest.Common
{
    /**
     * 公共方法类
     */ 
    public class BaseFunc
    {
        /// <summary>
        /// gzip压缩 【暂不启用压缩】
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        static public byte[] Compress(byte[] buffer)
        {
            byte[] bufferCompress;
            using (MemoryStream stream = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(stream, CompressionMode.Compress))
                {
                    gzip.Write(buffer, 0, buffer.Length);
                }
                bufferCompress = stream.ToArray();
            }
            return bufferCompress;
        }

    }
}
