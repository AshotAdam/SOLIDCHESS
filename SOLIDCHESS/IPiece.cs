public interface IPiece
{
    void Deplacer(Position position);
    void Manger();
    List<Position> GetDeplacementsPossibles();
}
