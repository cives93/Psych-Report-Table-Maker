use tauri::Manager;
use rusqlite::Result;
use tauri_app::{init_db, add_person, generate_report};

#[tauri::command]
fn add_person_command(name: String) -> Result<()> {
    let conn = init_db()?;
    add_person(&conn, &name)
}

#[tauri::command]
fn generate_report_command() -> Result<String> {
    generate_report()
}

fn main() {
    tauri::Builder::default()
        .setup(|_| {
            // Initialize SQLite database on startup
            let _ = init_db().expect("failed to init db");
            Ok(())
        })
        .invoke_handler(tauri::generate_handler![add_person_command, generate_report_command])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}
