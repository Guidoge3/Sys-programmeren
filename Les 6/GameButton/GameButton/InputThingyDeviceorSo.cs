using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GameButton
{
    public interface InputThingyDeviceorSo
    {
        float GetHorizontalAnalog();
        bool IsDown(GameButtons buttonboi);
    }
}
