﻿using Verse;


namespace Mutations40k
{
    public class Mutations40kSettings : ModSettings
    {
        public bool hasMutationChoice = true;

        public float baseChanceForGiftAcceptance = 50f;

        public float baseChanceForGiftOffer = 70f;

        public int maxGiftsWhenGiven = 1;

        public int opinionGainAndLossOnGift = 1;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref hasMutationChoice, "HasMutationChoice", true);
            Scribe_Values.Look(ref baseChanceForGiftAcceptance, "baseChanceForGiftAcceptance", 50f);
            Scribe_Values.Look(ref baseChanceForGiftOffer, "baseChanceForGiftOffer", 70f);
            Scribe_Values.Look(ref maxGiftsWhenGiven, "maxGiftsWhenGiven", 1);
            Scribe_Values.Look(ref opinionGainAndLossOnGift, "opinionGainAndLossOnGift", 1);
            base.ExposeData();
        }
    }
}