﻿using Photon.Deterministic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum.Platformer
{
    public unsafe class GameSessionStateSystem : SystemMainThreadFilter<GameSessionStateSystem.Filter>
    {

        public struct Filter
        {
            public EntityRef Entity;
            public GameSession* GameSession;
        }

        public override void OnInit(Frame f)
        {
            GameSession* gameSession = f.Unsafe.GetPointerSingleton<GameSession>();
            gameSession->State = GameState.Gameplay;
        }

        public override void Update(Frame f, ref Filter filter)
        {
            throw new NotImplementedException();
        }

    }

}