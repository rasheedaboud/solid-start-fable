# SolidStart

Everything you need to build a Solid project, powered by [`solid-start`](https://start.solidjs.com) and [`fable`](https://fable.io/).


## Why F#?
F# adds real type safety and functional programming capabilities to JavaScript, making your SolidJS projects safer and more robust. By using Fable, F# can be transpiled to JavaScript, allowing you to leverage the powerful type system and immutable data structures of F# while still running your code in a JavaScript environment. This approach significantly reduces runtime errors and provides a more reliable development experience compared to traditional JavaScript or TypeScript solutions.

With F#, you also gain features like pattern matching, discriminated unions, and concise syntax, which improve both the expressiveness and maintainability of your code. Combining SolidJS with F# ensures that you get the best of both worlds—an efficient reactive UI framework with the safety and elegance of functional programming.

## Getting Started

### Prerequisites

Ensure you have the following installed on your system:

- [Node.js](https://nodejs.org/)
- [pnpm](https://pnpm.io/)
- [.NET SDK](https://dotnet.microsoft.com/download) (version 8 or higher)
- [Fable](https://fable.io/) (installed as a global tool)

### Creating a Project

To create a new project, clone the repository and install the dependencies:

```bash
git clone https://github.com/rasheedaboud/solid-start-fable
cd solid-start-fable
pnpm install
```

## Developing

Start a development server to work on your project:

```bash
pnpm dev
```

This will start a local server and watch for file changes, enabling hot-reloading.

## Building

Solid apps are built with _presets_, which optimize your project for deployment to different environments.

By default, `pnpm build` will generate a Node app that you can run with `pnpm start`. To use a different preset, add it to the `devDependencies` in `package.json` and specify it in your `app.config.js`.

Example configuration:

```javascript
// app.config.js
export default {
    server: {
        preset: "node_server", // Change to any Nitro-supported preset
    },
};
```

## .NET Toolchain

This app assumes you have Fable installed as a global tool and .NET SDK version 8 or higher installed.

### Installing .NET SDK

Download and install the .NET SDK from the [.NET website](https://dotnet.microsoft.com/download).

### Installing Fable

To install Fable as a global tool, run:

```bash
dotnet tool install -g fable
```

Verify the installation by running:

```bash
fable --version
```

Ensure the version is compatible with your project requirements.

## Styling

This project uses [Tailwind CSS](https://tailwindcss.com/) and [DaisyUI](https://daisyui.com/) for styling.

### Tailwind CSS

Tailwind CSS is a utility-first CSS framework that provides low-level utility classes to build custom designs.

### DaisyUI

DaisyUI is a plugin for Tailwind CSS that provides a set of high-quality, pre-designed components.

## Server-Only Functions

SolidStart uses `'use-server'` to tell the framework to ignore certain functions when bundling client-side code.

In `Solid.Core.fs`, there is a static member that can be used to annotate an F# function with `'use-server'`.

```fsharp
type Core () =
        [<Emit("\"use server\";")>]
        static member inline useServerDirective: unit = jsNative
```

Annotate your F# function as follows:

```fsharp
let serverOnly() = 
        promise {
                useServerDirective
                do! Promise.sleep 1500
                return Some "Hello from F#"
        }
```

This results in:

```javascript
export async function serverOnly() {
        "use server";
        //...rest of code
}
```

## SolidJS Types

Fable is an incredible tool that makes JavaScript interop incredibly easy. Basic F# wrappers to support Solid basics are included in `Solid.Core.fs`. Extend this as needed to add any missing functionality required to support your use case.