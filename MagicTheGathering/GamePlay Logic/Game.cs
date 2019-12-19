using MagicTheGathering.Models;
using MTGGame;
using System.Collections.Generic;

public sealed partial class Game
{
    private readonly INarrator _narrator;
    public List<Player> Players { get; set; } = new List<Player>();
    private TurnTypes[] turnTypes = { TurnTypes.UntapPhase, TurnTypes.DrawPhase, TurnTypes.MainPhase1, TurnTypes.CombatPhase, TurnTypes.MainPhase2, TurnTypes.EndPhase };

    public Game(List<Player> players)
    {
        Players = players;
    }

    public void Start()
    {
        _narrator.GameStart(Players);

        while (true)
        {
            foreach (TurnTypes turn in turnTypes)
            {
                Untap();
                Draw();

            }
        }
    }

    public void Draw() { }
    public void DetermineFirstPlayer() { }
    public void Shuffle() { }

    public Player TurnManagement()
    {
        while (true)
        {

        }
    }
}