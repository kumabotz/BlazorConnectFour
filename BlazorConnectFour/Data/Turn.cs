namespace BlazorConnectFour.Data
{
    public class Turn
    {
        public PieceColor Color { get; }
        public string Emoji { get; }
        public Position Position { get; private set; }

        public Turn(PieceColor color, string emoji)
        {
            Color = color;
            Emoji = emoji;
        }

        public void SetPosition(Position position)
        {
            Position = position;
        }
    }

    public struct Position
    {
        public int X;
        public int Y;

        public Position(int x = -1, int y = -1)
        {
            X = x;
            Y = y;
        }
    }
}