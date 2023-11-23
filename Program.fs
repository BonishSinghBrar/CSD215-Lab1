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
]

let calculateWinningPercentage team =
    float team.Stats.Wins / float (team.Stats.Wins + team.Stats.Losses) * 100.0

let bestTeams =
    teams
    |> List.maxBy calculateWinningPercentage

let goodTeams =
    teams
    |> List.filter (fun team -> team.Stats.Wins = bestTeams.Stats.Wins)

let averageSuccessRate =
    teams
    |> List.averageBy calculateWinningPercentage

printfn "Best Team by Winning Percentage: %s" bestTeams.Name
printfn "Good Teams: %A" goodTeams
printfn "Average Success Rate of All Teams: %.2f" averageSuccessRate