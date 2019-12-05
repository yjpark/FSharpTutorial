// Learn more about F# at http://fsharp.org

open System

let readNumber () =
    printfn "Please input an integer number: "
    let str = System.Console.ReadLine ()
    str

let readOp () =
    printfn "Please input an operator (one of '+' '-' '*' '/' ): "
    let str = System.Console.ReadLine ()
    str

let calc number1 op number2 =
    let result = "?"
    printf "%s %s %s = %s" number1 op number2 result
    result

[<EntryPoint>]
let main argv =
    let number1 = readNumber ()
    let op = readOp ()
    let number2 = readNumber ()
    let result = calc number1 op number2
    0 // return an integer exit code
