using MTGGame;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Exception = System.Exception;

public class TooManyPlayersException : Exception
{
    public string ExceptionMessage { get; set; } = "";
    public TooManyPlayersException() { }
    public TooManyPlayersException(string message) : base(message){ }
    public TooManyPlayersException(string message, Exception innerException) : base(message, innerException) { }
    protected TooManyPlayersException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    public bool PlayerCountLessThan4(List<Player> players)
    {
        try
        {
            players.Take(4);
        }
        catch (TooManyPlayersException playerException) when (playerException.PlayerCountLessThan4(players) = true)
        {
            return playerException.;
        }

        if (players.Count() == 4)
            return false;
        return true;
    }
}

