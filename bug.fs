let mutable x = 10
let y = &x
!y <- 20
printf "%d %d" x (!y)

(*The above code will print 20 20.  This is because the ! operator dereferences the mutable reference y and assigns a new value to x.  The value of x is updated to 20, and the value of y (which is a reference to x) also reflects this change.*)