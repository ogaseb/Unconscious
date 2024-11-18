﻿
using System.Collections.Generic;

namespace Unconscious.src.Config
{
    public class ModConfig
    {
        public int UnconsciousDuration = 300;
        public float RevivePerTickDuration = 0.2f;

        public float FinishingTimer = 3f;

        public float MaxHealthPercentAfterRevive = 0.15f;

        public string UnconsciousCmdPrivilege = "ban";
        public string ReviveCmdPrivilege = "ban";
    }
}