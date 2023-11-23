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
    { Name = "Miami Heat"; Coach = { Name = "Erik Spoelstra"; FormerPlayer = true }; Stats = { Wins = 2400; Losses = 2000 } }
]

let goodTeam = teams |> List.maxBy (fun team -> team.Stats.Wins)

printfn "Team with Maximum Wins: %s" goodTeam.Name
