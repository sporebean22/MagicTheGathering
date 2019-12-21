using MagicTheGathering;
using MagicTheGathering.Models;
using MTGGame;
using System.Collections.Generic;

public sealed partial class Game
{
    private readonly INarrator _narrator;
    public List<Player> Players { get; set; } = new List<Player>();

    public Game(List<Player> players)
    {
        Players = players;
    }

    public void Start()
    {
        _narrator.GameStart(Players);

        foreach (Player player in Players)
        {
            player.Shuffle();
            player.Draw(5);
            DeterminePlayers();
        }

        while (true)
        {
            foreach (Player player in Players)
            {
                Untap();
                player.Draw(1);
                MainPhase1();
                Combat();
                MainPhase2();
                EndPhase();
            }
        }
    }

    private TurnType EndPhase()
    {
        return TurnType.EndPhase;
    }

    private TurnType MainPhase2()
    {
        return TurnType.MainPhase2;
    }

    private TurnType MainPhase1()
    {
        return TurnType.MainPhase1;
    }

    private TurnType Combat()
    {
        return TurnType.CombatPhase;
    }

    private TurnType Untap()
    {
        return TurnType.UntapPhase;
    }


    public void DeterminePlayers() 
    { 
        
    }
}