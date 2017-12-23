# Code Casing

[![Build status](https://ci.appveyor.com/api/projects/status/gpfoxsf6cbvgwh05?svg=true)](https://ci.appveyor.com/project/kyleherzog/codecasing)

This library is available from [NuGet.org](https://www.nuget.org/packages/CodeCasing/)
or download from the [CI build feed](https://ci.appveyor.com/nuget/CodeCasing).

--------------------------

.NET Standard class library that converts string identifiers to various code casing styles

See the [changelog](CHANGELOG.md) for changes and roadmap.

## Extension Methods

### ExpandToSentenceCase
The first word is capitalized, while all other text is lower cased.  A space is placed between each word.
>##### Example
>TheQuickBrownFox -> The quick brown fox

### ExpandToTitleCase
All words are separated by a space and the first letter of each word is capitalized.
>##### Example
>greatest-story-ever-told -> Greatest Story Ever Told

### ToHungarianCase
The first word is lower cased, while all other words have their first lister uppercased.  No delimitters are placed between each word.
>##### Example
>big_blue_button -> bigBlueButton

### ToPascalCase
All words have their first letter uppercased.  No delimitters are placed between each word.
>##### Example
>MY-DATA-OUTPUT -> MyDataOutput

### ToScreamingSnakeCase
All words are uppercased and delimitted by an underscore character.
>##### Example
>TheOutputArea -> THE_OUTPUT_AREA

### ToSnakeCase
All words are lowercased and delimitted by an underscore character.
>##### Example
>topUserLabel -> top_user_label

### ToSpinalCase
All words are lowercased and delimitted by a hyphen character.
>##### Example
>BottomAreaWrapper -> bottom-area-wrapper

### ToTrainCase
The first letter of the first word is uppercased, while all other words are fully lowercased. Each word is delimitted by a hyphen character.
>##### Example
>WideTextBox -> Wide-text-box

## License
[Apache 2.0](LICENSE)