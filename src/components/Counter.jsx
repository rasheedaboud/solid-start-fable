import { createSignal } from "solid-js";
import { printf, toConsole } from "../fable_modules/fable-library-js.4.22.0/String.js";
import "./Counter.css";

function Counter() {
    const patternInput = createSignal(0);
    const setCount = patternInput[1];
    const count = patternInput[0];
    const increment = (_arg) => {
        setCount(count() + 1);
    };
    const decrement = (_arg_1) => {
        setCount(count() - 1);
    };
    return     <>
        <p class='text-center text-xl uppercase my-6'>Count is {(toConsole(printf("Evaluating expression...")), count())}</p>
        
        <div class='space-x-4'>

        <button class="btn btn-primary" onclick={increment}>
            Increment!
        </button>
        <button class="btn " onclick={decrement}>
            Decrement!
        </button>
        </div>

    </>
    ;
}

export default Counter;

