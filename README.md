# Psych Report Table Maker

This repository originally contained a VB.NET Windows Forms application that relies on Windows-specific technologies. To make the project cross-platform and macOS compatible, a new Tauri + Rust implementation is being introduced.

## Structure

- `Psych Report Table Maker/` – Legacy VB.NET application.
- `tauri-app/` – New cross-platform Tauri project written in Rust.

## Building the Legacy Application (Windows)

1. Open `Psych Report Table Maker.sln` in Visual Studio 2010 or later.
2. Restore NuGet packages (SQL Server CE, OpenXML, MathNet, etc.).
3. Build the solution to produce a Windows executable.

## New Tauri + Rust Project

The `tauri-app` directory contains a skeleton Tauri project intended to replace the VB.NET application. It uses SQLite for data storage and will generate Word documents via the `docx-rs` crate.

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

### Porting Status

Only a minimal Rust backend and SQLite setup are included. The original VB.NET logic and UI must still be translated into Rust commands and a web-based UI.
