# List Filter

<!--
#fsharp #tutorial #assignment
-->

## Prerequsites

### Read F# Lists Document

- https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/lists

## Count Positive Numbers in List

Write a function to count how many positive numbers in it

```fsharp
let countPositive = fun (input : int list) ->
    // add logic here, and leave the result as last line
    input.Length
```

```fsharp
let runTest = fun (input : int list) ->
    printfn "input = %A" input
    printfn "output = %d" <| countPositive input
```

```fsharp
runTest <| [1, 2, 3, 4, 5, 0, -1, 20, -2, 30]
```
