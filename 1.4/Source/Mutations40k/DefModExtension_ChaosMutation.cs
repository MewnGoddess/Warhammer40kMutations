﻿using Core40k;
using System.Collections.Generic;
using Verse;

namespace Mutations40k
{
    //This DefModExtension should be given to GeneDef, to allow said gene to be considered in the pool of genes given on mental breaks.
    public class DefModExtension_ChaosMutation : DefModExtension
    {
        //List of chaos gods that gives said gene when dealing with them
        public List<ChaosGods> givenBy;

        //Weight of gene to be given, 1 is standard, if it should be more common increase it, if less decrease it
        //NOTE: If one gene has a really high one like 10 it will get pick quite often compared to all other
        public float selectionWeight = 1;
    }

}