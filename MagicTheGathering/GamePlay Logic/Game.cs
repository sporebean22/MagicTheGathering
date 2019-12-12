using MagicTheGathering;
using MagicTheGathering.Models;
using MTGGame;
using System.Collections.Generic;
using System.Text;

public sealed partial class Game
{
    private readonly INarrator _narrator;
    public List<Player> Players { get; set; } = new List<Player>();

    public Game(Player[] players)
    {
        Players = players;
    }

    public void Start()
    {
        _narrator.GameStart(Players);

        while (true)
        {

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

