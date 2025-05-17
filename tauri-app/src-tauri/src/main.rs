use tauri::Manager;
use rusqlite::{Connection, Result};

#[tauri::command]
fn generate_report() -> Result<String> {
    // TODO: Implement report generation using docx-rs
    Ok("Report generated".into())
}

fn init_db() -> Result<Connection> {
    let conn = Connection::open("table_maker.db")?;
    conn.execute(
        "CREATE TABLE IF NOT EXISTS people (
            id INTEGER PRIMARY KEY,
            name TEXT NOT NULL
        )",
        [],
    )?;
    Ok(conn)
}

fn main() {
    tauri::Builder::default()
        .setup(|app| {
            // Initialize SQLite database on startup
            let _conn = init_db().expect("failed to init db");
            Ok(())
        })
        .invoke_handler(tauri::generate_handler![generate_report])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}
