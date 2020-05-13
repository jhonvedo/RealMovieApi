using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMovieApi.Utils
{
    public static class LogService
    {
        public static void InsertLog(string method,string user,string path)
        {
            Log.Information($">>>>>>USER:{user} ACTION:{method} PATH:{path}");
        }
    }
}
