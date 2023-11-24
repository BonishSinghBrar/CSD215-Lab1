type Coach = {
    Name: string
    FormerPlayer: bool
}

type Stats = {
    Wins: int
    Losses: int
}

type Team = {
    Name: string
    Coach: Coach
    Stats: Stats
}

let teams : Team list = [
    { Name = "Chicago Bulls"; Coach = { Name = "Billy Donovan"; FormerPlayer = true }; Stats = { Wins = 2344; Losses = 2254 } }
    { Name = "Milwaukee Bucks"; Coach = { Name = "Adrian Griffin"; FormerPlayer = false }; Stats = { Wins = 2340; Losses = 2103 } }
    { Name = "Los Angeles Lakers"; Coach = { Name = "Frank Vogel"; FormerPlayer = false }; Stats = { Wins = 2400; Losses = 2200 } }
    { Name = "Miami Heat"; Coach = { Name = "Erik Spoelstra"; FormerPlayer = true }; Stats = { Wins = 2300; Losses = 2000 } }
    { Name = "Detroit Pistons"; Coach = { Name = "Monty Williams"; FormerPlayer = true }; Stats = { Wins = 2813; Losses = 3103 } }
]
let goodTeams =
    teams
    |> List.filter (fun team -> team.Stats.Wins > team.Stats.Losses)
    |> List.map (fun team -> team.Name)
printfn "Good Teams : %A" goodTeams
let calculateWinningPercentage team =
    match team.Stats.Wins + team.Stats.Losses with
    | 0 -> 0.0
    | totalGames -> float team.Stats.Wins / float totalGames * 100.0
let teamsWithSuccessRate =
    teams
    |> List.map (fun team ->
        let successRate = calculateWinningPercentage team
        sprintf "%s: %.2f%%" team.Name successRate)
printfn "Teams with Success Rates: %A" teamsWithSuccessRate