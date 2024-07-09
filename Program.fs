open Microsoft.Data.Sqlite
open SQLitePCL


[<Core.EntryPointAttribute>]
let main _ =
    printfn "running"
    let sqlConString = new SqliteConnectionStringBuilder()
    sqlConString.DataSource <- "./foo.db"

    let sqLiteConnection = new SqliteConnection(sqlConString.ConnectionString)
    sqLiteConnection.Open()

    let conn = sqLiteConnection.Handle

    SQLitePCL.raw.sqlite3_trace (conn, delegate_trace (fun _ _ -> ()), null)
    0
