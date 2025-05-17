use tauri::Manager;
use rusqlite::{params, Connection, Result};
use serde::Deserialize;

#[tauri::command]
fn generate_report() -> Result<String> {
    // TODO: Implement report generation using docx-rs
    Ok("Report generated".into())
}

#[derive(Deserialize)]
struct NewPerson {
    first_name: String,
    last_name: String,
    client_id: Option<String>,
    birthdate: Option<String>, // ISO 8601 date string
    sex: Option<i32>,
}

fn init_db() -> Result<Connection> {
    let conn = Connection::open("table_maker.db")?;
    conn.execute(
        "CREATE TABLE IF NOT EXISTS people (
            id INTEGER PRIMARY KEY,
            first_name TEXT,
            last_name TEXT NOT NULL,
            client_id TEXT,
            birthdate TEXT,
            sex INTEGER
        )",
        [],
    )?;
    Ok(conn)
}

#[tauri::command]
fn add_person(person: NewPerson) -> Result<()> {
    let conn = init_db()?;
    conn.execute(
        "INSERT INTO people (first_name, last_name, client_id, birthdate, sex) VALUES (?1, ?2, ?3, ?4, ?5)",
        params![
            person.first_name,
            person.last_name,
            person.client_id,
            person.birthdate,
            person.sex
        ],
    )?;
    Ok(())
}

fn main() {
    tauri::Builder::default()
        .setup(|app| {
            // Initialize SQLite database on startup
            let _conn = init_db().expect("failed to init db");
            Ok(())
        })
        .invoke_handler(tauri::generate_handler![add_person, generate_report])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}
