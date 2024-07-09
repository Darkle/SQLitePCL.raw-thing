# SQLitePCL.raw-thing

Simple example using `SQLitePCL.raw.sqlite3_trace` with Fsharp

Note: Using the `Microsoft.Data.Sqlite` and the `SQLitePCLRaw.core` libraries together in your `.fsproj` file seems to make things break. The `Microsoft.Data.Sqlite` comes with the `SQLitePCLRaw.core` lib built in, so just use the one built into `Microsoft.Data.Sqlite`.
