import { Title, MetaProvider } from "@solidjs/meta";
import { A, Router } from "@solidjs/router";
import { FileRoutes } from "@solidjs/start/router";
import { Suspense } from "solid-js";
import "./app.css";

function App() {
    const handleClick = () => {
        window.location.href = "/";
    };
    return             <>
            <Router
                root={props => (
                    <MetaProvider>
                    <Title>SolidStart - Basic</Title>
                    <div class="navbar bg-neutral text-neutral-content">
                        <button onClick={handleClick} class="btn btn-ghost text-xl">SolidStart</button>

                        <div class='navbar-start space-x-4' >
                        <A href='/about' class="link ">About</A>
                        </div>
            
                    </div>
                    <Suspense>{props.children}</Suspense>
                    </MetaProvider>
                )}
                >
            <FileRoutes />
            </Router>
            </>
        ;
}

export default App;

