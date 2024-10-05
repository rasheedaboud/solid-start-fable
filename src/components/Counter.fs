module Counter

open Fable.Core
open Fable.Core.JsInterop
open Solid

[<JSX.Component>]
[<ExportDefault>]
let private Counter () =
    importSideEffects "./Counter.css"
    let count, setCount = createSignal (0)
    let increment = fun _ -> count () + 1 |> setCount
    let decrement = fun _ -> count () - 1 |> setCount

    JSX.jsx
        $"""
    <>
        <p class='text-center text-xl uppercase my-6'>Count is {let _ = printfn "Evaluating expression..." in count ()}</p>
        
        <div class='space-x-4'>

        <button class="btn btn-primary" onclick={increment}>
            Increment!
        </button>
        <button class="btn " onclick={decrement}>
            Decrement!
        </button>
        </div>

    </>
    """
