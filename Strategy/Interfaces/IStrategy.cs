using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Interfaces
{
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
