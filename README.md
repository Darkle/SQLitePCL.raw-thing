# SQLitePCL.raw-thing

Simple example using `SQLitePCL.raw.sqlite3_trace` with Fsharp

Note: Adding both the `Microsoft.Data.Sqlite` and `SQLitePCLRaw.core` libraries together in your `.fsproj` file seems to make things break. The `Microsoft.Data.Sqlite` comes with the `SQLitePCLRaw.core` lib built in, so you can just add `Microsoft.Data.Sqlite` to your `.fsproj` file and you will have access to `SQLitePCLRaw` as well in your code.
