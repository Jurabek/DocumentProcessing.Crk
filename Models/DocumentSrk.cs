using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentProcessing.Srk.Models
{
    public class DocumentSrk
    {
        [Key]
        public Guid Id { get; set; }
        
        /// <summary>
        /// Макони воридшавӣ
        /// </summary>
        [ForeignKey("EntryLocationId")]
        public Location EntryLocation { get; set; }

        public long ImportNumber { get; set; }

        public DateTime ImportDate { get; set; }
        
        /// <summary>
        /// Ирсолкунанда
        /// </summary>
        public string Creator { get; set; }
        
        public long ExportNumber { get; set; }

        public DateTime ExportDate { get; set; }

        public string Description { get; set; }

        public string SignedBy { get; set; }
        
        public DateTime SignedDate { get; set; }

        public bool IsControlled { get; set; }

        /// <summary>
        ///  Иҷрокунанда 
        /// </summary>
        public string Executor { get; set; }

        public DateTime Until { get; set; }

        public Guid FirstOrderId { get; set; }
        
        [ForeignKey("FirstOrderId")]
        public virtual Order FirstOrder { get; set; }

        public Guid SecondOrderId { get; set; }
        
        [ForeignKey("SecondOrderId")]
        public virtual Order SecondOrder { get; set; }
    }
}