module MyApp.Main

open MyApp.Shared.Types

#if FABLE_COMPILER_JAVASCRIPT
open Thoth.Json.JavaScript
#endif

#if FABLE_COMPILER_PYTHON
open Thoth.Json.Python
#endif

[<EntryPoint>]
let main argv =
    {
        Name = "Alice"
        Age = 42
    }
    |> User.Encoder
    |> Encode.toString 4
    |> printfn "%s"

    0
