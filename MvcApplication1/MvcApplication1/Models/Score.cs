//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Score
    {
        public string testid { get; set; }
        public string studentid { get; set; }
        public byte score1 { get; set; }
    
        public virtual Test Test { get; set; }
    }
}
