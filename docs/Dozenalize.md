
## Dozenalize

Base twelve is an interesting one because it needs only 2 characters more and the base twelve is highly
composable.

https://en.wikipedia.org/wiki/Duodecimal

Here is a nice video from Numberphile about the Dozenal system:
https://www.youtube.com/watch?v=U6xJfP7-HCc

### Usage

Because we need two additional digits for dozenal, you have to provide a config for these two characters.

```fsharp
open Dozenalize

let config = Config.create "A" "B"
```

There are also [prepared configs](src/Dozenalize/Types.fs) for commonly used ones:
```fsharp
open Dozenalize

let config = Config.ab
```

Now you can use this config together with your wanted precision and number to create a string in dozenal:

```fsharp
open Dozenalize

Display.number config 0uy 13.16 // 11
Display.number config 2uy 13.16 // 11.1B
Display.number config 5uy 13.16 // 11.1B059
```
