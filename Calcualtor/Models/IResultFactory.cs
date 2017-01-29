using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcualtor.Models
{
   public interface IResultFactory
    {
        string Type { get; }

        IResult Create(float res);
    }
}
