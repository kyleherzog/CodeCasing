using System;

namespace CodeCasing;

public static class CasingConverter
{
    public static string Convert(string source, CasingStyle targetStyle)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        return targetStyle switch
        {
            CasingStyle.None => source,
            CasingStyle.Title => source.ExpandToTitleCase(),
            CasingStyle.Sentence => source.ExpandToSentenceCase(),
            CasingStyle.Hungarian => source.ToHungarianCase(),
            CasingStyle.Pascal => source.ToPascalCase(),
            CasingStyle.Snake => source.ToSnakeCase(),
            CasingStyle.ScreamingSnake => source.ToScreamingSnakeCase(),
            CasingStyle.Spinal => source.ToSpinalCase(),
            CasingStyle.Train => source.ToTrainCase(),
            _ => throw new ArgumentOutOfRangeException(nameof(targetStyle)),
        };
    }
}