module Solid

open Fable.Core
open Fable.Core.JS

[<AllowNullLiteral>]
type IResourceActions<'T> =
    abstract member mutate: ('T option -> unit)
    abstract member refetch: (unit -> unit)
    abstract member loading: bool

[<AutoOpen>]
type Core() =

    [<Import("createSignal", "solid-js")>]
    static member inline createSignal<'T>(initialValue: 'T) : (unit -> 'T) * ('T -> unit) = jsNative

    [<Import("onMount", "solid-js")>]
    static member inline onMount(fn: unit -> unit) : unit = jsNative

    [<Import("onCleanup", "solid-js")>]
    static member inline onCleanup(fn: unit -> unit) : unit = jsNative

    [<Import("createEffect", "solid-js")>]
    static member inline createEffect(fn: unit -> unit) : unit = jsNative

    [<Import("createEffect", "solid-js")>]
    static member inline createEffect(fn: unit -> Promise<unit>) : unit = jsNative

    [<Import("createMemo", "solid-js")>]
    static member inline createMemo<'T>(fn: unit -> 'T) : unit -> 'T = jsNative

    [<Import("createRoot", "solid-js")>]
    static member inline createRoot<'T>(fn: (unit -> unit) -> 'T) : 'T = jsNative



    [<Import("createResource", "solid-js")>]
    static member inline createResource<'S, 'T>
        (
            fetcher: 'S -> Promise<'T>,
            ?source: 'S option
        ) : (unit -> 'T option) * IResourceActions<'T> =
        jsNative

    [<Import("cache", "@solidjs/router")>]
    static member inline cache<'T>(operation: unit -> Promise<'T>, key: string) : 'T option = jsNative

    [<Import("createAsync", "@solidjs/router")>]
    static member inline createAsync<'T>(operation: unit -> Promise<'T>) : unit -> 'T option = jsNative



    [<Emit("\"use server\";")>]
    static member inline useServerDirective: unit = jsNative
