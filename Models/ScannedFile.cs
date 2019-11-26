using System;
using System.ComponentModel.DataAnnotations;

namespace DocumentProcessing.Srk.Models
{
    public class ScannedFile
    {
        [Key]
        public Guid Id { get; set; }

        public string ContentType { get; set; }

        public long Length { get; set; }

        public string FileName { get; set; }

        public byte[] File { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}