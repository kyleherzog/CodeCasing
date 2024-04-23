using System;
using System.Text.RegularExpressions;

namespace CodeCasing;

public static class CasingExtensions
{
    public static string ExpandToSentenceCase(this string value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        var result = value;

        result = result.Replace("-", " ").Replace("_", " ");
        result = Regex.Replace(result, "[A-Z]{2,}", m => m.Value.ToLowerInvariant());

        result = Regex.Replace(result, @"([a-z][A-Z])", m => m.Value[0] + " " + m.Value[1]);
        result = Regex.Replace(result, @"\W[A-Z]", m => m.Value.ToLowerInvariant());
        result = Regex.Replace(result, @"^[a-z]", m => m.Value.ToUpperInvariant());
        return result;
    }

    public static string ExpandToTitleCase(this string value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        var result = value.ExpandToSentenceCase();
        result = Regex.Replace(result, @"\W[a-z]", m => m.Value.ToUpperInvariant());
        return result;
    }

    public static string ToCamelCase(this string value)
    {
        return ToHungarianCase(value);
    }

    public static string ToCobolCase(this string value)
    {
        return ToSpinalCase(value).ToUpperInvariant();
    }

    public static string ToFlatCase(this string value)
    {
        return ToPascalCase(value).ToLowerInvariant();
    }

    public static string ToHungarianCase(this string value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        var result = value.ToPascalCase();
        result = Regex.Replace(result, @"^[A-Z]", m => m.Value.ToLowerInvariant());

        return result;
    }

    public static string ToKebabCase(this string value)
    {
        return ToSpinalCase(value);
    }

    public static string ToMacroCase(this string value)
    {
        return ToScreamingSnakeCase(value);
    }

    public static string ToPascalCase(this string value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        var result = value.ExpandToTitleCase();
        result = result.Replace(" ", string.Empty);

        return result;
    }

    public static string ToScreamingSnakeCase(this string value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        var result = value.ToSnakeCase().ToUpperInvariant();

        return result;
    }

    public static string ToSnakeCase(this string value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        var result = value.ExpandToSentenceCase();
        result = result.Replace(" ", "_").ToLowerInvariant();

        return result;
    }

    public static string ToSpinalCase(this string value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        var result = value.ToTrainCase().ToLowerInvariant();

        return result;
    }

    public static string ToTrainCase(this string value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        var result = value.ExpandToSentenceCase();
        result = result.Replace(" ", "-");

        return result;
    }
}