public interface IPlateau
{
    void AddPiece(IPiece piece, Position position, ILogService logService);
    void RemovePiece(IPiece piece);
    IPiece GetPiece(Position position);
    void DeplacerPiece(IPiece piece, Position position);
}