using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sigma3.Models
{
    public class NasaViewModel
    {
        public NasaViewModel(string title, string explanation, Uri url) =>
            (Title, Explanation, Url) = (title, explanation, url);
        public string Explanation { get; set; }
        public Uri Hdurl { get; set; }
        public string Title { get; set; }
        public Uri Url { get; set; }
    }
}