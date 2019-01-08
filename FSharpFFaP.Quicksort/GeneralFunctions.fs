module GeneralFunctions

let generateRandomNumberList count =
    let rnd = System.Random()
    List.init count (fun _ -> rnd.Next(1, 100))
