# List Palindrome

<!--
#fsharp #tutorial #assignment
-->

## Prerequsites

### Read F# Lists Document

- https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/lists

## Check Whether a List is Palindrome

A palindrome means the list is same when it's read from both end, an example is

```fsharp
let palindrome = [1, 2, 3, 2, 1]
```

Write a function to check whether the input list is palindrome.

```fsharp
let isPalindrome = fun (input : int list) ->
    // add logic here, and leave the result as last line
    true
```

```fsharp
let runTest = fun (input : int list) ->
    printfn "input = %A" input
    printfn "output = %A" <| isPalindrome input
```

```fsharp
runTest <| [1, 2, 3, 4, 5, 0, -1, 20, -2, 30]
```
