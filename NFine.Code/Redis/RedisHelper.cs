using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Code.Redis
{
    public class RedisHelper
    {
        string RedisIp = "127.0.0.1";
        int RedisPort = 6379;
        public bool Ping()
        {
            try
            {
                RedisClient redisClient = new RedisClient(RedisIp, RedisPort);//redis服务IP和端口
                if (redisClient.Ping())
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        public void setValue(string key, string value)
        {
            RedisClient redisClient = new RedisClient(RedisIp, RedisPort);//redis服务IP和端口
            redisClient.Set(key,value);
        }
        public string getValue(string key)
        {
            RedisClient redisClient = new RedisClient(RedisIp, RedisPort);//redis服务IP和端口
            return redisClient.Get<string>(key);
        }
    }
}
