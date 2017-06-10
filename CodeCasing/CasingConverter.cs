using System;

namespace CodeCasing
{
    public static class CasingConverter
    {
        public static string Convert(string source, CasingStyle targetStyle)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            switch (targetStyle)
            {
                case CasingStyle.None:
                    return source;

                case CasingStyle.Title:
                    return source.ExpandToTitleCase();

                case CasingStyle.Sentence:
                    return source.ExpandToSentenceCase();

                case CasingStyle.Hungarian:
                    return source.ToHungarianCase();

                case CasingStyle.Pascal:
                    return source.ToPascalCase();

                case CasingStyle.Snake:
                    return source.ToSnakeCase();

                case CasingStyle.ScreamingSnake:
                    return source.ToScreamingSnakeCase();

                case CasingStyle.Spinal:
                    return source.ToSpinalCase();

                case CasingStyle.Train:
                    return source.ToTrainCase();

                default:
                    throw new ArgumentOutOfRangeException("targetStyle");
            }
        }
    }
}