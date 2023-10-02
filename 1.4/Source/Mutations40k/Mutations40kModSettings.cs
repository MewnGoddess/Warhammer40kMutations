﻿using Verse;


namespace Mutations40k
{
    public class Mutations40kSettings : ModSettings
    {
        public bool hasMutationChoice = true;

        public float baseChanceForGiftOffer = 70f;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref hasMutationChoice, "HasMutationChoice", true);
            Scribe_Values.Look(ref baseChanceForGiftOffer, "baseChanceForGiftOffer", 70f);
            base.ExposeData();
        }
    }
}