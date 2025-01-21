let mutable x = 10
let y = ref x

// Correctly updates the value of x via the reference y
!y <- 20
printf "%d %d" x (!y)

(* The above code utilizes the ref keyword to create a reference cell correctly and subsequently updates the value of x via this reference.*)

//Another way to update x without using a reference cell
let updateX value = x <- value
updateX 30
printf "%d" x