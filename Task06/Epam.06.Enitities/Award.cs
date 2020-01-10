using System;
using System.Collections.Generic;
using System.Text;

namespace Epam._06.Enitities
{
    public class Award
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return $"ID: {Id}. Title: {Title}.";
        }
    }
}
