// Learn more about F# at http://fsharp.org

open System

module myFirstModule =
    let func1 arg = arg * arg
    let helloWorld = printfn "Hello World from F#!"
    
    // this is "bind"
    let number = 2
    let mutable mutableNumber = 3
    let mutableTest =
        number = number + 2 // this is not assign, but compare         
        mutableNumber = mutableNumber + 2 // either
        mutableNumber <- mutableNumber + 2 // assign
        
    let string1 = "Hello World"
    let string2 = "from F#!"
    let mutable string3 = ""
    let stringTest =
        printfn "%s %s" string1 string2
        string3 <- string1 + " " + string2
        printfn "%s" string3

module PipelineModule =
    let dividedBy operand num =
        num % operand = 0
        
    let Filter list prime =
        list |> List.filter (fun x -> x |> dividedBy prime = false)
 
    let rec Sieve (list:List<int>) =
        if list.Head > 33 then list
        else [list.Head] @ Sieve (Filter list.Tail list.Head) 
        
        
    
[<EntryPoint>]
let main argv =
    
    let result = myFirstModule.func1 3.0f
    printfn "%f" result
    myFirstModule.helloWorld 
    myFirstModule.stringTest
    myFirstModule.mutableTest
    
    printfn "%A" (PipelineModule.Sieve [2..300])
    printfn "%A" (PipelineModule.Sieve [2..1000])
    
    0 // return an integer exit code    
        