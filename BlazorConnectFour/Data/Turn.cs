namespace BlazorConnectFour.Data
{
    public class Turn
    {
        public PieceColor Color { get; }
        public string Emoji { get; }

        public Turn(PieceColor color, string emoji)
        {
            Color = color;
            Emoji = emoji;
        }
    }
}