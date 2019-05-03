using System;

namespace CGame.Game.Main
{
    public class StartupController
    {
        private Updater _updater;
        private PlayState _game;

        public StartupController()
        {
            _updater = new Updater();
            _game = new PlayState();
            _updater.AddObject(_game);
            _updater.Start();
            Console.ReadLine();
        }
    }
}