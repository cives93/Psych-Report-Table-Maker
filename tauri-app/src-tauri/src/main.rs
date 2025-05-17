use tauri::Manager;
use rusqlite::{params, Connection, Result};
use serde::Deserialize;

#[derive(Deserialize)]
pub struct NewPerson {
    first_name: String,
    last_name: String,
    client_id: String,
    birthdate: String,
    sex: i32,
}

#[tauri::command]
fn generate_report() -> Result<String> {
    // TODO: Implement report generation using docx-rs
    Ok("Report generated".into())
}

pub fn init_db(path: &str) -> Result<Connection> {
    let conn = Connection::open(path)?;
    conn.execute(
        "CREATE TABLE IF NOT EXISTS person (
            id INTEGER PRIMARY KEY,
            first_name TEXT,
            last_name TEXT,
            client_id TEXT,
            birthdate TEXT,
            sex INTEGER
        )",
        [],
    )?;
    Ok(conn)
}

#[tauri::command]
pub fn add_person(person: NewPerson) -> Result<i64> {
    let conn = Connection::open("table_maker.db")?;
    conn.execute(
        "INSERT INTO person (first_name, last_name, client_id, birthdate, sex) VALUES (?1, ?2, ?3, ?4, ?5)",
        params![
            person.first_name,
            person.last_name,
            person.client_id,
            person.birthdate,
            person.sex
        ],
    )?;
    Ok(conn.last_insert_rowid())
}

fn main() {
    tauri::Builder::default()
        .setup(|_app| {
            // Initialize SQLite database on startup
            let _conn = init_db("table_maker.db").expect("failed to init db");
            Ok(())
        })
        .invoke_handler(tauri::generate_handler![generate_report, add_person])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}
