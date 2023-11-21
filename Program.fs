//QUESTION 1 PART A
let x = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
printfn "Salaries: %A" x
//PART B
let hix =
    x |> List.filter (fun salary -> salary > 100000)
printfn "High Salaries: %A" hix
//PART C
let calt salary =
    match salary with
    | z when z <= 49020 -> float (float z * 0.15)
    | z when z <= 98040 -> float (float z * 0.205)
    | z when z <= 151978 -> float (float z * 0.26)
    | z when z <= 216511 -> float (float z * 0.29)
    | _ -> int (float salary * 0.33)
let t =  x |> List.map calt
printfn "Taxes respective to the salary: %A" t
//PART D
let y =
    x |> List.filter (fun salary -> salary <= 49020)
      |> List.map (fun salary -> salary + 20000)
printfn "Increased salaries: %A" y
//PART E
let totalx =
    x |> List.filter (fun salary -> salary >= 50000 && salary <= 100000)
      |> List.sum
printfn "Total of salaries between the given range: %d" totalx

//QUESTION 2

let total n =
    let rec total a c =
        if c > n then
            a
        else
            total (a + c) (c + 3)
    total 0 3
let ans = total 100
printfn "ans: %d" ans

//This is end of my code///