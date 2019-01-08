// Learn more about F# at http://fsharp.org

open System
open Quicksort
open GeneralFunctions

printfn "Hello World from F#!"

let unsortedNumbers = generateRandomNumberList 20 //[7;5;34;85;27;93;61;37;76;70;44;44;41;61;70;65;84;47;36;10]

printfn "%s: %A" "quicksort" (quicksort unsortedNumbers)

0 // return an integer exit code
