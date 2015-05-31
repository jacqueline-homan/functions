// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
let square x = x * x

printfn "square 5 returns %d" (square 5)

let add x y =
    let result =
        x + y
    result
printfn "add 2 + 4 returns %d" (add 2 4)

let add' w z =
    let result =
        w + z
    result
printfn "You can also use the mathematical tic notation"
printfn "like so: let add' w z"
printfn "add' wz returns %d" (add' 8 5)

let add5and3 = add 5 3
printfn "add5and3 equals %d" (add 5 3)

let result = add (square 12) 7
printfn "add the square of 12 to 7 and you get: %d" (add(square 12) 7)





[<EntryPoint>]
let main argv = 
    let welcome =
        printfn "This is a simple program showing legit function declaration and calls in F#" 
    //(square x) // An error will show if you do not declare the function before calling it here
    //(add 5 3) |> ignore
    printfn "The result of (add 5 3) is: %d" (add 5 3)


    //let c = myFirstFunction()
    0 // return an integer exit code

