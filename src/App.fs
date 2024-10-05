module App


open Fable.Core
open Fable.Core.JsInterop
open Browser.Dom

[<JSX.Component>]
[<ExportDefault>]
let private App () =

    importSideEffects "./app.css"
    let handleClick () = window.location.href <- "/"

    JSX.jsx
        $"""
            import {{ MetaProvider, Title }} from "@solidjs/meta";
            import {{ Router,A }} from "@solidjs/router";
            import {{ FileRoutes }} from "@solidjs/start/router";
            import {{ Suspense }} from "solid-js";

            <>
            <Router
                root={{props => (
                    <MetaProvider>
                    <Title>SolidStart - Basic</Title>
                    <div class="navbar bg-neutral text-neutral-content">
                        <button onClick={handleClick} class="btn btn-ghost text-xl">SolidStart</button>

                        <div class='navbar-start space-x-4' >
                        <A href='/about' class="link ">About</A>
                        </div>
            
                    </div>
                    <Suspense>{{props.children}}</Suspense>
                    </MetaProvider>
                )}}
                >
            <FileRoutes />
            </Router>
            </>
        """
