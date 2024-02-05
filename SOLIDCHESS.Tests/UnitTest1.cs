namespace SOLIDCHESS.Tests;


public class UnitTest1
{
    [Fact]
    public void Create_Piece_Blanc()
    {
        PieceService pieceService = new PieceService();
        Piece p = pieceService.Create(new LogService(), TypePiece.Pion, Couleur.Blanc, new Position(1, 1));
        Assert.Equal(p.Couleur.ToString(), "Blanc");
    }

    [Theory]
    [InlineData(1, 2)]
    [InlineData(2, 3)]
    [InlineData(3, 4)]
    public void Test2(int a, int b)
    {
        Assert.True(true);
    }
}