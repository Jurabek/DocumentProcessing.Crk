using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentProcessing.Srk.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        
        public DateTime CreatedDate { get; set; }

        public string Description { get; set; }

        public Guid ScannedFileId { get; set; }
        
        [ForeignKey("ScannedFileId")]
        public virtual ScannedFile ScannedFile { get; set; }
    }
}