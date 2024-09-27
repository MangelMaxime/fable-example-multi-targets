namespace MyApp.Shared.Types

open Thoth.Json.Core

type User =
    {
        Name : string
        Age : int
    }

    static member Decoder : Decoder<User> =
        Decode.object (fun get ->
            {
                Name = get.Required.Field "name" Decode.string
                Age = get.Required.Field "age" Decode.int
            }
        )

    static member Encoder (value : User) =
        Encode.object [
            "name", Encode.string value.Name
            "age", Encode.int value.Age
        ]
