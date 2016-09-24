using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dev_1.Core
{
    public interface IVehicle
    {
        void IncreaseSpeed(int amount);
        void DecreaseSpeed(int amount);
        int GetSpeed();
    }
}
