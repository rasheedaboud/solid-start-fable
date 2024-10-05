import { Match, Switch, createEffect, createSignal } from "solid-js";
import { value, some } from "../fable_modules/fable-library-js.4.22.0/Option.js";
import { PromiseBuilder__Delay_62FBFDE1, PromiseBuilder__Run_212F1D4B } from "../fable_modules/Fable.Promise.3.2.0/Promise.fs.js";
import { promise } from "../fable_modules/Fable.Promise.3.2.0/PromiseImpl.fs.js";
import { getMessage } from "../lib/Server.jsx";
import { Title } from "@solidjs/meta";
import Counter from "~/components/Counter";
import { A } from "@solidjs/router";

function Index() {
    const patternInput = createSignal(undefined);
    const setMessage = patternInput[1];
    const message = patternInput[0];
    createEffect(() => {
        const matchValue = message();
        if (matchValue == null) {
            console.log(some("Waiting for server response..."));
        }
        else {
            const message_1 = matchValue;
            console.log(some("Server response: "), message_1);
        }
    });
    createEffect(() => PromiseBuilder__Run_212F1D4B(promise, PromiseBuilder__Delay_62FBFDE1(promise, () => (getMessage().then((_arg) => {
        const response = _arg;
        if (response == null) {
            setMessage(undefined);
            return Promise.resolve();
        }
        else {
            const message_2 = response;
            setMessage(message_2);
            return Promise.resolve();
        }
    })))));
    return         <main className="container w-full mx-auto p-6 min-h-screen flex flex-col items-center">
          <Title>Hello World</Title>
          
          <h1 className="text-4xl font-bold text-blue-600 mb-4">Hello World!</h1>
          
          <Switch>
            <Match when={message() != null}>
              <p className="text-lg font-semibold mt-2">{value(message())}</p>
            </Match>
            <Match when={message() == null}>
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
        ;
}

export default Index;

