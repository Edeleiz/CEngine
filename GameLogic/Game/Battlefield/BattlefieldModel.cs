using System.Collections.Generic;
using CEngine.Interfaces.Objects.Units;
using CGame.Core.Objects;

namespace CGame.Game.Battlefield
{
    public class BattlefieldModel
    {
        public const int CellWidth = 8;
        public const int CellHeight = 8;

        private List<BaseUnit> _playerUnits;
        private List<BaseUnit> _enemyUnits;

        public BattlefieldModel()
        {
            _playerUnits = new List<BaseUnit>();
            _enemyUnits = new List<BaseUnit>();
        }

        public void AddPlayerUnit(BaseUnit unit, int posX, int posY)
        {
            unit.X = posX;
            unit.Y = posY;
            AddPlayerUnit(unit);
        }

        public void AddPlayerUnit(BaseUnit unit)
        {
            _playerUnits.Add(unit);
        }
    }
}