open Microsoft.Data.Sqlite


[<Core.EntryPointAttribute>]
let main _ =
    printfn "running"
    let sqlConString = new SqliteConnectionStringBuilder()
    sqlConString.DataSource <- "./foo.db"

    let sqLiteConnection = new SqliteConnection(sqlConString.ConnectionString)
    sqLiteConnection.Open()

    let conn = sqLiteConnection.Handle

    SQLitePCL.raw.sqlite3_trace (
        conn,
        SQLitePCL.delegate_trace (fun _ statement -> printfn "%A" (statement.utf8_to_string())),
        null
    )

    let sqlCommand = sqLiteConnection.CreateCommand()
    sqlCommand.CommandText <- "SELECT * FROM sqlite_master"
    sqlCommand.ExecuteNonQuery() |> ignore

    0
