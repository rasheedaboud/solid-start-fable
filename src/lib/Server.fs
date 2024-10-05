module Server

open Fable.Core
open Solid

let getMessage () =
    promise {
        try
            do! Promise.sleep 1500
            return Some "Hello from F#"
        with
        | exn -> return None

    }

let getMessageServer () =
    useServerDirective

    promise {
        try
            do! Promise.sleep 1500
            return Some "Hello from F#"
        with
        | exn -> return None

    }

let cachedTest () = cache (getMessage, "test-cache")
