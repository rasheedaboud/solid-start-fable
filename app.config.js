import { defineConfig } from "@solidjs/start/config";

export default defineConfig({
  server: {
    preset: "node_server",
  },
  resolve: {
    alias: {
      "@fable": "/src/fable-build",
    },
  },
});
