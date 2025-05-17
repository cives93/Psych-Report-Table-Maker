use tauri_app::{init_db_with_path, add_person};
use assert_fs::TempDir;

#[test]
fn add_person_inserts_row() {
    let dir = TempDir::new().unwrap();
    let db_path = dir.path().join("test.db");
    let conn = init_db_with_path(&db_path).unwrap();
    add_person(&conn, "Alice").unwrap();
    let name: String = conn
        .query_row("SELECT name FROM people", [], |row| row.get(0))
        .unwrap();
    assert_eq!(name, "Alice");
}
