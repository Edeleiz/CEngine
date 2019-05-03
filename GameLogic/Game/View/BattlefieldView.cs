using CGame.Game.Battlefield;

namespace CGame.Game.View
{
    public class BattlefieldView : BaseView
    {
        public BattlefieldView(BattlefieldModel model)
        {
            
        }

        public override string Render()
        {
            var result = "";
            for (var i = 0; i < BattlefieldModel.CellHeight; i++)
            {
                for (var j = 0; j < BattlefieldModel.CellWidth; j++)
                {
                    result += "o ";
                }

                result += "\n";
            }
            
            return result;
        }
    }
}