using System.Collections.Generic;
public class Player : GenericSingleton<Player>
{
    public int PlayerStorageLimit
    {
        get; set;
    }
    public readonly Storage PlayerStorage;
    private readonly List<Character> PlayerParty;
    public override void Awake()
    {
        base.Awake();
        PlayerStorageLimit = 10;
        PlayerStorage = new Storage(PlayerStorageLimit);
        PlayerParty = new List<Character>();
    }
}