using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuntes.Models
{
    internal class Notes
    {
        public string FileName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
