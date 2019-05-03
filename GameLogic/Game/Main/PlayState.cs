using System;
using CGame.Core.Objects;
using CGame.Game.Battlefield;
using CGame.Game.View;

namespace CGame.Game.Main
{
    public class PlayState : IUpdatable
    {
        public void Update(float timePassed)
        {
            var bv = new BattlefieldView(new BattlefieldModel());
            Console.Clear();
            Console.Write(bv.Render());
        }
    }
}