using System;

namespace SpecflowExample.Logic
{
    public class ConceptCalculator
    {
        public enum ConceptCode
        {
            Positive1,
            Positive2,
            Positive3,
            Positive4,
            Positive5,
            Negative1,
            Negative2,
            Negative3,
            Negative4,
            Negative5,
        }

        public ConceptCode GetConceptCode(String previous, String current)
        {
            return ConceptCode.Negative1;
        }
    }
}