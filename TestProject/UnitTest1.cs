using GameLib;
using NUnit.Framework.Legacy;

namespace TestProject
{
    [TestFixture]
    public class GameLogicTests
    {
        private GameLogic _gameLogic;

        [SetUp]
        public void SetUp()
        {
            _gameLogic = new GameLogic();
        }

        [Test]
        public void NewGame_StartWithEmptyBoardAndPlayerX()
        {
            ClassicAssert.AreEqual('X', _gameLogic.currentPlayer, "Начальным игроком должен быть 'X'.");
            ClassicAssert.AreEqual(GameStatus.Running, _gameLogic.Status, "Статус игры должен быть 'в процессе' в начале.");
        }

        [Test]
        public void PlayerMove_ShouldPlacePlayerSymbolOnBoard()
        {
            bool moveResult = _gameLogic.PlayerMove(0, 0);
            ClassicAssert.IsTrue(moveResult, "Ход должен быть корректным.");
            ClassicAssert.AreEqual('X', _gameLogic.lastMovedPlayer, "Последним игроком должен быть 'X'.");
        }

        [Test]
        public void PlayerMove_ShouldNotAllowMoveOnOccupiedCell()
        {
            _gameLogic.PlayerMove(0, 0);
            bool moveResult = _gameLogic.PlayerMove(0, 0);
            ClassicAssert.IsFalse(moveResult, "Ход должен быть некорректным, так как ячейка уже занята.");
        }

        [Test]
        public void PlayerMove_ShouldSwitchPlayerAfterValidMove()
        {
            _gameLogic.PlayerMove(0, 0);
            ClassicAssert.AreEqual('O', _gameLogic.currentPlayer, "Текущий игрок должен переключиться на 'O'.");
        }

        [Test]
        public void CheckGameEnd_DetectWinHorizontally()
        {
            _gameLogic.PlayerMove(0, 0);
            _gameLogic.PlayerMove(1, 0);
            _gameLogic.PlayerMove(0, 1);
            _gameLogic.PlayerMove(1, 1);
            _gameLogic.PlayerMove(0, 2);

            ClassicAssert.IsTrue(_gameLogic.Status==GameStatus.Win, "Игра должна завершиться победой.");
        }

        [Test]
        public void CheckGameEnd_DetectWinVertically()
        {
            _gameLogic.PlayerMove(0, 0);
            _gameLogic.PlayerMove(0, 1);
            _gameLogic.PlayerMove(1, 0);
            _gameLogic.PlayerMove(1, 1);
            _gameLogic.PlayerMove(2, 0);

            ClassicAssert.IsTrue(_gameLogic.Status == GameStatus.Win, "Игра должна завершиться победой.");
        }

        [Test]
        public void CheckGameEnd_DetectWinDiagonally()
        {
            _gameLogic.PlayerMove(0, 0);
            _gameLogic.PlayerMove(0, 1);
            _gameLogic.PlayerMove(1, 1);
            _gameLogic.PlayerMove(0, 2);
            _gameLogic.PlayerMove(2, 2);

            ClassicAssert.IsTrue(_gameLogic.Status == GameStatus.Win, "Игра должна завершиться победой.");
        }

        [Test]
        public void CheckGameEnd_DetectDraw()
        {
            _gameLogic.PlayerMove(0, 0);
            _gameLogic.PlayerMove(0, 1);
            _gameLogic.PlayerMove(0, 2);
            _gameLogic.PlayerMove(1, 1);
            _gameLogic.PlayerMove(1, 0);
            _gameLogic.PlayerMove(1, 2);
            _gameLogic.PlayerMove(2, 1);
            _gameLogic.PlayerMove(2, 0);
            _gameLogic.PlayerMove(2, 2);

            ClassicAssert.IsTrue(_gameLogic.Status == GameStatus.Draw, "Игра должна завершиться ничьей.");
        }

        [Test]
        public void ResetGame_ResetState()
        {
            _gameLogic.PlayerMove(0, 0);
            _gameLogic.ResetGame();

            ClassicAssert.AreEqual('X', _gameLogic.currentPlayer, "Начальный игрок должен сброситься на 'X'.");
            ClassicAssert.AreEqual(GameStatus.Running, _gameLogic.Status, "Статус игры должен сброситься на 'в процессе'.");
            ClassicAssert.IsFalse(_gameLogic.Status == GameStatus.Win, "Состояние победы должно быть сброшено.");
            ClassicAssert.IsFalse(_gameLogic.Status == GameStatus.Draw, "Состояние ничьей должно быть сброшено.");
        }

        [Test]
        public void ComputerMove_PlaceSymbol()
        {
            _gameLogic.ComputerMove();
            ClassicAssert.AreEqual('X', _gameLogic.lastMovedPlayer, "Последним игроком должен быть 'X', если это первый ход.");
        }
    }
}
