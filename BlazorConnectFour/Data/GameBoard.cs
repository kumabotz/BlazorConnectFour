namespace BlazorConnectFour.Data
{
    public class GameBoard
    {
        /// 7 cols x 6 rows, [col,row] starts from top left
        /// [0,0] .. [6,0]
        /// ..
        /// [0,5] .. [6,5]
        public GamePiece[,] Board { get; set; }

        public const int Cols = 7;
        public const int Rows = 6;

        public GameBoard()
        {
            Board = new GamePiece[Cols, Rows];

            for (var i = 0; i < Cols; i++)
            {
                for (var j = 0; j < Rows; j++)
                {
                    Board[i, j] = new GamePiece(PieceColor.Blank);
                }
            }
        }
    }
}
