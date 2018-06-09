open System
 
let main() =
    let values = Console.ReadLine() |>int

    let myArray : int array = Array.zeroCreate values
   
    for i = 0 to myArray.Length - 1 do
        myArray.[i] <- Console.ReadLine() |>int


    for value in myArray do
        printfn "%A" (value * value)

    // Used for pausing the console application
    Console.ReadLine() |> ignore
 
[<EntryPoint>]
main()