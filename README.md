# Psych Report Table Maker

This repository originally contained a VB.NET Windows Forms application that relied on Windows-only technologies. A new Tauri + Rust implementation is underway so the project can run on macOS and other platforms.

## Structure

- `Psych Report Table Maker/` – Legacy VB.NET application.
- `tauri-app/` – Cross-platform Tauri project written in Rust and using SQLite.

## Building the Legacy Application (Windows)

1. Open `Psych Report Table Maker.sln` in Visual Studio 2010 or later.
2. Restore NuGet packages (SQL Server CE, OpenXML, MathNet, etc.).
3. Build the solution to produce a Windows executable.

## New Tauri + Rust Project

The `tauri-app` directory contains the new application. It initializes an SQLite database, provides an `add_person` command, and will eventually generate Word documents via the `docx-rs` crate.

### Prerequisites

- [Rust](https://rustup.rs/) with the stable toolchain.
- [Node.js](https://nodejs.org/) (for the Tauri frontend build).

### Build Steps

```bash
cd tauri-app
npm install       # installs frontend dependencies
npm run tauri dev # runs the Tauri application in development mode
```

To build a production bundle for macOS:

```bash
npm run tauri build -- --target aarch64-apple-darwin
```

### Running Tests

Integration tests use offline-friendly crates (`assert_cmd`, `assert_fs`, `tempfile`). After dependencies are fetched once, they can be run with:

```bash
cargo test --offline
```

### Porting Status

- SQLite database initialization and an `add_person` command are implemented.
- A minimal HTML form calls the command via Tauri.
- Document generation and the rest of the VB.NET logic still need to be ported.
