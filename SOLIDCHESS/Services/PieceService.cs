using System.Runtime.InteropServices;

public class PieceService
{
    public Piece Create(ILogService loger, TypePiece typePiece, Couleur couleur, Position position)
    {
        switch(typePiece){
            case TypePiece.Pion:
                loger.WriteLog("Creation d'un pion " + couleur);
                return new Pion(position, couleur);
            /*case TypePiece.Tour:
                return new Tour(couleur);
            case TypePiece.Fou:
                return new Fou(couleur);
            case TypePiece.Cavalier:
                return new Cavalier(couleur);
            case TypePiece.Dame:
                return new Dame(couleur);
            case TypePiece.Roi:
                return new Roi(couleur);*/
            default:
                throw new System.Exception("Type de pièce inconnu");
        }
    }

    public void Remove(IPiece piece)
    {
        piece.Manger();
    }
}
