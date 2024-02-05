using System.Linq.Expressions;

public class Plateau : IPlateau
{
    private Case[,] cases;
    private int _width;
    private int _height;

    public int Width{
        get{return _width;}
        set{_width = value;}
    }

    public int Height{
        get{return _height;}
        set{_height = value;}
    }
    
    public Plateau(int width, int height)
    {
        _width = width;
        _height = height;
        cases = new Case[width,height];
        for(int i = 0; i < width; i++){
            for(int j = 0; j < height; j++){
                cases[i,j] = new Case(new Position(){X=width,Y=height});
            }
        }
    }

    public void AddPiece(IPiece piece, Position position, ILogService logService)
    {
        cases[position.X, position.Y].piece = piece;
        logService.WriteLog($"Ajout de la pièce {piece.GetType().Name}");
    }

    public void RemovePiece(IPiece piece, Position position, ILogService logService)
    {
        cases[position.X, position.Y].piece = null;
        logService.WriteLog($"Suppression de la pièce {piece.GetType().Name}");
    }

    public void MovePiece(IPiece piece, Position position, ILogService logService)
    {
        piece.Deplacer(position);
        logService.WriteLog($"Déplacement de la pièce {piece.GetType().Name}");
    }

    public IPiece GetPiece(Position position)
    {
        if(cases[position.X, position.Y].piece == null)
        {
            return null;
        }
        return cases[position.X, position.Y].piece;
    }


    public void RemovePiece(IPiece piece)
    {
        throw new NotImplementedException();
    }

    public void DeplacerPiece(IPiece piece, Position position)
    {
        throw new NotImplementedException();
    }
}