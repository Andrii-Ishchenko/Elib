//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ELib.Common.DbDiagram
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookFormat
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int FormatId { get; set; }
        public string FilePath { get; set; }
        public System.DateTime InsertDate { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual FileFormat FileFormat { get; set; }
    }
}
