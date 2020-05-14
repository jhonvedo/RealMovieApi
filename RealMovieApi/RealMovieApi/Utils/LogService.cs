using Microsoft.AspNetCore.Http;
using RestSharp.Serialization;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealMovieApi.Utils
{
    public static class LogService
    {
        public static  void  InsertHttpLog(HttpContext context)
        {
            var username = context.Request.Headers["username"];
            var userid = context.Request.Headers["userid"]; 
            string log = $"USER:{ username} ({ userid}) ACTION: { context.Request.Method} PATH: {context.Request.Path} RESPONSE:{context.Response.StatusCode}";

            Log.Information(log);
        }
    }
}
