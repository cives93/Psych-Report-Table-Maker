use rusqlite::{params, Connection, Result};
use serde::{Deserialize, Serialize};

#[derive(Debug, Serialize, Deserialize)]
pub struct NewPerson {
    pub first_name: String,
    pub last_name: String,
    pub client_id: Option<String>,
    pub birthdate: String,
    pub sex: i32,
}

pub fn init_db(path: &str) -> Result<()> {
    let conn = Connection::open(path)?;
    conn.execute(
        "CREATE TABLE IF NOT EXISTS people (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            first_name TEXT NOT NULL,
            last_name TEXT NOT NULL,
            client_id TEXT,
            birthdate TEXT NOT NULL,
            sex INTEGER NOT NULL
        )",
        [],
    )?;
    Ok(())
}

pub fn add_person(db_path: &str, person: NewPerson) -> Result<i64> {
    let conn = Connection::open(db_path)?;
    conn.execute(
        "INSERT INTO people (first_name, last_name, client_id, birthdate, sex) VALUES (?1, ?2, ?3, ?4, ?5)",
        params![person.first_name, person.last_name, person.client_id, person.birthdate, person.sex],
    )?;
    Ok(conn.last_insert_rowid())
}

#[cfg(test)]
mod tests {
    use super::*;
    use tempfile::NamedTempFile;

    #[test]
    fn test_add_person() {
        let file = NamedTempFile::new().unwrap();
        let path = file.path().to_str().unwrap();
        init_db(path).unwrap();

        let person = NewPerson {
            first_name: "Alice".into(),
            last_name: "Smith".into(),
            client_id: Some("123".into()),
            birthdate: "2024-01-01".into(),
            sex: 0,
        };
        let id = add_person(path, person).unwrap();
        assert!(id > 0);
    }
}
