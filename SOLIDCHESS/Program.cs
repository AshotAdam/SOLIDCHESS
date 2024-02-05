// See https://aka.ms/new-console-template for more information

ILogService logService = new LogService();
logService.WriteLog("Lancement du jeu");
Player player1 = new Player(Couleur.Blanc, "Joueur 1", logService);
Player player2 = new Player(Couleur.Noir, "Joueur 2", logService);
PieceService pieceService = new PieceService();
Plateau plateau = new Plateau(3,3);
IPiece pion = pieceService.Create(logService, TypePiece.Pion, Couleur.Blanc,  new Position(){X=1, Y=1});
PieceFactory pion2 = new PionFactory();

/*plateau.AddPiece(pion, logService);
plateau.RemovePiece(pion, logService);*/


for(int i = 0; i < plateau.Width; i++){
    Console.WriteLine("\n -  -  -  -  -  -  - ");
    for(int j = 0; j < plateau.Height; j++){
        Console.Write("| |");
        if(plateau.GetPiece(new Position(){X=i, Y=j}) == null)
            Console.Write(" ");
        else
        Console.Write(plateau.GetPiece(new Position(){X=i, Y=j}));
    }
}




