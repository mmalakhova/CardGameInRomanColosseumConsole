﻿using CardGameInRomanColosseum.Cards;

namespace CardGameInRomanColosseum;

public class Shuffler
{
    public Deck ShuffleCards(Deck deck)
    {
        var shuffledCards = deck.Cards.OrderBy(_ => new Random().Next());
        deck.Cards = shuffledCards.ToList();
        return deck;
    }
}