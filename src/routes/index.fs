open Fable.Core
open Solid
open Fable.Core.JS

// This must be private to properly
// export this route to Solid
[<JSX.Component>]
[<ExportDefault>]
let private Index () =

    let (message, setMessage) = createSignal<Option<string>> (None)

    createEffect (fun () ->
        match message () with
        | Some message -> console.log ("Server response: ", message)
        | None -> console.log ("Waiting for server response..."))

    createEffect (fun () ->
        promise {
            let! response = Server.getMessage ()

            match response with
            | Some message -> setMessage (Some message)
            | None -> setMessage (None)
        })

    JSX.jsx
        $"""
        import {{ Title }} from "@solidjs/meta";
        import Counter from "~/components/Counter";
        import {{ Switch, Match }} from "solid-js";
        import {{ A }} from "@solidjs/router"; 

        <main className="container w-full mx-auto p-6 min-h-screen flex flex-col items-center">
          <Title>Hello World</Title>
          
          <h1 className="text-4xl font-bold text-blue-600 mb-4">Hello World!</h1>
          
          <Switch>
            <Match when={message().IsSome}>
              <p className="text-lg font-semibold mt-2">{message().Value}</p>
            </Match>
            <Match when={message().IsNone}>
              <p className="text-lg font-semibold mt-2">Loading...</p>
            </Match>
          </Switch>
          
          <div className="mx-auto items-center mt-6">
            <Counter />
          </div>
          
          <div className="mt-6 text-center">
            <p className="text-md text-gray-700">
              Visit{" "}
              <a href="https://start.solidjs.com" target="_blank" className="text-blue-500 underline hover:text-blue-700">
                start.solidjs.com
              </a>{" "}
              to learn how to build SolidStart apps.
            </p>
            <p className="text-md text-gray-700 mt-2">
              Visit{" "}
              <A href="https://fable.io/" className="text-blue-500 underline hover:text-blue-700">
                Fable
              </A>{" "}
              to learn more about using F# with JavaScript.
            </p>
          </div>
        </main>
        """
