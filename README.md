# CodeCasing

.NET Standard class library that provides methods for converting string identifiers to various code casing styles


See the [changelog](CHANGELOG.md) for changes.

![NuGet](https://img.shields.io/nuget/v/CodeCasing)
[![Build status](https://ci.appveyor.com/api/projects/status/gpfoxsf6cbvgwh05?svg=true)](https://ci.appveyor.com/project/kyleherzog/codecasing)

## Extension Methods

### ExpandToSentenceCase()
The first word is capitalized, while all other text is lower cased.  A space is placed between each word.
>**Example:** TheQuickBrownFox -> The quick brown fox

### ExpandToTitleCase()
All words are separated by a space and the first letter of each word is capitalized.
>**Example:** greatest-story-ever-told -> Greatest Story Ever Told

### ToCamelCase()
The first word is lower cased, while all other words have their first lister uppercased.  No delimiters are placed between each word.
>**Example:** big_blue_button -> bigBlueButton

### ToCobolCase()
All words are uppercased and delimited by a hyphen character.
>**Example:** TheOutputArea -> THE-OUTPUT-AREA

### ToFlatCase()
All words are lowercased. No delimiters are placed between each word.
>**Example:** big_blue_button -> bigbluebutton

### ToHungarianCase()
The first word is lower cased, while all other words have their first lister uppercased.  No delimiters are placed between each word.
>**Example:** big_blue_button -> bigBlueButton

### ToKebabCase()
All words are lowercased and delimited by a hyphen character.
>**Example:** TheOutputArea -> the-output-area

### ToMacroCase()
All words are uppercased and delimited by an underscore character.
>**Example:** TheOutputArea -> THE_OUTPUT_AREA

### ToPascalCase()
All words have their first letter uppercased.  No delimiters are placed between each word.
>**Example:** MY-DATA-OUTPUT -> MyDataOutput

### ToScreamingSnakeCase()
All words are uppercased and delimited by an underscore character.
>**Example:** TheOutputArea -> THE_OUTPUT_AREA

### ToSnakeCase()
All words are lowercased and delimited by an underscore character.
>**Example:** topUserLabel -> top_user_label

### ToSpinalCase()
All words are lowercased and delimited by a hyphen character.
>**Example:** BottomAreaWrapper -> bottom-area-wrapper

### ToTrainCase()
The first letter of the first word is uppercased, while all other words are fully lowercased. Each word is delimited by a hyphen character.
>**Example:** WideTextBox -> Wide-text-box