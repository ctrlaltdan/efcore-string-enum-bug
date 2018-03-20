# EF Core (2.1.0-preview-1) Enum to string migration bug.

Repro steps:

 - Create new migration using VS package manager console `add-migration "two"`
 - Notice the migrations tool attempts to alter the `FromCurrency` and `TwoCurrency`
 - ... repeat
 
EF core issue tracker:

https://github.com/aspnet/EntityFrameworkCore/issues/11343
