public class Pion : Piece
{
    public Pion(Position position, Couleur couleur) : base(position, couleur)
    {
    }

    public override void Deplacer(Position position)
    {
        // ...
    }

    public override void Manger()
    {
        // ...
    }

    public override List<Position> GetDeplacementsPossibles()
    {
        return new List<Position>();
    }
}