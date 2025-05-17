use tauri::Manager;
use rusqlite::Result;

mod db;
use db::{add_person, init_db, NewPerson};

const DB_PATH: &str = "table_maker.db";

#[tauri::command]
fn add_person_command(person: NewPerson) -> Result<i64> {
    add_person(DB_PATH, person)
}

#[tauri::command]
fn generate_report() -> Result<String> {
    // TODO: Implement report generation using docx-rs
    Ok("Report generated".into())
}

fn main() {
    tauri::Builder::default()
        .setup(|_app| {
            init_db(DB_PATH).expect("failed to init db");
            Ok(())
        })
        .invoke_handler(tauri::generate_handler![add_person_command, generate_report])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}
