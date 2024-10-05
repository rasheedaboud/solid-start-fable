# SolidStart

Everything you need to build a Solid project, powered by [`solid-start`](https://start.solidjs.com) and [`fable`](https://fable.io/);


## Developing

Once you've created a project and installed dependencies with `pnpm install`, start a development server:

```bash
pnpm  dev
```

## Building

Solid apps are built with _presets_, which optimise your project for deployment to different environments.

By default, `pnpm build` will generate a Node app that you can run with `pnpm start`. To use a different preset, add it to the `devDependencies` in `package.json` and specify in your `app.config.js`.

```bash
 //default
 server: {
    preset: "node_server", //<- change to any nitro support preset
  },
```
