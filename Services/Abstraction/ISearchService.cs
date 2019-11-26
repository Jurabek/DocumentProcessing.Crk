using System;
using System.Collections.Generic;
using DocumentProcessing.Srk.Models;

namespace DocumentProcessing.Srk.Services.Abstraction
{
    public interface ISearchService
    {
        IAsyncEnumerable<DocumentSrk> GetByDate(DateTime from, DateTime to);
        
        IAsyncEnumerable<DocumentSrk> GetByKeyword(string keyword);
    }
}