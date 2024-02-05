public class Player
{
    private Couleur _couleur{get;init;}
    private string _name{get;init;}
    public Player(Couleur couleur, string name, ILogService logService)
    {
        _couleur = couleur;
        _name = name;
        logService.WriteLog($"Player {_name} created");
    }
}