﻿using System.Collections.Generic;

namespace LedDashboardCore.Modules.Common
{
    public class Animation
    {
        public LEDColorData[] Frames { get; private set; }
        public int FrameCount => Frames.Length;

        public Animation(LEDColorData[] anim)
        {
            Frames = anim;
        }

        public LEDColorData this[int index]
        {
            get => Frames[index];
        }
    }
}
