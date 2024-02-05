public class Case{
    Position position{get;set;}
    public IPiece piece;

    public Case(Position position)
    {
        this.position = position;
    }
}