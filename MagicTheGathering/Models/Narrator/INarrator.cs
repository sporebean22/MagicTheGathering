using MTGGame;
using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    public interface INarrator
    {
        string GameBegin();
        string NarrateSpellBasic(Spell spell);
        string NarrateSpellBasic(TerrainColour terrainColour, string cardName, Dictionary<TerrainColour, int> manaCost);
        string NarrateBasicMonster(Monster monster);
        string NarrateCardCast(Card card);
        string TranslateMana(Card card);
        string TranslateMana(Dictionary<TerrainColour, int> manaCost);
        string GameStart(List<Player> players);
    }
}