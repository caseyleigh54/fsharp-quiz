let rec factorial n = 
  match n with 
  | 0 -> 1
  | _ -> n * factorial (n-1)

let rec sum L = 
  match L with 
  | [] -> 0.0
  | hd::tail -> hd + sum tail

let rec length L = 
  match L with
  | []      -> 0
  | e::rest -> 1 + length rest

[<EntryPoint>]
let main argv =
  printfn ""

  let R = factorial 5
  printfn "%A" R

  printfn ""
  printfn ""
  0
