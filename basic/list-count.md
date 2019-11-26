# List Count

<!--
#fsharp #tutorial #assignment
-->

## Prerequsites

### Read F# Lists Document

- https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/lists

## Find the Most Common Item in List

Write a function to find the most common item in a list

```fsharp
let countMostCommon = fun (input : int list) ->
    // add logic here, and leave the result as last line
```

```fsharp
let runTest = fun (input : int list) ->
    printfn "input = %A" input
    printfn "output = %d" <| countMostCommon input
```

```fsharp
runTest <| [1, 2, 3, 3] // output should be 3
```

