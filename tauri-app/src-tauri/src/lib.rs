use rusqlite::{params, Connection, Result};

pub fn init_db_with_path<P: AsRef<std::path::Path>>(path: P) -> Result<Connection> {
    let conn = Connection::open(path)?;
    conn.execute(
        "CREATE TABLE IF NOT EXISTS people (
            id INTEGER PRIMARY KEY,
            name TEXT NOT NULL
        )",
        [],
    )?;
    Ok(conn)
}

pub fn init_db() -> Result<Connection> {
    init_db_with_path("table_maker.db")
}

pub fn add_person(conn: &Connection, name: &str) -> Result<()> {
    conn.execute("INSERT INTO people (name) VALUES (?1)", params![name])?;
    Ok(())
}

pub fn generate_report() -> Result<String> {
    // TODO: Implement report generation using docx-rs
    Ok("Report generated".into())
}
