
public class Piece : IPiece
{
    private Position _position{get;set;}
    private Couleur _couleur{get;set;}

    public Position Position
    {
        get
        {
            return _position;
        }
    }

    public Couleur Couleur
    {
        get
        {
            return _couleur;
        }
    }
    public Piece(Position position, Couleur couleur)
    {
        _position = position;
        _couleur = couleur;
    }

    public virtual void Deplacer(Position position)
    {
        _position = position;
    }

    public virtual void Manger()
    {
        // ...
    }

    public virtual List<Position> GetDeplacementsPossibles()
    {
        return new List<Position>();
    }
}
