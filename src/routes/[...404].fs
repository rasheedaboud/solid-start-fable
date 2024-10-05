module NotFound

open Fable.Core

//This must be private to properly
//export this route to solid
[<JSX.Component>]
[<ExportDefault>]
let private NotFound () =

    JSX.jsx
        $"""
    import {{ Title }} from "@solidjs/meta";
    import {{ HttpStatusCode }} from "@solidjs/start";
    
    <main>
        <Title>Not Found</Title>
        <HttpStatusCode code={404} />
        <h1>Page Not Found</h1>
        <p>
        Visit{" "}
        <a href="https://start.solidjs.com" target="_blank">
            start.solidjs.com
        </a>{" "}
        to learn how to build SolidStart apps.
        </p>
    </main>
       
    
    """
