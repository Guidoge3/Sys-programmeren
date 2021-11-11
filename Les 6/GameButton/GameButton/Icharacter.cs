using System;
using System.Collections.Generic;
using System.Text;

namespace GameButton
{
    public interface ICharacter
    {
        void SetHorizontalDirection(float dx);
        void PerformAttack();
        void StartJump();

        void Logic(float frametime)
        {

        }
    }
}
