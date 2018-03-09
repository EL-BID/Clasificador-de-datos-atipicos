using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sisben.WebApps.QAML.Helpers
{
    public static class Alert
    {
        public static string GetClass(double score)
        {
            string result = string.Empty;
            if (score >= 0.75)
                result = "alert-success";
            else if (score >= 0.25)
                result = "alert-warning";
            else
                result = "alert-danger";
            return result;
        }
    }
}