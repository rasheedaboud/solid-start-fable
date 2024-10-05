import { PromiseBuilder__Delay_62FBFDE1, PromiseBuilder__Run_212F1D4B } from "../fable_modules/Fable.Promise.3.2.0/Promise.fs.js";
import { promise } from "../fable_modules/Fable.Promise.3.2.0/PromiseImpl.fs.js";
import { cache } from "@solidjs/router";

export function getMessage() {
    return PromiseBuilder__Run_212F1D4B(promise, PromiseBuilder__Delay_62FBFDE1(promise, () => (PromiseBuilder__Delay_62FBFDE1(promise, () => ((new Promise(resolve => setTimeout(resolve, 1500))).then(() => (Promise.resolve("Hello from F#"))))).catch((_arg_1) => {
        const exn = _arg_1;
        return Promise.resolve(undefined);
    }))));
}

export function getMessageServer() {
    "use server";;
    return PromiseBuilder__Run_212F1D4B(promise, PromiseBuilder__Delay_62FBFDE1(promise, () => (PromiseBuilder__Delay_62FBFDE1(promise, () => ((new Promise(resolve => setTimeout(resolve, 1500))).then(() => (Promise.resolve("Hello from F#"))))).catch((_arg_1) => {
        const exn = _arg_1;
        return Promise.resolve(undefined);
    }))));
}

export function cachedTest() {
    return cache(getMessage, "test-cache");
}

