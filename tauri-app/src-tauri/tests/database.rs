use tauri_app::{init_db, add_person, NewPerson};
use tempfile::NamedTempFile;
use rusqlite::Connection;

#[test]
fn test_add_person() {
    let file = NamedTempFile::new().unwrap();
    let path = file.path().to_str().unwrap();
    let conn = init_db(path).unwrap();

    let person = NewPerson {
        first_name: "John".into(),
        last_name: "Doe".into(),
        client_id: "123".into(),
        birthdate: "2000-01-01".into(),
        sex: 0,
    };

    let id = add_person(person).unwrap();
    let mut stmt = conn.prepare("SELECT COUNT(*) FROM person WHERE id=?1").unwrap();
    let count: i64 = stmt.query_row([id], |row| row.get(0)).unwrap();
    assert_eq!(count, 1);
}
