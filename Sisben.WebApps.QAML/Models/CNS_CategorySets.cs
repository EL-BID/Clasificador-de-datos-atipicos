//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sisben.WebApps.QAML.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CNS_CategorySets
    {
        public long Id { get; set; }
        public string Cluster { get; set; }
        public byte k { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double P_i { get; set; }
        public double Curr { get; set; }
        public double Tolerance { get; set; }
        public double P_ip1 { get; set; }
        public double EvalMin { get; set; }
        public double EvalMax { get; set; }
        public double MinObs { get; set; }
        public double MaxObs { get; set; }
        public double AvgEval { get; set; }
        public double AvgObs { get; set; }
        public double EvalDist { get; set; }
        public double EvalMinX { get; set; }
        public double EvalMaxX { get; set; }
        public double AlertMin { get; set; }
        public double AlertMax { get; set; }
    }
}
